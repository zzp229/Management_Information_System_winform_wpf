   M S B A M L   `   `   `  ����P  L医药管理系统wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:医药管理系统wpf医药管理系统wpf  5   	   #    医药管理系统wpf.FrmMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:医药管理系统wpf     5   	     � Title$  FrmMain��5   	   $	��722��6   $	��898��6&    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ microsoft YaHei)�6+   6E   �� 5       � ��$ 23(�6)   66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��9* �6   6*   �� 5      $��8* �6   6*   �� 5      $��6* �6   6*   �� 5      $��6* �6   6*   �� 5      $	��50* �6   6+    � ColumnDefinitions 5   
   �� 5      $	��15* �6   6-   �� 5      $	��35* �6   6-   �� 5      $	��35* �6   6-   �� 5      $	��15* �6   6-   .+�5"   
   �� $��0��6*   $��0��67   $��4��6G   $��Center=�6[   $��Center=�6x   ��6   �� *Title+6�   �� 5#   
   $��0��63   $��3��6@   $��
9, 5, 9, 0q�6P   $
��Left=�6d   $��Center=�6   $��15, 5q�6�   ��6   �� *LogoutCommand+.��6�   注销账号6�   �� 5$   
   $��1��6   $��1��6   .��6-   	查询：62   �� 5%   
   $��1��6   $��2��6   .��6-   	录入：62   �� 5&   
   -   5        $��cmb_Inquire��5&   Y   $��2��6l   $��1��6y   $��
0, 5, 9, 0q�6�   ��6   �� *InquireList+ �� SelectedItem 67   �� *
Inquired+6�   �� 5'   
   $��2��6X   $��2��6e   $��
9, 5, 9, 0q�6u   ��6   �� *CheckInList+ 67   �� *	CheckIn+6�   �� 5(   
   $��3��64   $��1��6A   $��
0, 5, 9, 0q�6Q   $
��Left=�6e   $��Center=�6�   $��15, 5q�6�   	 �� 	IsDefault	 . ��6   �� *InquireCommand+.��5*      查询6   �� 5+   
   $��3��64   $��2��6A   $��
9, 5, 9, 0q�6Q   $
��Left=�6e   $��Center=�6�   $��15, 5q�6�   ��6   �� *CheckInCommand+.��5,      录入6   5.      5/      