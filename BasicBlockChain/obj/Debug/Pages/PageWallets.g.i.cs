﻿#pragma checksum "..\..\..\Pages\PageWallets.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3918D5D9DD5CC838FBA0DC4B7ECE2D94D62FFB71"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BasicBlockChain.Pages;
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


namespace BasicBlockChain.Pages {
    
    
    /// <summary>
    /// PageWallets
    /// </summary>
    public partial class PageWallets : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GeneratorButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorText;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PublicKeyTextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrivateKeyTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BalanceContainer;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\PageWallets.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/BasicBlockChain;component/pages/pagewallets.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageWallets.xaml"
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
            this.GeneratorButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\PageWallets.xaml"
            this.GeneratorButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pages\PageWallets.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ErrorText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.PublicKeyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PrivateKeyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BalanceContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.BalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

