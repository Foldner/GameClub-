   M S B A M L   `   `   `  ����C  ?GameClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GameClub.Views.Frames.IncomeGameClub.Views.Frames.Income  5      9!clr-namespace:GameClub.ViewModelsGameClub.ViewModels  5      0    *GameClub.Views.Frames.Income.IncomeCounter   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      6local*clr-namespace:GameClub.Views.Frames.Income  5      2
viewmodels!clr-namespace:GameClub.ViewModels  5      $
��1230��5
      $	��830��5        N� Title$  IncomeCounter��5       � DataContext 5      '   !GameClub.ViewModels.VMCountIncome  5   
   .��5      �� .��5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��3* �6#   �� 5      $��1* �6#    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5!      � $��1��6   $��0��6#   
������� 5"      �� 5#      $��1* �6'   �� 5$      $��1* �6'   �� 5%      $
��auto �6'   .+�5'      � $��0��6    5(      �� 5)      $
��auto �6(   �� 5*      $
��auto �6(   .+�5,      �� $��0��6    $��Center=�6.   $��ОТ:��6K   
���� ��$��20(�6j   $
��Bold"�6x    �� TextAlignment$ Center=�6�   $��Center=�6�   $��26��6�   $	��142��6�   $��
26,0,196,2q�6�   6�   (  "System.Windows.Controls.DatePicker  5-      $��Center=�6i   $��1��6�   $��Center=�6�   $	��200��6�   $��20(�6�      SelectedDate 6!   �� *	StartDT+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5.      � 50      $��1��6    51      �� 52      $
��auto �6(   �� 53      $
��auto �6(   .+�55      �� $��0��6    $��Center=�6-   $��ДО:��6J   
���� ��$��20(�6i   $
��Bold"�6w   $ Center=�6�   $��Center=�6�   $��27��6�   $	��142��6�   $��
31,1,191,0q�6�   6�     56      $��Center=�6h   $��1��6�   $��Center=�6�   $	��200��6�   $��20(�6�    6!   �� *
FinishDT+$ PropertyChanged=�6�   57      �� 5:      
���� ��$��1��6N   $��20��6^   $��Right=�6j   $��Center=�6�   $��
0,23,10,27q�6�   $��22��6�   ��6   �� *CountIncome+6�   5>      &   System.Windows.Controls.DataGrid  5@      $��1��6   $��1��6'      AutoGenerateColumns .     
IsReadOnly . $��5q�6�   ��64   �� *IncomeCount+	 �� SelectedItem	 6u   �� *SelectedIncome+
   Columns
 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Доход��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Income�6X   5D      5G      5I      5J      