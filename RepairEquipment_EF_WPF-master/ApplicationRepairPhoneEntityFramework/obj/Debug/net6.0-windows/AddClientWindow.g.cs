﻿#pragma checksum "..\..\..\AddClientWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D135E30EC383C6C1275832BEF5172316D3CDEF2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationRepairPhoneEntityFramework;
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


namespace ApplicationRepairPhoneEntityFramework {
    
    
    /// <summary>
    /// AddClientWindow
    /// </summary>
    public partial class AddClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_ID_Client;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Name_Client;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Name;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_SeriesNumber;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_SeriesNumber;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_PhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_PhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Email;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Email;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add_Client;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/addclientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddClientWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbx_ID_Client = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbx_Name_Client = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\AddClientWindow.xaml"
            this.txbx_Name_Client.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Name_Client_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lb_Name = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txbx_SeriesNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\AddClientWindow.xaml"
            this.txbx_SeriesNumber.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_SeriesNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb_SeriesNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txbx_PhoneNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\AddClientWindow.xaml"
            this.txbx_PhoneNumber.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_PhoneNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lb_PhoneNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txbx_Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\AddClientWindow.xaml"
            this.txbx_Email.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Email_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lb_Email = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_Add_Client = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\AddClientWindow.xaml"
            this.btn_Add_Client.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Client_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

