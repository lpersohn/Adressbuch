   M S B A M L   `   `   `  ����E  AAdressbuch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Adressbuch
Adressbuch  5          Adressbuch.EditPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Adressbuch     5      
�������$	��345��5	   7   $	��345��6G   $	��610��6W   $	��610��6f   .��5
      �� -   5          ��Name$  editP��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��115 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6"   $��0��63   $��2��6C    �� Orientation$ Vertical=�6W   .+�5      �� $	��120��6   �� 5      $��	/Bild.png��6   $	��120��6+   $��30,0,0,0q�68   5      �� 5      $��Adresse:��6   �� 5      -   5         ��Name$ Adress��5      $
��Left=�6&   $	��200��6A   �� 5      $��Postleitzahl:��6   �� 5      -   5        $	 PLZ��5      $
��Left=�6#   $	��200��6>   �� 5      $��Wohnort:��6   �� 5       -   5        $ Wohnort��5       $
��Left=�6'   $	��200��6B   �� 5!      $��Telefon:��6   �� 5"      -   5        $ Number��5"      $
��Left=�6&   $	��200��6A   �� 5#      $��E-Mail*:��6   �� 5$      -   5        $ Email��5$      $
��Left=�6%   $	��200��6@   5%      �� 5'      $��0��6   $��2��6&   $��1��67   $ Vertical=�6G   .+�5(      �� $'��!Spitzname oder Mitarbeiternummer:��6   $��5,0,0,0q�6@   �� 5)      -   5        $ NumorNN��5)      $
��Left=�6'   $	��200��6B   $��5,0,0,0q�6N    �� 
IsReadOnly$
 True��6_   �� 5*      $��Vorname:��6   $��5,0,0,0q�6'   �� 5+      -   5        $ Vorname��5+      $
��Left=�6'   $	��200��6B   $��5,0,0,0q�6N   �� 5,      $��	Nachname:��6   $��5,0,0,0q�6(   �� 5-      -	   5        $ Nachname��5-      $
��Left=�6(   $	��200��6C   $��5,0,0,0q�6O   �� 5.      $��Geburtstag:��6   $��
5,0,0,-0.7q�6*   (  "System.Windows.Controls.DatePicker  5/      -
   5          Name$ Birthday��5/      $
��Left=�6+   $	��200��6F   $��25��6R   $��5,0,0,0q�6^    � ToolTip$ 
dd.mm.yyyy��6o   �� 50      -   5         ��Name$ 	btnAccept��50      $��Bestätigen��6(   $��Right=�6=   $��
0,115,10,0q�6Y   $
��62.5��6m   6z   �� 51      -   5        $ btnBreak��51      $��	Abbrechen��6'   $��Right=�6;   $��0,5,10,0q�6W   6i   52      53      54      55      