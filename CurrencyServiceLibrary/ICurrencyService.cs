using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyServiceLibrary
{
    [ServiceContract]
    public interface ICurrencyService
    {
        [OperationContract]
        double ConvertCurrency(string ISO, double value);
    }
}
