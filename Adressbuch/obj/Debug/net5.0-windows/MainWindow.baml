   M S B A M L   `   `   `  ����E  AAdressbuch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Adressbuch
Adressbuch  5   	       Adressbuch.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Adressbuch     5   	     � Title$  
MainWindow��5   	   $	��475��6   $	��460��6-   $	��865��6=   $	��855��6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $��90 �6   �� 5      $��40 �6   �� 5      $	��315 �6    � ColumnDefinitions 5   
   �� 5      $	��245 �6   �� 5      $	��610 �6   .+�5   
   �� $��0��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   ���#6FA8DC.+�5      �� $��
Adressbuch��6   $
��Left=�6)   $��Center=�6D   $��30(�6_   $��20,20,350,20q�6m   �� 5      -   5         ��Name$ 
searchName��5      $��Right=�6*   $��12(�6F   $��
20,20,0,20q�6T   $��20��6h   $	��200��6t   6�   �� 5      -   5         ��Name$ 	btnSearch��5      $��Suchen��6(   $��20��69   6E   5      �� 5   
   $��1��6   $��0��6"   $��2��62   $ 
Horizontal=�6C   $
��Left=�6\   .+�5      c� $	��Top=�6   .@�5      �� -   5        $ Kalender��5       � ToolTip$ Zu Kalender wechseln��6E   .��5      �� $��/kalender.png��6   $��35��63   5      �� 5      -   5        $ Kontaktliste��5      $ Zu Kontakte wechseln��6I   .��5       �� $��/Kontakte.png��6   $��35��63   $��15,0,0,0q�6?   5!      �� 5"      -   5        $ Hinzufügen��5"      $ Neuen Kontakt hinzufügen��6B   .��5#      �� $��/Hinzufügen.png��6   $��35��65   $��15,0,0,0q�6A   5$      �� 5%      -   5        $ Löschen��5%      $$ Ausgewählten Kontakt löschen��6B   .��5&      �� $��/Löschen.png��6   $��35��62   $��15,0,0,0q�6>   5'      5(      5)      �� 5+   
   -   5         ��Name$ contactList��5+      $��2��6'   $��0��64   $	��315��6D   6Q   �� 5-   
   -   5         ��Name$
 main��5-      $��1��6'   $��1��64   $��2��6D   5.      5/      