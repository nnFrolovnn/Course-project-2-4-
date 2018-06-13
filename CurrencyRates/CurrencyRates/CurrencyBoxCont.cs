using CurrencyRates.NBRB;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace CurrencyRates
{
    public partial class CurrencyBoxCont : UserControl
    {
        public string CurrencyName { get { return currName.Text; } set { currName.Text = value; } }
        public string CurrencySellRate { get { return textBoxSell.Text; } set { textBoxSell.Text = value; } }
        public string CurrencyBuyRate { get { return textBoxBuy.Text; } set { textBoxBuy.Text = value; } }
        public Image CurrencySellInc { set { pictureBoxSell.Image = (value); } }
        public Image CurrencyBuyInc { set { pictureBoxBuy.Image = (value); } }
        public Rate CurrencyRate { get => CurrencyRate; set => CurrencyRate = value; }
        public CurrencyBoxCont()
        {
            InitializeComponent();
            CurrencyBox_Resize(this, new EventArgs());
        }

        private void CurrencyBox_Resize(object sender, EventArgs e)
        {      
            Font font = new Font(textBoxSell.Font.Name, (float)(this.Height / 1.5), FontStyle.Regular);

            textBoxBuy.Font = font;
            textBoxSell.Font = font;

            Size size = new Size(17, 20);
            pictureBoxBuy.Size = size;
            pictureBoxSell.Size = size;

            size = new Size(80, 23);
            textBoxBuy.Size = size;
            textBoxSell.Size = size;

            textBoxSell.Left = 180;
            textBoxBuy.Left = 73;
            pictureBoxBuy.Left = 161;
            pictureBoxSell.Left = 56;

            this.Width = 260;
            this.Height = 20;
        }

        private void CurrencyBoxCont_Load(object sender, EventArgs e)
        {
            CurrencyBox_Resize(this, new EventArgs());
        }
    }
}
