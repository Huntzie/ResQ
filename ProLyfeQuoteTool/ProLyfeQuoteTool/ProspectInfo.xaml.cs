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

        string[] args;
        DataSet1TableAdapters.LeadTableAdapter leadTableAdapter;
        DataSet1TableAdapters.ProspectTableAdapter prospectTableAdapter;
        DataSet1TableAdapters.ContactInfoTableAdapter contactTableAdapter;
        int prospectID;
        int leadID;
        int contactID;

        bool ContactRecord = false;
        bool ProspectRecord = false;

        public ProspectInfo()
        {
            args = Environment.GetCommandLineArgs();
            InitializeComponent();

            leadTableAdapter = new DataSet1TableAdapters.LeadTableAdapter();
            prospectTableAdapter = new DataSet1TableAdapters.ProspectTableAdapter();
            contactTableAdapter = new DataSet1TableAdapters.ContactInfoTableAdapter();

            leadID = int.Parse(args[4]);

            

            if ((string)leadTableAdapter.GetNameByID(leadID) != null)
            {
                FullName.Text = (string)leadTableAdapter.GetNameByID(leadID);
            }
            if ((string)leadTableAdapter.GetEmailByID(leadID) != null)
            {
                Email.Text = (string)leadTableAdapter.GetEmailByID(leadID);
            }

            FillInfo();
        }

        private void FillInfo()
        {
            try
            {
                prospectID = (int)prospectTableAdapter.GetIDByLeadID(leadID);
                
                FirstName.Text = (string)prospectTableAdapter.GetFirstNameByProspectID(prospectID);
                LastName.Text = (string)prospectTableAdapter.GetLastNameByProspectID(prospectID);
                DOB.SelectedDate = (DateTime)prospectTableAdapter.GetDOBByProspectID(prospectID);

                ProspectRecord = true;
            }
            catch
            {
                ProspectRecord = false;
            }

            try
            {

                contactID = (int)contactTableAdapter.GetIDFromProspectID(prospectID);

                HomeNumber.Text = contactTableAdapter.GetHomeNumberByID(contactID).ToString();
                MobileNumber.Text = contactTableAdapter.GetMobileNumberByID(contactID).ToString();
                WorkNumber.Text = contactTableAdapter.GetWorkNumberByID(contactID).ToString();

                ContactRecord = true;
            }
            catch
            {
                ContactRecord = false;
            }


            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            CustomerInfo CustomerPage = new CustomerInfo();
            this.NavigationService.Navigate(CustomerPage);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {


            if (ProspectRecord)
            {
                prospectTableAdapter.UpdateQuery(FirstName.Text, LastName.Text, DOB.DisplayDate, prospectID, prospectID);
                //Update Record
            }
            else
            {
                prospectTableAdapter.InsertQuery(leadID, FirstName.Text, LastName.Text, DOB.DisplayDate);
                //create new record
                prospectID = (int)prospectTableAdapter.GetIDByLeadID(leadID);

                if (ContactRecord)
                {
                    contactTableAdapter.UpdateQuery1(int.Parse(HomeNumber.Text), int.Parse(MobileNumber.Text), int.Parse(WorkNumber.Text), contactID, contactID);
                    //Update Record
                }
                else
                {
                    contactTableAdapter.InsertQuery(prospectID, int.Parse(HomeNumber.Text), int.Parse(MobileNumber.Text), int.Parse(WorkNumber.Text));

                }
            }

            


            QuoteRequest QuotePage = new QuoteRequest(prospectID);
            this.NavigationService.Navigate(QuotePage);
        }
    }
}
