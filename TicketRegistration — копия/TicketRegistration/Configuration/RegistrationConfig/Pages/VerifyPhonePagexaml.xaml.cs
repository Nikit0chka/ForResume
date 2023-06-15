using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class VerifyPhonePagexaml : Page
{

    private const string SENDER_ADRESS = "voronsov.nikita19742004@gmail.com";
    private const string PASSWORD = "wyitkqjoxqjbdase";

    private string _recipentAdress;
    private string _code;

    public bool IsCodeVerified = false;

    public VerifyPhonePagexaml(string email)
    {
        InitializeComponent();

        _recipentAdress = email;
        SendCode();
    }

    #region Events
    private void VerifyButt_Click(object sender, RoutedEventArgs e)
    {
        VerifyCode();
    }

    private void BackButt_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }

    private void GenerateCode()
    {
        for (int i = 0; i < 4; i++)
        {
            Random rnd = new Random();
            _code += rnd.Next(0, 9).ToString();
        }
    }
    #endregion

    #region Logic
    private void VerifyCode()
    {
        if (CodeTxtBx.Text == _code)
        {
            IsCodeVerified = true;
            NavigationService.Navigate(new MainUserPage());
        }
        else
            MessageBox.Show("Verify code is not match!");
    }

    private void SendCode()
    {
        GenerateCode();

        using var emailMessage = new MimeMessage();

        emailMessage.From.Add(new MailboxAddress("", SENDER_ADRESS));
        emailMessage.To.Add(new MailboxAddress("", _recipentAdress));
        emailMessage.Subject = "Your verify code";
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = "Your verify code : " + _code
        };

        using (var client = new SmtpClient())
        {
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate(SENDER_ADRESS, PASSWORD);
            client.Send(emailMessage);
            client.Disconnect(true);
        }
    }
    #endregion
}