   M S B A M L   `   `   `  ����P  L医药管理系统wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:医药管理系统wpf医药管理系统wpf  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   *    $医药管理系统wpf.FrmView_Agency   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:医药管理系统wpf     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	     � Title$  FrmView_Agency��5
   	   $	��643��6    $	��806��6-    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         DeleteButtonStyle �� 
TargetType �� Property �� Value  EditButtonStyle  
dgRowStyle)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value	 ]� 
Conditions
 �� Property �� Value  dgCellStyle*  $System.Windows.Controls.DataGridCell��%g  &	        &	     &	     &	 �    �� 5   
   " ��6*   .�5      ��  � ��
 �  ��6+   �� 5       � ��
 �����6+   �� 5       � ��
 �  ��6,   �� 5       � ��$ 1q�60   �� 5       � ��$	 5,2q�6(   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6(   .�5      ��  � ��
 � � �6+   �� 5       � ��
 �����6+   �� 5       � ��
 � d �6,   �� 5       � ��$ 1q�60   �� 5       � ��$	 5,2q�6(   �� 5       � ��$ 5q�6'   5       �� 5#   
   "  6#    5%      P� 5'       �@ 
IsSelected . . �5(      ��  � ��
 � � �63   5)      P� 5,       �@J�IsMouseOver . . �5-      ��  � �� �#f4f6ee63   5.      ]� 51      	 52      �� 53      
 �@ 
IsSelected . 6:   �� 54      
 �@J�IsMouseOver . 6;   ./�56      ��  � ��
 � � �63   57      59      �� 5<   
   "  6$    5=      P� 5>       �@ 
IsSelected . . �5?      ��  � ��
 ���� 63   �� 5@       � ��
 �����6C   5A      5C      5E      .��5H      �  � RowDefinitions 5I   
   �� 5J      $��7* �6   6*   �� 5K      $	��23* �6   6+   �� 5L      $	��55* �6   6+   �� 5M      $	��15* �6   6+   .+�5P   
   �� $��0��6   $��Center=�6   $��Center=�6:   .��6U   经办人信息查询6^   �� 5Q   
   $��0��6   $��	80 0 80 5q�6   
���   �$��0 0 0 1q�6E   6a   �� 5V   
   $��1��6   $��5q�6    $!��请选择查询的信息：��6+   ��5W      � 5X       5Y      �� 5Z      6*   �� 5[      6*    � ColumnDefinitions 5]      �� 5^      6-   �� 5_      6-   �� 5`      6-   �� 5a      6-   .+�5c      �� $��0��6   $��0��6)   $��Center=�69   .��6T   	编号：6Y   �� 5d      $��0��63   $��0��6@   $	��100��6P   $��25��6\   ��6   �� *Ano+6j   �� 5e      $��0��6   $��1��6)   $��Center=�69   .��6T   	性别：6Y   �� 5f      -   5        $��cmb_asex��5f   a   $��0��6q   $��1��6~   $	��100��6�   $��25��6�   ��6   �� *Asex+ �� SelectedItem 6<   �� *AsexSeleted+6�   �� 5g      $��0��6   $��2��6)   $��Center=�69   .��6T   	电话：6Y   �� 5h      $��0��66   $��2��6C   $	��100��6S   $��25��6_   ��6   �� *Aphone+6m   �� 5i      $��1��6   $��0��6)   $��Center=�69   .��6T   	姓名：6Y   �� 5j      $��1��65   $��0��6B   $	��100��6R   $��25��6^   ��6   �� *Aname+6l   �� 5k      $��1��6   $��1��6)   $��Center=�69   .��6T   	备注：6Y   �� 5l      $��1��67   $��1��6D   $��2��6T   $	��300��6h   $��25��6t   ��6   �� *	Aremark+6�   �� 5n      $��1��6>   $��3��6K   $��Center=�6[   $
��Left=�6v   $��50��6�   ��6   �� *QueryCommand+.��6�   查询6�   5o      5q      &   System.Windows.Controls.DataGrid  5u   
   -   5          Name$ dataGrid��5u      $��2��6F   $��8q�6S      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . ��6%   �� *
Agencies+   Columns 5x      0  *System.Windows.Controls.DataGridTextColumn  5z      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Ano+6I     5{      $ 姓名��6%   $ 70 6K    61   �� *Aname+6K     5|      $ 性别��6%   $ 50 6J    61   �� *Asex+6J     5}      $ 电话��6%   $	 100 6L    61   �� *Aphone+6L     5~      $ 备注��6%   $	 200 6M    61   �� *	Aremark+6M   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 操作��6)      CellTemplate 5�      �� 5�      .R�5�      ��  �� Orientation$ 
Horizontal=�6)   .+�5�   "   �� $��删除��6)   #��[  66   ��5�   )   �� *Ano+��5�   )   �� *DataContext.DelCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ DataGridL��� 5�   "   $��编辑��6)   #��[ 66   ��5�   )   �� *Ano+��5�   )   �� *DataContext.EditCommand+ �� $ FindAncestor=�$ DataGridL�5�      5�      5�       � ContextMenu 5�      �� 5�      .@�5�      m� $��删除选中项��6    m� Command 6.   �� *DeleteSelectedCommand+5�         RowStyle 5�      �� 5�       �� BasedOn# [ 6   "  6>   5�          	CellStyle  5�      �� 5�      # [ 6   "  6?   5�      .	  (System.Windows.Interactivity.Interaction! 	  Triggers! 5�      /
  )System.Windows.Interactivity.EventTrigger
  5�      " 
  	EventName$" MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase#   Actions.# 5�      6  0System.Windows.Interactivity.InvokeCommandAction  $   Command$ 6,   �� *EditCommand+%   CommandParameter% 6L   �� *SelectedItem.Ano+& �� ElementName$& dataGrid��5�      5�      � 5�   
   $��3��6   $��RightToLeft=�6!   .+�5�      �� $��15, 5q�6   $��7q�6%   .��60   打印64   �� 5�      $��15, 5q�6   $��7q�6%   .��60   报表64   �� 5�      $
��7, 5q�6   $��7q�6$   .��6/   导出到Excel69   5�      5�      5�      