   M S B A M L   `   `   `  ����M  ITicketRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TicketRegistrationTicketRegistration  5      .    (TicketRegistration.UserAuthorizationPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TicketRegistration     5        N� Title$  AuthorizationPage��5	       N� 
Background
 �   �.��5      �  � RowDefinitions 5   
   �� 5      $	��11* �6   �� 5      $��3* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   $��10, 10, 0, 0q�6G   .+�5      �� $��Login��6      TextBlockStyle#��[  6%   �� 5      -   5         ��Name$ 
LoginTxtBx��5        TextBoxStyle#��[ 6*   �� 5      $��Password��6   #��[  6(   G� 5      -   5         G�Name$ PasswordPasBx��5      $��23��61   $	��120��6=   $	��Top=�6I   $
��Left=�6a   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�5      �� -   5         ��Name$ 
SignInButt��5      $��Sign in��6)     ButtonStyle#��[ 6;   6`   �� 5      -   5        $ 
SignUpButt��5      $��Sign up��6)   #��[ 6;   6`   5      5      5      