   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath��%�  &	        � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                            <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                            <Expense ExpenseType="Gift" ExpenseAmount="125" />
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                            <Expense ExpenseType="New machine" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="Theo" Department="Marketing">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="James" Department="Education">
                            <Expense ExpenseType="Book" ExpenseAmount="80" />
                        </Person>
                        <Person Name="David" Department="Engineering">
                            <Expense ExpenseType="New machine" ExpenseAmount="800" />
                        </Person>
                    </Expenses>        5*      5+       � ColumnDefinitions 5-   
   �� 5.      �� 5/      $	��230 �6    � RowDefinitions 51   
   �� 52      �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   ��58   
   �� 59       �� ImageSource$ watermark.png��6   .+�5<   
   �� $��3��6   $��0��6   $��5q�6-   ��68   ��  �� Path$ LastChecked��� 5>   
   $��2��6   $��0��6   ��6/   �� $ PersonsChecked�5?      �� 5A   
   $��1��6   .��6    View Expense Report65   �� 5C   
   $��35��6    �� Padding$ 5q�6   ���#4E87D4$��1��6>   $��1��6N   ._�5D      �� $��Center=�6   
�������.��6C   Names6J   5E      �� 5F   
   -   5        $��peopleListBox��5F      $��1��6'   $��2��67   ��6D   ��  �� Source# [  	 �� XPath$	 Person����5G      �� 5H      .R�5I      �� ��6   �� $	 @Name��5J      5L      �� 5M   
   -   5        $��0,10,0,0q�5M   d   $��1��6v   $��3��6�   $	��125��6�   $��25��6�   $��Right=�6�   ��6   �� 
 �� ElementName$
 peopleListBox��$# SelectedItem.Attributes[Name]�6�   �� 5N   
   -   5         ��Name$ button_Greeting��5N      $��Greeting��6*   $
��Left=�6=   $��1��6X   $��3��6h   $��0,10,0,0q�6u   6�   5O      5P      