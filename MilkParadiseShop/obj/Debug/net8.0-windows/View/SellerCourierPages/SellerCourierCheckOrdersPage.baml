   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MilkParadiseShop.View.SellerPages!MilkParadiseShop.View.SellerPages  5      D    >MilkParadiseShop.View.SellerPages.SellerCourierCheckOrdersPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:MilkParadiseShop.View.SellerPages  5      -   5          N� Title$  SellerCheckOrdersPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��70 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $��1��6   $��5q�6%   $��Center=�60   .+�5      �� -   5        $��TextDataOfSellerAccount��5      $/��)Данные учетной записи:��67   
���   �$��Arial)�5      $��16(�6+   $��DemiBold"�69   5      �� 5   
   $��1��6   $��1��6"   $��5q�62    �� Orientation$ 
Horizontal=�6=   $��Center=�5      $��Center=�6*   .+�5      �� -   5        $��TextOrdersCount��5      $	��170��6/   
���   �$��Arial)�6N   $��14(�6a   $��Medium"�6o   �� 5       $��Номер:��6   $��20 0 0 0q�6&   
���   �$��Arial)�6K   $��14(�6^   $��Medium"�6l   �� 5!      -   5        $��InputOrderId��5!      $��40��6*   
���   �$��Arial)�6H   $��14(�6[   $��Medium"�6i   
����i��$��2q�5"   $   $��Center=�68   $��5 0 2 0q�5#       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �67   �� 5%      $ ��Дата создания:��6   $��20 0 0 0q�6.   
���   �$��Arial)�6S   $��14(�6f   $��Medium"�6t   (  "System.Windows.Controls.DatePicker  5&      -   5        $��SelectOrderDateCreate��5&      $	��120��66   
���   �$��Arial)�6U   $��14(�6h   $��Medium"�6v   
����i��$��2q�5'   (   $��Center=�6<   $��5 0 2 0q�6^   �� 5)      $��Статус:��6   $��20 0 0 0q�6'   
���   �$��Arial)�6L   $��14(�6_   $��Medium"�6m   �� 5*      -   5        $��ChooseOrderStatus��5*      $	��120��60    �� SelectedIndex$ 0��6<   
���   �$��Arial)�6a   $��14(�6t   $��Medium"�6�   
����i��$��2q�5+   (   $��Center=�6<   $��5 0 2 0q�6^   �� 5,      -   5        $��CheckSearchOrders��5,   X   $)��#Использовать поиск��6   $��20 0 0 0q�64    d� 	IsChecked$ FalseY�6F   $��14(�5-      $��Arial)�6   $��Medium"�60   
����i��6D   5.      &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$! DataGridSellerCourierOrders��5/      	   
IsReadOnly$
	 True��68   $��2��6J   $��1��6W   $��2��50      
   AutoGenerateColumns$
 False��6%      SelectionMode$ Single=�6A   $��0 0 0 20q�6X      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��6%      
Foreground
 �   �   
FontFamily$ Arial)�53   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 52   ;   �� *NumId+53   F     54      $ Сотрудник��6%   
 �   �$ Arial)�55   %   $ 16Q�68   $ DemiBold"�6F    54   8   �� *WorkerFullName+55   F     56      $ Дата создания��6%   
 �   �$ Arial)�57   %   $ 16Q�68   $ DemiBold"�6F    56   <   �� *
DateCreate+ �� StringFormat$ 
dd-MM-yyyy��57   F     58      $# Дата завершения��6%   
 �   �$ Arial)�59   %   $ 16Q�68   $ DemiBold"�6F    58   >   �� *	DateEnd+$ 
dd-MM-yyyy��59   F     5:      $ 
Адрес��6%   
 �   �$ Arial)�5;   %   $ 16Q�68   $ DemiBold"�6F    5:   4   �� *	Address+5;   F     5<      $ Тип заказа��6%   
 �   �$ Arial)�5=   %   $ 16Q�68   $ DemiBold"�6F    5<   9   �� *	OrderType+5=   F     5>      $ Статус��6%   
 �   �$ Arial)�5?   %   $ 16Q�68   $ DemiBold"�6F    5>   5   �� *Status+5?   F     5@      $) #Количество товаров��6%   
 �   �$ Arial)�5A   %   $ 16Q�68   $ DemiBold"�6F    5@   A   �� *TotalProdQuantity+5A   F     5B      $) #Итоговая стоимость��6%   
 �   �$ Arial)�5C   %   $ 16Q�68   $ DemiBold"�6F    5B   A   �� *
TotalPrice+5C   F   4  .System.Windows.Controls.DataGridTemplateColumn  5D         CellTemplate 5E      �� 5F      .R�5G      �� -	   5        $��Состав заказа��5G   %   $	��170��6Z      MaterialDesignRaisedButton#��[  5H   &   
���P��
���   �$��Arial)�5I   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��68   $��12(�6e   $��DemiBold"�6s   5J      5L        5M       5N      �� 5O      .R�5P      �� -
   5        $��Принять заказ��5P   %   $	��170��6U   #��[  5Q   &   
���P��
���   �$��Arial)�5R   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5S      5U        5V       5W      �� 5X      .R�5Y      �� -   5        $��Завершить��5Y   %   $	��170��6S   #��[  5Z   &   
���P��
���   �$��Arial)�5[   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5\      5^        5_       5`      �� 5a      .R�5b      �� -   5        $��Отменить��5b   %   $	��170��6R   #��[  5c   &   
���P��
���   �$��Arial)�5d   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5e      5g      5i      �� 5k   
   $ Vertical=�6   $��5q�6,   $��Center=�67   $��0��5l      $��0��6"   $��3��62   .+�5m      �� -   5        $��60��5m      $��60��6    $��5q�6,    & "MaterialDesignFloatingActionButton#��[ 5n      $��Arial)�6Q   
���P��
���   �$��10(�5o   <   $��DemiBold"�6J   ��5p      �� 5q      $��
Выйти��6    5s      5t      5u      5v      