﻿#pragma checksum "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CE5ACB6BEEC12F6B743971EC405A267D34899743"
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
using TicketRegistration;


namespace TicketRegistration {
    
    
    /// <summary>
    /// VerifyPhonePagexaml
    /// </summary>
    public partial class VerifyPhonePagexaml : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeTxtBx;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VerifyButt;
        
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
            System.Uri resourceLocater = new System.Uri("/TicketRegistration;component/configuration/registrationconfig/pages/verifyphonep" +
                    "agexaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
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
            this.BackButt = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
            this.BackButt.Click += new System.Windows.RoutedEventHandler(this.BackButt_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CodeTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.VerifyButt = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\..\Configuration\RegistrationConfig\Pages\VerifyPhonePagexaml.xaml"
            this.VerifyButt.Click += new System.Windows.RoutedEventHandler(this.VerifyButt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

