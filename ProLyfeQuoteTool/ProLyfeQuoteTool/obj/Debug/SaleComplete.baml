   M S B A M L   `   `   `  ����K  GProLyfeQuoteTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProLyfeQuoteToolProLyfeQuoteTool  5      #    ProLyfeQuoteTool.SaleComplete   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ProLyfeQuoteTool     5        N� Title$  SaleComplete��5      $��353.023��6   $��731.34��6(    � 	Resources 5
         ProLyfeQuoteTool.DataSet1   dataSet1  purchaseView1ViewSource �� Source �� Source��%^   &	        &	      7     5   
   6   �� 5   
    6?   �� *PurchaseView1+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ purchaseView1DataGrid��5         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6m   �� # [ 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        firstNameColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 
First Name��5   \      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	FirstName+6p     5      -   5        lastNameColumn��$
 	Last Name��5   Z   $ SizeToHeader 6m    6=   �� *
LastName+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        	dOBColumn��$	
 DOB��5   <   $ SizeToHeader 6I      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *DOB+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        line1Column��$
 Line 1��5   T   $ SizeToHeader 6d    6:   �� *Line1+6d     5      -   5        line2Column��$
 Line 2��5   T   $ SizeToHeader 6d    6:   �� *Line2+6d     5      -   5        postcodeColumn��$
 Postcode��5   Z   $ SizeToHeader 6l    6=   �� *
Postcode+6l     5      -   5        accountNumColumn��$
 Account Num��5   ^   $ SizeToHeader 6s    6?   �� *
AccountNum+6s     5      -	   5        accountNameColumn��$
 Account Name��5   `   $ SizeToHeader 6v    6@   �� *AccountName+6v     5       -
   5        sortCodeColumn��$
 	Sort Code��5    Z   $ SizeToHeader 6m    6=   �� *
SortCode+6m     5!      -   5        dressCostColumn��$
 
Dress Cost��5!   \   $ SizeToHeader 6p    6>   �� *	DressCost+6p     5"      -   5        venueCostColumn��$
 
Venue Cost��5"   \   $ SizeToHeader 6p    6>   �� *	VenueCost+6p     5#      -   5        cateringCostColumn��$
 Catering Cost��5#   b   $ SizeToHeader 6y    6A   �� *CateringCost+6y     5$      -   5        monthlyPremiumColumn��$
 Monthly Premium��5$   f   $ SizeToHeader 6    6C   �� *MonthlyPremium+6     5%      -   5        startDateColumn��$
 
Start Date��5%   B   $ SizeToHeader 6V    5&      �� 5'      .R�5(         6)   �� *	StartDate+$ TwoWay=� .  . 5)      5+        5,      -   5        iDColumn��$
 ID��5,   N   $ SizeToHeader 6Z    67   �� *ID+6Z   5.      5/      50      