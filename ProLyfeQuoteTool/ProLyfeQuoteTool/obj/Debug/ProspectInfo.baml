   M S B A M L   `   `   `  ����K  GProLyfeQuoteTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProLyfeQuoteToolProLyfeQuoteTool  5      #    ProLyfeQuoteTool.ProspectInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ProLyfeQuoteTool     5        N� Title$  ProspectInfo��5	      $	��497��6    � 	Resources 5         ProLyfeQuoteTool.DataSet1   dataSet1  addressViewSource �� Source �� Source��%X   &	        &	      7     5   
   6   �� 5   
    69   �� *	Address+8   5      .��5      �  � DataContext# [ 6   $��	0,0,20,20q�6<   .+�5   
   �� $��Update Customer Info��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $	��153��6u   ���	#FF8EB9BF6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��	10,41,0,0q�6@   $	��Top=�6S   ���	#FF8EB9BF6k   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��	10,72,0,0q�6?   $	��Top=�6R   ���	#FF8EB9BF6j   �� 5   
   $	��DOB��6   $
��Left=�6   $��	9,103,0,0q�69   $	��Top=�6L   ���	#FF8EB9BF6d   �� 5   
   $��Home Number��6   $
��Left=�6&   $��
10,134,0,0q�6A   $	��Top=�6U   ���	#FF8EB9BF6m   �� 5   
   $��Mobile Number��6   $
��Left=�6(   $��	9,165,0,0q�6C   $	��Top=�6V   ���	#FF8EB9BF6n   �� 5   
   $��Work Number��6   $
��Left=�6&   $��
10,196,0,0q�6A   $	��Top=�6U   ���	#FF8EB9BF6m   �� 5   
   -   5         ��Name$ 	FirstName��5        textboxStyle#��[ 6%   $
��Left=�6K   $��23��6f   $��
159,45,0,0q�6r    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ LastName��5      #��[ 6$   $
��Left=�6J   $��23��6e   $��
159,76,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 
HomeNumber��5      #��[ 6&   $
��Left=�6L   $��23��6g   $��159,138,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ MobileNumber��5      #��[ 6(   $
��Left=�6N   $��23��6i   $��159,169,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 
WorkNumber��5      #��[ 6&   $
��Left=�6L   $��23��6g   $��159,200,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ Email��5      #��[ 6!   $
��Left=�6G   $��23��6b   $��314,107,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��161��6�   �� 5   
   -   5        $
��Next��5        buttonStyle#��[ 6    $
��Left=�6E   $��400,270,0,0q�6`   $	��Top=�6u   $��75��6�   6�   �� 5    
   -   5        $��Previous��5       #��[ 6$   $
��Left=�6I   $��
10,270,0,0q�6d   $	��Top=�6x   $��75��6�   6�   �� 5!   
   $��Lead Full Name��6   $
��Left=�6)   $��
314,10,0,0q�6D   $	��Top=�6X   $	��161��6p   $��26��6|   ���	#FF8EB9BF6�   �� 5"   
   -	   5        $ FullName��5"      #��[ 6$   $
��Left=�6J   $��23��6e   $��
314,45,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $	��161��6�   �� 5#   
   $��Email��6   $
��Left=�6    $��
314,76,0,0q�6;   $	��Top=�6O   $	��161��6g   ���	#FF8EB9BF6s   (  "System.Windows.Controls.DatePicker  5$   
   -
   5          Name$	 DOB��5$      $
��Left=�6#   $��159,106,0,0q�6>   $	��Top=�6S   $	��120��6k   �� 5%   
   -   5         ��Name$ Warning��5%      $ ��! Please fill in all boxes��6!   $��159,239,0,0q�6F   $��Center=�6[   
���  ��$y�Hidden=�6�   $
��Left=�6�   5&      5'      