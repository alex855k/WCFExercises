using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CurrencyExchange.CurrencyExchangeService;

namespace CurrencyExchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CurrencyExchangeService.ICurrencyService currencyServices = new CurrencyServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExchangeCurrency()
        {
            string currencyType;
            if (comboBox_currencyType.SelectedValue != null)
            {
                currencyType = comboBox_currencyType.Text;

                double value;
                if (double.TryParse(textBox_value.Text, out value))
                {
                     label_changedOutput.Content = currencyServices.ConvertCurrency(currencyType, value);
                }
            }
            else
            {
                label_changedOutput.Content = textBox_value.Text;
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExchangeCurrency();
            }
        }
    }
}
