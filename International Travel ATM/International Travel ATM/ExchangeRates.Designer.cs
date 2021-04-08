namespace International_Travel_ATM
{
    partial class ExchangeRates
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
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.exrtLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.exrateLabel = new System.Windows.Forms.Label();
            this.exchangeRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 20;
            this.countriesListBox.Location = new System.Drawing.Point(19, 84);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(282, 144);
            this.countriesListBox.TabIndex = 0;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // exrtLabel
            // 
            this.exrtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrtLabel.Location = new System.Drawing.Point(25, 18);
            this.exrtLabel.Name = "exrtLabel";
            this.exrtLabel.Size = new System.Drawing.Size(270, 63);
            this.exrtLabel.TabIndex = 1;
            this.exrtLabel.Text = "Click on a country to see the current exchange rate per $1.00 USD";
            this.exrtLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(118, 316);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 36);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // exrateLabel
            // 
            this.exrateLabel.AutoSize = true;
            this.exrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrateLabel.Location = new System.Drawing.Point(12, 283);
            this.exrateLabel.Name = "exrateLabel";
            this.exrateLabel.Size = new System.Drawing.Size(123, 20);
            this.exrateLabel.TabIndex = 3;
            this.exrateLabel.Text = "Exchange Rate:";
            // 
            // exchangeRateLabel
            // 
            this.exchangeRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exchangeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateLabel.Location = new System.Drawing.Point(141, 275);
            this.exchangeRateLabel.Name = "exchangeRateLabel";
            this.exchangeRateLabel.Size = new System.Drawing.Size(140, 28);
            this.exchangeRateLabel.TabIndex = 4;
            // 
            // ExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 364);
            this.Controls.Add(this.exchangeRateLabel);
            this.Controls.Add(this.exrateLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exrtLabel);
            this.Controls.Add(this.countriesListBox);
            this.Name = "ExchangeRates";
            this.Text = "ExchangeRates";
            this.Load += new System.EventHandler(this.ExchangeRates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Label exrtLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label exrateLabel;
        private System.Windows.Forms.Label exchangeRateLabel;
    }
}