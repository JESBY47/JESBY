﻿#pragma checksum "..\..\..\AuthorizationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "984C3307B6D4A83BB6788FCBBE6EAD9906A5FA36"
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
    /// AuthorizationWindow
    /// </summary>
    public partial class AuthorizationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_server;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_login;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txbx_pawword;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cxbx_Member;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar connectionProgressBar;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label connectionLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/authorizationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AuthorizationWindow.xaml"
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
            this.txbx_server = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\AuthorizationWindow.xaml"
            this.txbx_server.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_server_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbx_login = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\AuthorizationWindow.xaml"
            this.txbx_login.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_login_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbx_pawword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 49 "..\..\..\AuthorizationWindow.xaml"
            this.txbx_pawword.PasswordChanged += new System.Windows.RoutedEventHandler(this.txbx_pawword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\AuthorizationWindow.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cxbx_Member = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\..\AuthorizationWindow.xaml"
            this.cxbx_Member.Checked += new System.Windows.RoutedEventHandler(this.cxbx_Member_Checked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\AuthorizationWindow.xaml"
            this.cxbx_Member.Unloaded += new System.Windows.RoutedEventHandler(this.cxbx_Member_Unloaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.connectionProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.connectionLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

