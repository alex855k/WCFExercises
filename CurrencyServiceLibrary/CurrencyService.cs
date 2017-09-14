using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;

namespace CurrencyServiceLibrary
{
    public class CurrencyService : ICurrencyService
    {
        public double ConvertCurrency(string ISO, double value)
        {
            double val = 0;
            switch (ISO) {
                case "USD": val = value * 5.2402;
                    break;
                case "CAD":val = value * 4.9227;
                    break;
                case "EUR":val = value * 7.4599;
                    break;
                case "NOK":val = value * 0.9034;
                    break;
                case "GDP":
                    val = value * 9.4753;
                    break;
                case "SEK":
                    val = value * 0.7821;
                    break;
            }
            return val;
        }
    }
}
