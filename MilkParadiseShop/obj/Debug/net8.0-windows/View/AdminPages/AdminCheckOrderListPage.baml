   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      >    8MilkParadiseShop.View.AdminPages.AdminCheckOrderListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5      -   5          N� Title$  AdminCheckOrderListPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��5q�6#   $��Center=�6.   $��Center=�6K    �� Orientation$ 
Horizontal=�6f   .+�5      �� -   5        $��TextOrdersCount��5      $	��170��6/   
���   �$��Arial)�6N   $��14(�6a   $��Medium"�6o   �� 5      $��Номер:��6   $��70 0 0 0q�6&   
���   �$��Arial)�6K   $��14(�6^   $��Medium"�6l   �� 5      -   5        $��InputOrderId��5      $��40��6*   
���   �$��Arial)�6H   $��14(�6[   $��Medium"�6i   
����i��$��2q�5   ,   $��Center=�6@   $��5 0 2 0q�5       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6?   �� 5      $ ��Дата создания:��6   $��20 0 0 0q�6.   
���   �$��Arial)�6S   $��14(�6f   $��Medium"�6t   (  "System.Windows.Controls.DatePicker  5      -   5        $��SelectOrderDateCreate��5      $	��120��66   
���   �$��Arial)�6U   $��14(�6h   $��Medium"�6v   
����i��$��2q�5   /   $��Center=�6C   $��5 0 2 0q�6e   �� 5      $��Статус:��6   $��20 0 0 0q�6'   
���   �$��Arial)�6L   $��14(�6_   $��Medium"�6m   �� 5      -   5        $��ChooseOrderStatus��5      $	��120��60    �� SelectedIndex$ 0��6<   
���   �$��Arial)�6a   $��14(�6t   $��Medium"�5      
����i��$��2q�6A   $��Center=�6U   $��5 0 2 0q�6w   �� 5       -   5        $��CheckSearchOrders��5    X   $)��#Использовать поиск��6   $��20 0 0 0q�64    d� 	IsChecked$ FalseY�6F   $��14(�5!      $��Arial)�6%   $��Medium"�68   
����i��6L   5"      &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ DataGridAdminOrders��5#         
IsReadOnly$
 True��60   	   AutoGenerateColumns$	 False��5$      
   SelectionMode$
 Single=�6/   $��1��6F      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��6%      
Foreground
 �   �   
FontFamily$ Arial)�5'   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5&   ;   �� *NumId+5'   F     5(      $ Сотрудник��6%   
 �   �$ Arial)�5)   %   $ 16Q�68   $ DemiBold"�6F    5(   8   �� *WorkerFullName+5)   F     5*      $ Дата создания��6%   
 �   �$ Arial)�5+   %   $ 16Q�68   $ DemiBold"�6F    5*   <   �� *
DateCreate+ �� StringFormat$ 
dd-MM-yyyy��5+   F     5,      $# Дата завершения��6%   
 �   �$ Arial)�5-   %   $ 16Q�68   $ DemiBold"�6F    5,   >   �� *	DateEnd+$ 
dd-MM-yyyy��5-   F     5.      $ 
Адрес��6%   
 �   �$ Arial)�5/   %   $ 16Q�68   $ DemiBold"�6F    5.   4   �� *	Address+5/   F     50      $ Тип заказа��6%   
 �   �$ Arial)�51   %   $ 16Q�68   $ DemiBold"�6F    50   9   �� *	OrderType+51   F     52      $ Статус��6%   
 �   �$ Arial)�53   %   $ 16Q�68   $ DemiBold"�6F    52   5   �� *Status+53   F     54      $) #Количество товаров��6%   
 �   �$ Arial)�55   %   $ 16Q�68   $ DemiBold"�6F    54   A   �� *TotalProdQuantity+55   F     56      $) #Итоговая стоимость��6%   
 �   �$ Arial)�57   %   $ 16Q�68   $ DemiBold"�6F    56   A   �� *
TotalPrice+$ {0:F2}��57   F     58      $&  Положение в архие��6%   
 �   �$ Arial)�59   %   $ 16Q�68   $ DemiBold"�6F    58   @   �� *ArchiveText+59   F   4  .System.Windows.Controls.DataGridTemplateColumn  5:         CellTemplate 5;      �� 5<      .R�5=      �� -   5        $��Состав заказа��5=   %      MaterialDesignRaisedButton#��[  5>   %   
���P��
���   �$��Arial)�5?   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��68   $��12(�6e   $��DemiBold"�6s   5@      5B        5C       5D      �� 5E      .R�5F      �� -	   5        $)��#Архивировать заказ��5F   %   $	��170��6b   #��[  5G   %   
���P��
���   �$��Arial)�5H   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5I      5K        5L       5M      �� 5N      .R�5O      �� -
   5        $$��Убрать из архива��5O   %   $	��170��6c   #��[  5P   %   
���P��
���   �$��Arial)�5Q   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5R      5T      5V      �� 5X   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   $��5q�6s   .+�5Y      �� -   5        $��На главную��5Y      $	��180��6*   $��30��66   $��5q�6W   $
��Left=�5Z      
���P��
���   �#��[  5[      $��14(�6I   $��DemiBold"�6W   $��Arial)�5\      $ 5��6(   5]      5^      5_      