   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      -    'TicketRegistration.CityRegistrationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� 
Background
  �   � N� Title$ CityRegistrationPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��155 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� $��0,10,0,0q�6   $
��Wrap=�6&   $#��Название страны��6:   $��0��6Q      TextBlockStyle#��[  6a   �� 5   
   $��0,70,0,0q�6   $
��Wrap=�6&   $#��Название города��6:   $��0��6Q   #��[  6a   �� 5   
   -   5         ��Name$ CountryCombBx��5      $��0,30,0,0q�6)   $��0��6;     ComboBoxStyle#��[ 6K    �� Text 5      �� *CityRegCountry+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError$
 True��5   K   �� 5   
   -   5        $ 
CityCombBx��5      $��0,90,0,0q�6&   $��0��68   #��[ 6H    5      �� *CityRegCity+$
 True��$ PropertyChanged=�$
 True��5   H   �� 5   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�62   $��1��6K   $��2��6X   $��0��6l   .+�5      �� -   5        
 ��Name$
 AddCityButton��5      $��Добавить��6,     ButtonStyle#��[ 6[   �� 5       -   5        $
 DeleteCityButton��5       $��Удалить��6/   #��[ 6`   �� 5!      -   5        $
 UpdateButton��5!      $��Обновить��6+   #��[ 6Y   5"      5#      5$      