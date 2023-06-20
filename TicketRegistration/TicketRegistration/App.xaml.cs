using System;
using System.Windows;

namespace TicketRegistration;

public partial class App : Application
{
    [STAThread()]
    private static void Main()
    {
        App app = new();
        app.InitializeComponent();
        app.Run();
    }
}
