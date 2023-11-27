using System.Data;


namespace HomeWork5_Task1_GasStation
{
    public partial class bestOilGasStationForm : Form
    {
        private decimal totalIncome;
        private Product[] petroliumTypes;
        private Product[] menu;
        private Cart cart;
        public bestOilGasStationForm()
        {
            InitializeComponent();

            petroliumTypes = new Product[]
            {
                new Product{ Name = "A 92", Price = 52.75m },
                new Product{ Name = "A 95", Price = 55.59m },
                new Product{ Name = "A 95+", Price = 56.74m },
                new Product{ Name = "Diesel", Price = 55.69m },
                new Product{ Name = "Gas", Price = 29.97m }
            };

            menu = new Product[]
            {
                new Product{ Name = "HOT-DOG", Price = 70m },
                new Product{ Name = "HAMBURGER", Price = 125m },
                new Product{ Name = "FRIES", Price = 80m },
                new Product{ Name = "COCA-COLA", Price = 45m }
            };

            cart = new Cart();
        }

        private void InitilizeCafeMenu()
        {
            int top = 75, topOffset = 35, left = 10, textBoxOffset = 134, numericOffset = 178;

            for (int i = 0; i < menu.Length; ++i)
            {
                CheckBox cafeCheckBox = new CheckBox()
                {
                    Name = $"CheckBox-{menu[i].Id}",
                    Text = menu[i].Name,
                    Location = new Point(left, top)
                };

                cafeCheckBox.CheckedChanged += CafeCheckBox_CheckedChanged;

                TextBox cafeTextBox = new TextBox()
                {
                    Text = menu[i].Price.ToString(),
                    BorderStyle = BorderStyle.FixedSingle,
                    Enabled = false,
                    BackColor = Color.AntiqueWhite,
                    Width = 34,
                    Height = 28,
                    Location = new Point(left + textBoxOffset, top)
                };

                NumericUpDown cafeNumericUpDown = new NumericUpDown()
                {
                    Name = $"Numeric-{menu[i].Id}",
                    BorderStyle = BorderStyle.FixedSingle,
                    Minimum = 0,
                    Enabled = false,
                    BackColor = Color.AntiqueWhite,
                    Width = 50,
                    Height = 28,
                    Location = new Point(left + numericOffset, top)
                };

                cafeNumericUpDown.ValueChanged += CafeNumericUpDown_ValueChanged;

                cafeGroupBox.Controls.Add(cafeCheckBox);
                cafeGroupBox.Controls.Add(cafeTextBox);
                cafeGroupBox.Controls.Add(cafeNumericUpDown);

                top = cafeCheckBox.Top + topOffset;
            }

        }

        private void CafeNumericUpDown_ValueChanged(object? sender, EventArgs e)
        {
            NumericUpDown selectedNumeric = sender as NumericUpDown;
            string id = selectedNumeric.Name.Substring(selectedNumeric.Name.IndexOf('-') + 1);
            cart.ChangeAmount(id, (int)selectedNumeric.Value);
            cafeOutputLabel.Text = cart.TotalMiniCafe.ToString("C");
            calculateOutputLabel.Text = cart.TotalToPay.ToString("C");
        }

        private void CafeCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox selectedCheckBox = sender as CheckBox;
            string id = selectedCheckBox.Name.Substring(selectedCheckBox.Name.IndexOf('-') + 1);

            NumericUpDown selectedNumeric = cafeGroupBox.Controls.OfType<NumericUpDown>()
                .FirstOrDefault(e => e.Name.Equals($"Numeric-{id}"));

            if (selectedCheckBox.Checked)
            {
                selectedNumeric.Enabled = true;
                selectedNumeric.BackColor = Color.Ivory;
                selectedNumeric.Value = 1;

                cart.AddProduct(menu.FirstOrDefault(e => e.Id.Equals(id)));
            }
            else
            {
                selectedNumeric.Enabled = false;
                selectedNumeric.BackColor = Color.AntiqueWhite;
                selectedNumeric.Value = 0;

                cart.RemoveProduct(menu.FirstOrDefault(e => e.Id.Equals(id)));
            }
            cafeOutputLabel.Text = cart.TotalMiniCafe.ToString("C");
            calculateOutputLabel.Text = cart.TotalToPay.ToString("C");
        }
        private void bestOilGasStationForm_Load(object sender, EventArgs e)
        {
            amountNumeric.BackColor = Color.Ivory;
            totalNumeric.BackColor = Color.AntiqueWhite;
            amountNumeric.Enabled = true;
            totalNumeric.Enabled = false;

            gasStationOutputLabel.Text = cart.TotalGasStation.ToString("C");
            cafeOutputLabel.Text = cart.TotalMiniCafe.ToString("C");
            calculateOutputLabel.Text = cart.TotalToPay.ToString("C");

            petrolTypeComboBox.Items.AddRange(petroliumTypes);
            petrolTypeComboBox.SelectedIndex = 0;

            InitilizeCafeMenu();

            this.FormClosing += bestOilGasStationForm_FormClosing;
        }
        private void bestOilGasStationForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Daily income: {totalIncome}");
        }

        private void petrolTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            petrolPriceOtputTextBox.Text = petroliumTypes[petrolTypeComboBox.SelectedIndex].Price.ToString();
        }

        private void SwitchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton.Name.Equals("petrolAmountRadioButton"))
            {
                gasStationOutputGroupBox.Text = "ÄÎ ÑÏËÀÒÈ";

                decimal total = amountNumeric.Value * petroliumTypes[petrolTypeComboBox.SelectedIndex].Price;

                gasStationOutputLabel.Text = total.ToString("C");

                amountNumeric.Enabled = true;
                totalNumeric.Enabled = false;
                amountNumeric.BackColor = Color.Ivory;
                totalNumeric.BackColor = Color.AntiqueWhite;

                cart.TotalGasStation = total;
            }
            else
            {
                gasStationOutputGroupBox.Text = "ÄÎ ÂÈÄÀ×²";

                decimal total = totalNumeric.Value / petroliumTypes[petrolTypeComboBox.SelectedIndex].Price;

                gasStationOutputLabel.Text = total.ToString() + " l";

                totalNumeric.Enabled = true;
                amountNumeric.Enabled = false;
                totalNumeric.BackColor = Color.Ivory;
                amountNumeric.BackColor = Color.AntiqueWhite;

                cart.TotalGasStation = decimal.Parse(totalNumeric.Text);
            }

            calculateOutputLabel.Text = cart.TotalGasStation.ToString();
        }

        private void amountNumeric_ValueChanged(object sender, EventArgs e)
        {
            gasStationOutputLabel.Text = (amountNumeric.Value * petroliumTypes[petrolTypeComboBox.SelectedIndex].Price).ToString("C");
            cart.TotalGasStation = amountNumeric.Value * petroliumTypes[petrolTypeComboBox.SelectedIndex].Price;
            calculateOutputLabel.Text = cart.TotalGasStation.ToString("C");
        }

        private void totalNumeric_ValueChanged(object sender, EventArgs e)
        {
            gasStationOutputLabel.Text = (Math.Round(totalNumeric.Value / petroliumTypes[petrolTypeComboBox.SelectedIndex].Price, 2)).ToString() + "l";
            cart.TotalGasStation = totalNumeric.Value;
            calculateOutputLabel.Text = cart.TotalGasStation.ToString("C");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                totalIncome += cart.TotalToPay;
                await Task.Delay(1000);
                var dialogResult = MessageBox.Show
                ("Clear all fields now?", "Clean",
                MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    await Task.Delay(10000);
                }
                Clear();
            });
        }

        private void Clear()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                petrolTypeComboBox.SelectedIndex = 0;

                petrolAmountRadioButton.Checked = true;
                petrolTotalRadioButton.Checked = false;

                amountNumeric.Value = 0;
                totalNumeric.Value = 0;

                cart.TotalToPay = 0;
                calculateOutputLabel.Text = cart.TotalToPay.ToString("C");

                foreach (var item in cafeGroupBox.Controls.OfType<NumericUpDown>())
                {
                    item.Value = 0;
                    item.Enabled = false;
                }
                foreach (var item in cafeGroupBox.Controls.OfType<CheckBox>())
                {
                    item.Checked = false;
                }
            }));
            cart = new();
        }
    }
}