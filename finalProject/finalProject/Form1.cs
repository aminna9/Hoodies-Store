using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace finalProject
{
    public partial class hoodiezStoreForm : Form
    {
        private int clickCount = 0;
        private bool isConfirmed = false;
        bool sizeChosen = false;
        public hoodiezStoreForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = (welcomeLabel.Location.X + 10) % (welcomePanel.Width - welcomeLabel.Width);

            welcomeLabel.Location = new Point(x, welcomeLabel.Location.Y);
        }

        private void hoodiezStoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customer' table. You can move, or remove it, as needed.
            // this.customerTableAdapter.Fill(this.database1DataSet.Customer);
            timer1.Interval = 300; //in ms

            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void increment3Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity3Label.Text);
            result += 1;
            quantity3Label.Text = result.ToString();
        }

        private void hoodie1AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    if (clickCount == 1)
                    {
                        double price1 = double.Parse(quantity1Label.Text) * 12;

                        hoodie1.Text = "Black Hoodie";
                        quantityHoodie1.Text = quantity1Label.Text;
                        priceHoodie1.Text = price1.ToString();

                        // Apply size selection for hoodie1
                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else
                    {
                        double price1 = double.Parse(quantity1Label.Text) * 12;

                        hoodie2.Text = "Black Hoodie";
                        quantityHoodie2.Text = quantity1Label.Text;
                        priceHoodie2.Text = price1.ToString();

                        // Apply size selection for hoodie2
                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }
        }

            private void label17_Click(object sender, EventArgs e)
        {

        }

        private void hoodie4PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void hoodie6PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void increment1Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity1Label.Text);
            result += 1;
            quantity1Label.Text = result.ToString();
        }

        private void increment2Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity2Label.Text);
            result += 1;
            quantity2Label.Text = result.ToString();
        }

        private void increment4Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity4Label.Text);
            result += 1;
            quantity4Label.Text = result.ToString();
        }

        private void increment5Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity5Label.Text);
            result += 1;
            quantity5Label.Text = result.ToString();
        }

        private void increment6Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity6Label.Text);
            result += 1;
            quantity6Label.Text = result.ToString();
        }

        private void decrement1Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity1Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity1Label.Text = result.ToString();
            }
        }

        private void decrement2Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity2Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity2Label.Text = result.ToString();
            }
        }

        private void decrement3Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity3Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity3Label.Text = result.ToString();
            }
        }

        private void decrement4Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity4Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity4Label.Text = result.ToString();
            }
        }

        private void decrement5Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity5Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity5Label.Text = result.ToString();
            }
        }

        private void decrement6Button_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(quantity6Label.Text);
            result -= 1;
            if (result >= 1)
            {
                quantity6Label.Text = result.ToString();
            }
        }

        private void hoodie2AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    if (clickCount == 1)
                    {
                        double price2 = double.Parse(quantity2Label.Text) * 12;

                        hoodie1.Text = "White Hoodie";
                        quantityHoodie1.Text = quantity2Label.Text;
                        priceHoodie1.Text = price2.ToString();

                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else 
                    {
                        double price2 = double.Parse(quantity2Label.Text) * 12;

                        hoodie2.Text = "White Hoodie";
                        quantityHoodie2.Text = quantity2Label.Text;
                        priceHoodie2.Text = price2.ToString();

                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                  

                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }

        }

        private void hoodie3AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    if (clickCount == 1)
                    {
                        double price3 = double.Parse(quantity3Label.Text) * 12;

                        hoodie1.Text = "Red Hoodie";
                        quantityHoodie1.Text = quantity3Label.Text;
                        priceHoodie1.Text = price3.ToString();

                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else if (clickCount == 2)
                    {
                        double price3 = double.Parse(quantity3Label.Text) * 12;

                        hoodie2.Text = "Red Hoodie";
                        quantityHoodie2.Text = quantity3Label.Text;
                        priceHoodie2.Text = price3.ToString();

                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                    else
                    {
                        double price3 = double.Parse(quantity3Label.Text) * 12;

                        hoodie3.Text = "Red Hoodie";
                        quantityHoodie3.Text = quantity3Label.Text;
                        priceHoodie3.Text = price3.ToString();

                        if (small3RadioButton.Checked)
                        {
                            size3Label.Text = "S";
                        }
                        else if (medium3RadioButton.Checked)
                        {
                            size3Label.Text = "M";
                        }
                        else if (large3RadioButton.Checked)
                        {
                            size3Label.Text = "L";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }
        }

        private void hoodie4AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    if (clickCount == 1)
                    {
                        double price4 = double.Parse(quantity4Label.Text) * 12;

                        hoodie1.Text = "Blue Hoodie";
                        quantityHoodie1.Text = quantity4Label.Text;
                        priceHoodie1.Text = price4.ToString();

                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else if (clickCount == 2)
                    {
                        double price4 = double.Parse(quantity4Label.Text) * 12;

                        hoodie2.Text = "Blue Hoodie";
                        quantityHoodie2.Text = quantity4Label.Text;
                        priceHoodie2.Text = price4.ToString();

                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                    else if (clickCount == 3)
                    {
                        double price4 = double.Parse(quantity4Label.Text) * 12;

                        hoodie3.Text = "Blue Hoodie";
                        quantityHoodie3.Text = quantity4Label.Text;
                        priceHoodie3.Text = price4.ToString();

                        if (small3RadioButton.Checked)
                        {
                            size3Label.Text = "S";
                        }
                        else if (medium3RadioButton.Checked)
                        {
                            size3Label.Text = "M";
                        }
                        else if (large3RadioButton.Checked)
                        {
                            size3Label.Text = "L";
                        }
                    }
                    else
                    {
                        double price4 = double.Parse(quantity4Label.Text) * 12;

                        hoodie4.Text = "Blue Hoodie";
                        quantityHoodie4.Text = quantity4Label.Text;
                        priceHoodie4.Text = price4.ToString();

                        if (small4RadioButton.Checked)
                        {
                            size4Label.Text = "S";
                        }
                        else if (medium4RadioButton.Checked)
                        {
                            size4Label.Text = "M";
                        }
                        else if (large4RadioButton.Checked)
                        {
                            size4Label.Text = "L";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }
        }
        private void hoodie15AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    if (clickCount == 1)
                    {
                        double price5 = double.Parse(quantity5Label.Text) * 12;

                        hoodie1.Text = "Grey Hoodie";
                        quantityHoodie1.Text = quantity5Label.Text;
                        priceHoodie1.Text = price5.ToString();

                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else if (clickCount == 2)
                    {
                        double price5 = double.Parse(quantity5Label.Text) * 12;

                        hoodie2.Text = "Grey Hoodie";
                        quantityHoodie2.Text = quantity5Label.Text;
                        priceHoodie2.Text = price5.ToString();

                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                    else if (clickCount == 3)
                    {
                        double price5 = double.Parse(quantity5Label.Text) * 12;

                        hoodie3.Text = "Grey Hoodie";
                        quantityHoodie3.Text = quantity5Label.Text;
                        priceHoodie3.Text = price5.ToString();

                        if (small3RadioButton.Checked)
                        {
                            size3Label.Text = "S";
                        }
                        else if (medium3RadioButton.Checked)
                        {
                            size3Label.Text = "M";
                        }
                        else if (large3RadioButton.Checked)
                        {
                            size3Label.Text = "L";
                        }
                    }
                    else if (clickCount == 4)
                    {
                        double price5 = double.Parse(quantity5Label.Text) * 12;

                        hoodie4.Text = "Grey Hoodie";
                        quantityHoodie4.Text = quantity5Label.Text;
                        priceHoodie4.Text = price5.ToString();

                        if (small4RadioButton.Checked)
                        {
                            size4Label.Text = "S";
                        }
                        else if (medium4RadioButton.Checked)
                        {
                            size4Label.Text = "M";
                        }
                        else if (large4RadioButton.Checked)
                        {
                            size4Label.Text = "L";
                        }
                    }
                    else
                    {
                        double price5 = double.Parse(quantity5Label.Text) * 12;

                        hoodie5.Text = "Grey Hoodie";
                        quantityHoodie5.Text = quantity5Label.Text;
                        priceHoodie5.Text = price5.ToString();

                        if (small5RadioButton.Checked)
                        {
                            size5Label.Text = "S";
                        }
                        else if (medium5RadioButton.Checked)
                        {
                            size5Label.Text = "M";
                        }
                        else if (large5RadioButton.Checked)
                        {
                            size5Label.Text = "L";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }
        }
        private void hoodie6AddButton_Click(object sender, EventArgs e)
        {
            if (sizeChosen)
            {
                clickCount++;

                try
                {
                    double price = double.Parse(quantity6Label.Text) * 12;

                    if (clickCount == 1)
                    {
                        hoodie1.Text = "Grey Hoodie";
                        quantityHoodie1.Text = quantity6Label.Text;
                        priceHoodie1.Text = price.ToString();

                        if (small1RadioButton.Checked)
                        {
                            size1Label.Text = "S";
                        }
                        else if (medium1RadioButton.Checked)
                        {
                            size1Label.Text = "M";
                        }
                        else if (large1RadioButton.Checked)
                        {
                            size1Label.Text = "L";
                        }
                    }
                    else if (clickCount == 2)
                    {
                        hoodie2.Text = "Green Hoodie";
                        quantityHoodie2.Text = quantity6Label.Text;
                        priceHoodie2.Text = price.ToString();

                        if (small2RadioButton.Checked)
                        {
                            size2Label.Text = "S";
                        }
                        else if (medium2RadioButton.Checked)
                        {
                            size2Label.Text = "M";
                        }
                        else if (large2RadioButton.Checked)
                        {
                            size2Label.Text = "L";
                        }
                    }
                    else if (clickCount == 3)
                    {
                        hoodie3.Text = "Green Hoodie";
                        quantityHoodie3.Text = quantity6Label.Text;
                        priceHoodie3.Text = price.ToString();

                        if (small3RadioButton.Checked)
                        {
                            size3Label.Text = "S";
                        }
                        else if (medium3RadioButton.Checked)
                        {
                            size3Label.Text = "M";
                        }
                        else if (large3RadioButton.Checked)
                        {
                            size3Label.Text = "L";
                        }
                    }
                    else if (clickCount == 4)
                    {
                        hoodie4.Text = "Green Hoodie";
                        quantityHoodie4.Text = quantity6Label.Text;
                        priceHoodie4.Text = price.ToString();

                        if (small4RadioButton.Checked)
                        {
                            size4Label.Text = "S";
                        }
                        else if (medium4RadioButton.Checked)
                        {
                            size4Label.Text = "M";
                        }
                        else if (large4RadioButton.Checked)
                        {
                            size4Label.Text = "L";
                        }
                    }
                    else if (clickCount == 5)
                    {
                        hoodie5.Text = "Green Hoodie";
                        quantityHoodie5.Text = quantity6Label.Text;
                        priceHoodie5.Text = price.ToString();

                        if (small5RadioButton.Checked)
                        {
                            size5Label.Text = "S";
                        }
                        else if (medium5RadioButton.Checked)
                        {
                            size5Label.Text = "M";
                        }
                        else if (large5RadioButton.Checked)
                        {
                            size5Label.Text = "L";
                        }
                    }
                    else
                    {
                        hoodie6.Text = "Green Hoodie";
                        quantityHoodie6.Text = quantity6Label.Text;
                        priceHoodie6.Text = price.ToString();

                        if (small6RadioButton.Checked)
                        {
                            size6Label.Text = "S";
                        }
                        else if (medium6RadioButton.Checked)
                        {
                            size6Label.Text = "M";
                        }
                        else if (large6RadioButton.Checked)
                        {
                            size6Label.Text = "L";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please remove the item to proceed");
                }
            }
            else
            {
                MessageBox.Show("Please select a size before adding to the cart");
            }
        }
            private void button5_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie1.Text = "";
            quantityHoodie1.Text = "";
            priceHoodie1.Text = "";
            size1Label.Text = "";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie2.Text = "";
            quantityHoodie2.Text = "";
            priceHoodie2.Text = "";
            size2Label.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie3.Text = "";
            quantityHoodie3.Text = "";
            priceHoodie3.Text = "";
            size3Label.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie4.Text = "";
            quantityHoodie4.Text = "";
            priceHoodie4.Text = "";
            size4Label.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie5.Text = "";
            quantityHoodie5.Text = "";
            priceHoodie5.Text = "";
            size5Label.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie6.Text = "";
            quantityHoodie6.Text = "";
            priceHoodie6.Text = "";
            size6Label.Text = "";
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            hoodie1.Text = "";
            hoodie2.Text = "";
            hoodie3.Text = "";
            hoodie4.Text = "";
            hoodie5.Text = "";
            hoodie6.Text = "";
            quantityHoodie1.Text = "";
            quantityHoodie2.Text = "";
            quantityHoodie3.Text = "";
            quantityHoodie4.Text = "";
            quantityHoodie5.Text = "";
            quantityHoodie6.Text = "";
            priceHoodie1.Text = "";
            priceHoodie2.Text = "";
            priceHoodie3.Text = "";
            priceHoodie4.Text = "";
            priceHoodie5.Text = "";
            priceHoodie6.Text = "";
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (firstNameTextBox.Text != " " && int.TryParse(firstNameTextBox.Text, out result))
            {
                MessageBox.Show("Invalid name value", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Clear();
            }
            else
            {
                requiredLabel.Visible = false;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (lastNameTextBox.Text != " " && int.TryParse(lastNameTextBox.Text, out result))
            {
                MessageBox.Show("Invalid name value", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Clear();
            }
            else
            {
                requiredLabel1.Visible = false;
            }
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (contactTextBox.Text != " " && !int.TryParse(contactTextBox.Text, out result))
            {
                MessageBox.Show("Invalid contact number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contactTextBox.Clear();
            }
            else if (contactTextBox.Text.Length > 8)
            {
                MessageBox.Show("Contact number must have a maximum of 8 digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contactTextBox.Text = contactTextBox.Text.Substring(0, 8);
                contactTextBox.SelectionStart = 8;
            }
            else
            {
                requiredLabel2.Visible = false;
            }
        }

        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result;
            if (areaComboBox.Text != " " && int.TryParse(areaComboBox.Text, out result))
            {
                MessageBox.Show("Invalid area", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                areaComboBox.SelectedIndex = -1;
            }
            else
            {
                requiredLabel3.Visible = false;
            }
        }

        private void houseTextBox_TextChanged(object sender, EventArgs e)
        {

            int result;
            if (houseTextBox.Text != " " && !int.TryParse(houseTextBox.Text, out result))
            {
                MessageBox.Show("Invalid house number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                houseTextBox.Clear();
            }
            else
            {
                requiredLabel4.Visible = false;
            }
        }

        private void roadTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (roadTextBox.Text != " " && !int.TryParse(roadTextBox.Text, out result))
            {
                MessageBox.Show("Invalid road number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roadTextBox.Clear();
            }
            else
            {
                requiredLabel5.Visible = false;
            }
        }

        private void blockTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (blockTextBox.Text != " " && !int.TryParse(blockTextBox.Text, out result))
            {
                MessageBox.Show("Invalid block number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blockTextBox.Clear();
            }
            else
            {
                requiredLabel6.Visible = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool hasMissingInformation = false;

            double price, vat, total;
            double.TryParse(priceHoodie1.Text, out double hoodie1Price);
            double.TryParse(priceHoodie2.Text, out double hoodie2Price);
            double.TryParse(priceHoodie3.Text, out double hoodie3Price);
            double.TryParse(priceHoodie4.Text, out double hoodie4Price);
            double.TryParse(priceHoodie5.Text, out double hoodie5Price);
            double.TryParse(priceHoodie6.Text, out double hoodie6Price);

            price = hoodie1Price + hoodie2Price + hoodie3Price + hoodie4Price + hoodie5Price + hoodie6Price;

            vat = price * 0.1;

            total = price + vat;
            double delivery = 1.5;
            double finalPrice = total + delivery;
           

            finalPriceLabel.Text = finalPrice+ " BD";

            if (firstNameTextBox.Text == "") // to check if Textbox is empty
            {
                requiredLabel.Visible = true; 
                hasMissingInformation = true;
            }
            if (lastNameTextBox.Text == "")
            {
                requiredLabel1.Visible = true;
                hasMissingInformation = true;
            }
            if (contactTextBox.Text == "")
            {
                requiredLabel2.Visible = true;
                hasMissingInformation = true;
            }
            if (areaComboBox.Text == "")
            {
                requiredLabel3.Visible = true;
                hasMissingInformation = true;
            }
            if (houseTextBox.Text == "")
            {
                requiredLabel4.Visible = true;
                hasMissingInformation = true;
            }
            if (roadTextBox.Text == "")
            {
                requiredLabel5.Visible = true;
                hasMissingInformation = true;
            }
            if (blockTextBox.Text == "")
            {
                requiredLabel6.Visible = true;
                hasMissingInformation = true;
            }


            if (!hasMissingInformation)
            {
                invoicePanel.Visible = true;


                invoiceNameLabel.Text = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1).ToLower() + " " + lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1).ToLower();
                invoiceContactLabel.Text = contactTextBox.Text;
                invoiceAddressLabel.Text = areaComboBox.Text + ", House:" + houseTextBox.Text + ", Road:" + roadTextBox.Text + ", Block:" + blockTextBox.Text;

              

                if (benefitRadioButton.Checked)
                {
                    invoicePaymentLabel.Text = benefitRadioButton.Text;
                }
                else if (visaCardRadioButton.Checked)
                {
                    invoicePaymentLabel.Text = visaCardRadioButton.Text;
                }
                else if (applePayRadioButton.Checked)
                {
                    invoicePaymentLabel.Text = applePayRadioButton.Text;
                }
                isConfirmed = true; //event is confirmed 
                exitButton.Visible = true;
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            saveFileDialog1.ShowDialog();
            MessageBox.Show("Hope you enjoyed our shop ☺");
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            double price, vat, total;
            double.TryParse(priceHoodie1.Text, out double hoodie1Price);
            double.TryParse(priceHoodie2.Text, out double hoodie2Price);
            double.TryParse(priceHoodie3.Text, out double hoodie3Price);
            double.TryParse(priceHoodie4.Text, out double hoodie4Price);
            double.TryParse(priceHoodie5.Text, out double hoodie5Price);
            double.TryParse(priceHoodie6.Text, out double hoodie6Price);

            price = hoodie1Price + hoodie2Price + hoodie3Price + hoodie4Price + hoodie5Price + hoodie6Price;

            vat = price * 0.1;

            total = price + vat;

            priceAmountLabel.Text  = price.ToString() + " BD";
            cartVATLabel.Text = vat.ToString() + " BD";
            totalPriceAmountLabel.Text = total.ToString() + " BD";

            
            deliveryGroupBox.Visible = true;
        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceAmountLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void finalPriceLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void invoiceContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void small1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void large1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void small2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void large2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void small3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void large3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void small4radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium4radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium5radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void large4radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void small5radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void small6radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void medium6radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void large6radioButton_CheckedChanged(object sender, EventArgs e)
        {
            sizeChosen = true;
        }

        private void size1Label_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void totalPriceAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           // this.Validate();
           //this.customerBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
