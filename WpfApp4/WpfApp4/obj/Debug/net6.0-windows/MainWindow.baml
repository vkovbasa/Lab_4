   M S B A M L   `   `   `  ����  WpfApp4    WpfApp4.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Calculator��5   	   $	��400��6   $	��600��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   �� -   5        $��Perform Operations��5      $��Center=�6N   $��Center=�6k   $
��0 20q�6�   �� 5   
   -   5         ��Name$ ResultTextBlock��5   !   $��1��6   $��Center=�6:   $��Center=�6W   $
��Wrap=�6r   �� 5   
   -   5         ��Name$ OperationsListView��5       $��2��6   $��20q�6<   
�������$��1q�6[    �� View 5      �� 5      .P�5      �� $��	Operation��6%    �� DisplayMemberBinding 68   �� *	Operation+�� 5      $��Result��6%    65   �� *Result+5      5      5      5      