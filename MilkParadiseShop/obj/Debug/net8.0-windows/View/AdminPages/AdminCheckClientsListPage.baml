   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      @    :MilkParadiseShop.View.AdminPages.AdminCheckClientsListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5      -   5          N� Title$  AdminCheckClientsListPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   $��Center=�69   $��Center=�6V   .+�5      �� $��Номер:��6   $��50 0 0 0q�6&   
���   �$��Arial)�6K   $��14(�6^   $��Medium"�6l   �� 5      -   5        $��InputClientId��5      $��40��6+   
���   �$��Arial)�6I   $��14(�6\   $��Medium"�6j   
����i��$��2q�5   ,   $��Center=�6@   $��5 0 2 0q�5       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6?   �� 5      $��Имя:��6   $��20 0 0 0q�6$   
���   �$��Arial)�6I   $��14(�6\   $��Medium"�6j   �� 5      -   5        $��InputClientName��5      $	��150��6-   
���   �$��Arial)�6L   $��14(�6_   $��Medium"�6m   
����i��$��2q�5   ,   $��Center=�6@   $��5 0 2 0q�5      
 �   �
 �   �6?   �� 5      $��Пол:��6   $��20 0 0 0q�6$   
���   �$��Arial)�6I   $��14(�6\   $��Medium"�6j   �� 5      -   5        $��ChooseClientGender��5      $	��120��61    �� SelectedIndex$ 0��6=   
���   �$��Arial)�6b   $��14(�6u   $��Medium"�6�   
����i��$��2q�5   -   $��Center=�6A   $��5 0 2 0q�6c   �� 5!      -   5        $��CheckSearchWorkers��5!   X   $)��#Использовать поиск��6   $��20 0 0 0q�64    d� 	IsChecked$ FalseY�6F   $��14(�5"      $��Arial)�6%   $��Medium"�68   
����i��6L   5#      &   System.Windows.Controls.DataGrid  5%   
   -   5        $��DataGridAdminCheckClients��5%       $��1��6      
IsReadOnly$
 True��6A      AutoGenerateColumns$ False��5&      	   SelectionMode$	 Single=�6+   $��5q�6B   
   Columns
 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5)   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(   4   �� *NumId+5)   F     5*      $ Фамилия��6%   
 �   �$ Arial)�5+   %   $ 16Q�68   $ DemiBold"�6F    5*   6   �� *	SurName+5+   F     5,      $ Имя��6%   
 �   �$ Arial)�5-   %   $ 16Q�68   $ DemiBold"�6F    5,   2   �� *Name+5-   F     5.      $ Отчество��6%   
 �   �$ Arial)�5/   %   $ 16Q�68   $ DemiBold"�6F    5.   7   �� *
Patronymic+5/   F     50      $ 
Логин��6%   
 �   �$ Arial)�51   %   $ 16Q�68   $ DemiBold"�6F    50   4   �� *Login+51   F     52      $ Пароль��6%   
 �   �$ Arial)�53   %   $ 16Q�68   $ DemiBold"�6F    52   5   �� *
Password+53   F     54      $ 
Почта��6%   
 �   �$ Arial)�55   %   $ 16Q�68   $ DemiBold"�6F    54   4   �� *Email+55   F     56      $! Номер телефона��6%   
 �   �$ Arial)�57   %   $ 16Q�68   $ DemiBold"�6F    56   =   �� *PhoneNumber+57   F     58      $ Скидка��6%   
 �   �$ Arial)�59   %   $ 16Q�68   $ DemiBold"�6F    58   5   �� *
Discount+59   F   4  .System.Windows.Controls.DataGridTemplateColumn  5:         CellTemplate 5;      �� 5<      .R�5=      �� -   5        $#��Изменить скидку��5=   %   $	��170��6_      MaterialDesignRaisedButton#��[  5>   %   
���P��
���   �$��Arial)�5?   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��68   $��12(�6e   $��DemiBold"�6s   5@      5B        5C       5D      �� 5E      .R�5F      �� -   5        $��Удалить��5F   %   $	��170��6R   #��[  5G   %   
���P��
���   �$��Arial)�5H   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5I      5K      5M      �� 5O   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   $��5q�6s   .+�5P      �� -	   5        $��На главную��5P      $	��150��6*   $��30��66   $��5q�6W   
���P��
���   �#��[  5R      $��14(�6I   $��DemiBold"�6W   $��Arial)�5S      $ 5��6(   5T      5U      5V      