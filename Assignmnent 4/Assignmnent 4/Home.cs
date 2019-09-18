using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnent_4
{
    public partial class Home : Form
    {
        int price = 0;
        int index = 0;

        List<string> customerNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantities = new List<int>();
        List<int> totalPrices = new List<int>();
        public Home()
        {

            InitializeComponent();

            orderComboBox.Text = "Select an item";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string customerName = nameTextBox.Text;
            string contactNumber = noTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            string quantity = quantityTextBox.Text;

            if (customerName == "" || contactNumber == "" || address == "" || order == "")
            {
                MessageBox.Show("Please, Fill up all input field !");
                return;
            }

            if (Convert.ToInt32(quantityTextBox.Text) == 0)
            {
                MessageBox.Show("Enter quantity");
                return;
            }
            if (order == "Select an item")
            {
                MessageBox.Show("Please, Select an item");
                return;
            }
            for (int i = 0; i < contactNumbers.Count(); i++)
            {
                if (contactNumber == contactNumbers[i])
                {
                    MessageBox.Show("Contact no. already exist.");
                    return;
                }

            }
            if (order == "Select an item")
            {
                MessageBox.Show("Please, Select an item");
                return;
            }
            else
            {
                if (order == "Black")
                {
                    price = 120;
                }
                else if (order == "Cold")
                {
                    price = 100;
                }
                else if (order == "Hot")
                {
                    price = 90;
                }
                else
                {
                    price = 80;
                }
                int totalPrice = price * Convert.ToInt32(quantity);


                customerNames.Add(customerName);
                contactNumbers.Add(contactNumber);
                addresses.Add(address);
                orders.Add(order);
                quantities.Add(Convert.ToInt32(quantity));
                totalPrices.Add(totalPrice);

                infoTextBox.Text = "";
                for (int j = index; j <= index; j++)
                {
                    infoTextBox.Text = "Name : " + customerNames[j] +
                                                 "\nContact No : " + contactNumbers[j] +
                                                 "\nAddress : " + addresses[j] +
                                                 "\nOrder : " + orders[j] +
                                                 "\nQuantity : " + quantities[j] +
                                                 "\nTotal Price : " + totalPrices[j] + "\n\n";
                }
                index++;
            }
            }

        private void showButton_Click(object sender, EventArgs e)
        {
            infoTextBox.Text ="";
            for (int j = 0; j < customerNames.Count();j++)
            {
                infoTextBox.Text += "Name : " + customerNames[j] + "\nContact No : " + contactNumbers[j] + "\nAddress : " + addresses[j] + "\nOrder : " + orders[j] + "\nTotal Price : " + totalPrices[j] + "\n\n";

            }
        }
    }
        }
        
    

