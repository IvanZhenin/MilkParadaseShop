   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      D    >MilkParadiseShop.View.AdminPages.AdminAddOrEditMarketPointPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5        N� Title$#  AdminAddOrEditMarketPointPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      �� $ 
Horizontal=�6   $��5q�62   .+�5      �� $	��200��6   $��
Номер��6(   
���   �$��Arial)�6H   $��14(�6[   $��Medium"�6i   �� 5      -   5        $��
InputNumId��5       �� 
IsReadOnly$
 True��6C   
���   �$��Arial)�5      $��14(�6-   $��Medium"�6;   
����i��$��0 0 0 2q�5      $��Center=�64   $��5 0 2 0q�6V    �� SelectionBrush
 �   � �� 
CaretBrush
 �   �$	��220��5   D   ��5   ,   �� *NumId+5   D   5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5      �� $	��200��6   $��
Адрес��6(   
���   �$��Arial)�6H   $��14(�6[   $��Medium"�6i   �� 5      -   5        $��InputAddress��5      
���   �$��Arial)�5      $��14(�6-   $��Medium"�6;   
����i��$��0 0 0 2q�5      $��Center=�64   $��5 0 2 0q�6V   
 �   �
 �   �$	��220��5   D   ��5   .   �� *	Address+5   D   5      5       �� 5"   
   $��1��6   $��Center=�6"   $��Center=�6=   $��5q�5#      $ 
Horizontal=�6   .+�5$      �� -   5        $��Сохранить��5$      $��5q�6)   $	��150��64   $��30��6@   $
��Left=�5%      
���P��
���   �   MaterialDesignRaisedButton#��[  5&      $��14(�6I   $��DemiBold"�6W   $��Arial)�5'      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6(   6U   �� 5(      -   5        $��Отменить��5(      $��5q�6(   $	��150��63   $��30��6?   $
��Left=�5)      
���P��
���   �#��[  5*      $��14(�6I   $��DemiBold"�6W   $��Arial)�5+      $ 5��6(   6U   5,      5-      5.      