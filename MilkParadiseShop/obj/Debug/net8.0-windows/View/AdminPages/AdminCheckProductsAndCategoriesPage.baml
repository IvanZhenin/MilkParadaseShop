   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      J    DMilkParadiseShop.View.AdminPages.AdminCheckProductsAndCategoriesPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5      -   5          N� Title$)  #AdminCheckProductsAndCategoriesPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   .+�5   
   �� .@�5      �� $��Товары��6   $	��100��6&   .��5      � $��5q�6    5      �� 5      �� 5      $��60 �6(   .+�5      �� -   5        $��ListViewProducts��5      $��0��67   $��5q�6D   $��Center=�6O   $��Disabled=�5       �� SelectionMode$ Single=�6U   ��5      �� 5      .R�5   "   �  � Orientation$ 
Horizontal=�6,   $��Center=�6E   5      ��5      �� 5      .R�5    "   �� $	��400��6)   $	��400��65   $��2q�6B   
����i��._�5!   &   �� $��5q�61    �� Orientation$ Vertical=�6<   .+�5"   *   �� $	��220��60   $	��150��6<   ��5#   .   �� 5$   2    �� Path$ Image�6:    �� TargetNullValue 5%   6   ��5&   :   !/Resources/DefaultProduct.png��6e   5(   3   5*   +   �� 5+   *   $��5q�6f   
���   �$��Arial)�5,   4   $��16(�6G   $��DemiBold"�6U   ��5+   4   �� *NumId+ �� StringFormat$ Номер: {0}��5,   U   �� 5-   *   $��5q�6h   
���   �$��Arial)�5.   4   $��16(�6G   $��DemiBold"�6U   ��5-   4   �� *Name+$ Название: {0}��5.   U   �� 5/   *   $��5q�6q   
���   �$��Arial)�50   4   $��16(�6G   $��DemiBold"�6U   ��5/   4   �� *CategoryName+$ Категория: {0}��50   U   �� 51   *   $��5q�6q   
���   �$��Arial)�52   4   $��16(�6G   $��DemiBold"�6U   ��51   4   �� *	Equipment+$# Комплектация: {0}��52   U   �� 53   *   $��5q�6l   
���   �$��Arial)�54   4   $��16(�6G   $��DemiBold"�6U   ��53   4   �� *Weight+$ Вес: {0:F2} Кг.��54   U   �� 55   *   $��5q�6m   
���   �$��Arial)�56   4   $��16(�6G   $��DemiBold"�6U   ��55   4   �� *Price+$ Цена: {0:F2} Руб.��56   U   �� 57   *   $ 
Horizontal=�65   .+�58   .   �� -   5        $	��100��58   5   $��50��6A   $��5q�6M   $��Изменить��59   5      MaterialDesignRaisedButton#��[  5:   5   
���P��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5;   5   
���   �$��Arial)�5<   H   $��12(�6[   $��DemiBold"�6i   �� 5=   .   -   5        $	��100��5=   5   $��50��6A   $��5q�6M   $��Удалить��5>   5   #��[  5?   5   
���P��$ 5��5@   5   
���   �$��Arial)�5A   H   $��12(�6[   $��DemiBold"�6i   5B   +   5C   '   5D   #   5E      5G      �� 5H      -   5        $��1��5H      $,��&Добавить новый товар��6*   $	��250��6I   $��45��5I      $��5q�6)   
���P��
���   �#��[  5J      $��14(�6Q   $��DemiBold"�6_   $��Arial)�5K      $ 5��60   5L      5M      �� 5N      $��Категории��6   $	��100��6)   .��5O      � $��5q�6    5P      �� 5Q      �� 5R      $��60 �6(   .+�5T      &   System.Windows.Controls.DataGrid  -   5        $"��DataGridAdminCheckCategories��5T   ,   $��0��6   	   
IsReadOnly$
	 True��6P   
   AutoGenerateColumns$
 False��5U         SelectionMode$ Single=�6;   $��5q�6R      Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��61      
Foreground
 �   �   
FontFamily$ Arial)�5X   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5W   @   �� *NumId+5X   F     5Y      $ Название��61   
 �   �$ Arial)�5Z   %   $ 16Q�68   $ DemiBold"�6F    5Y   C   �� *Name+5Z   F   4  .System.Windows.Controls.DataGridTemplateColumn  5[         CellTemplate 5\   "   �� 5]   &   .R�5^   *   �� -   5        $��Изменить��5^   1   $	��170��6_   #��[  5_   1   
���P��
���   �$��Arial)�5`   1   $ 5��6D   $��12(�6q   $��DemiBold"�6   5a   '   5c        5d       5e   "   �� 5f   &   .R�5g   *   �� -   5        $��Удалить��5g   1   $	��170��6`   #��[  5h   1   
���P��
���   �$��Arial)�5i   1   $ 5��6D   $��12(�6q   $��DemiBold"�6   5j   '   5l      5n      �� 5o      -	   5        $��1��5o      $4��.Добавить новую категорию��6*   $	��250��6M   $��45��5p      $��5q�6)   
���P��
���   �#��[  5q      $��14(�6Q   $��DemiBold"�6_   $��Arial)�5r      $ 5��60   5s      5t      5u      �� 5w   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   $��5q�6s   .+�5x      �� -
   5        $��На главную��5x      $	��150��6*   $��30��66   $��5q�6W   
���P��
���   �$��14(�5y   ;   $��DemiBold"�6I   $��Arial)�5z      $ 5��6(   #��[  5{      5|      5}      5~      