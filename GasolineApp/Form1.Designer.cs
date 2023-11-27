namespace HomeWork5_Task1_GasStation
{
    partial class bestOilGasStationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateGroupBox = new GroupBox();
            calculateOutputLabel = new Label();
            calculateButton = new Button();
            gasStationGroupBox = new GroupBox();
            gasStationOutputGroupBox = new GroupBox();
            gasStationOutputLabel = new Label();
            petrolAmountTotalGroupBox = new GroupBox();
            totalNumeric = new NumericUpDown();
            amountNumeric = new NumericUpDown();
            petrolTotalRadioButton = new RadioButton();
            petrolAmountRadioButton = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            petrolPriceOtputTextBox = new TextBox();
            petrolTypeComboBox = new ComboBox();
            cafeGroupBox = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cafeOutputLabel = new Label();
            calculateGroupBox.SuspendLayout();
            gasStationGroupBox.SuspendLayout();
            gasStationOutputGroupBox.SuspendLayout();
            petrolAmountTotalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).BeginInit();
            cafeGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // calculateGroupBox
            // 
            calculateGroupBox.BackColor = Color.RosyBrown;
            calculateGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            calculateGroupBox.Controls.Add(calculateOutputLabel);
            calculateGroupBox.Controls.Add(calculateButton);
            calculateGroupBox.Dock = DockStyle.Bottom;
            calculateGroupBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculateGroupBox.Location = new Point(0, 250);
            calculateGroupBox.Margin = new Padding(2);
            calculateGroupBox.Name = "calculateGroupBox";
            calculateGroupBox.Padding = new Padding(2);
            calculateGroupBox.Size = new Size(561, 75);
            calculateGroupBox.TabIndex = 1;
            calculateGroupBox.TabStop = false;
            calculateGroupBox.Text = "ВСЬОГО ДО СПЛАТИ";
            // 
            // calculateOutputLabel
            // 
            calculateOutputLabel.AutoSize = true;
            calculateOutputLabel.Dock = DockStyle.Right;
            calculateOutputLabel.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            calculateOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            calculateOutputLabel.Location = new Point(559, 22);
            calculateOutputLabel.Margin = new Padding(2, 0, 2, 0);
            calculateOutputLabel.Name = "calculateOutputLabel";
            calculateOutputLabel.Size = new Size(0, 58);
            calculateOutputLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.DarkRed;
            calculateButton.BackgroundImageLayout = ImageLayout.Stretch;
            calculateButton.Dock = DockStyle.Left;
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.Font = new Font("Bahnschrift SemiBold Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.Ivory;
            calculateButton.Location = new Point(2, 22);
            calculateButton.Margin = new Padding(2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(133, 51);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "РОЗРАХУВАТИ";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // gasStationGroupBox
            // 
            gasStationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gasStationGroupBox.BackColor = Color.RosyBrown;
            gasStationGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            gasStationGroupBox.Controls.Add(gasStationOutputGroupBox);
            gasStationGroupBox.Controls.Add(petrolAmountTotalGroupBox);
            gasStationGroupBox.Controls.Add(label2);
            gasStationGroupBox.Controls.Add(label1);
            gasStationGroupBox.Controls.Add(petrolPriceOtputTextBox);
            gasStationGroupBox.Controls.Add(petrolTypeComboBox);
            gasStationGroupBox.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gasStationGroupBox.Location = new Point(4, 6);
            gasStationGroupBox.Margin = new Padding(2);
            gasStationGroupBox.Name = "gasStationGroupBox";
            gasStationGroupBox.Padding = new Padding(2);
            gasStationGroupBox.Size = new Size(281, 236);
            gasStationGroupBox.TabIndex = 3;
            gasStationGroupBox.TabStop = false;
            gasStationGroupBox.Text = "АВТОЗАПРАВКА";
            // 
            // gasStationOutputGroupBox
            // 
            gasStationOutputGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gasStationOutputGroupBox.Controls.Add(gasStationOutputLabel);
            gasStationOutputGroupBox.Location = new Point(3, 172);
            gasStationOutputGroupBox.Margin = new Padding(2);
            gasStationOutputGroupBox.Name = "gasStationOutputGroupBox";
            gasStationOutputGroupBox.Padding = new Padding(2);
            gasStationOutputGroupBox.Size = new Size(274, 60);
            gasStationOutputGroupBox.TabIndex = 7;
            gasStationOutputGroupBox.TabStop = false;
            gasStationOutputGroupBox.Text = "ДО СПЛАТИ";
            // 
            // gasStationOutputLabel
            // 
            gasStationOutputLabel.AutoSize = true;
            gasStationOutputLabel.Dock = DockStyle.Right;
            gasStationOutputLabel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            gasStationOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            gasStationOutputLabel.Location = new Point(272, 19);
            gasStationOutputLabel.Margin = new Padding(2, 0, 2, 0);
            gasStationOutputLabel.Name = "gasStationOutputLabel";
            gasStationOutputLabel.Size = new Size(0, 39);
            gasStationOutputLabel.TabIndex = 0;
            // 
            // petrolAmountTotalGroupBox
            // 
            petrolAmountTotalGroupBox.Controls.Add(totalNumeric);
            petrolAmountTotalGroupBox.Controls.Add(amountNumeric);
            petrolAmountTotalGroupBox.Controls.Add(petrolTotalRadioButton);
            petrolAmountTotalGroupBox.Controls.Add(petrolAmountRadioButton);
            petrolAmountTotalGroupBox.Location = new Point(4, 86);
            petrolAmountTotalGroupBox.Margin = new Padding(2);
            petrolAmountTotalGroupBox.Name = "petrolAmountTotalGroupBox";
            petrolAmountTotalGroupBox.Padding = new Padding(2);
            petrolAmountTotalGroupBox.Size = new Size(273, 86);
            petrolAmountTotalGroupBox.TabIndex = 4;
            petrolAmountTotalGroupBox.TabStop = false;
            // 
            // totalNumeric
            // 
            totalNumeric.BackColor = Color.LightCoral;
            totalNumeric.Location = new Point(89, 49);
            totalNumeric.Margin = new Padding(2);
            totalNumeric.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            totalNumeric.Name = "totalNumeric";
            totalNumeric.Size = new Size(152, 24);
            totalNumeric.TabIndex = 3;
            totalNumeric.ValueChanged += totalNumeric_ValueChanged;
            // 
            // amountNumeric
            // 
            amountNumeric.BackColor = Color.LightCoral;
            amountNumeric.Location = new Point(89, 22);
            amountNumeric.Margin = new Padding(2);
            amountNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountNumeric.Name = "amountNumeric";
            amountNumeric.Size = new Size(152, 24);
            amountNumeric.TabIndex = 2;
            amountNumeric.ValueChanged += amountNumeric_ValueChanged;
            // 
            // petrolTotalRadioButton
            // 
            petrolTotalRadioButton.AutoSize = true;
            petrolTotalRadioButton.Location = new Point(5, 49);
            petrolTotalRadioButton.Margin = new Padding(2);
            petrolTotalRadioButton.Name = "petrolTotalRadioButton";
            petrolTotalRadioButton.Size = new Size(52, 21);
            petrolTotalRadioButton.TabIndex = 1;
            petrolTotalRadioButton.Text = "СУМА";
            petrolTotalRadioButton.UseVisualStyleBackColor = true;
            petrolTotalRadioButton.CheckedChanged += SwitchRadioButton_CheckedChanged;
            // 
            // petrolAmountRadioButton
            // 
            petrolAmountRadioButton.AutoSize = true;
            petrolAmountRadioButton.Checked = true;
            petrolAmountRadioButton.Location = new Point(5, 22);
            petrolAmountRadioButton.Margin = new Padding(2);
            petrolAmountRadioButton.Name = "petrolAmountRadioButton";
            petrolAmountRadioButton.Size = new Size(73, 21);
            petrolAmountRadioButton.TabIndex = 0;
            petrolAmountRadioButton.TabStop = true;
            petrolAmountRadioButton.Text = "КІЛЬКІСТЬ";
            petrolAmountRadioButton.UseVisualStyleBackColor = true;
            petrolAmountRadioButton.CheckedChanged += SwitchRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 3;
            label2.Text = "ЦІНА";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 2;
            label1.Text = "ПАЛИВО";
            // 
            // petrolPriceOtputTextBox
            // 
            petrolPriceOtputTextBox.BackColor = Color.LightCoral;
            petrolPriceOtputTextBox.BorderStyle = BorderStyle.FixedSingle;
            petrolPriceOtputTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            petrolPriceOtputTextBox.Location = new Point(93, 56);
            petrolPriceOtputTextBox.Margin = new Padding(2);
            petrolPriceOtputTextBox.Name = "petrolPriceOtputTextBox";
            petrolPriceOtputTextBox.ReadOnly = true;
            petrolPriceOtputTextBox.Size = new Size(152, 24);
            petrolPriceOtputTextBox.TabIndex = 1;
            // 
            // petrolTypeComboBox
            // 
            petrolTypeComboBox.BackColor = Color.LightCoral;
            petrolTypeComboBox.FlatStyle = FlatStyle.Popup;
            petrolTypeComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            petrolTypeComboBox.FormattingEnabled = true;
            petrolTypeComboBox.IntegralHeight = false;
            petrolTypeComboBox.Location = new Point(93, 30);
            petrolTypeComboBox.Margin = new Padding(2);
            petrolTypeComboBox.MaxDropDownItems = 6;
            petrolTypeComboBox.Name = "petrolTypeComboBox";
            petrolTypeComboBox.RightToLeft = RightToLeft.No;
            petrolTypeComboBox.Size = new Size(152, 25);
            petrolTypeComboBox.TabIndex = 0;
            petrolTypeComboBox.SelectedIndexChanged += petrolTypeComboBox_SelectedIndexChanged;
            // 
            // cafeGroupBox
            // 
            cafeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cafeGroupBox.BackColor = Color.RosyBrown;
            cafeGroupBox.Controls.Add(label5);
            cafeGroupBox.Controls.Add(label4);
            cafeGroupBox.Controls.Add(groupBox1);
            cafeGroupBox.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cafeGroupBox.Location = new Point(289, 6);
            cafeGroupBox.Margin = new Padding(2);
            cafeGroupBox.Name = "cafeGroupBox";
            cafeGroupBox.Padding = new Padding(2);
            cafeGroupBox.Size = new Size(268, 236);
            cafeGroupBox.TabIndex = 4;
            cafeGroupBox.TabStop = false;
            cafeGroupBox.Text = "МІНІ-КАФЕ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 33);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 10;
            label5.Text = "КІЛЬКІСТЬ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 33);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(29, 17);
            label4.TabIndex = 9;
            label4.Text = "ЦІНА";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(cafeOutputLabel);
            groupBox1.Location = new Point(4, 172);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(260, 60);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ДО СПЛАТИ";
            // 
            // cafeOutputLabel
            // 
            cafeOutputLabel.AutoSize = true;
            cafeOutputLabel.Dock = DockStyle.Right;
            cafeOutputLabel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            cafeOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            cafeOutputLabel.Location = new Point(258, 19);
            cafeOutputLabel.Margin = new Padding(2, 0, 2, 0);
            cafeOutputLabel.Name = "cafeOutputLabel";
            cafeOutputLabel.Size = new Size(0, 39);
            cafeOutputLabel.TabIndex = 0;
            // 
            // bestOilGasStationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(561, 325);
            Controls.Add(cafeGroupBox);
            Controls.Add(gasStationGroupBox);
            Controls.Add(calculateGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "bestOilGasStationForm";
            Text = "Best Oil";
            Load += bestOilGasStationForm_Load;
            calculateGroupBox.ResumeLayout(false);
            calculateGroupBox.PerformLayout();
            gasStationGroupBox.ResumeLayout(false);
            gasStationGroupBox.PerformLayout();
            gasStationOutputGroupBox.ResumeLayout(false);
            gasStationOutputGroupBox.PerformLayout();
            petrolAmountTotalGroupBox.ResumeLayout(false);
            petrolAmountTotalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).EndInit();
            cafeGroupBox.ResumeLayout(false);
            cafeGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox calculateGroupBox;
        private Button calculateButton;
        private Label calculateOutputLabel;
        private GroupBox gasStationGroupBox;
        private GroupBox cafeGroupBox;
        private TextBox petrolPriceOtputTextBox;
        private ComboBox petrolTypeComboBox;
        private Label label2;
        private Label label1;
        private GroupBox petrolAmountTotalGroupBox;
        private RadioButton petrolTotalRadioButton;
        private RadioButton petrolAmountRadioButton;
        private GroupBox gasStationOutputGroupBox;
        private Label gasStationOutputLabel;
        private GroupBox groupBox1;
        private Label cafeOutputLabel;
        private Label label5;
        private Label label4;
        private NumericUpDown totalNumeric;
        private NumericUpDown amountNumeric;
    }
}