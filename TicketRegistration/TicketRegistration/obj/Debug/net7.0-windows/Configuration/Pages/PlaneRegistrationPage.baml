   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      .    (TicketRegistration.PlaneRegistrationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� 
Background
  �   � N� Title$ PlaneRegistrationPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��155 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� $��0,10,0,0q�6   $
��Wrap=�6&   $'��!Название самолета��6:      TextBlockStyle#��[  6S   �� 5   
   $��0,70,0,0q�6   $
��Wrap=�6&   $0��*Количество эконом мест��6:   #��[  6X   �� 5   
   $��	0,130,0,0q�6   $
��Wrap=�6'   $0��*Количество бизнес мест��6;   #��[  6Y   �� 5   
   -   5         ��Name$ 
PlaneCmbBx��5      $��0,30,0,0q�6'   $��0��6:     ComboBoxStyle#��[ 6J    �� 
IsEditable$
 True��6q    �� Text 5      �� *PlaneRegPlaneName+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�	 �� NotifyOnValidationError$
	 True��5   q   �� 5   
   -   5        
 ��Name$
 EconomySeatsNumberTxtBx��5      $��0,90,0,0q�63    �� TextWrapping$
 Wrap=�6E   $��0��6Y     TextBoxStyle#��[ 6i   ��5      �� *PlaneRegNumberEcoSeats+$
 True��$ PropertyChanged=�$
	 True��5   i   �� 5   
   -   5        $
 BusinessSeatsNumberTxtBx��5      $��	0,150,0,0q�64   $
 Wrap=�6G   $��0��6[   #��[ 6k   ��5      �� *PlaneRegNumberBusSeats+$
 True��$ PropertyChanged=�$
	 True��5   k   �� 5!   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��1��6K   $��2��6X   .+�5"      �� -   5         ��Name$ AddPlaneButton��5"      $��Добавить��6-     ButtonStyle#��[ 6]   �� 5#      -   5        $ DeletePlaneButton��5#      $��Удалить��60   #��[ 6b   �� 5$      -   5        $ UpdateButton��5$      $��Обновить��6+   #��[ 6Y   5%      5&      5'      