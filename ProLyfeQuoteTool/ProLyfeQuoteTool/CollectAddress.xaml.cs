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
    /// Interaction logic for CollectAddress.xaml
    /// </summary>
    public partial class CollectAddress : Page
    {
        int ProspectID;
        DataSet1TableAdapters.AddressTableAdapter AdrTableAdapter;

        public CollectAddress(int p_ProspectID)
        {
            InitializeComponent();

            ProspectID = p_ProspectID;
            AdrTableAdapter = new DataSet1TableAdapters.AddressTableAdapter();
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            AdrTableAdapter.InsertQuery(ProspectID, AddType.SelectedIndex, Line1.Text, Line2.Text, PostCode.Text);
            this.NavigationService.Navigate(new BillingInfo(ProspectID));
            //store address
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

    }
}
