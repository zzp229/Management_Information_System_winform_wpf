   M S B A M L   `   `   `  ����P  L医药管理系统wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:医药管理系统wpf医药管理系统wpf  5   	   ,    &医药管理系统wpf.FrmView_Medicine   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:医药管理系统wpf     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  药品管理��5	   	   $	��643��6   $	��806��6#    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value   DeleteButtonStyle  EditButtonStyle  
dgRowStyle)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value	 ]� 
Conditions
 �� Property �� Value  dgCellStyle*  $System.Windows.Controls.DataGridCell��%  '��       '�� M     &	  �     &	 �    &	 �    &	 +    �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ 17(�6)   66   5      �� 5   
   " ��6*   .�5      ��  � ��
 �  ��6+   �� 5       � ��
 �����6+   �� 5       � ��
 �  ��6,   �� 5       � ��$ 1q�60   �� 5       � ��$	 5,2q�6(   �� 5       � ��$ 5q�6'   5      �� 5    
   " ��6(   .�5!      ��  � ��
 � � �6+   �� 5"       � ��
 �����6+   �� 5#       � ��
 � d �6,   �� 5$       � ��$ 1q�60   �� 5%       � ��$	 5,2q�6(   �� 5&       � ��$ 5q�6'   5'      �� 5*   
   "  6#    5,      P� 5.       �@ 
IsSelected . . �5/      ��  � ��
 � � �63   50      P� 53       �@J�IsMouseOver . . �54      ��  � �� �#f4f6ee63   55      ]� 58      	 59      �� 5:      
 �@ 
IsSelected . 6:   �� 5;      
 �@J�IsMouseOver . 6;   ./�5=      ��  � ��
 � � �63   5>      5@      �� 5C   
   "  6$    5D      P� 5E       �@ 
IsSelected . . �5F      ��  � ��
 ���� 63   �� 5G       � ��
 �����6C   5H      5J      5K      .��5N      �  � RowDefinitions 5O   
   �� 5P      $	��10* �6   6+   �� 5Q      $	��20* �6   6+   �� 5R      $	��70* �6   6+   �� 5S      $	��20* �6   6+   .+�5V   
   �� $��Center=�6   $��Center=�61   $��23(�6L   药品管理系统6b   �� 5W   
   $��	50 0 50 0q�6   
���   �$��0 0 0 1q�68   6T   �� 5Z   
   $��1��6   $5��/请选择查询的信息(默认查询全部)：��6    $��	20 0 20 0q�6;   ��5[      � 5\      $��1��6   $��	10 0 10 0q�6$    5]      �� 5^      �� 5_       � ColumnDefinitions 5a      �� 5b      �� 5c      �� 5d      .+�5g      �� $��	编号：��6   6,   �� 5h      $��60 5 5 5q�63   ��6   �� *Mno+6G   �� 5j      $��1��6   $��服用方法：��6,   6>   �� 5k      $��1��6i   $��	100 5 5 5q�6y   ��6   �� *MmodeSource+ �� SelectedItem 6C   �� *MmodeSeleted+6�   �� 5m      $��1��6   $��	名称：��6)   69   �� 5n      $��1��65   $��0��6B   $��70 5 5 5q�6R   ��6   �� *Mname+6f   �� 5p      $��1��6   $��1��6)   $��	功效：��69   6I   �� 5q      $��1��69   $��1��6F   $��70 5 5 5q�6V   ��6   �� *	Mefficacy+6j   �� 5s      $��1��6>   $��2��6K   $��80��6[   $��30��6f   $��查询��6r   ��6   �� *QueryCommand+6r   5t      5v      &   System.Windows.Controls.DataGrid  5y   
   -   5          Name$ dataGrid��5y      $��8q�6G   $��2��6R      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly . ��6%   �� *	Medicines+   Columns 5|      0  *System.Windows.Controls.DataGridTextColumn  5}      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Mno+6W     5~      $ 名称��6%   $ 50 6K    61   �� *Mname+6X     5      $ 服用方法��6%   $	 150 6M    63   �� *Mmode+6[     5�      $ 功效��6%   $	 150 6O    61   �� *	Mefficacy+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 操作��6)   $	 200 65      CellTemplate 5�      �� 5�      .R�5�      ��  �� Orientation$ 
Horizontal=�6)   .+�5�   "   �� $��删除��6)   #��[  66   ��5�   )   �� *Mno+��5�   )   �� *DataContext.DelCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ DataGridL�6�   �� 5�   "   $��编辑��6)   #��[ 66   ��5�   )   �� *Mno+��5�   )   �� *DataContext.EditCommand+ �� $ FindAncestor=�$ DataGridL�5�      5�      5�       � ContextMenu 5�      �� 5�      .@�5�      m� $��删除��6    m� Command 6+   �� *DeleteSelectedCommand+6W   5�         RowStyle 5�      �� 5�       �� BasedOn# [ 6   "  6>   5�          	CellStyle  5�      �� 5�      # [ 6   "  6?   5�      .	  (System.Windows.Interactivity.Interaction! 	  Triggers! 5�      /
  )System.Windows.Interactivity.EventTrigger
  5�      " 
  	EventName$" MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase#   Actions.# 5�      6  0System.Windows.Interactivity.InvokeCommandAction  $   Command$ 6,   �� *EditCommand+%   CommandParameter% 6L   �� *SelectedItem.Mno+& �� ElementName$& dataGrid��5�      5�      5�      5�      