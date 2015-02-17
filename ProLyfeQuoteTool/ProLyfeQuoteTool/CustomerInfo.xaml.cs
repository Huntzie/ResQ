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
    /// Interaction logic for CustomerInfo.xaml
    /// </summary>
    public partial class CustomerInfo : Page
    {
        string[] args;
        DataSet1TableAdapters.LeadTableAdapter leadAdapter;
        DataSet1TableAdapters.vw_CustomerInfoTableAdapter vw_custInfoAdapter;

        public CustomerInfo()
        {
            InitializeComponent();

            leadAdapter = new DataSet1TableAdapters.LeadTableAdapter();
            vw_custInfoAdapter = new DataSet1TableAdapters.vw_CustomerInfoTableAdapter();
            
            args = Environment.GetCommandLineArgs();
            int leadID= int.Parse(args[4]);
            Name.Text = (string)leadAdapter.GetNameByID(leadID);
            CLI.Text = args[1];
            Email.Text = (string)leadAdapter.GetEmailByID(leadID);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProspectInfo prospectPage = new ProspectInfo();
            this.NavigationService.Navigate(prospectPage);
        }
    }
}
