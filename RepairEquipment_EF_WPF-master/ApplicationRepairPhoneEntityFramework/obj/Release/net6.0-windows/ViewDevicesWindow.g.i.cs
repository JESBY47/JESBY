﻿#pragma checksum "..\..\..\ViewDevicesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "470EDB3C4A449378B2374EF7EC17D8BF414E1D6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// ViewDevicesWindow
    /// </summary>
    public partial class ViewDevicesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 80 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_search_device;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDevices;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Id_Device;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_Name;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_serielNumber;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_description;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_manufacturer;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbx_model;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add_Device;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Update_Device;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\ViewDevicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete_Device;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ApplicationRepairPhoneEntityFramework;component/viewdeviceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewDevicesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbx_search_device = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_search_device.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_search_device_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridDevices = ((System.Windows.Controls.DataGrid)(target));
            
            #line 84 "..\..\..\ViewDevicesWindow.xaml"
            this.dataGridDevices.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dataGridDevices_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbx_Id_Device = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_Id_Device.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Id_Device_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbx_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_Name.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_Name_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbx_serielNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 111 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_serielNumber.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_serielNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbx_description = ((System.Windows.Controls.TextBox)(target));
            
            #line 115 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_description.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_description_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txbx_manufacturer = ((System.Windows.Controls.TextBox)(target));
            
            #line 119 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_manufacturer.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_manufacturer_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txbx_model = ((System.Windows.Controls.TextBox)(target));
            
            #line 123 "..\..\..\ViewDevicesWindow.xaml"
            this.txbx_model.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbx_model_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Add_Device = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\ViewDevicesWindow.xaml"
            this.btn_Add_Device.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Device_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Update_Device = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\ViewDevicesWindow.xaml"
            this.btn_Update_Device.Click += new System.Windows.RoutedEventHandler(this.btn_Update_Device_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Delete_Device = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\ViewDevicesWindow.xaml"
            this.btn_Delete_Device.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Device_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

