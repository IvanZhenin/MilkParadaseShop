   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MilkParadiseShop.View.ClientPages!MilkParadiseShop.View.ClientPages  5      <    6MilkParadiseShop.View.ClientPages.ClientOrdersListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:MilkParadiseShop.View.ClientPages  5      -   5          N� Title$  ClientOrdersListPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��70 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $��1��6   $��5q�6%   $��Center=�60   .+�5      �� -   5        $��TextDataOfClientAccount��5      $/��)Данные учетной записи:��67   
���   �$��Arial)�5      $��16(�6+   $��DemiBold"�69   �� 5      -   5        $#��Изменить данные��5   ;   $	��180��5      $
��Left=�6!   $��5q�6<   
���P��
���   �   MaterialDesignRaisedButton#��[  5      $��14(�6I   $��DemiBold"�6W   $��Arial)�5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6(   �� 5      $,��&Список ваших заказов��6   
���   �$��Arial)�5      $��16(�6+   $��DemiBold"�69   5       �� 5"   
   $��1��6   $��1��6"   $��5q�62    �� Orientation$ 
Horizontal=�6=   $��Center=�5#      $��Center=�62   .+�5$      �� -   5        $��TextOrdersCount��5$      $	��170��6/   
���   �$��Arial)�6N   $��14(�6a   $��Medium"�6o   �� 5%      $��Номер:��6   $��20 0 0 0q�6&   
���   �$��Arial)�6K   $��14(�6^   $��Medium"�6l   �� 5&      -   5        $��InputOrderId��5&      $��40��6*   
���   �$��Arial)�6H   $��14(�6[   $��Medium"�6i   
����i��$��2q�5'   ,   $��Center=�6@   $��5 0 2 0q�5(       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6?   �� 5*      $ ��Дата создания:��6   $��20 0 0 0q�6.   
���   �$��Arial)�6S   $��14(�6f   $��Medium"�6t   (  "System.Windows.Controls.DatePicker  5+      -   5        $��SelectOrderDateCreate��5+      $	��120��66   
���   �$��Arial)�6U   $��14(�6h   $��Medium"�6v   
����i��$��2q�5,   0   $��Center=�6D   $��5 0 2 0q�6f   �� 5.      $��Статус:��6   $��20 0 0 0q�6'   
���   �$��Arial)�6L   $��14(�6_   $��Medium"�6m   �� 5/      -   5        $��ChooseOrderStatus��5/      $	��120��60    �� SelectedIndex$ 0��6<   
���   �$��Arial)�6a   $��14(�6t   $��Medium"�6�   
����i��$��2q�50   0   $��Center=�6D   $��5 0 2 0q�6f   �� 51      -   5        $��CheckSearchOrders��51   X   $)��#Использовать поиск��6   $��20 0 0 0q�64    d� 	IsChecked$ FalseY�6F   $��14(�52      $��Arial)�6%   $��Medium"�68   
����i��6L   53      &   System.Windows.Controls.DataGrid  55   
   -	   5        	  Name$	 DataGridClientOrders��55      
   
IsReadOnly$

 True��61   $��2��6C   $��2��6P   $��0 0 0 20q�6a      AutoGenerateColumns$ False��56         SelectionMode$ Single=�6/   $��1��6F      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��6%      
Foreground
 �   �   
FontFamily$ Arial)�59   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 58   ;   �� *NumId+59   F     5:      $ Сотрудник��6%   
 �   �$ Arial)�5;   %   $ 16Q�68   $ DemiBold"�6F    5:   8   �� *WorkerFullName+5;   F     5<      $ Дата создания��6%   
 �   �$ Arial)�5=   %   $ 16Q�68   $ DemiBold"�6F    5<   <   �� *
DateCreate+ �� StringFormat$ 
dd-MM-yyyy��5=   F     5>      $# Дата завершения��6%   
 �   �$ Arial)�5?   %   $ 16Q�68   $ DemiBold"�6F    5>   >   �� *	DateEnd+$ 
dd-MM-yyyy��5?   F     5@      $ 
Адрес��6%   
 �   �$ Arial)�5A   %   $ 16Q�68   $ DemiBold"�6F    5@   4   �� *	Address+5A   F     5B      $ Тип заказа��6%   
 �   �$ Arial)�5C   %   $ 16Q�68   $ DemiBold"�6F    5B   9   �� *	OrderType+5C   F     5D      $ Статус��6%   
 �   �$ Arial)�5E   %   $ 16Q�68   $ DemiBold"�6F    5D   5   �� *Status+5E   F     5F      $) #Количество товаров��6%   
 �   �$ Arial)�5G   %   $ 16Q�68   $ DemiBold"�6F    5F   A   �� *TotalProdQuantity+5G   F     5H      $) #Итоговая стоимость��6%   
 �   �$ Arial)�5I   %   $ 16Q�68   $ DemiBold"�6F    5H   A   �� *
TotalPrice+5I   F   4  .System.Windows.Controls.DataGridTemplateColumn  5J         CellTemplate 5K      �� 5L      .R�5M      �� -
   5        $��Состав заказа��5M   %   $	��170��6Z   #��[  5N   %   
���P��
���   �$��Arial)�5O   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5P      5R        5S       5T      �� 5U      .R�5V      �� -   5        $��Отменить��5V   %   $	��170��6R   #��[  5W   %   
���P��
���   �$��Arial)�5X   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5Y      5[      5]      �� 5^   
   $ Vertical=�6   $��5q�6,   $��Center=�67   $��0��5_      $��0��6"   $��4��62   .+�5`      �� -   5        $��60��5`      $��60��6    $��5q�6,    & "MaterialDesignFloatingActionButton#��[ 5a      $��Arial)�6Q   
���P��
���   �$��10(�5b   <   $��DemiBold"�6J   ��5c      �� 5d      $��Товары��6    5f      �� 5g      -   5        $��60��5g      $��60��6    $��5q�6,   #��[ 5h      $��Arial)�6Q   
���P��
���   �$��10(�5i   <   $��DemiBold"�6J   ��5j      �� 5k      $��
Выйти��6    5m      5n      5o      5p      