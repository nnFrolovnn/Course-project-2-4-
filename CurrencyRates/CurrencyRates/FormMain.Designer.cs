namespace CurrencyRates
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelCurrState = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.panelEMS = new System.Windows.Forms.Panel();
            this.labelInfoNetwork = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelToday = new System.Windows.Forms.Label();
            this.dataCurr = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_srate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelExch = new System.Windows.Forms.Panel();
            this.labelErrConvert = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxto = new System.Windows.Forms.ComboBox();
            this.comboBoxfrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.panelStat = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGetStat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCurrStat = new System.Windows.Forms.ComboBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelLastErr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCleanErrors = new System.Windows.Forms.Button();
            this.labelSett = new System.Windows.Forms.Label();
            this.buttonSaveRateShort = new System.Windows.Forms.Button();
            this.buttonSaveRate = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelThanks = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLeaveComment = new System.Windows.Forms.Button();
            this.textBoxWish = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.panelEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurr)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelExch.SuspendLayout();
            this.panelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelControl.Controls.Add(this.panelCurrState);
            this.panelControl.Controls.Add(this.panelTitle);
            this.panelControl.Controls.Add(this.buttonHome);
            this.panelControl.Controls.Add(this.buttonSettings);
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Controls.Add(this.buttonRefresh);
            this.panelControl.Controls.Add(this.buttonStatistics);
            this.panelControl.Controls.Add(this.buttonExchange);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(75, 380);
            this.panelControl.TabIndex = 0;
            // 
            // panelCurrState
            // 
            this.panelCurrState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panelCurrState.Location = new System.Drawing.Point(73, 38);
            this.panelCurrState.Name = "panelCurrState";
            this.panelCurrState.Size = new System.Drawing.Size(2, 52);
            this.panelCurrState.TabIndex = 7;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(75, 37);
            this.panelTitle.TabIndex = 6;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.Location = new System.Drawing.Point(0, 38);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 52);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSettings.Location = new System.Drawing.Point(0, 326);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 52);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(0, 197);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 52);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(0, 250);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 52);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStatistics.Location = new System.Drawing.Point(0, 144);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(75, 52);
            this.buttonStatistics.TabIndex = 2;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonExchange
            // 
            this.buttonExchange.FlatAppearance.BorderSize = 0;
            this.buttonExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExchange.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExchange.ForeColor = System.Drawing.Color.White;
            this.buttonExchange.Image = ((System.Drawing.Image)(resources.GetObject("buttonExchange.Image")));
            this.buttonExchange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExchange.Location = new System.Drawing.Point(0, 91);
            this.buttonExchange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(75, 52);
            this.buttonExchange.TabIndex = 1;
            this.buttonExchange.Text = "Exchange";
            this.buttonExchange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // panelEMS
            // 
            this.panelEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelEMS.Controls.Add(this.labelInfoNetwork);
            this.panelEMS.Controls.Add(this.buttonMin);
            this.panelEMS.Controls.Add(this.buttonExit);
            this.panelEMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEMS.Location = new System.Drawing.Point(75, 0);
            this.panelEMS.Name = "panelEMS";
            this.panelEMS.Size = new System.Drawing.Size(367, 38);
            this.panelEMS.TabIndex = 1;
            this.panelEMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.panelEMS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            this.panelEMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // labelInfoNetwork
            // 
            this.labelInfoNetwork.AutoSize = true;
            this.labelInfoNetwork.Location = new System.Drawing.Point(0, 0);
            this.labelInfoNetwork.Name = "labelInfoNetwork";
            this.labelInfoNetwork.Size = new System.Drawing.Size(0, 17);
            this.labelInfoNetwork.TabIndex = 7;
            // 
            // buttonMin
            // 
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMin.Location = new System.Drawing.Point(283, 0);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(41, 39);
            this.buttonMin.TabIndex = 6;
            this.buttonMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(324, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(43, 39);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Location = new System.Drawing.Point(5, 0);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(89, 17);
            this.labelToday.TabIndex = 0;
            this.labelToday.Text = "Rates today:";
            // 
            // dataCurr
            // 
            this.dataCurr.AllowUserToAddRows = false;
            this.dataCurr.AllowUserToDeleteRows = false;
            this.dataCurr.AllowUserToResizeColumns = false;
            this.dataCurr.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dataCurr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCurr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataCurr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataCurr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCurr.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataCurr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCurr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCurr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_srate,
            this.col_brate,
            this.col_scale});
            this.dataCurr.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCurr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCurr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCurr.EnableHeadersVisualStyles = false;
            this.dataCurr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataCurr.Location = new System.Drawing.Point(2, 20);
            this.dataCurr.MultiSelect = false;
            this.dataCurr.Name = "dataCurr";
            this.dataCurr.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCurr.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCurr.RowHeadersVisible = false;
            this.dataCurr.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.dataCurr.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataCurr.RowTemplate.Height = 15;
            this.dataCurr.Size = new System.Drawing.Size(361, 322);
            this.dataCurr.TabIndex = 4;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 140;
            // 
            // col_srate
            // 
            this.col_srate.HeaderText = "Sell rate";
            this.col_srate.Name = "col_srate";
            this.col_srate.ReadOnly = true;
            // 
            // col_brate
            // 
            this.col_brate.HeaderText = "Buy rate";
            this.col_brate.Name = "col_brate";
            this.col_brate.ReadOnly = true;
            // 
            // col_scale
            // 
            this.col_scale.HeaderText = "Scale";
            this.col_scale.Name = "col_scale";
            this.col_scale.ReadOnly = true;
            this.col_scale.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(345, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 323);
            this.panel1.TabIndex = 5;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.labelToday);
            this.panelHome.Controls.Add(this.panel1);
            this.panelHome.Controls.Add(this.dataCurr);
            this.panelHome.Location = new System.Drawing.Point(76, 38);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(363, 62);
            this.panelHome.TabIndex = 6;
            // 
            // panelExch
            // 
            this.panelExch.Controls.Add(this.label8);
            this.panelExch.Controls.Add(this.label7);
            this.panelExch.Controls.Add(this.labelErrConvert);
            this.panelExch.Controls.Add(this.button2);
            this.panelExch.Controls.Add(this.comboBoxto);
            this.panelExch.Controls.Add(this.comboBoxfrom);
            this.panelExch.Controls.Add(this.label2);
            this.panelExch.Controls.Add(this.textBoxto);
            this.panelExch.Controls.Add(this.label1);
            this.panelExch.Controls.Add(this.textBoxfrom);
            this.panelExch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExch.Location = new System.Drawing.Point(75, 38);
            this.panelExch.Name = "panelExch";
            this.panelExch.Size = new System.Drawing.Size(367, 342);
            this.panelExch.TabIndex = 7;
            // 
            // labelErrConvert
            // 
            this.labelErrConvert.AutoSize = true;
            this.labelErrConvert.Location = new System.Drawing.Point(5, 159);
            this.labelErrConvert.Name = "labelErrConvert";
            this.labelErrConvert.Size = new System.Drawing.Size(0, 17);
            this.labelErrConvert.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxto
            // 
            this.comboBoxto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.comboBoxto.FormattingEnabled = true;
            this.comboBoxto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxto.Location = new System.Drawing.Point(149, 73);
            this.comboBoxto.Name = "comboBoxto";
            this.comboBoxto.Size = new System.Drawing.Size(200, 25);
            this.comboBoxto.TabIndex = 5;
            // 
            // comboBoxfrom
            // 
            this.comboBoxfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxfrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.comboBoxfrom.FormattingEnabled = true;
            this.comboBoxfrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxfrom.Location = new System.Drawing.Point(149, 28);
            this.comboBoxfrom.Name = "comboBoxfrom";
            this.comboBoxfrom.Size = new System.Drawing.Size(200, 25);
            this.comboBoxfrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // textBoxto
            // 
            this.textBoxto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxto.Location = new System.Drawing.Point(5, 73);
            this.textBoxto.Name = "textBoxto";
            this.textBoxto.ReadOnly = true;
            this.textBoxto.Size = new System.Drawing.Size(130, 23);
            this.textBoxto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxfrom.Location = new System.Drawing.Point(5, 28);
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.Size = new System.Drawing.Size(130, 23);
            this.textBoxfrom.TabIndex = 0;
            // 
            // panelStat
            // 
            this.panelStat.Controls.Add(this.label4);
            this.panelStat.Controls.Add(this.myChart);
            this.panelStat.Controls.Add(this.buttonGetStat);
            this.panelStat.Controls.Add(this.label3);
            this.panelStat.Controls.Add(this.comboBoxCurrStat);
            this.panelStat.Location = new System.Drawing.Point(89, 116);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(331, 52);
            this.panelStat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Exchange rate statistics for the month";
            // 
            // myChart
            // 
            this.myChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.myChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Statistics";
            this.myChart.ChartAreas.Add(chartArea1);
            this.myChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myChart.Location = new System.Drawing.Point(0, 32);
            this.myChart.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.myChart.Name = "myChart";
            series1.ChartArea = "Statistics";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.MarkerBorderWidth = 2;
            series1.Name = "Statistics";
            series1.YValuesPerPoint = 2;
            this.myChart.Series.Add(series1);
            this.myChart.Size = new System.Drawing.Size(331, 20);
            this.myChart.TabIndex = 10;
            this.myChart.Text = "chart1";
            // 
            // buttonGetStat
            // 
            this.buttonGetStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetStat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetStat.ForeColor = System.Drawing.Color.White;
            this.buttonGetStat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGetStat.Location = new System.Drawing.Point(3, 55);
            this.buttonGetStat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetStat.Name = "buttonGetStat";
            this.buttonGetStat.Size = new System.Drawing.Size(325, 30);
            this.buttonGetStat.TabIndex = 9;
            this.buttonGetStat.Text = "Get Statistics";
            this.buttonGetStat.UseVisualStyleBackColor = true;
            this.buttonGetStat.Click += new System.EventHandler(this.buttonGetStat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose value: ";
            // 
            // comboBoxCurrStat
            // 
            this.comboBoxCurrStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxCurrStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCurrStat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCurrStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.comboBoxCurrStat.FormattingEnabled = true;
            this.comboBoxCurrStat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCurrStat.Location = new System.Drawing.Point(3, 26);
            this.comboBoxCurrStat.Name = "comboBoxCurrStat";
            this.comboBoxCurrStat.Size = new System.Drawing.Size(325, 25);
            this.comboBoxCurrStat.TabIndex = 5;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelLastErr);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.buttonCleanErrors);
            this.panelSettings.Controls.Add(this.labelSett);
            this.panelSettings.Controls.Add(this.buttonSaveRateShort);
            this.panelSettings.Controls.Add(this.buttonSaveRate);
            this.panelSettings.Location = new System.Drawing.Point(89, 197);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(200, 145);
            this.panelSettings.TabIndex = 9;
            // 
            // labelLastErr
            // 
            this.labelLastErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.labelLastErr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLastErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelLastErr.Location = new System.Drawing.Point(7, 133);
            this.labelLastErr.Multiline = true;
            this.labelLastErr.Name = "labelLastErr";
            this.labelLastErr.ReadOnly = true;
            this.labelLastErr.Size = new System.Drawing.Size(356, 160);
            this.labelLastErr.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last Error:";
            // 
            // buttonCleanErrors
            // 
            this.buttonCleanErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanErrors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCleanErrors.ForeColor = System.Drawing.Color.White;
            this.buttonCleanErrors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCleanErrors.Location = new System.Drawing.Point(194, 20);
            this.buttonCleanErrors.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCleanErrors.Name = "buttonCleanErrors";
            this.buttonCleanErrors.Size = new System.Drawing.Size(157, 28);
            this.buttonCleanErrors.TabIndex = 12;
            this.buttonCleanErrors.Text = "Delete Error files";
            this.buttonCleanErrors.UseVisualStyleBackColor = true;
            this.buttonCleanErrors.Click += new System.EventHandler(this.buttonCleanErrors_Click);
            // 
            // labelSett
            // 
            this.labelSett.AutoSize = true;
            this.labelSett.Location = new System.Drawing.Point(11, 318);
            this.labelSett.Name = "labelSett";
            this.labelSett.Size = new System.Drawing.Size(0, 17);
            this.labelSett.TabIndex = 11;
            // 
            // buttonSaveRateShort
            // 
            this.buttonSaveRateShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRateShort.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRateShort.ForeColor = System.Drawing.Color.White;
            this.buttonSaveRateShort.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveRateShort.Location = new System.Drawing.Point(7, 56);
            this.buttonSaveRateShort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveRateShort.Name = "buttonSaveRateShort";
            this.buttonSaveRateShort.Size = new System.Drawing.Size(157, 27);
            this.buttonSaveRateShort.TabIndex = 10;
            this.buttonSaveRateShort.Text = "Save RateShort";
            this.buttonSaveRateShort.UseVisualStyleBackColor = true;
            this.buttonSaveRateShort.Click += new System.EventHandler(this.buttonSaveRateShort_Click);
            // 
            // buttonSaveRate
            // 
            this.buttonSaveRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRate.ForeColor = System.Drawing.Color.White;
            this.buttonSaveRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveRate.Location = new System.Drawing.Point(7, 21);
            this.buttonSaveRate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveRate.Name = "buttonSaveRate";
            this.buttonSaveRate.Size = new System.Drawing.Size(157, 27);
            this.buttonSaveRate.TabIndex = 9;
            this.buttonSaveRate.Text = "Save Rate";
            this.buttonSaveRate.UseVisualStyleBackColor = true;
            this.buttonSaveRate.Click += new System.EventHandler(this.buttonSaveRate_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelThanks);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.buttonLeaveComment);
            this.panelAdd.Controls.Add(this.textBoxWish);
            this.panelAdd.Location = new System.Drawing.Point(309, 268);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(200, 100);
            this.panelAdd.TabIndex = 10;
            // 
            // labelThanks
            // 
            this.labelThanks.AutoSize = true;
            this.labelThanks.Location = new System.Drawing.Point(7, 242);
            this.labelThanks.Name = "labelThanks";
            this.labelThanks.Size = new System.Drawing.Size(0, 17);
            this.labelThanks.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "your wish or suggestion:";
            // 
            // buttonLeaveComment
            // 
            this.buttonLeaveComment.FlatAppearance.BorderSize = 0;
            this.buttonLeaveComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaveComment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeaveComment.ForeColor = System.Drawing.Color.White;
            this.buttonLeaveComment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLeaveComment.Location = new System.Drawing.Point(9, 203);
            this.buttonLeaveComment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeaveComment.Name = "buttonLeaveComment";
            this.buttonLeaveComment.Size = new System.Drawing.Size(346, 27);
            this.buttonLeaveComment.TabIndex = 10;
            this.buttonLeaveComment.Text = "Leave";
            this.buttonLeaveComment.UseVisualStyleBackColor = true;
            this.buttonLeaveComment.Click += new System.EventHandler(this.buttonLeaveComment_Click);
            // 
            // textBoxWish
            // 
            this.textBoxWish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxWish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxWish.Location = new System.Drawing.Point(9, 24);
            this.textBoxWish.Multiline = true;
            this.textBoxWish.Name = "textBoxWish";
            this.textBoxWish.Size = new System.Drawing.Size(346, 172);
            this.textBoxWish.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter here:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "You can get:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.panelExch);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelStat);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelEMS);
            this.Controls.Add(this.panelControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelControl.ResumeLayout(false);
            this.panelEMS.ResumeLayout(false);
            this.panelEMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurr)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelExch.ResumeLayout(false);
            this.panelExch.PerformLayout();
            this.panelStat.ResumeLayout(false);
            this.panelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.Panel panelEMS;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelCurrState;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.DataGridView dataCurr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelExch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxto;
        private System.Windows.Forms.ComboBox comboBoxfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfrom;
        private System.Windows.Forms.Label labelErrConvert;
        private System.Windows.Forms.Label labelInfoNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_srate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_scale;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCurrStat;
        private System.Windows.Forms.Button buttonGetStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button buttonSaveRate;
        private System.Windows.Forms.Button buttonSaveRateShort;
        private System.Windows.Forms.Label labelSett;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLeaveComment;
        private System.Windows.Forms.TextBox textBoxWish;
        private System.Windows.Forms.Label labelThanks;
        private System.Windows.Forms.Button buttonCleanErrors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox labelLastErr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

