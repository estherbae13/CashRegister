using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //allows the use of SoundPlayer
using System.Threading; //allows the use of Thread.Sleep()

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //global varities
        double bookPrice = 14.00;
        double bookmarkPrice = 2.00;
        double journalPrice = 10.00;
        double bookNumber;
        double bookmarkNumber;
        double journalNumber;
        double subtotal;
        double taxrate = 0.13;
        double tax;
        double total;
        double amountPaid;
        double change;

        public Form1()
        {
            InitializeComponent();
            //disable buttons + paid amount text input box
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            resetButton.Enabled = false;
            paidInput.Enabled = false;
        }

        private void calculatetotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //enable change button and paid input box
                changeButton.Enabled = true;
                paidInput.Enabled = true;

                //declare the number of items
                bookNumber = Convert.ToDouble(booksInput.Text);
                bookmarkNumber = Convert.ToDouble(bookmarksInput.Text);
                journalNumber = Convert.ToDouble(journalsInput.Text);

                //calculate and show subtotal
                subtotal = bookPrice * bookNumber + bookmarkPrice * bookmarkNumber + journalPrice * journalNumber;
                subtotalOutput.Text = subtotal.ToString("0.00");

                //calculate and show taxes
                tax = subtotal * taxrate;
                taxOutput.Text = tax.ToString("0.00");

                //calculate and show total
                total = subtotal + tax;
                totalOutput.Text = total.ToString("0.00");

                //cash register sound
                SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.cash_register);
                alertPlayer.Play();
            }
            catch
            {
                receipt1Output.Text = "Please enter a numerical value.";

                //error sound
                SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.error);
                alertPlayer.Play();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //enable receipt button
                receiptButton.Enabled = true;

                //show the amount paid
                amountPaid = Convert.ToDouble(paidInput.Text);

                //calculate and show change
                change = amountPaid - total;
                changeOutput.Text = change.ToString("0.00");

                //cash register sound
                SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.cash_register);
                alertPlayer.Play();
            }
            catch
            {
                receipt1Output.Text = "Please enter a numerical value";

                //error sound
                SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.error);
                alertPlayer.Play();
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //printing sound
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.printer);
            alertPlayer.Play();

            //show receipt
            receipt1Output.Text = "           book store";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\n\nBooks             x{bookNumber} @ $";
            receipt2Output.Text = $"\n\n{bookPrice.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\nBookmarks         x{bookmarkNumber} @ $";
            receipt2Output.Text += $"\n{bookmarkPrice.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\nJournals          x{journalNumber} @ $";
            receipt2Output.Text += $"\n{journalPrice.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\n\nSubtotal               $";
            receipt2Output.Text += $"\n\n{subtotal.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\nTax                    $";
            receipt2Output.Text += $"\n{tax.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\nTotal                  $";
            receipt2Output.Text += $"\n{total.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\n\nAmount Paid            $";
            receipt2Output.Text += $"\n\n{amountPaid.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt1Output.Text += $"\nChange                 $";
            receipt2Output.Text += $"\n{change.ToString("0.00")}";
            Refresh();
            Thread.Sleep(300);

            receipt3Output.Text = $"Thank you for your purchase!";

            //enable new order button
            resetButton.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //clear everything
            booksInput.Text = "";
            bookmarksInput.Text = "";
            journalsInput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
            paidInput.Text = "";
            receipt1Output.Text = "";
            receipt2Output.Text = "";
            receipt3Output.Text = "";

            //play clearing sound
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.clear);
            alertPlayer.Play();
        }
    }
}
