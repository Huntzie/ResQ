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
    /// Interaction logic for BillingInfo.xaml
    /// </summary>
    public partial class BillingInfo : Page
    {

        DataSet1TableAdapters.BillingTableAdapter billingTableAdapter;

        int billingID;
        bool BillingRecord;
        int prospectID;
        

        public BillingInfo(int p_prospectID)
        {
            prospectID = p_prospectID;

            InitializeComponent();

            billingTableAdapter = new DataSet1TableAdapters.BillingTableAdapter();

            try
            {
                billingID = (int)billingTableAdapter.GetBillingIDFromProspectID(prospectID);
                BillingRecord = true;
            }
            catch {

                BillingRecord = false;
            }


        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (BillingRecord)
            {
                billingTableAdapter.UpdateQuery(int.Parse(AccNum.Text), AccName.Text, int.Parse(SortCode.Text), billingID, billingID);
                //Update Record
            }
            else
            {
                billingTableAdapter.InsertQuery(prospectID, int.Parse(AccNum.Text), AccName.Text, int.Parse(SortCode.Text));
            }


            SaleComplete SalesPage = new SaleComplete(prospectID);
            this.NavigationService.Navigate(SalesPage);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }
    }
}
