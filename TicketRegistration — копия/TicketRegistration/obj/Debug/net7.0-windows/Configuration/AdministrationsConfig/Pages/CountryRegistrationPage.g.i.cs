﻿#pragma checksum "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E9AD8A3F72589AD20743069631B87534CB16620F"
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
    /// CountryRegistrationPage
    /// </summary>
    public partial class CountryRegistrationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CountryCmbBx;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCountryButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCountryButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TicketRegistration;component/configuration/administrationsconfig/pages/countryre" +
                    "gistrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
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
            this.CountryCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.AddCountryButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
            this.AddCountryButton.Click += new System.Windows.RoutedEventHandler(this.AddCountryButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteCountryButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
            this.DeleteCountryButton.Click += new System.Windows.RoutedEventHandler(this.DeleteCountryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\..\Configuration\AdministrationsConfig\Pages\CountryRegistrationPage.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

