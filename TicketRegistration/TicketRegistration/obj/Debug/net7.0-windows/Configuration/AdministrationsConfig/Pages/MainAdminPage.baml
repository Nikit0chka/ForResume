   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      &     TicketRegistration.MainAdminPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� Title$  MainAdminPage��5	       N� 
Background
 �   � � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value��%;  '��       �� 5   
   " ��6   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ 0��6)   �� 5       � �� �	#FF1F1F1F6+   �� 5       � ��
 �����6+   �� 5       � �� �	#E51F1F1F6,   �� 5       � ��$ 50��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �	#FF2F2E2E63   5      5!      5"      .��5$      � 
 � ColumnDefinitions
 5%   
   �� 5&      $	��135 �6   �� 5'      .+�5*   
   �� .+�5+      �� -   5         ��Name$ CountriesButton��5+      $��	Countries��6.   6B   �� 5,      -   5        $ CitiesButton��5,      $��Cities��6+   6<   �� 5-      -   5        $ PlanesButton��5-      $��Planes��6+   6<   �� 5.      -   5        $ FlightsButton��5.      $��FLights��6,   6>   �� 5/      -   5        $ AdminManageButton��5/      $��Manage admins��60   6H   �� 50      -   5        $ UserManageButton��50      $��Manage users��6/   6F   51      �� 53   
   -   5        $ 
BackButton��53      $
��Back��6%   $
��Left=�64   $��Bottom=�6O   $��50��6j   $��30��6u   6�    � 55   
   -   5          �Name$ 	MainFrame��55      $��1��6#   $��5,0,0,0q�63     � NavigationUIVisibility$ Hidden=�6D   56      57      