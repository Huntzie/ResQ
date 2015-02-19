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

        int ProspectID;
        int QuoteRequestID;
        int QuoteResponseID;

        public QuoteRequest(int p_ProspectID)
        {

         InitializeComponent();

         ProspectID = p_ProspectID;

         quoteReqTableAdapter = new DataSet1TableAdapters.QuoteRequestTableAdapter();
         quoteResTableAdapter = new DataSet1TableAdapters.QuoteResponseTableAdapter();



        }

        private void b_quoteReqNext_Click(object sender, RoutedEventArgs e)
        {
                RequestQuote();
                QuoteResponse ResponsePage = new QuoteResponse(QuoteResponseID, ProspectID);
                this.NavigationService.Navigate(ResponsePage);
        }

        private void b_quoteReqPrevious(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        /// <summary>
        /// Event that allows only numbers for a text field, will also allow a one '.' for decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersOnlyPreviewTextEvent(object sender, TextCompositionEventArgs e)
        {
            dynamic test = Convert.ChangeType(sender, sender.GetType());

            try
            {
                if (e.Text == ".")
                {
                    if (test.Text.Contains("."))
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

        private void RequestQuote()
        {
            //insert quote request into DB then generate quote and pass ID to next page

            QuoteRequestID = (int)quoteReqTableAdapter.InsertQuery(ProspectID, decimal.Parse(tb_dressCost.Text), decimal.Parse(tb_venueCost.Text), decimal.Parse(tb_cateringCost.Text));


            QuoteResponse();
        }

        private void QuoteResponse()
        {
            decimal total = decimal.Parse(tb_cateringCost.Text) + decimal.Parse(tb_dressCost.Text) + decimal.Parse(tb_venueCost.Text);

            decimal premium = total / 100;
            DateTime start = DateTime.Now.AddDays(7);

            //insert quote into db

            QuoteResponseID = (int)quoteResTableAdapter.InsertQuery(QuoteRequestID, premium, start);
        }
    }
}
