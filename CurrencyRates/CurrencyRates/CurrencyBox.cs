using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRates
{
    public partial class CurrencyBox : UserControl
    {
        public Image CurrencyImage { get { return pictureCurrency.Image; } set { pictureCurrency.Image = value; } }
        public string CurrencySellRate { get { return textBoxSell.Text; } set { textBoxSell.Text = value; } }
        public string CurrencyBuyRate { get { return textBoxBuy.Text; } set { textBoxBuy.Text = value; } }
        public bool CurrencySellInc { set { pictureBoxSell.Image = (value) ? pictureBoxSell.Image = Properties.Resources.Long_Arrow_Up_25px : pictureBoxSell.Image = Properties.Resources.Arrow_Pointing_Down_25px1; } }
        public bool CurrencyBuyInc { set { pictureBoxBuy.Image = (value) ? pictureBoxBuy.Image = Properties.Resources.Long_Arrow_Up_25px : pictureBoxBuy.Image = Properties.Resources.Arrow_Pointing_Down_25px1; } }
        public CurrencyBox()
        {
            InitializeComponent();
        }

        private void CurrencyBox_Resize(object sender, EventArgs e)
        {      
            Font font = new Font("Century Gothic", this.Height / 2);
            Font te = new Font(textBoxSell.Font.Name, this.Height / 2, FontStyle.Regular);

            textBoxBuy.Height = (int)(this.Height);
            textBoxSell.Height = (int)(this.Height);

            textBoxBuy.Font = te;
            textBoxSell.Font = font;

            int temp = this.Width - panelt.Width;
            textBoxBuy.Width = (int)(temp * 0.25);
            textBoxSell.Width = (int)(temp * 0.25);
            pictureBoxBuy.Width = 
            //set location
            textBoxBuy.Left = panelt.Width;
            pictureBoxBuy.Left = textBoxBuy.Left + textBoxBuy.Width;
        }
    }
}
