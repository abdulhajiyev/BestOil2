using System;
using System.Windows.Forms;

namespace BestOil2
{
    public partial class Form1 : Form
    {
        BestOil bestOil = new BestOil();
        MiniCafe miniCafe = new MiniCafe();
        PetrolStation petrolStation = new PetrolStation();

        public Form1()
        {
            InitializeComponent();
            bestOil.MiniCafe = miniCafe;
            bestOil.PetrolStation = petrolStation;
            literRadio.Enabled = false;
            priceRadio.Enabled = false;
            gasComboBox.Items.Add(petrolStation.Gasolines[0].Type);
            gasComboBox.Items.Add(petrolStation.Gasolines[1].Type);
            gasComboBox.Items.Add(petrolStation.Gasolines[2].Type);
            hotdogPrice.Text = miniCafe.Foods[0].Price.ToString();
            hamburgerPrice.Text = miniCafe.Foods[1].Price.ToString();
            friesPrice.Text = miniCafe.Foods[2].Price.ToString();
            colaPrice.Text = miniCafe.Foods[3].Price.ToString();
        }

        private void gasComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            literRadio.Enabled = true;
            priceRadio.Enabled = true;
            PetrolStation petrolStation = new PetrolStation();

            int index = gasComboBox.SelectedIndex;
            gasPriceTextBox.Text = petrolStation.Gasolines[index].Price.ToString();
        }

        private void literRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            /*literAmount.Enabled = true;
            moneyAmount.Enabled = false;
            if (moneyAmount.Text == String.Empty) return;
            try { moneyAmount.Text = default; }
            catch { }*/

            if (literRadio.Checked)
            {
                literAmount.Enabled = true;
                moneyAmount.Enabled = false;
                if (moneyAmount.Text == String.Empty) return;
            }
            else
            {
                moneyAmount.Text = "0";
                moneyAmount.Text = "";
            }
        }

        private void priceRadio_CheckedChanged(object sender, EventArgs e)
        {
            /*moneyAmount.Enabled = true;
            literAmount.Enabled = false;
            if (literAmount.Text == String.Empty) return;
            try
            {
                literAmount.Text = default;
            }
            catch
            {
                // ignored
            }*/

            if (priceRadio.Checked)
            {
                moneyAmount.Enabled = true;
                literAmount.Enabled = false;
                if (literAmount.Text == String.Empty) return;
            }
            else
            {
                literAmount.Text = "0";
                literAmount.Text = "";
            }
        }

        private void literAmount_TextChanged(object sender, EventArgs e)
        {
            if (literAmount.Text == String.Empty)
            {
                try
                {
                    literAmount.Text = default;
                }
                catch
                {
                    // ignored
                }
            }
            int index = gasComboBox.SelectedIndex;
            petrolStation.Price = petrolStation.Gasolines[index].Price;
            try
            {
                petrolStation.Liter = double.Parse(literAmount.Text);
            }
            catch
            {
                // ignored
            }

            gasSum.Text = petrolStation.GetPrice().ToString();
            totalSum.Text = petrolStation.GetPrice().ToString();
        }

        private void moneyAmount_TextChanged(object sender, EventArgs e)
        {
            if (moneyAmount.Text == String.Empty)
            {
                try
                {
                    moneyAmount.Text = default;
                }
                catch
                {
                    // ignored
                }
            }
            int index = gasComboBox.SelectedIndex;
            petrolStation.Price = petrolStation.Gasolines[index].Price;
            try
            {
                double price = double.Parse(moneyAmount.Text);
                petrolStation.Liter = price / petrolStation.Gasolines[index].Price;
            }
            catch
            {
                // ignored
            }

            literAmount.Text = ((int)petrolStation.Liter).ToString();
            gasSum.Text = petrolStation.GetPrice().ToString();
            totalSum.Text = petrolStation.GetPrice().ToString();
        }

        private void hotdogCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!hotdogQuantity.Enabled)
            {
                hotdogQuantity.Enabled = true;
            }
            else
            {
                hotdogQuantity.Text = "0";
                hotdogQuantity.Enabled = false;
                hotdogQuantity.Text = "";
            }

            if (hotdogQuantity.Text != String.Empty)
            {
                miniCafe.Foods[0].Count = int.Parse(hotdogQuantity.Text);
            }
        }

        private void hamburgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!hamburgerQuantity.Enabled)
            {
                hamburgerQuantity.Enabled = true;
            }
            else
            {
                hamburgerQuantity.Text = "0";
                hamburgerQuantity.Enabled = false;
                hamburgerQuantity.Text = "";
            }

            if (hamburgerQuantity.Text != String.Empty)
            {
                miniCafe.Foods[1].Count = int.Parse(hamburgerQuantity.Text);
            }
        }

        private void friesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!friesQuantity.Enabled)
            {
                friesQuantity.Enabled = true;
            }
            else
            {
                friesQuantity.Text = "0";
                friesQuantity.Enabled = false;
                friesQuantity.Text = "";
            }

            if (friesQuantity.Text != String.Empty)
            {
                miniCafe.Foods[2].Count = int.Parse(friesQuantity.Text);
            }
        }

        private void colaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!colaQuantity.Enabled)
            {
                colaQuantity.Enabled = true;
            }
            else
            {
                colaQuantity.Text = "0";
                colaQuantity.Enabled = false;
                colaQuantity.Text = "";
            }

            if (colaQuantity.Text != String.Empty)
            {
                miniCafe.Foods[3].Count = int.Parse(colaQuantity.Text);
            }
        }

        private void hotdogQuantity_TextChanged(object sender, EventArgs e)
        {
            /*if (hotdogQuantity.Text.StartsWith("0"))
            {
                hotdogQuantity.Text = "0";
                hotdogQuantity.Text = String.Empty;
            }*/

            if (hotdogQuantity.Text != String.Empty)
            {
                miniCafe.Foods[0].Count = int.Parse(hotdogQuantity.Text);
            }
            else
            {
                hotdogQuantity.Text = "";
            }
            cafeSum.Text = miniCafe.GetPrice().ToString();
            totalSum.Text = miniCafe.GetPrice().ToString();
            if (cafeSum.Text == "0")
            {
                cafeSum.Text = "";
            }
        }

        private void hamburgerQuantity_TextChanged(object sender, EventArgs e)
        {
            /*if (hamburgerQuantity.Text.StartsWith("0"))
            {
                hamburgerQuantity.Text = "0";
                hamburgerQuantity.Text = String.Empty;
            }*/

            if (hamburgerQuantity.Text != String.Empty)
            {
                miniCafe.Foods[1].Count = int.Parse(hamburgerQuantity.Text);
            }
            else
            {
                hamburgerQuantity.Text = "";
            }
            cafeSum.Text = miniCafe.GetPrice().ToString();
            totalSum.Text = miniCafe.GetPrice().ToString();

            if (cafeSum.Text == "0")
            {
                cafeSum.Text = "";
            }
        }

        private void friesQuantity_TextChanged(object sender, EventArgs e)
        {
            /*if (friesQuantity.Text.StartsWith("0"))
            {
                friesQuantity.Text = "0";
                friesQuantity.Text = String.Empty;
            }*/

            if (friesQuantity.Text != String.Empty)
            {
                miniCafe.Foods[2].Count = int.Parse(friesQuantity.Text);
            }
            else
            {
                friesQuantity.Text = "";
            }

            cafeSum.Text = miniCafe.GetPrice().ToString();
            totalSum.Text = miniCafe.GetPrice().ToString();
            if (cafeSum.Text == "0")
            {
                cafeSum.Text = "";
            }
        }

        private void colaQuantity_TextChanged(object sender, EventArgs e)
        {
           /* if (colaQuantity.Text.StartsWith("0"))
            {
                colaQuantity.Text = "0";
                colaQuantity.Text = String.Empty;
            }*/

            if (colaQuantity.Text != String.Empty)
            {
                miniCafe.Foods[3].Count = int.Parse(colaQuantity.Text);
            }
            else
            {
                colaQuantity.Text = "";
            }
            cafeSum.Text = miniCafe.GetPrice().ToString();
            totalSum.Text = miniCafe.GetPrice().ToString();
            if (cafeSum.Text == "0")
            {
                cafeSum.Text = "";
            }
        }

        private void totalSum_TextChanged(object sender, EventArgs e)
        {
            totalSum.Text = $"{bestOil.PriceTotal()} AZN";
        }

        private void hotdogQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (hotdogQuantity.Text.Length == 0 && e.KeyChar == (int) Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || hotdogQuantity.Text.Length != 1) return;
            hotdogQuantity.Text = "0";
            hotdogQuantity.Text = "";
        }

        private void hamburgerQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (hamburgerQuantity.Text.Length == 0 && e.KeyChar == (int)Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || hamburgerQuantity.Text.Length != 1) return;
            hamburgerQuantity.Text = "0";
            hamburgerQuantity.Text = "";
        }

        private void friesQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (friesQuantity.Text.Length == 0 && e.KeyChar == (int)Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || friesQuantity.Text.Length != 1) return;
            friesQuantity.Text = "0";
            friesQuantity.Text = "";
        }

        private void colaQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (colaQuantity.Text.Length == 0 && e.KeyChar == (int)Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || colaQuantity.Text.Length != 1) return;
            colaQuantity.Text = "0";
            colaQuantity.Text = "";
        }

        private void literAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (literAmount.Text.Length == 0 && e.KeyChar == (int)Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || colaQuantity.Text.Length != 1) return;
            colaQuantity.Text = "0";
            colaQuantity.Text = "";
        }

        private void moneyAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (moneyAmount.Text.Length == 0 && e.KeyChar == (int)Keys.D0)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back || colaQuantity.Text.Length != 1) return;
            colaQuantity.Text = "0";
            colaQuantity.Text = "";
        }
    }
}