﻿#pragma checksum "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D99A7F8D6D4B1D135C18E1041CA52A4BD1DFAB38B2A8B6953F00679691B60583"
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


namespace CPS.Views.Reports {
    
    
    /// <summary>
    /// TotalReprintedChequeReport
    /// </summary>
    public partial class TotalReprintedChequeReport : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtPrintDateFrom;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtPrintDateTo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBrach;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowColumns;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrint;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTotalReprintedCheque;
        
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
            System.Uri resourceLocater = new System.Uri("/CPS;component/views/reports/totalreprintedchequereport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
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
            this.btnShowColumns = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
            this.btnShowColumns.Click += new System.Windows.RoutedEventHandler(this.btnShowColumns_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\Reports\TotalReprintedChequeReport.xaml"
            this.btnPrint.Click += new System.Windows.RoutedEventHandler(this.btnPrint_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgTotalReprintedCheque = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

