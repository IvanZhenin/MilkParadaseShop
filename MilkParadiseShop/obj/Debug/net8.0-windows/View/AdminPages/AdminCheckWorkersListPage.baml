   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.AdminPages MilkParadiseShop.View.AdminPages  5      @    :MilkParadiseShop.View.AdminPages.AdminCheckWorkersListPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.AdminPages  5      -   5          N� Title$  AdminCheckWorkersListPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   $��Center=�69   $��Center=�6V   .+�5      �� $��Номер:��6   $��50 0 0 0q�6&   
���   �$��Arial)�6K   $��14(�6^   $��Medium"�6l   �� 5      -   5        $��InputWorkerId��5      $��40��6+   
���   �$��Arial)�6I   $��14(�6\   $��Medium"�6j   
����i��$��2q�5   ,   $��Center=�6@   $��5 0 2 0q�5       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6?   �� 5      $��Должность:��6   $��20 0 0 0q�6*   
���   �$��Arial)�6O   $��14(�6b   $��Medium"�6p   �� 5      -   5        $��SelectWorkerRole��5      $	��150��6/    �� SelectedIndex$ 0��6;   
���   �$��Arial)�6`   $��14(�6s   $��Medium"�6�   
����i��$��2q�5   -   $��Center=�6A   $��5 0 2 0q�6c   �� 5      $��Пол:��6   $��20 0 0 0q�6$   
���   �$��Arial)�6I   $��14(�6\   $��Medium"�6j   �� 5      -   5        $��ChooseWorkerGender��5      $	��120��61   $ 0��6=   
���   �$��Arial)�6b   $��14(�6u   $��Medium"�6�   
����i��$��2q�5   ,   $��Center=�6@   $��5 0 2 0q�6b   �� 5       -   5        $��CheckSearchWorkers��5    X   $)��#Использовать поиск��6   $��20 0 0 0q�64    d� 	IsChecked$ FalseY�6F   $��14(�5!      $��Arial)�6%   $��Medium"�68   
����i��6L   5"      &   System.Windows.Controls.DataGrid  5$   
   -   5        $��DataGridAdminCheckWorkers��5$       $��1��6      
IsReadOnly$
 True��6A      AutoGenerateColumns$ False��5%      	   SelectionMode$	 Single=�6/   $��5q�6F   
   Columns
 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Foreground
 �   �   
FontFamily$ Arial)�5(   %      FontSize$ 16Q�68      
FontWeight$ DemiBold"�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5'   4   �� *NumId+5(   F   4  .System.Windows.Controls.DataGridTemplateColumn  5)      $ Фотография��6)      CellTemplate 5*      �� 5+      .R�5,      �� $��70��6$   $��70��6/   ��5-   "   �� 5.   &    �� Path$ Image�6.    �� TargetNullValue 5/   *   ��50   .   %!/Resources/DefaultWorkerImage.png��6]   52   '   54      55      57        58      $ Фамилия��6%   
 �   �$ Arial)�59   %   $ 16Q�68   $ DemiBold"�6F    58   6   �� *	SurName+59   F     5:      $ Имя��6%   
 �   �$ Arial)�5;   %   $ 16Q�68   $ DemiBold"�6F    5:   2   �� *Name+5;   F     5<      $ Отчество��6%   
 �   �$ Arial)�5=   %   $ 16Q�68   $ DemiBold"�6F    5<   7   �� *
Patronymic+5=   F     5>      $ Пол��6%   
 �   �$ Arial)�5?   %   $ 16Q�68   $ DemiBold"�6F    5>   2   �� *Gender+5?   F     5@      $ Должность��6%   
 �   �$ Arial)�5A   %   $ 16Q�68   $ DemiBold"�6F    5@   8   �� *	JobName+5A   F     5B      $ 
Логин��6%   
 �   �$ Arial)�5C   %   $ 16Q�68   $ DemiBold"�6F    5B   4   �� *Login+5C   F     5D      $ Пароль��6%   
 �   �$ Arial)�5E   %   $ 16Q�68   $ DemiBold"�6F    5D   5   �� *
Password+5E   F     5F      $ 
Почта��6%   
 �   �$ Arial)�5G   %   $ 16Q�68   $ DemiBold"�6F    5F   4   �� *Email+5G   F     5H      $! Номер телефона��6%   
 �   �$ Arial)�5I   %   $ 16Q�68   $ DemiBold"�6F    5H   =   �� *PhoneNumber+5I   F     5J       5K      �� 5L      .R�5M      �� -   5        $��Изменить��5M   %   $	��170��6Q      MaterialDesignRaisedButton#��[  5N   %   
���P��
���   �$��Arial)�5O   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��68   $��12(�6e   $��DemiBold"�6s   5P      5R        5S       5T      �� 5U      .R�5V      �� -   5        $��Удалить��5V   %   $	��170��6R   #��[  5W   %   
���P��
���   �$��Arial)�5X   %   $ 5��68   $��12(�6e   $��DemiBold"�6s   5Y      5[      5]      �� 5_   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   $��5q�6s   .+�5`      �� -	   5        $8��2Добавить нового сотрудника��5`      $	��250��6:   $��30��6F   $��5q�6m   
���P��
���   �#��[  5b      $��14(�6I   $��DemiBold"�6W   $��Arial)�5c      $ 5��6(   �� 5d      -
   5        $��На главную��5d      $	��150��6*   $��30��66   $��5q�6W   
���P��
���   �#��[  5f      $��14(�6I   $��DemiBold"�6W   $��Arial)�5g      $ 5��6(   5h      5i      5j      