   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      0    *TicketRegistration.FlightRegistratrionPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5      l hDotNetProjects.Wpf.Extended.Toolkit, Version=5.0.103.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  66     N� 
Background
  �   �.��5
      �  � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6/   $��0��6L   $��0 10 0 0q�6Y   .+�5      �� $��0 0 10 0q�6   .+�5      �� $��Departure country��6      TextBlockStyle#��[  65   �� 5      -   5         ��Name$ DepartureCountryCmbBx��5        ComboBoxStyle#��[ 63    �� Text 5      �� *DepartureCountry+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ Default=� �� NotifyOnValidationError$
 True��5   Z   �� 5      $��Departure city��6   #��[  62   �� 5      -   5        $ DepartureCityCmbBx��5      #��[ 6/    5      �� *DepartureCity+$
 True��$ PropertyChanged=�$
 True��5   /   �� 5      $��
Plane name��6   #��[  6.   �� 5      -   5        $ 
PlaneCmbBx��5      #��[ 6'    5      �� *	PlaneName+$
 True��$ PropertyChanged=�$
 True��5   '   �� 5      $��Economy seats price��6   #��[  67   �� 5      -   5         ��Name$ EconomySeatPriceTxtBx��5         TextBoxStyle#��[ 61   ��5      �� *EconomySeatsPrice+$
 True��$ PropertyChanged=�$
 True��5    1   5!      �� 5"      .+�5#      �� $��Arrival country��6   #��[  63   �� 5$      -   5        $ ArrivalCountryCmbBx��5%      #��[ 62    5$      �� *ArrivalCountry+$
 True��$ PropertyChanged=�$
 True��5%   Y   �� 5'      $��Arrival city��6   #��[  60   �� 5(      -   5        $ ArrivalCityCmbBx��5)      #��[ 6.    5(      �� *ArrivalCity+$
 True��$ PropertyChanged=�$
 True��5)   .   �� 5+      $��Departure date time��6   #��[  67   &   Xceed.Wpf.Toolkit.DateTimePicker  5,      -   5        	  Name$	 DateTimePicker��5-   !   $��0,0,0,8q�69   $
��Left=�6J   $	��Top=�6e   $	��120��6}   
   CalendarWidth$	
 300Q�6�   $��Arial)�6�   $��25��6�   $��1��6�   $��10(�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6�      FormatString$ yyyy-MM-dd hh:mm��6�   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 5,   &   �� *DepartureTime+$
 True��$ PropertyChanged=�$
 True��5-   �   �� 5/      $��Business seats price��6   #��[  68   �� 50      -   5        $ BusinessSeatPriceTxtBx��51      #��[ 62   ��50      �� *BusinessSeatsPrice+$
 True��$ PropertyChanged=�$
 True��51   2   52      53      �� 55   
   $��Center=�6   $ 
Horizontal=�62   $��1��6K   $��2��6X   .+�56      �� -	   5         ��Name$ AddFlightButton��56      $	��Add��6.     ButtonStyle#��[ 6Z   �� 57      -
   5        $ DeleteFlightButton��57      $��Delete��61   #��[ 6c   �� 58      -   5        $ UpdateButton��58      $��Update��6+   #��[ 6W   59      5:      5;      