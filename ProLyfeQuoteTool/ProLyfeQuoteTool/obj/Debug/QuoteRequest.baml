   M S B A M L   `   `   `  ����K  GProLyfeQuoteTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProLyfeQuoteToolProLyfeQuoteTool  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      #    ProLyfeQuoteTool.QuoteRequest   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ProLyfeQuoteTool     5      6sys&clr-namespace:System;assembly=mscorlib     5      -   5          N�Name$  	p_Request��5
       N� Title$ QuoteRequest��6   $	��341��6*    � 	Resources 5         ProLyfeQuoteTool.DataSet1   dataSet1  vw_QuoteViewSource �� Source �� Source  quotesViewSource��%�   &	        &	      7   &	 A     7     5   
   6   �� 5   
    6:   �� *
vw_Quote+8   �� 5   
    68   �� *Quotes+8   5      .��5      � $��	0,2,20,20q�6    � DataContext# [ 6   .+�5   
   �� $��Quote Request��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   ���	#FF8EB9BF6n   �� 5   
   $��
Dress Cost��6   $
��Left=�6%   $��	12,43,0,0q�6@   $	��Top=�6S   ���	#FF8EB9BF6k   �� 5   
   -   5         ��Name$ tb_dressCost��5        textboxStyle#��[ 6(   $
��Left=�6N   $��23��6i   $��	96,47,0,0q�6u    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   .��6�   5      �� 5   
   $��
Venue Cost��6   $��	12,71,0,0q�6%   $
��Left=�68   $��70��6S   $��26��6^   $	��Top=�6j   ���	#FF8EB9BF6�   �� 5   
   -   5        $ tb_venueCost��5      #��[ 6(   $
��Left=�6N   $��23��6i   $��	96,75,0,0q�6u   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   $��Catering Cost��6   $
��Left=�6(   $��	12,99,0,0q�6C   $	��Top=�6V   ���	#FF8EB9BF6n   �� 5   
   -   5        $ tb_cateringCost��5      #��[ 6+   $
��Left=�6Q   $��23��6l   $��
96,103,0,0q�6x   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5         ��Name$ b_quoteReqQuote��5      $��Quote��6*     buttonStyle#��[ 6:   $
��Left=�6_   $��
306,99,0,0q�6z   $	��Top=�6�   $	��155��6�   6�   �� 5   
   -   5        $ b_QuoteReqPrevious��5      $��Previous��6-   #��[ 6@   $
��Left=�6e   $��
10,291,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $��b_goPurchase��5      $��Go to Purchase��6%   #��[ 6>   $
��Left=�6c   $��363,291,0,0q�6~   $	��Top=�6�   $��98��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtp_startDate��5      $
��Left=�6*   $��
338,47,0,0q�6E   $	��Top=�6Y   $	��123��6q   
	 �� Now
   DisplayDateStart#
 Z	 6�      DisplayDate# Z	 6�   �� 5   
   $��Payment Start Date��6   $
��Left=�6-   $��
221,45,0,0q�6H   $	��Top=�6\   ���	#FF8EB9BF6t   &   System.Windows.Controls.DataGrid  5    
   -	   5          Name$ quotesDataGrid��5          AutoGenerateColumns .     EnableRowVirtualization . $��10,131,0,35q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly . $
��Left=�6�   $	��451��6  ���	#FF8EB9BF   HeadersVisibility$ Column=�6h     RowHeaderWidth$ 0Q�6�     GridLinesVisibility$
 None=�6�  ��6f   �� # [ ��6$  Z� ��6:  Z�    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -
   5        iDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5"   N      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *ID+6Z     5#      -   5        dressCostColumn��$ 
Dress Cost��5#   \   $ SizeToHeader 6p    6>   �� *	DressCost+6p     5$      -   5        venueCostColumn��$ 
Venue Cost��5$   \   $ SizeToHeader 6p    6>   �� *	VenueCost+6p     5%      -   5        cateringCostColumn��$ Catering Cost��5%   b   $ SizeToHeader 6y    6A   �� *CateringCost+6y     5&      -   5        monthlyPremiumColumn��$ Monthly Premium��5&   f   $ SizeToHeader 6    6C   �� *MonthlyPremium+6     5'      -   5        startDateColumn��$ 
Start Date��5'   >   $ SizeToHeader 6R    6g   �� *	StartDate+ �� StringFormat$ d��5)      5*      5+      