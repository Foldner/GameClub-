   M S B A M L   `   `   `  ����C  ?GameClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GameClub.Views.Frames.OrderGameClub.Views.Frames.Order  5      9!clr-namespace:GameClub.ViewModelsGameClub.ViewModels  5      *    $GameClub.Views.Frames.Order.EditPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:GameClub.Views.Frames.Order     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      2
viewmodels!clr-namespace:GameClub.ViewModels  5      $
��1230��5
      $	��830��5        N� Title$  EditPage��5       � DataContext 5      %   GameClub.ViewModels.VMOrderEdit  5   
   .��5      �� .��5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��3* �6#   �� 5      $��1* �6#   .+�5      � $��1��6   
������� 5      �� 5      $��1* �6'   �� 5      $��2* �6'    � RowDefinitions 5!      �� 5"      $	��21* �6$   �� 5#      $��0* �6$   �� 5$      $	��69* �6$   �� 5%      $	��73* �6$   �� 5&      $	��92* �6$   �� 5'      $	��92* �6$   �� 5(      $	��93* �6$   �� 5)      $	��92* �6$   �� 5*      $	��92* �6$   �� 5+      $	��92* �6$   �� 5,      $	��92* �6$   �� 5-      $	��29* �6$   �� 5.      $	��63* �6$   �� 5/      $��0* �6$   .+�53      �� $��0��6   $��0��6*   $��Center=�6:   
�������$��15(�6�    �� TextAlignment$ Center=�6�   $��Center=�6�   $��122,0,121,1q�6�   $��20��6�   $��0��6�   ��6W   �� *Textst+6�   �� 55      
���� ��$��11��6�   $��1��6�   $��34��6�   $��Right=�6�   $��Center=�6�   $��0,28,267,30q�6�   $	��186��6�   $��2��6  ��6   �� *CreateUpdateCommand+��6U   �� *SelectedOrder+.��56      � $	��270��6   .+�58      �� $��Center=�6$   $��Сохранить��6A   
�������$��20(�6e   $��23,-2,130,2q�6s   $	��117��6�   6�   59      5;      �� 5=      $��2��6   $��0��6)   $��Center=�69   $��Клиент��6V   
���� ��$��20(�6x   $
��Bold"�6�   $ Center=�6�   $��Center=�6�   $��50,26,51,16q�6�   $��27��6�   $	��142��6�   6�   �� 5>       �� SelectedValuePath$ Id��5@       �� DisplayMemberPath$ CustomerName��5A         MaterialDesignComboBox#���   5C      $��1��6L   $��Center=�6\   $��2��6y   $��Center=�6�   $��17��6�   $��20(�6�   $��234,17,234,16q�6�   $��36��6�   ��5>      �� *
Customer+ �� SelectedValue 5?      �� *SelectedOrder.CustomerId+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=�5C   �   �� 5E      $��3��6   $��0��6)   $��Center=�69   $��Устройство��6V   
���� ��$��20(�6|   $
��Bold"�6�   $ Center=�6�   $��Center=�6�   $��50,24,51,22q�6�   $��27��6�   $	��142��6�   6�   �� 5F      $ Id��5H      $ 
DeviceName��5I      #���   5K      $��1��6L   $��Center=�6\   $��3��6y   $��Center=�6�   $��17��6�   $��20(�6�   $��234,24,234,13q�6�   $��36��6�   ��5F      �� *Device+ 5G      �� *SelectedOrder.DeviceId+$ PropertyChanged=�$	 TwoWay=�5K   �   �� 5L      $��4��6   $��0��6*   $��Center=�6:   $%��Количество часов��6W   
���� ��$��20(�6�   $
��Bold"�6�   $ Center=�6�   $��Center=�6�   $��28��6�   $	��229��6�   $��
4,33,10,31q�6�   6  �� 5M      $��4��6i   $��1��6v   
���� ��$��20(�6�   
 �� 
CaretBrush

 �   �4  .System.Windows.Automation.AutomationProperties   HelpText$! Введите запрос��6�   
�������
���� ��$��
9,24,10,31q�6  ��6   �� *SelectedOrder.TotalCost+$ PropertyChanged=�6  �� 5O      $��5��6   $��0��6)   $��Center=�69   $��Тип заказа��6V   
���� ��$��20(�6|   $
��Bold"�6�   $ Center=�6�   $��Center=�6�   $��50,31,51,31q�6�   $��27��6�   $	��142��6�   �� 5P      $ Id��5R      $ TypeName��5S      #���   5U      $��1��6F   $��Center=�6V   $��5��6s   $��Center=�6�   $��17��6�   $��20(�6�   $��234,31,234,22q�6�   $��36��6�   ��5P      �� *	OrderType+ 5Q      �� *SelectedOrder.OrderTypeId+$	 TwoWay=�$ PropertyChanged=�5U   �   5V      5Y      5[      5]      