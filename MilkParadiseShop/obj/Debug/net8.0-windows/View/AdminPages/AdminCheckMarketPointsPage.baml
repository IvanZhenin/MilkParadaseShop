   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      A    ;MilkParadiseShop.View.AdminPages.AdminCheckMarketPointsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5      -   5          N� Title$   AdminCheckMarketPointsPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $$��DataGridAdminCheckMarketPoints��5       $��0��6      
IsReadOnly$
 True��6F      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/   $��5q�6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5   %   	   FontSize$	 16Q�68   
   
FontWeight$
 DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   4   �� *NumId+5   F     5      $ 
Адрес��6%   
 �   �$ Arial)�5   %   $	 16Q�68   $
 DemiBold"�6F    5   4   �� *	Address+5   F   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� -   5        $��Изменить��5   %   68   5      5        5       5      �� 5       .R�5!      �� -   5        $��Удалить��5!   %   $	��170��6W      MaterialDesignRaisedButton#��[  5"   %   
���P��
���   �$��Arial)�5#   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��68   $��12(�6e   $��DemiBold"�6s   5$      5&      5(      �� 5)   
   $��1��6   $��5q�6"    �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�5*      �� -   5        $0��*Добавить новый магазин��5*      $	��250��66   $��45��6B   $��5q�6N   
���P��
���   �$��14(�5+   ;   $��DemiBold"�6I   $��Arial)�5,      $ 5��6(   #��[  5-      �� 5.      -   5        $,��&Вернуться на главную��5.      $	��250��64   $��45��6@   $��5q�6L   
���P��
���   �$��14(�5/   ;   $��DemiBold"�6I   $��Arial)�50      $ 5��6(   #��[  51      52      54      55      