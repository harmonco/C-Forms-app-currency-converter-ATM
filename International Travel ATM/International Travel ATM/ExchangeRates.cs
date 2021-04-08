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
    public partial class ExchangeRates : Form
    {
        //create a dictionary to hold the countries and exchange rates
        Dictionary<string, string> exchRates = new Dictionary<string, string>()
        {
            {"Great Britain", "0.91 GPB" }, {"Japan", "106.76 Yen"},
            {"India", "75.61 Rupee" }, {"Mexico", "24.77 Peso"},
            {"Brazil", "5.49 Real" }
        };
        public ExchangeRates()
        {
            InitializeComponent();
        }

        private void ExchangeRates_Load(object sender, EventArgs e)
        {
            //populate the countries in the list box
            foreach (var element in exchRates)
            {
                countriesListBox.Items.Add(element.Key);
            }
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the country selected in the list box and display the exchange rate
            string exchangeRates = countriesListBox.SelectedItem.ToString();
            if (exchRates.ContainsKey(exchangeRates))
            {
                exchangeRateLabel.Text = exchRates[exchangeRates];
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
