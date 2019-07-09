namespace OptionsPricing
{
    partial class OptionsPricing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStockPrice = new System.Windows.Forms.TextBox();
            this.textBoxStrikePrice = new System.Windows.Forms.TextBox();
            this.textBoxTimeToMat = new System.Windows.Forms.TextBox();
            this.textBoxStdDev = new System.Windows.Forms.TextBox();
            this.textBoxRiskFreeRate = new System.Windows.Forms.TextBox();
            this.PriceButton = new System.Windows.Forms.Button();
            this.textBoxCallPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPutPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strike Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time To Maturity (Years)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Standard Deviation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Risk Free Rate";
            // 
            // textBoxStockPrice
            // 
            this.textBoxStockPrice.Location = new System.Drawing.Point(15, 43);
            this.textBoxStockPrice.Name = "textBoxStockPrice";
            this.textBoxStockPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxStockPrice.TabIndex = 5;
            // 
            // textBoxStrikePrice
            // 
            this.textBoxStrikePrice.Location = new System.Drawing.Point(12, 132);
            this.textBoxStrikePrice.Name = "textBoxStrikePrice";
            this.textBoxStrikePrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxStrikePrice.TabIndex = 6;
            // 
            // textBoxTimeToMat
            // 
            this.textBoxTimeToMat.Location = new System.Drawing.Point(12, 225);
            this.textBoxTimeToMat.Name = "textBoxTimeToMat";
            this.textBoxTimeToMat.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeToMat.TabIndex = 7;
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Location = new System.Drawing.Point(12, 303);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(100, 22);
            this.textBoxStdDev.TabIndex = 8;
            // 
            // textBoxRiskFreeRate
            // 
            this.textBoxRiskFreeRate.Location = new System.Drawing.Point(12, 397);
            this.textBoxRiskFreeRate.Name = "textBoxRiskFreeRate";
            this.textBoxRiskFreeRate.Size = new System.Drawing.Size(100, 22);
            this.textBoxRiskFreeRate.TabIndex = 9;
            // 
            // PriceButton
            // 
            this.PriceButton.Location = new System.Drawing.Point(440, 46);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(131, 38);
            this.PriceButton.TabIndex = 10;
            this.PriceButton.Text = "Price";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // textBoxCallPrice
            // 
            this.textBoxCallPrice.Location = new System.Drawing.Point(440, 178);
            this.textBoxCallPrice.Name = "textBoxCallPrice";
            this.textBoxCallPrice.ReadOnly = true;
            this.textBoxCallPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxCallPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Call Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Put Price";
            // 
            // textBoxPutPrice
            // 
            this.textBoxPutPrice.Location = new System.Drawing.Point(440, 268);
            this.textBoxPutPrice.Name = "textBoxPutPrice";
            this.textBoxPutPrice.ReadOnly = true;
            this.textBoxPutPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPutPrice.TabIndex = 14;
            // 
            // OptionsPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPutPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCallPrice);
            this.Controls.Add(this.PriceButton);
            this.Controls.Add(this.textBoxRiskFreeRate);
            this.Controls.Add(this.textBoxStdDev);
            this.Controls.Add(this.textBoxTimeToMat);
            this.Controls.Add(this.textBoxStrikePrice);
            this.Controls.Add(this.textBoxStockPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsPricing";
            this.Text = "OptionsPricing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStockPrice;
        private System.Windows.Forms.TextBox textBoxStrikePrice;
        private System.Windows.Forms.TextBox textBoxTimeToMat;
        private System.Windows.Forms.TextBox textBoxStdDev;
        private System.Windows.Forms.TextBox textBoxRiskFreeRate;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.TextBox textBoxCallPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPutPrice;
    }
}

