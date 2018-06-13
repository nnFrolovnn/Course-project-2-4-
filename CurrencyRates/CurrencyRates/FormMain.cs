using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using CurrencyRates.bank;
using CurrencyRates.NBRB;
using CurrencyRates.Settings;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.IO;

namespace CurrencyRates
{
    public partial class FormMain : Form
    {
        Form form;
        NatBank nbrb;
        ErrorReporting reporting;
        delegate void RefreshRatesDelegate(ComboBox comboBox);

        public FormMain()
        {
            InitializeComponent();
            form = this;
            nbrb = new NatBank();
            reporting = ErrorReporting.GetReportingFile();

            panelHome.Dock = DockStyle.Fill;
            panelExch.Dock = DockStyle.Fill;
            panelStat.Dock = DockStyle.Fill;
            panelAdd.Dock = DockStyle.Fill;
            panelSettings.Dock = DockStyle.Fill;

            myChart.Height = (int)(panelStat.Height * 0.7);
            panelHome.BringToFront();
           
        }
        private bool CheckNetwork()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {

                    labelInfoNetwork.Text = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
                labelInfoNetwork.Text = "Network is not available";
            }
            return false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        #region MoveWindow

        bool isrelocate = false;
        Point locatepoint;
        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (isrelocate)
            {
                form.Location = new Point(form.Location.X + e.Location.X - locatepoint.X, form.Location.Y + e.Location.Y - locatepoint.Y);
            }
        }

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            locatepoint = e.Location;
            isrelocate = true;
        }

        private void Move_MouseUp(object sender, MouseEventArgs e)
        {
            isrelocate = false;
        }

        #endregion   

        #region MenuButtons

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelCurrState.Top = buttonHome.Top;
            panelHome.BringToFront();
        }

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            panelCurrState.Top = buttonExchange.Top;
            panelExch.BringToFront();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            panelCurrState.Top = buttonStatistics.Top;
            panelStat.BringToFront();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelCurrState.Top = buttonAdd.Top;
            labelThanks.Text = "";

            panelAdd.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelCurrState.Top = buttonSettings.Top;
            labelSett.Text = "";
            panelSettings.BringToFront();
        }

        #endregion

        #region Refresh Home
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNetwork())
                {
                    DOAsync(this);
                    labelToday.Text = "Rates today : (Last update : " + DateTime.Now.ToShortTimeString() + ")";
                    RefreshStatistics();
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private async void DOAsync(FormMain form)
        {
            try
            {
                BankParserTUTBY parser = new BankParserTUTBY();
                ParserWorker<RateShort[]> parserWorker = new ParserWorker<RateShort[]>(parser);
                parserWorker.ParserSettings = new BankSettings($"https://finance.tut.by/kurs/");

                AppSettings.Settings.RatesShort = await parserWorker.Parse();
                ShowInForm(form.dataCurr, AppSettings.Settings.RatesShort);

                UpdateComboBox(form.comboBoxfrom, form.dataCurr);
                UpdateComboBox(form.comboBoxto, form.dataCurr);
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }

        }
        private void ShowInForm(DataGridView obj, RateShort[] res)
        {
            try
            {
                obj.Rows.Clear();
                if (res != null)
                {
                    int i = 0;
                    foreach (RateShort temp in res)
                    {
                        temp.Cur_Name = temp.Cur_Name.Trim();

                        string[] row = { temp.Cur_Name, temp.Cur_SellRate.ToString(), temp.Cur_BuyRate.ToString(), temp.Cur_Scale.ToString() };
                        obj.Rows.Insert(i, row);
                        i++;
                    }
                    string[] rowb = { "Белорусский рубль", "1", "1", "1"};
                    obj.Rows.Add(rowb);
                    obj.Rows[obj.RowCount - 1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private void UpdateComboBox(ComboBox box, DataGridView dataGrid)
        {
            try
            {
                box.Items.Clear();

                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    box.Items.Add(dataGrid["col_name", i].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        #endregion

        #region Refresh Statistics

        private void RefreshStatistics()
        {
            try
            {
                RefreshRatesDelegate refreshRates = new RefreshRatesDelegate(RefreshRates);
                refreshRates.Invoke(comboBoxCurrStat);
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private void RefreshRates(ComboBox box)
        {
            try
            {                
                AppSettings.Settings.Rates = nbrb.GetAllRates();

                box.Items.Clear();
                foreach (Rate item in AppSettings.Settings.Rates)
                {
                    box.Items.Add(item.Cur_Name);
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private void buttonGetStat_Click(object sender, EventArgs e)
        {
            try
            {
                string value = comboBoxCurrStat.SelectedItem.ToString();
                int cur_id = -1;
                foreach(Rate item in AppSettings.Settings.Rates)
                {
                    if (item.Cur_Name == value)
                    {
                        cur_id = item.Cur_ID;
                        break;
                    }
                }
                if (cur_id > 0)
                {
                    DateTime dateTime = DateTime.Now;
                    AppSettings.Settings.RatesShort = nbrb.GetRateForPeriod(cur_id, dateTime.AddMonths(-1), dateTime);
                    DrawFunc(AppSettings.Settings.RatesShort);
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private void DrawFunc(RateShort[] rateShort)
        {
            myChart.Series["Statistics"].Points.Clear();

            int day = 1;
            foreach (RateShort item in rateShort)
            {
                myChart.Series["Statistics"].Points.AddXY(day++, item.Cur_OfficialRate);
            }
        }

        #endregion 

        
        #region Convert
        private void button2_Click(object sender, EventArgs e)
        {
            double fromvalue = 0;
            string fromcurr = "";
            string tocurr = "";

            labelErrConvert.Text = "";
            try
            {
                fromvalue = Convert.ToDouble(textBoxfrom.Text);
                fromcurr = comboBoxfrom.SelectedItem.ToString();
                tocurr = comboBoxto.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                labelErrConvert.Text = "Enter valid value!";
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
                return;
            }
            try
            {
                labelErrConvert.Text = "";

                double have = fromvalue, modif = 1;

                for (int i = 0; i < dataCurr.RowCount; i++)
                {
                    if (fromcurr == dataCurr["col_name", i].Value.ToString())
                    {
                        have *= Convert.ToDouble(dataCurr["col_brate", i].Value.ToString()) / Convert.ToInt32(dataCurr["col_scale", i].Value.ToString()); //in BYN
                    }
                    if (tocurr == dataCurr["col_name", i].Value.ToString())
                    {
                        modif *= Convert.ToDouble(dataCurr["col_srate", i].Value.ToString()) / Convert.ToInt32(dataCurr["col_scale", i].Value.ToString());
                    }
                }

                textBoxto.Text = (have / modif).ToString();
            }
            catch { }
        }

        #endregion 


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ErrorReporting.canreport)
            {
                reporting.Close();
            }

            AppSettings.Settings.SaveRate();
            AppSettings.Settings.SaveRateShort();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                labelToday.Text = "Loaded rates";
                AppSettings.Settings.LoadRate();
                AppSettings.Settings.LoadRateShort();
                if (AppSettings.Settings.RatesShort != null)
                {
                    ShowInForm(dataCurr, AppSettings.Settings.RatesShort);
                    UpdateComboBox(comboBoxfrom, dataCurr);
                    UpdateComboBox(comboBoxto, dataCurr);                  
                }
                if (AppSettings.Settings.Rates != null)
                {
                    comboBoxCurrStat.Items.Clear();
                    foreach (Rate item in AppSettings.Settings.Rates)
                    {
                        comboBoxCurrStat.Items.Add(item.Cur_Name);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }

        private void buttonSaveRate_Click(object sender, EventArgs e)
        {
            if (AppSettings.Settings.SaveRate())
            {
                labelSett.Text = "Rates Saved";
            }
            else
            {
                labelSett.Text = "Saving error!";
            }
        }

        private void buttonSaveRateShort_Click(object sender, EventArgs e)
        {
            if (AppSettings.Settings.SaveRateShort())
            {
                labelSett.Text = "Rates Short Saved";
            }
            else
            {
                labelSett.Text = "Saving error!";
            }
        }

        private void buttonLeaveComment_Click(object sender, EventArgs e)
        {
            labelThanks.Text = "Thanks!";
            AppSettings.Settings.SaveWish(textBoxWish.Lines);
            textBoxWish.Text = "";
        }

        private void buttonCleanErrors_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(".", "*.err", SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                if (ErrorReporting.canreport)
                {
                    reporting.ReportError(ex.ToString());
                }
                labelLastErr.Text = ex.ToString();
            }
        }
    }
}
