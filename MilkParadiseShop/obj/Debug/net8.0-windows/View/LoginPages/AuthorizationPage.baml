   M S B A M L   `   `   `  ����K  GMilkParadiseShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MilkParadiseShop.View.LoginPages MilkParadiseShop.View.LoginPages  5      8    2MilkParadiseShop.View.LoginPages.AuthorizationPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:MilkParadiseShop.View.LoginPages  5        N� Title$  AuthorizationDataPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      �� $��/Resources/ShopImage.png��6   $��70��66   $��70��6A   $
��Fill=�5      $	��Top=�6#   $��0 50 0 5q�6;   �� 5      $��Авторизация��6   $��Arial)�6+   $��20(�6>   $��SemiBold"�5      $��Center=�6.   5      �� 5   
   $ Vertical=�6   $��Center=�6,   $��Center=�6I   $��1��6d   .+�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��5q�66    � ToolTip$ 
Логин��6A   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6.   $��35��6:   $��35��6E   
���P��6Q   �� 5      -   5        $��
LoginField��5   *   $	��200��6   
���   �$��Arial)�6O   
����i��$��2q�6x   $��Center=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин��6@   $��5 0 2 0q�5       �� SelectionBrush
 �   � �� 
CaretBrush
 �   �6G   5      �� 5      $ 
Horizontal=�6   $��5q�66   $ Пароль��6A   .+�5         $ Password=�6.   $��35��6>   $��35��6I   
���P��6U   G� 5!      -   5        $��PasswordField��5!   .   $	��200��6"   
���   �$��Arial)�6V   
����i��$��2q�6   $��Center=�5"   "   $ ***********��6D   $��5 0 2 0q�5#   "    G� SelectionBrush
 �   �	 G� 
CaretBrush
	 �   �6K   5$      5%      5(      �� 5)   
   $ Vertical=�6   $��Center=�6,   $��Center=�6I   $��2��6d   .+�5*      �� $��Войти как:��6   $��18(�6*   $��Arial)�68   $��DemiBold"�6K   �� 5+      $ 
Horizontal=�6   $��5q�62   .+�5,      	� -   5        $��ClientButtonCheck��5,      $��Клиент��67   
 	� 	GroupName$
 
UserChange��6H    d� 	IsChecked$
 TrueY�6_   $��16(�5-      $��Arial)�6,   $��Medium"�6?   
����i��$��0 0 10 0q�6h   	� 5.      -   5        $��WorkerButtonCheck��5.      $��Сотрудник��67   $
 
UserChange��6K   $��16(�5/      $��Arial)�6,   $��Medium"�6?   
����i��6S   50      �� 51      $ 
Horizontal=�6   .+�52      �� -   5        $��
Войти��52         MaterialDesignRaisedButton#��[  6F   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��53      
���P��$��0 0 10 0q�6Y   $	��100��6k   �� 54      -   5        $��Регистрация��54      #��[  6P   $ 5��55      
���P��$	��130��6Y   56      57      58      59      