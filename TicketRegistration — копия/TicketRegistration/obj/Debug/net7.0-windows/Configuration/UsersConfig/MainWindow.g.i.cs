﻿#pragma checksum "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "323E40D082AD2C5D2A36B09028D286DB507F2119"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TicketReservation;


namespace TicketReservation {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DepartureCountryCmbBx;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ArrivalCountryCmbBx;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DepartureCityCmbBx;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ArrivalCityCmbBx;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DepartureDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InitializeFightsButt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FlightsPanels;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TicketRegistration;V1.0.0.0;component/configuration/usersconfig/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DepartureCountryCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ArrivalCountryCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DepartureCityCmbBx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
            this.DepartureCityCmbBx.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DepartureCityCmbBx_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ArrivalCityCmbBx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
            this.ArrivalCityCmbBx.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ArrivalCityCmbBx_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DepartureDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.InitializeFightsButt = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Configuration\UsersConfig\MainWindow.xaml"
            this.InitializeFightsButt.Click += new System.Windows.RoutedEventHandler(this.InitializeFightsButt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FlightsPanels = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

