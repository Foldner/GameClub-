   M S B A M L   `   `   `  ����C  ?GameClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GameClubGameClub  5   	   9!clr-namespace:GameClub.ViewModelsGameClub.ViewModels  5   	       GameClub.Views.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:GameClub     5   	   8
viewmodels!clr-namespace:GameClub.ViewModels     5   	     � Title$  Game Club Manage��5
   	   $	��900��6"   $
��1600��6/    J� RenderTransformOrigin$ 0.5,0.5&�6<    � WindowStyle$
 None=�6\      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      $��Bahnschrift)�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5   
    � 
ResizeMode$ CanResizeWithGrip=�5   	   $	��900��5   	   $
��1600��5   	    � DataContext 5      &   GameClub.ViewModels.VMMainWindow  5   
   .��5      �  � ColumnDefinitions 5    
   �� 5!      $	��350 �6   �� 5"      $��1* �6   	 � RowDefinitions	 5%   
   �� 5&      $��50 �6   �� 5'      $��* �6   .+�5+   
    � -   5        $��	WorkFrame��5+   d   $��1��60   $��1��6@   ���	#FFCFCFCF
  � NavigationUIVisibility$
 Hidden=�6u   $��2��6�   ��6   �� *CurrentPage+6�   � 5-   
   $��1��6   ��5.      �� 5/       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��50      �  � Color$ 	#FFC5C5C5��6#    � Offset$ 1Q�65   � 51      $ 	#FFE0E0E0��6#   52      	 54      �� 55      $��10 �6    �� 56       J� Effect 58      3  -System.Windows.Media.Effects.DropShadowEffect  59         
BlurRadius$ 20Q�6#      Color$ 	#FFDEDEDE��63      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   .+�5<      �� $��1��6   .+�5=      �� -   5         ��Name$ OrderMenuButton��5=   :   $��2,10,2,5q�6S   ���#9147ff$��80��6z   ��6   �� *OrderCommand+.��5>      � $	��270��6   .+�5?      �� $��Right=�6$   $��Заказы��6@   
�������$��30(�6a   $��0,0,85,0q�6o   5@      5A      �� 5B      -   5        $ DeviceMenuButton��5B   ;   $��2,10,2,5q�6U   ���#9147ff$��80��6|   ��6   �� *DeviceCommand+.��5C      � $	��270��6   .+�5D      �� $��Center=�6$   $��Устройства��6A   
�������$��30(�6f   5E      5F      �� 5G      -   5        $ IncomeMenuButton��5G   ;   $��2,10,2,5q�6V   ���#9147ff$��80��6}   $��30(�6�   ��6   �� *IncomeCommand+.��5H      � $	��270��6   .+�5I      �� $��Center=�6$   $��
Доход��6A   
�������$��30(�6a   5J      5K      �� 5L      -   5        $ CourierMenuButton��5L   <   $��2,10,2,5q�6W   ���#9147ff$��80��6~   ��6   �� *ProductCommand+.��5M      � $	��270��6   .+�5N      �� $��Right=�6$   $��Товары��6@   
�������$��30(�6a   $��0,0,74,0q�6o   5O      5P      5R      5U      � 5W   
   -   5         �Name$ UpperBar��5W      $��3��6!   ���#7741c9.+�5X      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��10, 0q�6M   .+�5Y      �� $��Center=�6   $��10, 0q�67   $��	Game Club��6F   $��30(�6W   $
��Bold"�6e   ���	#DDFFFFFF6�   5Z      �� 5\      $ 
Horizontal=�6   $��Right=�62   $��10, 0q�6N   .+�5^      �� -   5        $ NormalSizeButton��5^       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 64   $��5q�6z   $y�	Collapsed=�6�   $��45��6�   $��45��6�   
�������
���������6�   Z� 5_      �� 5a      -   5        $ FullSizeButton��5a      $��5q�61   $��45��6=   $��45��6H   
�������
���������6g   Z� 5b      �� 5d      -	   5        $ CloseButton��5d      $��5q�6.   $��45��6:   $��45��6E   ���#ef2366
���������6f   Z� 5e      5g      5h      5j      5l      