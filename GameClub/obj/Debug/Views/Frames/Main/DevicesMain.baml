   M S B A M L   `   `   `  ����C  ?GameClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GameClub.Views.Frames.MainGameClub.Views.Frames.Main  5      9!clr-namespace:GameClub.ViewModelsGameClub.ViewModels  5      ,    &GameClub.Views.Frames.Main.DevicesMain   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GameClub.Views.Frames.Main     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      2
viewmodels!clr-namespace:GameClub.ViewModels  5        N� Title$  DevicesMain��5      $
��1230��5      $	��830��5       � DataContext 5      "  GameClub.ViewModels.VMDevice  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��8* �6   �� 5      $��2* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��1* �6    �� 5      $	��13* �6    .+�5      � $��0��6   4  .System.Windows.Automation.AutomationProperties   HelpText$! Введите запрос��6     5       �� 5!      $
��377* �6'   �� 5"      $	��85* �6'   .+�5$      � $��0��6   .+�5%      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Введите запрос��66   $	��800��6f   $��40��6u   $��Center=�6�   $��	10,10,0,5q�6�   
���   � �� 
CaretBrush
 �   �$��20(�6�   $! Введите запрос��6�   
����������	#FFFFCD38��6   �� *Search+6(  5&      � 5'      $��1��6   .+�5(      �� $��Right=�6!   $��Center=�6=   $��1��6X   $��0, 0, 10, 0q�6h   $��40��6}   $	��152��6�   .+�5)      �� ���#9147ff$��40��6W   $	��120��6f   ��6!   �� *SearchDevice+.��5*      � $	��120��6#   .+�5+   "   �� $��Center=�6,   $��
Поиск��6I   
�������$��20(�6i   6y   5,      5-      5.      5/      50      � 52      $��1��6   .+�53      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly . $��10,10,10,132q�6�   ��6   �� *Device+	 �� SelectedItem	 6W   �� *SelectedDevice+
   Columns
 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ��  �� Path$ Id�6U     56      $ Название��6Q   $
 auto 6c    6-   �� $ 
DeviceName�6c   4	  .System.Windows.Controls.DataGridComboBoxColumn	  58      $ Тип��61    	  SelectedValuePath$ Id��6�    	  DisplayMemberPath$ TypeName��6�   $
 auto 6�    	  SelectedValueBinding 6>   �� *DeviceTypeId+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� 	  ElementStyle 59      �� 5:   "    �� 
TargetType" ��6(   .�5;   &   ��  �� Property � �� �� Value 6D   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" N�$ DataContext.DeviceType�5<   #    	  EditingElementStyle 5>      �� 5?   "   " ��6(   .�5@   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.DeviceType�5A   #   5C      	  5E      $ Статус��61   $ Id��6�   $ 
StatusName��6�   $
 auto 6�    6A   �� *StatusTypeId+$ PropertyChanged=�$ TwoWay=� 5F      �� 5G   "   " ��6(   .�5H   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.StatusType�5I   #    5K      �� 5L   "   " ��6(   .�5M   &   ��  � �� 6D   ��  �� *FindAncestor+" N�$ DataContext.StatusType�5N   #   5P      5R      5T      5V      � 5X   
   $��1��6   .+�5Z      �� $��-971,719,975,31q�61   ���#9147ff$��80��6_   ��6   �� *	Refresh+.��5[      � $	��202��6   .+�5\      �� $
��Left=�6    $��Обновить��6;   
�������$��20(�6^   $��52,0,0,0q�6l   5]      5^      �� 5a      $��-262,719,266,31q�6b   ���#9147ff$��80��6�   ��6   �� *DeleteDevice+��66   �� *SelectedDevice+.��5b      � $	��322��6    5c      �� 5d      $	��89* �6+   �� 5e      $	��46* �6+   .+�5g      �� $��Center=�6    $��Удалить��6=   
�������$��20(�6_   $��	68,0,71,0q�6m   5h      5i      �� 5k      $��Bottom=�6   
�������$��
0,0,10,582q�6I   .+�5m      �� $��9��6   $��0��6)   $��Center=�69   $��Статус��6V   
���� ��$��20(�6x   $
��Bold"�6�    �� TextAlignment$ Center=�6�   $��Center=�6�   $��52,33,52,32q�6�   $��27��6�   $	��142��6�   6�   �� 5o       �� SelectedValuePath$ Id��5q       �� DisplayMemberPath$ 
StatusName��5r         MaterialDesignComboBox#���   5t      $��1��6L   $��Center=�6\   $��9��6y   $��Center=�6�   $
��auto��6�   $��20(�6�   ��5o      �� *
StatusType+ �� SelectedValue 5p      �� *SelectedDevice.StatusTypeId+$ PropertyChanged=�$ TwoWay=�5t   �   �� 5v      $��	5,10,5,20q�6f   ���#9147ff$��80��6�   ��6   �� *ChangeStatus+��6:   �� *SelectedDevice+.��5w      � $	��270��6   .+�5y      �� $��Center=�6$   $��Изменить��6A   
�������$��20(�6d   $��
59,0,118,0q�6r   6�   5z      5{      5|      5}      5~      5      