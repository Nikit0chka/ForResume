   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      -    'TicketRegistration.CityRegistrationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� 
Background
  �   � N� Title$ CityRegistrationPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� $��	10 10 0 0q�6    �� Orientation$ Vertical=�6(   $
��Left=�6?   .+�5      �� $��Country name��6      TextBlockStyle#��[  6,   �� 5      -   5         ��Name$ CountryCombBx��5        ComboBoxStyle#��[ 6)    �� Text 5      �� *CityRegCountry+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError$
 True��5   P   �� 5      $��	City name��6   #��[  6)   �� 5      -   5        $ 
CityCombBx��5      #��[ 6&    5      �� *CityRegCity+$
 True��$ PropertyChanged=�$
 True��5   &   5      �� 5   
   $��Center=�6   $ 
Horizontal=�62   $��1��6K   .+�5      �� -   5        	 ��Name$	 AddCityButton��5      $	��Add��6,     ButtonStyle#��[ 6V   �� 5      -   5        $	 DeleteCityButton��5      $��Delete��6/   #��[ 6_   �� 5      -   5        $	 UpdateButton��5      $��Update��6+   #��[ 6W   5      5      5       