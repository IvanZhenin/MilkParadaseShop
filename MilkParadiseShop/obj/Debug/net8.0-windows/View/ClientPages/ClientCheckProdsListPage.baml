   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MilkParadiseShop.View.ClientPages!MilkParadiseShop.View.ClientPages  5      @    :MilkParadiseShop.View.ClientPages.ClientCheckProdsListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:MilkParadiseShop.View.ClientPages  5      -   5          N� Title$  ClientCheckProdsListPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��5q�6"    �� Orientation$ Vertical=�6-   .+�5      �� $��5q�6   $ Vertical=�6$   .+�5      �� $!��Список товаров��6   
���   �$��Arial)�6E   $��18(�6X   $��DemiBold"�6f   �� 5      -   5        $��TextCurrentCountProds��5      
���   �$��Arial)�6L   $��18(�6_   $��DemiBold"�6m   5      �� 5      $��5q�6   $ Vertical=�6$   .+�5      �� $ 
Horizontal=�6   $��5q�66   .+�5      �� $%��Название товара: ��6    
���   �$��Arial)�6L   $��14(�6_   $��Medium"�6m   �� 5      -   5         ��Name$ InputProductName��5      $	��150��68   
���   �$��Arial)�6W   $��14(�6j   $��Medium"�6x   
����i��$��2q�5   4   $��Center=�6H   $��5 0 2 0q�5       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6G   �� 5      $��Категория: ��6    $��20 0 0 0q�63   
���   �$��Arial)�6X   $��14(�6k   $��Medium"�6y   �� 5      -   5        $��ChooseProductCategory��5      $	��150��6<    �� SelectedIndex$ 0��6H   
���   �$��Arial)�6m   $��14(�5       $��Medium"�6-   
����i��$��2q�6W   $��Center=�6k   $��5 0 2 0q�6�   �� 5"      -   5        $��CheckSearchProducts��5"   G   $��5q�6   $)��#Использовать поиск��6*    d� 	IsChecked$ FalseY�6b   $��14(�5#      $��Arial)�6-   $��Medium"�6@   
����i��6T   5$      �� 5%      $ 
Horizontal=�6   $��5q�66   .+�5&      �� $��Мин. цена: ��6    
���   �$��Arial)�6F   $��14(�6Y   $��Medium"�6g   �� 5'      -   5        $��SelectMinimalProductPrice��5'      $	��150��6?   $��Arial)�6K   $��14(�6^   $��Medium"�6l   
����i��$��2q�5(   4   $��Center=�6H   $��5 0 2 0q�5)      
 �   �
 �   �6G   �� 5+      $��Макс. цена: ��6    $��20 0 0 0q�64   
���   �$��Arial)�6Y   $��14(�6l   $��Medium"�6z   �� 5,      -   5        $��SelectMaximalProductPrice��5,      $	��150��6?   $��Arial)�6K   $��14(�6^   $��Medium"�6l   
����i��$��2q�5-   4   $��Center=�6H   $��5 0 2 0q�5.      
 �   �
 �   �6G   5/      50      51      �� 53   
   -   5        $��ListViewProducts��53      $��1��6+   $��5q�68   $��Center=�6C   $��Disabled=�54       �� SelectionMode$ Single=�6I   ��55      �� 56      .R�57      � 	 � Orientation$	 
Horizontal=�6    $��Center=�69   58      ��5:      �� 5;      .R�5<      �� $	��400��6   $	��380��6)   $��2q�66   
����i��._�5=      �� $��5q�6%   $ Vertical=�60   .+�5>      �� $	��220��6$   $	��150��60   ��5?   "   �� 5@   &   
 �� Path$
 Image�6.    �� TargetNullValue 5A   *   ��5B   .   !/Resources/DefaultProduct.png��6Y   5D   '   5F      �� 5G      $��5q�6Z   
���   �$��Arial)�5H   (   $��16(�6;   $��DemiBold"�6I   ��5G   (   �� *NumId+ �� StringFormat$ Номер: {0}��5H   I   �� 5I      $��5q�6\   
���   �$��Arial)�5J   (   $��16(�6;   $��DemiBold"�6I   ��5I   (   �� *Name+$ Название: {0}��5J   I   �� 5K      $��5q�6e   
���   �$��Arial)�5L   (   $��16(�6;   $��DemiBold"�6I   ��5K   (   �� *CategoryName+$ Категория: {0}��5L   I   �� 5M      $��5q�6e   
���   �$��Arial)�5N   (   $��16(�6;   $��DemiBold"�6I   ��5M   (   �� *	Equipment+$# Комплектация: {0}��5N   I   �� 5O      $��5q�6`   
���   �$��Arial)�5P   (   $��16(�6;   $��DemiBold"�6I   ��5O   (   �� *Weight+$ Вес: {0:F2} Кг.��5P   I   �� 5Q      $��5q�6a   
���   �$��Arial)�5R   (   $��16(�6;   $��DemiBold"�6I   ��5Q   (   �� *Price+$ Цена: {0:F2} Руб.��5R   I   �� 5S      -	   5        $	��140��5S   %   $��40��61   $��В корзину��6=      MaterialDesignRaisedButton#��[  5T   %   
���P��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5U   %   $��2q�6R   
���   �$��Arial)�5V   8   $��12(�6K   $��DemiBold"�6Y   5W      5X      5Y      5[      �� 5\   
   $ 
Horizontal=�6   $��Center=�6.   $��2��6K   $��5q�6X   .+�5]      �� -
   5        $	��250��5]      $��50��6!   $5��/Перейти в корзину товаров��6-   $
��Left=�5^      
���P��
���   �$
��50 0q�6V   #��[  5_      $��14(�6I   $��DemiBold"�6W   $��Arial)�5`      $ 5��6(   �� 5a      -   5        $	��200��5a      $��50��6!   $%��Очистить корзину��6-   $
��Left=�5b      
���P��
���   �$
��50 0q�6V   #��[  5c      $��14(�6I   $��DemiBold"�6W   $��Arial)�5d      $ 5��6(   �� 5e      -   5        $	��200��5e      $��50��6!   $#��Вернуться назад��6-   $
��Left=�5f      
���P��
���   �$
��50 0q�6V   #��[  5g      $��14(�6I   $��DemiBold"�6W   $��Arial)�5h      $ 5��6(   5i      5j      5k      