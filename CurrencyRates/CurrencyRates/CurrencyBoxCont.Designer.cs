namespace CurrencyRates
{
    partial class CurrencyBoxCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyBoxCont));
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.textBoxBuy = new System.Windows.Forms.TextBox();
            this.pictureBoxBuy = new System.Windows.Forms.PictureBox();
            this.pictureBoxSell = new System.Windows.Forms.PictureBox();
            this.currName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSell
            // 
            this.textBoxSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSell.Enabled = false;
            this.textBoxSell.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxSell.Location = new System.Drawing.Point(71, 0);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new System.Drawing.Size(80, 23);
            this.textBoxSell.TabIndex = 2;
            this.textBoxSell.Text = "2.0200";
            // 
            // textBoxBuy
            // 
            this.textBoxBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuy.Enabled = false;
            this.textBoxBuy.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxBuy.Location = new System.Drawing.Point(178, 0);
            this.textBoxBuy.Name = "textBoxBuy";
            this.textBoxBuy.Size = new System.Drawing.Size(80, 23);
            this.textBoxBuy.TabIndex = 3;
            this.textBoxBuy.Text = "2.0150";
            // 
            // pictureBoxBuy
            // 
            this.pictureBoxBuy.Enabled = false;
            this.pictureBoxBuy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuy.Image")));
            this.pictureBoxBuy.Location = new System.Drawing.Point(159, 0);
            this.pictureBoxBuy.Name = "pictureBoxBuy";
            this.pictureBoxBuy.Size = new System.Drawing.Size(17, 20);
            this.pictureBoxBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBuy.TabIndex = 8;
            this.pictureBoxBuy.TabStop = false;
            // 
            // pictureBoxSell
            // 
            this.pictureBoxSell.Enabled = false;
            this.pictureBoxSell.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSell.Image")));
            this.pictureBoxSell.Location = new System.Drawing.Point(54, 0);
            this.pictureBoxSell.Name = "pictureBoxSell";
            this.pictureBoxSell.Size = new System.Drawing.Size(17, 20);
            this.pictureBoxSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSell.TabIndex = 7;
            this.pictureBoxSell.TabStop = false;
            // 
            // currName
            // 
            this.currName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.currName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currName.Enabled = false;
            this.currName.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.currName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.currName.Location = new System.Drawing.Point(0, 0);
            this.currName.Name = "currName";
            this.currName.Size = new System.Drawing.Size(45, 23);
            this.currName.TabIndex = 9;
            // 
            // CurrencyBoxCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.currName);
            this.Controls.Add(this.textBoxBuy);
            this.Controls.Add(this.pictureBoxBuy);
            this.Controls.Add(this.textBoxSell);
            this.Controls.Add(this.pictureBoxSell);
            this.Enabled = false;
            this.Name = "CurrencyBoxCont";
            this.Size = new System.Drawing.Size(260, 20);
            this.Load += new System.EventHandler(this.CurrencyBoxCont_Load);
            this.Resize += new System.EventHandler(this.CurrencyBox_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBuy;
        private System.Windows.Forms.PictureBox pictureBoxSell;
        private System.Windows.Forms.PictureBox pictureBoxBuy;
        private System.Windows.Forms.TextBox textBoxSell;
        private System.Windows.Forms.TextBox currName;
    }
}
