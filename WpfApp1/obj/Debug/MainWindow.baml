   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��759��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $
��Left=�6   $	��419��60   $	��Top=�6=   $	��751��6U   .@�5      �� $��Пользователь��6   .��5      �  � ColumnDefinitions 5      �� 5      $	��33* �6+   �� 5      $
��712* �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ userGrid��5   ;      AutoGenerateColumns .  	 J� RenderTransformOrigin$	 
0.497,0.45&�6M   $��0,0,0,56q�6p   $��2��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *name+6W     5      $ Фамилия��6N   $	 150 6_    61   �� *
lastName+6_     5       $ Отчество��6P   $	 150 6b    61   �� *
patronymic+6b     5!      $ 
Номер��6K   $	 150 6Z    61   �� *phone+   EditingElementStyle 5"   "   �� 5#   &   " ��6,   .�5$   *   ��  �@��	MaxLength$ 10��6F   5%   '   5'        5(      $ 
Почта��6K   $	 150 6Z    61   �� *email+6Z   5*      �� 5+      $��Center=�6!    �� Orientation$ 
Horizontal=�6>   $��190,340,246,0q�6W   $	��276��6n   $��1��6z   .+�5,      �� -   5         ��Name$ updateButton��5,   !   $��Обновить��67   6J   �� 5-      -   5        $ deleteButton��5-   !   $��Удалить��67   6I   5.      5/      50      �� 51      $��Реелтор��6   .��52      �  53      �� 54      $	��33* �6+   �� 55      $
��712* �6+   .+�57        -   5        $ realtorGrid��57   ;    .  $	 
0.497,0.45&�6P   $��0,0,0,56q�6s   $��2��6�   
 58        59      $ Имя��6J   $	 150 6W    61   �� *name+6W     5:      $ Фамилия��6N   $	 150 6_    61   �� *
lastName+6_     5;      $ Отчество��6P   $	 150 6b    61   �� *
patronymic+6b     5<      $ Процент��6M   $	 150 6^    61   �� *	procent+6^   5>      �� 5?      $��Center=�6!   $ 
Horizontal=�6>   $��190,340,246,0q�6W   $	��276��6n   $��1��6z   .+�5@      �� -   5        $ updateRealtorButton��5@   !   $��Обновить��6>   6Q   �� 5A      -   5        $ deleteRealtorButton��5A   !   $��Удалить��6>   6P   5B      5C      5D      �� 5E      $��
Поиск��6   .��5F      �  5G      �� 5H      $
��167* �6+   �� 5I      $	��31* �6+   �� 5J      $
��547* �6+   .+�5L      �� -   5         ��Name$
 name��5L      $
��Left=�6,   $��23��6G   $��
110,31,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��128��6�   $��3��6�   �� 5M      $��Фамилия��6   $
��Left=�6.   $��	10,27,0,0q�6I   $	��Top=�6\   $	��100��6t   �� 5N      $��Имя��6   $
��Left=�6*   $��	10,53,0,0q�6E   $	��Top=�6X   $	��100��6p   $	 
0.56,1.154&�6|   �� 5O      $��Отчетсво��6   $
��Left=�6/   $��	10,84,0,0q�6J   $	��Top=�6]   $	��100��6u   $	 
0.56,1.154&�6�   �� 5P      -   5        $ lastName��5P      $
��Left=�60   $��23��6K   $��
110,61,0,0q�6W   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��128��6�   $��3��6�   �� 5Q      -	   5        $ 
patronymic��5Q      $
��Left=�62   $��23��6M   $��
110,96,0,0q�6Y   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��128��6�   $��3��6�     5R      -
   5        $ leviGrid��5R      $
��Left=�61   $	��391��6L   $��99,0,0,0q�6Y   $	��Top=�6k   $	��448��6�   $��2��6�   
 5S      5V      �� 5W      -   5        $��
Поиск��5W      $
��Left=�6-   $��110,140,0,0q�6H   $	��Top=�6]   $	��109��6u   $��3��6�   5Y      5Z      5[      5\      5]      