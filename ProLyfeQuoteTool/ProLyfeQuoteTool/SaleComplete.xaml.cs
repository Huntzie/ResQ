﻿using System;
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
    /// Interaction logic for SaleComplete.xaml
    /// </summary>
    public partial class SaleComplete : Page
    {

        DataSet1TableAdapters.PurchaseView1TableAdapter purchaseViewAdapter;

        public SaleComplete(int ProspectID)
        {
           



            InitializeComponent();

            purchaseViewAdapter = new DataSet1TableAdapters.PurchaseView1TableAdapter();



            ProLyfeQuoteTool.DataSet1 DataSet = ((ProLyfeQuoteTool.DataSet1)(this.FindResource("dataSet1")));

            try
            {
                purchaseViewAdapter.FillByProspectID(DataSet.PurchaseView1, ProspectID);
            }
            catch { }

        }
    }
}
