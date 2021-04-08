namespace International_Travel_ATM
{
    partial class MainForm
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
            this.balLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.depwithGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawGroupBox = new System.Windows.Forms.GroupBox();
            this.wthdrwLabel = new System.Windows.Forms.Label();
            this.withDrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.dpLabel = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.exGroupBox = new System.Windows.Forms.GroupBox();
            this.ratesOfExchangeGroupBox = new System.Windows.Forms.GroupBox();
            this.seeRatesButton = new System.Windows.Forms.Button();
            this.seeRateGroupBox = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.trvlGroupBox = new System.Windows.Forms.GroupBox();
            this.greatBritainRadioButton = new System.Windows.Forms.RadioButton();
            this.japanRadioButton = new System.Windows.Forms.RadioButton();
            this.indiaRadioButton = new System.Windows.Forms.RadioButton();
            this.mexicoRadioButton = new System.Windows.Forms.RadioButton();
            this.brazilRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amntexLabel = new System.Windows.Forms.Label();
            this.exchangeAmountTextBox = new System.Windows.Forms.TextBox();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.depwithGroupBox.SuspendLayout();
            this.withdrawGroupBox.SuspendLayout();
            this.depositGroupBox.SuspendLayout();
            this.exGroupBox.SuspendLayout();
            this.ratesOfExchangeGroupBox.SuspendLayout();
            this.trvlGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // balLabel
            // 
            this.balLabel.AutoSize = true;
            this.balLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balLabel.Location = new System.Drawing.Point(108, 37);
            this.balLabel.Name = "balLabel";
            this.balLabel.Size = new System.Drawing.Size(79, 20);
            this.balLabel.TabIndex = 0;
            this.balLabel.Text = "Balance:";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBalanceLabel.Location = new System.Drawing.Point(195, 22);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(115, 35);
            this.accountBalanceLabel.TabIndex = 1;
            // 
            // depwithGroupBox
            // 
            this.depwithGroupBox.Controls.Add(this.withdrawGroupBox);
            this.depwithGroupBox.Controls.Add(this.depositGroupBox);
            this.depwithGroupBox.Controls.Add(this.balLabel);
            this.depwithGroupBox.Controls.Add(this.accountBalanceLabel);
            this.depwithGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depwithGroupBox.Location = new System.Drawing.Point(12, 12);
            this.depwithGroupBox.Name = "depwithGroupBox";
            this.depwithGroupBox.Size = new System.Drawing.Size(432, 241);
            this.depwithGroupBox.TabIndex = 2;
            this.depwithGroupBox.TabStop = false;
            this.depwithGroupBox.Text = "Deposit or Withdraw";
            // 
            // withdrawGroupBox
            // 
            this.withdrawGroupBox.Controls.Add(this.wthdrwLabel);
            this.withdrawGroupBox.Controls.Add(this.withDrawTextBox);
            this.withdrawGroupBox.Controls.Add(this.withdrawButton);
            this.withdrawGroupBox.Location = new System.Drawing.Point(224, 90);
            this.withdrawGroupBox.Name = "withdrawGroupBox";
            this.withdrawGroupBox.Size = new System.Drawing.Size(202, 145);
            this.withdrawGroupBox.TabIndex = 8;
            this.withdrawGroupBox.TabStop = false;
            this.withdrawGroupBox.Text = "Withdraw";
            // 
            // wthdrwLabel
            // 
            this.wthdrwLabel.AutoSize = true;
            this.wthdrwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthdrwLabel.Location = new System.Drawing.Point(17, 61);
            this.wthdrwLabel.Name = "wthdrwLabel";
            this.wthdrwLabel.Size = new System.Drawing.Size(69, 20);
            this.wthdrwLabel.TabIndex = 3;
            this.wthdrwLabel.Text = "Amount:";
            // 
            // withDrawTextBox
            // 
            this.withDrawTextBox.Location = new System.Drawing.Point(92, 55);
            this.withDrawTextBox.Name = "withDrawTextBox";
            this.withDrawTextBox.Size = new System.Drawing.Size(100, 26);
            this.withDrawTextBox.TabIndex = 5;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(53, 101);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(98, 38);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.dpLabel);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Location = new System.Drawing.Point(6, 90);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(198, 145);
            this.depositGroupBox.TabIndex = 7;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "Deposit";
            // 
            // dpLabel
            // 
            this.dpLabel.AutoSize = true;
            this.dpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLabel.Location = new System.Drawing.Point(6, 61);
            this.dpLabel.Name = "dpLabel";
            this.dpLabel.Size = new System.Drawing.Size(69, 20);
            this.dpLabel.TabIndex = 2;
            this.dpLabel.Text = "Amount:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(81, 55);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 26);
            this.depositTextBox.TabIndex = 4;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(50, 101);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(98, 38);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // exGroupBox
            // 
            this.exGroupBox.Controls.Add(this.groupBox1);
            this.exGroupBox.Controls.Add(this.trvlGroupBox);
            this.exGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exGroupBox.Location = new System.Drawing.Point(12, 299);
            this.exGroupBox.Name = "exGroupBox";
            this.exGroupBox.Size = new System.Drawing.Size(665, 250);
            this.exGroupBox.TabIndex = 3;
            this.exGroupBox.TabStop = false;
            this.exGroupBox.Text = "Exchange USD for foreign currency";
            // 
            // ratesOfExchangeGroupBox
            // 
            this.ratesOfExchangeGroupBox.Controls.Add(this.seeRatesButton);
            this.ratesOfExchangeGroupBox.Controls.Add(this.seeRateGroupBox);
            this.ratesOfExchangeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratesOfExchangeGroupBox.Location = new System.Drawing.Point(459, 12);
            this.ratesOfExchangeGroupBox.Name = "ratesOfExchangeGroupBox";
            this.ratesOfExchangeGroupBox.Size = new System.Drawing.Size(218, 241);
            this.ratesOfExchangeGroupBox.TabIndex = 6;
            this.ratesOfExchangeGroupBox.TabStop = false;
            this.ratesOfExchangeGroupBox.Text = "Rates of Exchange";
            // 
            // seeRatesButton
            // 
            this.seeRatesButton.Location = new System.Drawing.Point(60, 139);
            this.seeRatesButton.Name = "seeRatesButton";
            this.seeRatesButton.Size = new System.Drawing.Size(98, 38);
            this.seeRatesButton.TabIndex = 5;
            this.seeRatesButton.Text = "See Rates";
            this.seeRatesButton.UseVisualStyleBackColor = true;
            this.seeRatesButton.Click += new System.EventHandler(this.seeRatesButton_Click);
            // 
            // seeRateGroupBox
            // 
            this.seeRateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeRateGroupBox.Location = new System.Drawing.Point(12, 90);
            this.seeRateGroupBox.Name = "seeRateGroupBox";
            this.seeRateGroupBox.Size = new System.Drawing.Size(192, 46);
            this.seeRateGroupBox.TabIndex = 0;
            this.seeRateGroupBox.Text = "Click here to see current exchange rates";
            this.seeRateGroupBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(289, 555);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit ATM";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // trvlGroupBox
            // 
            this.trvlGroupBox.Controls.Add(this.brazilRadioButton);
            this.trvlGroupBox.Controls.Add(this.mexicoRadioButton);
            this.trvlGroupBox.Controls.Add(this.indiaRadioButton);
            this.trvlGroupBox.Controls.Add(this.japanRadioButton);
            this.trvlGroupBox.Controls.Add(this.greatBritainRadioButton);
            this.trvlGroupBox.Location = new System.Drawing.Point(16, 36);
            this.trvlGroupBox.Name = "trvlGroupBox";
            this.trvlGroupBox.Size = new System.Drawing.Size(309, 196);
            this.trvlGroupBox.TabIndex = 6;
            this.trvlGroupBox.TabStop = false;
            this.trvlGroupBox.Text = "Where are you traveling today?";
            // 
            // greatBritainRadioButton
            // 
            this.greatBritainRadioButton.AutoSize = true;
            this.greatBritainRadioButton.Checked = true;
            this.greatBritainRadioButton.Location = new System.Drawing.Point(17, 34);
            this.greatBritainRadioButton.Name = "greatBritainRadioButton";
            this.greatBritainRadioButton.Size = new System.Drawing.Size(117, 24);
            this.greatBritainRadioButton.TabIndex = 0;
            this.greatBritainRadioButton.Text = "Great Britain";
            this.greatBritainRadioButton.UseVisualStyleBackColor = true;
            // 
            // japanRadioButton
            // 
            this.japanRadioButton.AutoSize = true;
            this.japanRadioButton.Location = new System.Drawing.Point(17, 64);
            this.japanRadioButton.Name = "japanRadioButton";
            this.japanRadioButton.Size = new System.Drawing.Size(71, 24);
            this.japanRadioButton.TabIndex = 1;
            this.japanRadioButton.Text = "Japan";
            this.japanRadioButton.UseVisualStyleBackColor = true;
            // 
            // indiaRadioButton
            // 
            this.indiaRadioButton.AutoSize = true;
            this.indiaRadioButton.Location = new System.Drawing.Point(17, 94);
            this.indiaRadioButton.Name = "indiaRadioButton";
            this.indiaRadioButton.Size = new System.Drawing.Size(62, 24);
            this.indiaRadioButton.TabIndex = 2;
            this.indiaRadioButton.Text = "India";
            this.indiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mexicoRadioButton
            // 
            this.mexicoRadioButton.AutoSize = true;
            this.mexicoRadioButton.Location = new System.Drawing.Point(17, 124);
            this.mexicoRadioButton.Name = "mexicoRadioButton";
            this.mexicoRadioButton.Size = new System.Drawing.Size(76, 24);
            this.mexicoRadioButton.TabIndex = 3;
            this.mexicoRadioButton.Text = "Mexico";
            this.mexicoRadioButton.UseVisualStyleBackColor = true;
            // 
            // brazilRadioButton
            // 
            this.brazilRadioButton.AutoSize = true;
            this.brazilRadioButton.Location = new System.Drawing.Point(17, 153);
            this.brazilRadioButton.Name = "brazilRadioButton";
            this.brazilRadioButton.Size = new System.Drawing.Size(66, 24);
            this.brazilRadioButton.TabIndex = 4;
            this.brazilRadioButton.Text = "Brazil";
            this.brazilRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exchangeButton);
            this.groupBox1.Controls.Add(this.exchangeAmountTextBox);
            this.groupBox1.Controls.Add(this.amntexLabel);
            this.groupBox1.Location = new System.Drawing.Point(347, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How much $USD would you like to exchange?";
            // 
            // amntexLabel
            // 
            this.amntexLabel.AutoSize = true;
            this.amntexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntexLabel.Location = new System.Drawing.Point(41, 70);
            this.amntexLabel.Name = "amntexLabel";
            this.amntexLabel.Size = new System.Drawing.Size(69, 20);
            this.amntexLabel.TabIndex = 7;
            this.amntexLabel.Text = "Amount:";
            // 
            // exchangeAmountTextBox
            // 
            this.exchangeAmountTextBox.Location = new System.Drawing.Point(116, 64);
            this.exchangeAmountTextBox.Name = "exchangeAmountTextBox";
            this.exchangeAmountTextBox.Size = new System.Drawing.Size(100, 26);
            this.exchangeAmountTextBox.TabIndex = 7;
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(100, 115);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(98, 38);
            this.exchangeButton.TabIndex = 7;
            this.exchangeButton.Text = "Exchange";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 605);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ratesOfExchangeGroupBox);
            this.Controls.Add(this.exGroupBox);
            this.Controls.Add(this.depwithGroupBox);
            this.Name = "MainForm";
            this.Text = "International ATM Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.depwithGroupBox.ResumeLayout(false);
            this.depwithGroupBox.PerformLayout();
            this.withdrawGroupBox.ResumeLayout(false);
            this.withdrawGroupBox.PerformLayout();
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.exGroupBox.ResumeLayout(false);
            this.ratesOfExchangeGroupBox.ResumeLayout(false);
            this.trvlGroupBox.ResumeLayout(false);
            this.trvlGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label balLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.GroupBox depwithGroupBox;
        private System.Windows.Forms.GroupBox withdrawGroupBox;
        private System.Windows.Forms.Label wthdrwLabel;
        private System.Windows.Forms.TextBox withDrawTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Label dpLabel;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.GroupBox exGroupBox;
        private System.Windows.Forms.GroupBox ratesOfExchangeGroupBox;
        private System.Windows.Forms.Button seeRatesButton;
        private System.Windows.Forms.Label seeRateGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox exchangeAmountTextBox;
        private System.Windows.Forms.Label amntexLabel;
        private System.Windows.Forms.GroupBox trvlGroupBox;
        private System.Windows.Forms.RadioButton brazilRadioButton;
        private System.Windows.Forms.RadioButton mexicoRadioButton;
        private System.Windows.Forms.RadioButton indiaRadioButton;
        private System.Windows.Forms.RadioButton japanRadioButton;
        private System.Windows.Forms.RadioButton greatBritainRadioButton;
        private System.Windows.Forms.Button exchangeButton;
    }
}

