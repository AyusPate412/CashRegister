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
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        new SoundPlayer errorSound = new SoundPlayer(Properties.Resources.error);
        new SoundPlayer printingSound = new SoundPlayer(Properties.Resources.receiptPrinting);

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
                subtotalOutput.Text = subtotal.ToString("C");

                taxAmount = subtotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalPrice = subtotal + taxAmount;
                totalOutput.Text = $"{totalPrice.ToString("C")}";   
                
                calculateChange.Enabled = true;
                calculateChange.FlatAppearance.BorderColor = Color.Green;
                calculateChange.FlatAppearance.BorderSize = 1;

                tenderedInput.Enabled = true;
            }
            catch 
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
                tenderedInput.Enabled = false;
                errorSound.Play();
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

                change = moneyTendered - totalPrice;
                changeOutput.Text = $"{change.ToString("C")}";

                printReceipt.Enabled = true;
                printReceipt.FlatAppearance.BorderColor = Color.Green;
                printReceipt.FlatAppearance.BorderSize = 1;
            }
            catch 
            {
                errorSound.Play();
                changeOutput.Text = "ERROR";

            }
            if (moneyTendered < totalPrice)
            {
                errorSound.Play();
                printReceipt.Enabled = false;

                printReceipt.FlatAppearance.BorderColor = Color.Red;
                printReceipt.FlatAppearance.BorderSize = 4;

                changeOutput.Text = $"{tendered} is not enough.";

            }
            else if(tendered > totalPrice)
            {
                printReceipt.Enabled = true;
                errorSound.Stop();

                printReceipt.FlatAppearance.BorderColor = Color.Green;
                printReceipt.FlatAppearance.BorderSize = 1;
            }

        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
            printingSound.Play();
            receiptOutput.Text = $"\n\n\n Banana Inc.";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Order Number 112";
            receiptOutput.Text += $"\n February 22, 2023";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Airpods x{numOfAirpods} @ {airpodsPrice.ToString("C")}";
            receiptOutput.Text += $"\n Phones x{numOfPhones}     @ {phonesPrice.ToString("C")}";
            receiptOutput.Text += $"\n Laptops x{numOfLaptops}   @ {laptopsPrice.ToString("C")}";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Subtotal {subtotal.ToString("C")}";
            receiptOutput.Text += $"\n Tax   {taxAmount.ToString("C")}";
            receiptOutput.Text += $"\n Total {totalPrice.ToString("C")}";

            Thread.Sleep(300);
            Refresh(); 
            receiptOutput.Text += $"\n\n Tendered {tendered.ToString("C")}";
            receiptOutput.Text += $"\n Change {change.ToString("C")}";

            Thread.Sleep(300);
            Refresh();
            receiptOutput.Text += $"\n\n Have a Nice Day!!";

            printingSound.Stop();

            newOrder.Enabled = true;
            newOrder.FlatAppearance.BorderColor = Color.Green;
            newOrder.FlatAppearance.BorderSize = 1;
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            airpodsInput.Clear();
            phonesInput.Clear();
            laptopsInput.Clear();

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            tenderedInput.Clear();
            changeOutput.Text = "";

            receiptOutput.Text = "";

            calculateChange.Enabled = false;
            calculateChange.FlatAppearance.BorderColor = Color.Red;
            calculateChange.FlatAppearance.BorderSize = 4;

            printReceipt.Enabled = false;
            printReceipt.FlatAppearance.BorderColor = Color.Red;
            printReceipt.FlatAppearance.BorderSize = 4;

            newOrder.Enabled = false;
            newOrder.FlatAppearance.BorderColor = Color.Red;
            newOrder.FlatAppearance.BorderSize = 4;

            numOfAirpods = 0;
            numOfPhones = 0;
            numOfLaptops = 0;

            moneyTendered = 0;
            change = 0;

            subtotal = 0;
            taxAmount = 0;
            totalPrice = 0;
            tendered = 0;
        }
    }
}
