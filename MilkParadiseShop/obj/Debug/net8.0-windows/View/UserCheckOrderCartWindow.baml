   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MilkParadiseShop.ViewMilkParadiseShop.View  5   	   4    .MilkParadiseShop.View.UserCheckOrderCartWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /local#clr-namespace:MilkParadiseShop.View  5   	   $	��400��5	   	   $	��650��6   $	��400��6(   $	��650��5
   	     � 
ResizeMode$  CanMinimize=�6    � WindowStartupLocation$ CenterScreen=�61   .��5      � ��5   
   �� 5      .��5      �  � Color$ HotPink��6    � Offset$ 1Q�6/   � 5      $ Coral��6   $	 0.8Q�6-   5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   ��  �� CornerRadius$ 	70 0 70 0��6   $��5q�6*   
�������$��2��6O   �� 5   
   -   5        $ ��TextCurrentProdInOrderList��5      $��5q�66   
���   �$��Arial)�6T   $��14(�5      $��Medium"�6"   $��0��66   $��Center=�6C   $��Bottom=�6`   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridProductsInOrder��5         
IsReadOnly$
 True��62   $��1��6D   $��30 15 30 30q�6Q      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   4   �� *ProdId+5   F     5      $
 Название��6%   
 �   �$ Arial)�5   %   $ 16Q�68   $ DemiBold"�6F    5   7   �� *
ProdName+5   F     5       $
 Количество��6%   
 �   �$ Arial)�5!   %   $ 16Q�68   $ DemiBold"�6F    5    9   �� *
Quantity+5!   F   5#      5$      5%      