﻿#pragma checksum "..\..\QuoteRequest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D49CF8759D3840E8DA8F0E3541DD293"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace ProLyfeQuoteTool {
    
    
    /// <summary>
    /// QuoteRequest
    /// </summary>
    public partial class QuoteRequest : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProLyfeQuoteTool.QuoteRequest p_Request;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_dressCost;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tt_dressCostTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_venueCost;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_cateringCost;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_quoteReqNext;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\QuoteRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_QuoteReqPrevious;
        
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
            System.Uri resourceLocater = new System.Uri("/ProLyfeQuoteTool;component/quoterequest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QuoteRequest.xaml"
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
            this.p_Request = ((ProLyfeQuoteTool.QuoteRequest)(target));
            return;
            case 2:
            this.tb_dressCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\QuoteRequest.xaml"
            this.tb_dressCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnlyPreviewTextEvent);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tt_dressCostTB = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 4:
            this.tb_venueCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\QuoteRequest.xaml"
            this.tb_venueCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnlyPreviewTextEvent);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_cateringCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\QuoteRequest.xaml"
            this.tb_cateringCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnlyPreviewTextEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_quoteReqNext = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\QuoteRequest.xaml"
            this.b_quoteReqNext.Click += new System.Windows.RoutedEventHandler(this.b_quoteReqNext_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_QuoteReqPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\QuoteRequest.xaml"
            this.b_QuoteReqPrevious.Click += new System.Windows.RoutedEventHandler(this.b_quoteReqPrevious);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

