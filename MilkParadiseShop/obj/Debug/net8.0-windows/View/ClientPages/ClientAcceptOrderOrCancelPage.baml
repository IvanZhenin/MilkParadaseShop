   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MilkParadiseShop.View.ClientPages!MilkParadiseShop.View.ClientPages  5      E    ?MilkParadiseShop.View.ClientPages.ClientAcceptOrderOrCancelPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:MilkParadiseShop.View.ClientPages  5      -   5          N� Title$#  ClientAcceptOrderOrCancelPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $��60 �6   �� 5      $	��100 �6   .+�5   
   �� $'��!Оформление заказа��6   $
��Left=�6-   $��Center=�6H   $��15 5 5 5q�6c   
���   �$��Arial)�5   '   $��18(�6:   $��DemiBold"�6H   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridFinalShoppingCart��5         
IsReadOnly$
 True��64   $��1��6F   $��5q�6S      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5   %   	   FontSize$	 16Q�68   
   
FontWeight$
 DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   4   �� *ProdId+5   F     5      $ Название��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   7   �� *
ProdName+5   F     5      $ Количество��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   9   �� *
Quantity+5   F     5      $" Цена за позицию��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   >   �� *TotalPriceForProduct+ �� StringFormat$ {0:F2}��5   F   5       �� 5"   
    �� Orientation$ 
Horizontal=�6   $��5q�6.   $��2��69   $��Center=�6F   .+�5#      �� $'��!Способ получения: ��6   
���   �$��Arial)�6E   $��14(�6X   $��Medium"�6f   �� 5$      -   5        $��SelectMethodReceiveProds��5$      $	��150��67    �� SelectedIndex$ 0��6C   
���   �$��Arial)�5%   f   $��14(�5&      $��Medium"�6%   
����i��$��2q�6O   $��Center=�5'      $��5 0 2 0q�69   �� 5)      $ 
Horizontal=�6   $	��5 0q�62   .+�5*      �� -   5        $��SelectMarketPoint��5*      $	��200��64   $ 0��6@   
���   �$��Arial)�5+   j   $��14(�5,      $��Medium"�6)   
����i��$��2q�6S   $��Center=�5-      $��5 0 2 0q�6=   �� 5.      -   5        $��InputAddress��5.      $	��200��6.   
���   �$��Arial)�6N   $��14(�6a   $��Medium"�6o   
����i��$��2q�5/   4   $��Center=�6H   $��5q�6j   $��5 0 2 0q�50       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6G   51      �� 53      $ Vertical=�6   $��30 0 0 0q�60   .+�54      �� $"��Итого к оплате: ��6   
���   �$��Arial)�6G   $��14(�6Z   $��Medium"�6h   �� 55      -   5        $��TextClientDiscountPercent��55      $��Скидка: ��6=   
���   �$��Arial)�6`   $��14(�6s   $��Medium"�6�   56      �� 57      -   5        $��InputTotalOrderAmount��57      $	��200��63   $��30��6?    �� 
IsReadOnly$
 True��6K   
���   �$��Arial)�58   )   $��14(�6<   $��Medium"�6J   
����i��$��2q�59   ,   $��Center=�6@   $��5 0 2 0q�5:      
 �   �
 �   �6?   5;      �� 5=   
   $ 
Horizontal=�6   $��Center=�6.   $��3��6K   $��5q�6X   .+�5>      �� -   5        $	��200��5>      $��50��6!   $'��!Подтвердить заказ��6-   $
��50 0q�6c   $
��Left=�5?      
���P��
���   �   MaterialDesignRaisedButton#��[  5@      $��14(�6I   $��DemiBold"�6W   $��Arial)�5A      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6(   �� 5B      -	   5        $	��200��5B      $��50��6!   $#��Вернуться назад��6-   $
��50 0q�6\   $
��Left=�5C      
���P��
���   �#��[  5D      $��14(�6I   $��DemiBold"�6W   $��Arial)�5E      $ 5��6(   5F      5G      5H      