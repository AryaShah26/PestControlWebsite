﻿#pragma checksum "..\..\..\..\Views\Reports\PrintedCheque.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E90C77C9A804753E674382EDF1ADF5E7109C17CDAD5DACC4EBC3A9AEE3644A91"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Reporting.WinForms;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace CPS.Views.Reports {
    
    
    /// <summary>
    /// PrintedCheque
    /// </summary>
    public partial class PrintedCheque : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtPrintDateFrom;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtPrintDateTo;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBrach;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAccountType;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowColumns;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrint;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExportCsv;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPrintedCheque;
        
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
            System.Uri resourceLocater = new System.Uri("/CPS;component/views/reports/printedcheque.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
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
            this.dtPrintDateFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.dtPrintDateTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.cbBrach = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbAccountType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnShowColumns = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
            this.btnShowColumns.Click += new System.Windows.RoutedEventHandler(this.btnShowColumns_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
            this.btnPrint.Click += new System.Windows.RoutedEventHandler(this.btnPrint_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnExportCsv = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Views\Reports\PrintedCheque.xaml"
            this.btnExportCsv.Click += new System.Windows.RoutedEventHandler(this.btnExport_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgPrintedCheque = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

