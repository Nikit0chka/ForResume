   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      .    (TicketRegistration.PlaneRegistrationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� 
Background
  �   �.��5
      �  � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� $��	10 10 0 0q�6    �� Orientation$ Vertical=�6(   $
��Left=�6?   .+�5      �� $��
Plane name��6      TextBlockStyle#��[  6*   �� 5      -   5         ��Name$ 
PlaneCmbBx��5        ComboBoxStyle#��[ 6'    �� Text 5      �� *PlaneRegPlaneName+ �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError$
 True��5   '   �� 5      $��Economy seats number��6   #��[  64   �� 5      -   5         ��Name$ EconomySeatsNumberTxtBx��5        TextBoxStyle#��[ 63   ��5      �� *PlaneRegNumberEcoSeats+$
 True��$ PropertyChanged=�$
 True��5   3   �� 5      $��Business seats number��6   #��[  65   �� 5      -   5        $ BusinessSeatsNumberTxtBx��5      #��[ 64   ��5      �� *PlaneRegNumberBusSeats+$
 True��$ PropertyChanged=�$
 True��5   4   5      �� 5   
   $��Center=�6   $ 
Horizontal=�62   $��1��6K   .+�5      �� -   5        	 ��Name$	 AddPlaneButton��5      $	��Add��6-     ButtonStyle#��[ 6X   �� 5       -   5        $	 DeletePlaneButton��5       $��Delete��60   #��[ 6a   �� 5!      -   5        $	 UpdateButton��5!      $��Update��6+   #��[ 6W   5"      5#      5$      