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

namespace ProLyfeQuoteTool
{
    /// <summary>
    /// Interaction logic for ProspectInfo.xaml
    /// </summary>
    public partial class ProspectInfo : Page
    {
        public ProspectInfo()
        {
            InitializeComponent();
        }

        string leadID;

        public ProspectInfo(string p_leadID)
        {
            leadID = p_leadID;

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            CustomerInfo CustomerPage = new CustomerInfo();
            this.NavigationService.Navigate(CustomerPage);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            QuoteRequest QuotePage = new QuoteRequest();
            this.NavigationService.Navigate(QuotePage);
        }
    }
}
