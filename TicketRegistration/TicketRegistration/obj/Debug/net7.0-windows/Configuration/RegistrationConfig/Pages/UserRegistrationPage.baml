   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      -    'TicketRegistration.UserRegistrationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� Title$  RegistrationPage��5	       N� 
Background
 �   �.��5      �  � RowDefinitions 5   
   �� 5      $	��11* �6   �� 5      $��3* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��0��6K   $��0 10 0 0q�6X   .+�5      �� $��0 0 10 0q�6   .+�5      �� $
��Name��6      TextBlockStyle#��[  6(   �� 5      -   5         ��Name$ 	NameTxtBx��5        TextBoxStyle#��[ 6$   ��5      �� *Name+ �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5   $   �� 5      $��Email��6   #��[  6)   �� 5      -   5        $ 
EmailTxtBx��5      #��[ 6%   ��5      �� *Email+$
 True��$
 True��$ PropertyChanged=�5   %   �� 5      $��Login��6   #��[  6)   �� 5      -   5        $ 
LoginTxtBx��5      #��[ 6)   ��5      �� *Login+$
 True��$
 True��$ PropertyChanged=�5   )   �� 5      $��Check Password��6   #��[  62   G� 5       -   5         G�Name$ CheckPaswPasBx��5       $��23��66   $	��120��6B   $��0 0 0 10q�6N   $
��Left=�6`   5!      �� 5#      .+�5$      �� $��Surname��6   #��[  6+   �� 5%      -   5        $ SurnameTxtBx��5&      #��[ 6'   ��5%      �� *	Surname+$
 True��$
 True��$ PropertyChanged=�5&   '   �� 5(      $��Phone��6   #��[  6)   �� 5)      -   5        $ 
PhoneTxtBx��5*      #��[ 6%   ��5)      �� *Phone+$
 True��$
 True��$ PropertyChanged=�5*   %   �� 5,      $��Password��6   #��[  6,   G� 5-      -   5        $ PasswordPasBx��5-      $��23��65   $	��120��6A   $��0 0 0 10q�6M   $
��Left=�6_   5.      5/      �� 51   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�52      �� -   5        	 ��Name$	 
SignInButt��52      $��Sign in��6)     ButtonStyle#��[ 6;   6`   �� 53      -	   5        $	 
SignUpButt��53      $��Sign up��6)   #��[ 6;   6`   54      55      56      