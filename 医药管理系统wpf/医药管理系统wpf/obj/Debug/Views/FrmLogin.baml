   M S B A M L   `   `   `  ����P  L医药管理系统wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:医药管理系统wpf医药管理系统wpf  5   	   S.clr-namespace:医药管理系统wpf.ViewModels 医药管理系统wpf.ViewModels  6/   *    $医药管理系统wpf.Views.FrmLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:医药管理系统wpf     5   	   E
viewmodels.clr-namespace:医药管理系统wpf.ViewModels     6/     � Title$  主页��5   	   $	��450��6   $	��800��6!    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$ ./Picture/test.ico��5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%d   '��       �� 5   
   " ��6   .�5      ��  � ��$ Microsoft YaHei)�6+   6E   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   6+   �� 5      $	��32* �6   6+   �� 5      $	��23* �6   6+   �� 5      $	��25* �6   6+    � ColumnDefinitions 5   
   �� 5      $	��30* �6   6-   �� 5      $	��40* �6   6-   �� 5      $	��30* �6   6-   .+�5   
   �� $��0��6   $��3��6   $��40(�61   $��Center=�6?   .��6\   医药管理系统6d   �� 5"   
   $��3��6   $��2��6'   $��1��69   $��30q�6F   $��30(�6R   .��6`   登录信息6f   �� 5#   
   $��1��6   $��25(�6   $��Right=�6+   $��Bottom=�6G   .��6b   	账号：6g   �� 5%   
   -   5        	 ��Name$	 txt_LoginId��5%      $��1��6@   $��1��6M   $��30��6]   $��Center=�5&      $��Bottom=�5'      $��5q�6-   $��Center=�68   ��5%   '   �� *	LoginId+.��5)      ��5*      �� 5+      " ��6   
 �� Triggers
 5,      �� 5-       �� Binding 6&   �� *ShouldFocusOnLoginId+ �� Value True6O   .a�5.      ��  �@+�FocusedElement 6L   ��  �� ElementName$ txt_LoginId��6x   5/      51      .��52      53      �� 54   
   $��2��6   $��25(�6   $��Right=�6+   $	��Top=�6G   .��6_   	密码：6d   G� 58   
   -   5         G�Name$ txt_LoginPwd��58      $��2��59      $��1��6#   $��30��63   $	��Top=�6?   $��5q�6W   $��Center=�6b   $��Center=�6�   1   +医药管理系统wpf.PasswordBindingHelper   Password 58   ,   �� *
LoginPwd+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5:      �� 5;      " G�6   
 5<      �� 5=       6&   �� *ShouldFocusOnLoginPwd+ True6P   .a�5?      ��  �@+�FocusedElement 6L   �� $ txt_LoginPwd��6y   5@      5B      5D      �� 5I   
   -   5         ��Name$ 	btn_Login��5I   C    �� 	IsDefault . $��3��6V   $��1��6c   $	��Top=�6s   $
��Left=�6�   $	��100��6�   $��40��6�   $��登录��6�   $��26(�6�   ��6   �� *LoginCommand+6�   �� 5J   
   $��3��61   $��1��6>   $	��Top=�6N   $��Right=�6f   $	��100��6�   $��40��6�   $��退出��6�   $��26(�6�   ��6   �� *ExitCommand+6�   �� 5K   
   $��3��65   $��1��6B   $��Bottom=�6R   $��Center=�6m   $	��100��6�   $��40��6�   $��注册��6�   $��26(�6�   ��6   �� *RegisterCommand+6�   5L      5M      