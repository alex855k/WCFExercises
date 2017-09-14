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
using WPF_PersonService.PersonService;
using WPF_PersonService.CalcService;

namespace WPF_PersonService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IPersonWcfService pService = new PersonWcfServiceClient();
        private ICalcService cService = new CalcServiceClient();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var p in pService.GetAllePersoner())
            {
                ScrollData.Content += p.Fornavn + " " + p.Efternavn + " " + p.Adresse + "\n";
            }
        }

        private void textBox_radius_TextChanged(object sender, TextChangedEventArgs e)
        {
            double radius;
            if (Double.TryParse(textBox_radius.Text, out radius))
            {
                label_resultDiameter.Content = cService.CalcDiameter(radius);
                label_resultCircumference.Content = cService.CalcCircumference(radius);
            }
        }
    }
}
