   M S B A M L   `   `   `  ����P  L医药管理系统wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:医药管理系统wpf.Views.UserViews%医药管理系统wpf.Views.UserViews  5   	   8    2医药管理系统wpf.Views.UserViews.MedicineView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:医药管理系统wpf.Views.UserViews     5   	   -   5        $��window��5
   	     � Title$  添加医药��5   	   $	��450��6   $	��400��6#    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5         	BoolToVis�� 5   
   %   &	        �� 5      6+   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Center=�6   $��100 10q�6+   .��6;   	编号：6@   �� 5!   
   $��Center=�62   $��Center=�6M   ��6   �� *medicine.Mno+y�5"      �� *IsLableVisible+ �� 	Converter# [  6^   �� 5#   
   $	��100��60   $��20��6<   $��0��6H   ��6   �� *medicine.Mno+y�5$      �� *IsTextBoxVisible+# [  5%      �� 5'   
   $��Center=�6   $��100 10q�6+   $��1��6;   .��6H   	名称：6M   �� 5(   
   $	��100��62   $��20��6>   $��1��6J   ��6   �� *medicine.Mname+6Y   �� 5*   
   $��Center=�6   $��80 10q�6+   $��2��6:   .��6G   服用方法：6N   �� 5+   
   $	��100��6T   $��20��6`   $��2��6l   ��6   �� *	MmodeList+ �� SelectedItem 65   �� *Mmode+6{   �� 5-   
   $��Center=�6   $��100 10q�6+   $��3��6;   .��6H   	功效：6M   �� 5.   
   $	��100��66   $��20��6B   $��3��6N   ��6   �� *medicine.Mefficacy+6]   �� 51   
   $��5��6   $��80��6   $��30��6)   ��52      �� *CloseWindowCommand+��68   ��  �� ElementName$ window��.��53      保存6   55      56      