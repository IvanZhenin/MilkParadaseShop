   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MilkParadiseShop.View.ClientPages!MilkParadiseShop.View.ClientPages  5      D    >MilkParadiseShop.View.ClientPages.ClientPreviewCartInOrderPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:MilkParadiseShop.View.ClientPages  5      -   5          N� Title$  ClientPreviewCartInOrder��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $#��Корзина товаров��6   $
��Left=�6+   $��Center=�6F   $��15 5 5 5q�6a   
���   �$��Arial)�5   '   $��18(�6:   $��DemiBold"�6H   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridProductsInCart��5         
IsReadOnly$
 True��61   $��1��6C   $��5q�6P      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5   %   	   FontSize$	 16Q�68   
   
FontWeight$
 DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   4   �� *ProdId+5   F     5      $ Название��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   7   �� *
ProdName+5   F     5      $ Количество��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   9   �� *
Quantity+5   F     5      $" Цена за позицию��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   >   �� *TotalPriceForProduct+ �� StringFormat$ {0:F2}��5   F   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5       .R�5!      �� -   5        $+��%Изменить количество��5!   %      MaterialDesignRaisedButton#��[  5"   %   
���P��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5#   %   $��2q�6R   $	��185��6]   
���   �$��Arial)�5$   8   $��12(�6K   $��DemiBold"�6Y   5%      5'        5(       5)      �� 5*      .R�5+      �� -   5        $#��Удалить позицию��5+   %   #��[  5,   %   
���P��$ 5��5-   %   $��2q�6R   $	��185��6]   
���   �$��Arial)�5.   8   $��12(�6K   $��DemiBold"�6Y   5/      51      53      �� 55   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��2��6K   $��5q�6X   .+�56      �� -   5        $	��250��56      $��50��6!   $9��3Перейти к оформлению заказа��6-   $
��50 0q�6s   #��[  57      
���P��
���   �$��Arial)�6o   $ 5��58      $��14(�6B   $��DemiBold"�6P   �� 59      -   5        $	��190��59      $��50��6!   $%��Очистить корзину��6-   $
��50 0q�6o   #��[  5:      
���P��
���   �$��Arial)�6o   $ 5��5;      $��14(�6B   $��DemiBold"�6P   �� 5<      -   5        $	��190��5<      $��50��6!   $#��Вернуться назад��6-   $
��50 0q�6\   #��[  5=      
���P��
���   �$��Arial)�6o   $ 5��5>      $��14(�6B   $��DemiBold"�6P   5?      5@      5A      