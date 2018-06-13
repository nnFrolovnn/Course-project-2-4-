namespace CurrencyRates
{
    partial class CurrencyBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyBox));
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.textBoxBuy = new System.Windows.Forms.TextBox();
            this.panelt = new System.Windows.Forms.Panel();
            this.pictureCurrency = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuy = new System.Windows.Forms.PictureBox();
            this.pictureBoxSell = new System.Windows.Forms.PictureBox();
            this.panelt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSell
            // 
            this.textBoxSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSell.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSell.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSell.Location = new System.Drawing.Point(46, 0);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new System.Drawing.Size(80, 23);
            this.textBoxSell.TabIndex = 2;
            this.textBoxSell.Text = "2.0200";
            // 
            // textBoxBuy
            // 
            this.textBoxBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxBuy.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxBuy.Location = new System.Drawing.Point(143, 0);
            this.textBoxBuy.Name = "textBoxBuy";
            this.textBoxBuy.Size = new System.Drawing.Size(80, 23);
            this.textBoxBuy.TabIndex = 3;
            this.textBoxBuy.Text = "2.0150";
            // 
            // panelt
            // 
            this.panelt.Controls.Add(this.pictureCurrency);
            this.panelt.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelt.Location = new System.Drawing.Point(0, 0);
            this.panelt.Name = "panelt";
            this.panelt.Size = new System.Drawing.Size(46, 213);
            this.panelt.TabIndex = 6;
            // 
            // pictureCurrency
            // 
            this.pictureCurrency.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureCurrency.Image = ((System.Drawing.Image)(resources.GetObject("pictureCurrency.Image")));
            this.pictureCurrency.Location = new System.Drawing.Point(0, 0);
            this.pictureCurrency.Name = "pictureCurrency";
            this.pictureCurrency.Size = new System.Drawing.Size(34, 213);
            this.pictureCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCurrency.TabIndex = 0;
            this.pictureCurrency.TabStop = false;
            // 
            // pictureBoxBuy
            // 
            this.pictureBoxBuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBuy.Location = new System.Drawing.Point(223, 0);
            this.pictureBoxBuy.Name = "pictureBoxBuy";
            this.pictureBoxBuy.Size = new System.Drawing.Size(13, 213);
            this.pictureBoxBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBuy.TabIndex = 8;
            this.pictureBoxBuy.TabStop = false;
            // 
            // pictureBoxSell
            // 
            this.pictureBoxSell.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSell.Location = new System.Drawing.Point(126, 0);
            this.pictureBoxSell.Name = "pictureBoxSell";
            this.pictureBoxSell.Size = new System.Drawing.Size(17, 213);
            this.pictureBoxSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSell.TabIndex = 7;
            this.pictureBoxSell.TabStop = false;
            // 
            // CurrencyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pictureBoxBuy);
            this.Controls.Add(this.textBoxBuy);
            this.Controls.Add(this.pictureBoxSell);
            this.Controls.Add(this.textBoxSell);
            this.Controls.Add(this.panelt);
            this.Name = "CurrencyBox";
            this.Size = new System.Drawing.Size(419, 213);
            this.Resize += new System.EventHandler(this.CurrencyBox_Resize);
            this.panelt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCurrency;
        private System.Windows.Forms.TextBox textBoxBuy;
        private System.Windows.Forms.Panel panelt;
        private System.Windows.Forms.PictureBox pictureBoxSell;
        private System.Windows.Forms.PictureBox pictureBoxBuy;
        private System.Windows.Forms.TextBox textBoxSell;
    }
}
