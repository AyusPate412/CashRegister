using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double airpodsPrice = 399.00;
        double phonesPrice = 1299.00;
        double laptopsPrice = 2199.00;

        int numOfAirpods;
        int numOfPhones;
        int numOfLaptops;

        double moneyTendered = 0;
        double change = 0; 

        double subtotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalPrice;
        double tendered;

        public Form1()
        {
            InitializeComponent();
        }

        private void airpodsLabel_Click(object sender, EventArgs e)
        {

        }

        private void airpodsBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numOfAirpods = Convert.ToInt32(airpodsInput.Text);
                numOfPhones = Convert.ToInt32(phonesInput.Text);
                numOfLaptops = Convert.ToInt32(laptopsInput.Text);
                

                subtotal = (numOfAirpods * airpodsPrice) + (numOfPhones * phonesPrice) + (numOfLaptops * laptopsPrice);
                subtotalOutput.Text = $"{subtotal.ToString("C")}";

                double taxAmount = subtotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalPrice = subtotal + taxAmount;
                totalOutput.Text = $"{totalPrice.ToString("C")}";              
            }
            catch 
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
            }
        }

        private void taxLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            
            try
            {
                moneyTendered = Convert.ToInt32(tenderedInput.Text);
                tendered = moneyTendered;

                double change = moneyTendered - totalPrice;
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch 
            {
                changeOutput.Text = "ERROR";
            }
        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = $"\n\n\n Banana Inc.";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Order Number 112";
            receiptOutput.Text += $"\n February 22, 2023";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Airpods x{numOfAirpods} @ {airpodsPrice}";
            receiptOutput.Text += $"\n Phones x{numOfPhones} @ {phonesPrice}";
            receiptOutput.Text += $"\n Laptops x{numOfLaptops} @ {laptopsPrice}";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Subtotal ${subtotal}";
            receiptOutput.Text += $"\n Tax ${taxAmount}";
            receiptOutput.Text += $"\n Total ${totalPrice}";

            Thread.Sleep(300);
            Refresh(); 
            receiptOutput.Text += $"\n\n Tendered ${tendered}";
            receiptOutput.Text += $"\n Change ${change}";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Have a Nice Day!!";

        }
    }
}
