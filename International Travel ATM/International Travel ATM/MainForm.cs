using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace International_Travel_ATM
{
    public partial class MainForm : Form
    {
        //starting balance of $2250 on bank account field
        private BankAccount account = new BankAccount(2250);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //diplay the starting balance of the account
            accountBalanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            //variable to hold deposit amount
            decimal amount;

            //check input converts to a decimal
            if(decimal.TryParse(depositTextBox.Text, out amount))
            {
                //deposit amount into account
                account.Deposit(amount);

                //display the new balance
                accountBalanceLabel.Text = account.Balance.ToString("c");

                //clear the deposit text box
                depositTextBox.Clear();
            }
            else
            {
                //display error message
                MessageBox.Show("Invalid Amount.");
                //clear the text box
                depositTextBox.Clear();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //variable to hold withdraw amount
            decimal amount;

            //check input converts to a decimal
            if (decimal.TryParse(withDrawTextBox.Text, out amount))
            {
                //withdraw from the account
                account.Withdraw(amount);

                //display new balance
                accountBalanceLabel.Text = account.Balance.ToString("c");

                //clear withdraw text box
                withDrawTextBox.Clear();
            }
            else
            {
                //diplay error message
                MessageBox.Show("Invalid Amount.");
                //clear the text box
                withDrawTextBox.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Close();
        }

        private void seeRatesButton_Click(object sender, EventArgs e)
        {
            //create an instance of the ExchangeRates form
            ExchangeRates myExchangeRates = new ExchangeRates();

            //display the form
            myExchangeRates.ShowDialog();
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a decimal for the amount input
                decimal amount;
                //get the amount entered to be exchanged and check if it can parse to decimal
                amount = decimal.Parse(exchangeAmountTextBox.Text);
                //create an array to hold the exhange rates
                decimal[] exchangeRate = { 0.91m, 106.76m, 75.61m, 24.77m, 5.49m };
                //declare a decimal for the new amount in new currency
                decimal newAmount;
                //creat an index variable to access the array
                int index;

                //Great Britain exchange
                if (greatBritainRadioButton.Checked == true)
                {
                    //select index for GPB
                    index = 0;
                    //calculate new currency amount
                    newAmount = amount * exchangeRate[index];
                    //show message stating the amount was exchanged
                    MessageBox.Show("You exhanged $" + amount + " for " + newAmount + " Great British Pounds.");

                    //withdraw the amount from the account balance
                    account.Withdraw(amount);
                    //display the new account balance
                    accountBalanceLabel.Text = account.Balance.ToString("c");
                    //clear the exchanged amount box
                    exchangeAmountTextBox.Text = "";
                }
                //Japan exchange
                if (japanRadioButton.Checked == true)
                {
                    //select index for Japanese Yen
                    index = 1;
                    //calculate new currency amount
                    newAmount = amount * exchangeRate[index];
                    //show message stating the amount was exchanged
                    MessageBox.Show("You exhanged $" + amount + " for " + newAmount + " Japanese Yen.");

                    //withdraw the amount from the account balance
                    account.Withdraw(amount);
                    //display the new account balance
                    accountBalanceLabel.Text = account.Balance.ToString("c");
                    //clear the exchanged amount box
                    exchangeAmountTextBox.Text = "";
                }
                //India exchange
                if (indiaRadioButton.Checked == true)
                {
                    //select index for India Rupee
                    index = 2;
                    //calculate new currency amount
                    newAmount = amount * exchangeRate[index];
                    //show message stating the amount was exchanged
                    MessageBox.Show("You exhanged $" + amount + " for " + newAmount + " Indian Rupee.");

                    //withdraw the amount from the account balance
                    account.Withdraw(amount);
                    //display the new account balance
                    accountBalanceLabel.Text = account.Balance.ToString("c");
                    //clear the exchanged amount box
                    exchangeAmountTextBox.Text = "";
                }
                //Mexico exchange
                if (mexicoRadioButton.Checked == true)
                {
                    //select index for GPB
                    index = 3;
                    //calculate new currency amount
                    newAmount = amount * exchangeRate[index];
                    //show message stating the amount was exchanged
                    MessageBox.Show("You exhanged $" + amount + " for " + newAmount + " Mexican Peso.");

                    //withdraw the amount from the account balance
                    account.Withdraw(amount);
                    //display the new account balance
                    accountBalanceLabel.Text = account.Balance.ToString("c");
                    //clear the exchanged amount box
                    exchangeAmountTextBox.Text = "";
                }
                //Brazil exchange
                if (brazilRadioButton.Checked == true)
                {
                    //select index for GPB
                    index = 4;
                    //calculate new currency amount
                    newAmount = amount * exchangeRate[index];
                    //show message stating the amount was exchanged
                    MessageBox.Show("You exhanged $" + amount + " for " + newAmount + " Brazilian Real.");

                    //withdraw the amount from the account balance
                    account.Withdraw(amount);
                    //display the new account balance
                    accountBalanceLabel.Text = account.Balance.ToString("c");
                    //clear the exchanged amount box
                    exchangeAmountTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                //error message for invalid input
                MessageBox.Show(ex.Message);
                //clear text box
                exchangeAmountTextBox.Text = "";
            }
        }
    }
}
