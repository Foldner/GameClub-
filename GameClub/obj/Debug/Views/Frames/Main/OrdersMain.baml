   M S B A M L   `   `   `  ����C  ?GameClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GameClub.Views.Frames.MainGameClub.Views.Frames.Main  5      9!clr-namespace:GameClub.ViewModelsGameClub.ViewModels  5      +    %GameClub.Views.Frames.Main.OrdersMain   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GameClub.Views.Frames.Main     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      2
viewmodels!clr-namespace:GameClub.ViewModels  5        N� Title$  
OrdersMain��5      $
��1230��5      $	��830��5       � DataContext 5      !  GameClub.ViewModels.VMOrder  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��625* �6   �� 5      $	��17* �6   .+�5   
   � $��0��6    � RowDefinitions 5       �� 5!      $��1* �6    �� 5"      $	��13* �6    .+�5'      � $��0��6   4  .System.Windows.Automation.AutomationProperties   HelpText$! Введите запрос��6     5(      �� 5)      $
��377* �6'   �� 5*      $	��85* �6'   .+�5,      � $��0��6   .+�5-      �� $	��800��6[   $��40��6j   $��Center=�6y   $��10,10,-54,9q�6�   
���   � �� 
CaretBrush
 �   �$��20(�6�   $! Введите запрос��6�   
�������
���� ����6   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=�6  5.      � 5/      $��1��6   .+�50      �� $��Right=�6!   $��Center=�6=   $��1��6X   $��0, 0, 10, 0q�6h   $��40��6}   $	��152��6�   .+�51      �� ���#9147ff$��40��6W   $	��120��6f   ��6"   �� *SearchOrder+.��52      � $	��120��6#   .+�54   "   �� $��Center=�6,   $��
Поиск��6I   
�������$��20(�6i   $��	27,0,34,0q�6w   55      56      57      58      59      � 5;      $��1��6    5<      �� 5=      $	��81* �6'   �� 5>      $��1015* �6'   .+�5@      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly . $��10,10,10,166q�6�   $��2��6�   ��6   �� *Order+	 �� SelectedItem	 6V   �� *SelectedOrder+
   Columns
 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ��  �� Path$ Id�6U   4  .System.Windows.Controls.DataGridComboBoxColumn  5C      $ Клиент��61      SelectedValuePath$ Id��6�      DisplayMemberPath$ CustomerName��6�   $
 auto 6�      SelectedValueBinding 6A   �� *
CustomerId+$ PropertyChanged=� �� Mode$ TwoWay=�   ElementStyle 5D      �� 5E   "    �� 
TargetType" ��6(   .�5F   &   ��  �� Property � �� �� Value 6D   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" N�$ DataContext.Customer�5G   #      EditingElementStyle 5I      �� 5J   "   " ��6(   .�5K   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.Customer�5L   #   5N        5O      $ Дата заказа��6Q   $
 auto 6f    6-   �� $ 
OrderDates�6f     5P      $ Стоимость��6P   $
 auto 6c    6-   �� $ 	TotalCost�6c     5Q      $ Устройство��61   $ Id��6�   $ 
DeviceName��6�   $
 auto 6�    6E   �� *
DeviceId+$ PropertyChanged=�$ TwoWay=� 5R      �� 5S   "   " ��6(   .�5T   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.Device�5U   #    5W      �� 5X   "   " ��6(   .�5Y   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.Device�5Z   #   5\        5]      $ Продукт��61   $ Id��6�   $ ProductName��6�   $
 auto 6�    6B   �� *	ProductId+$ PropertyChanged=�$ TwoWay=� 5^      �� 5_   "   " ��6(   .�5`   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.Product�5a   #    5c      �� 5d   "   " ��6(   .�5e   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.Product�5f   #   5h        5i      $ Тип заказа��61   $ Id��6�   $ TypeName��6�   $
 auto 6�    6E   �� *OrderTypeId+$ PropertyChanged=�$ TwoWay=� 5j      �� 5k   "   " ��6(   .�5l   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.OrderType�5m   #    5o      �� 5p   "   " ��6(   .�5q   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.OrderType�5r   #   5t      5v      5w      5x      �� 5{      $��498,699,424,51q�6_   ���#9147ff$��80��6�   ��6   �� *	EditOrder+��63   �� *SelectedOrder+.��5|      � $	��270��6   .+�5~      �� $��Center=�6    $ ��Редактировать��6=   
�������$��20(�6e   6u   5      5�      �� 5�      $��894,699,22,51q�6`   ���#9147ff$��80��6�   ��6   �� *DeleteOrder+��65   �� *SelectedOrder+.��5�      � $	��270��6   .+�5�      �� $��Center=�6    $��Удалить��6=   
�������$��20(�6_   6o   5�      5�      �� 5�      $��47,699,823,51q�65   ���#9147ff$��80��6a   ��6   �� *CreateOrder+.��5�      � $	��270��6   .+�5�      �� $��Center=�6    $��
Новый��6=   
�������$��20(�6]   5�      5�      5�      5�      