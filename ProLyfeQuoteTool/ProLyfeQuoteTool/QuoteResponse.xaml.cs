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
    /// Interaction logic for QuoteResponse.xaml
    /// </summary>
    public partial class QuoteResponse : Page
    {

        DataSet1TableAdapters.QuoteResponseTableAdapter QuoteResTableAdapter;
        int ProspectID;

        public QuoteResponse(int p_QuoteResponseID, int p_ProspectID)
        {
            InitializeComponent();

            ProspectID = p_ProspectID;

            QuoteResTableAdapter = new DataSet1TableAdapters.QuoteResponseTableAdapter();

            PPM.Text = (string)QuoteResTableAdapter.GetPremiumFromQuoteReqID(p_QuoteResponseID).ToString();

            StartDate.SelectedDate = (DateTime)QuoteResTableAdapter.FindStartDateFromQuoteReqID(p_QuoteResponseID);

        }

        private void b_returnToRequest_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CollectAddress(ProspectID));
        }
    }
}
