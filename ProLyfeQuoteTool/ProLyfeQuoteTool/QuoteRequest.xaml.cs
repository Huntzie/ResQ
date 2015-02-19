using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for QuoteRequest.xaml
    /// </summary>
    public partial class QuoteRequest : Page
    {


        DataSet1TableAdapters.QuoteRequestTableAdapter quoteReqTableAdapter;
        DataSet1TableAdapters.QuoteResponseTableAdapter quoteResTableAdapter;        
        DataSet1TableAdapters.QuotesTableAdapter quotesTableAdapter;
        DataSet1 ds;

        int ProspectID;
        int QuoteRequestID;
        int QuoteResponseID;

        public QuoteRequest()
        {
            InitializeComponent();
        }

        public QuoteRequest(int p_ProspectID)
        {
            InitializeComponent();

            ProspectID = p_ProspectID;

            quoteReqTableAdapter = new DataSet1TableAdapters.QuoteRequestTableAdapter();
            quoteResTableAdapter = new DataSet1TableAdapters.QuoteResponseTableAdapter();
            quotesTableAdapter = new DataSet1TableAdapters.QuotesTableAdapter();
            


            ds = (DataSet1)FindResource("dataSet1");

            quotesTableAdapter.FillByProspectIDNotPurchased(ds.Quotes, ProspectID);

        }

        private void b_quoteReqQuote_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_cateringCost.Text) && !string.IsNullOrWhiteSpace(tb_dressCost.Text) && !string.IsNullOrWhiteSpace(tb_venueCost.Text))
            {
                if (dtp_startDate.DisplayDate > DateTime.Now.AddDays(7))
                {
                    RequestQuote();
                }
            }
            
        }

        private void b_quoteReqPrevious(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void RequestQuote()
        {
            //calculate quote response
            decimal total = decimal.Parse(tb_cateringCost.Text) + decimal.Parse(tb_dressCost.Text) + decimal.Parse(tb_venueCost.Text);
            decimal premium = total / 100;
            DateTime start = dtp_startDate.DisplayDate;

            //insert quote request into DB then generate quote and pass ID to next page

            int insertID = quotesTableAdapter.InsertQuote(ProspectID, decimal.Parse(tb_dressCost.Text), decimal.Parse(tb_venueCost.Text), decimal.Parse(tb_cateringCost.Text), premium, start);

            

            quotesTableAdapter.FillByProspectIDNotPurchased(ds.Quotes, ProspectID);
        }

        /// <summary>
        /// Event that allows only numbers for a text field, will also allow a one '.' for decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersOnlyPreviewTextEvent(object sender, TextCompositionEventArgs e)
        {
            dynamic control = Convert.ChangeType(sender, sender.GetType());

            try
            {
                if (e.Text == ".")
                {
                    if (control.Text.Contains("."))
                    {
                        e.Handled = true;
                        return;
                    }
                    return;
                }

                int.Parse(e.Text);
            }
            catch
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Verifies that the text being entered is a not a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextOnlyPreviewTextEvent(object sender, TextCompositionEventArgs e)
        {
            try
            {
                int.Parse(e.Text);
            }
            catch
            {
                return;
            }

            e.Handled = true;
        }

        private void dtp_startDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtp_startDate.DisplayDate > DateTime.Now.Date.AddDays(7))
            {
                MessageBox.Show("Start date must be at least 7 days in the future");
                e.Handled = true;
            }
        }

        private void b_goPurchase_Click(object sender, RoutedEventArgs e)
        {
            CollectAddress addressPage = new CollectAddress(ProspectID);
            this.NavigationService.Navigate(addressPage);
        }
    }
}
