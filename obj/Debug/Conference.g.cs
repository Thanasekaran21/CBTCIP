﻿#pragma checksum "..\..\Conference.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ED952F6C30E6AC292599D06F1726AF34156AA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace EVENTPLANNER360 {
    
    
    /// <summary>
    /// Conference
    /// </summary>
    public partial class Conference : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Locationcmbox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateselection;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel venuespanel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hallslist;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel D1;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel D2;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nametxt;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Numbertxt;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Addresstxt;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Paymentportal;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cnfrmbooking;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Conference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button trackingbudget;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EVENTPLANNER360;component/conference.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Conference.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Locationcmbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\Conference.xaml"
            this.Locationcmbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Locationcmbox_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dateselection = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            
            #line 68 "..\..\Conference.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 4:
            this.venuespanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.hallslist = ((System.Windows.Controls.ComboBox)(target));
            
            #line 75 "..\..\Conference.xaml"
            this.hallslist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.hallslist_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 79 "..\..\Conference.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            this.D1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.D2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.Nametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Numbertxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Addresstxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Paymentportal = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.cnfrmbooking = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\Conference.xaml"
            this.cnfrmbooking.Click += new System.Windows.RoutedEventHandler(this.cnfrmbooking_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.trackingbudget = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\Conference.xaml"
            this.trackingbudget.Click += new System.Windows.RoutedEventHandler(this.trackingbudget_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

