﻿#pragma checksum "..\..\ЗаявкаОкно.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "316202A560543CD6672FF9A6FA5B0ACF9DB52FF6BD3C4DD30C4377E0EED11818"
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
using Рекламное_агенство;


namespace Рекламное_агенство {
    
    
    /// <summary>
    /// ЗаявкаОкно
    /// </summary>
    public partial class ЗаявкаОкно : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Type;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Vol;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Editors;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Count;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Dop;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ЗаявкаОкно.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Date;
        
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
            System.Uri resourceLocater = new System.Uri("/Рекламное агенство;component/%d0%97%d0%b0%d1%8f%d0%b2%d0%ba%d0%b0%d0%9e%d0%ba%d0" +
                    "%bd%d0%be.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ЗаявкаОкно.xaml"
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
            this.tb_Type = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_Vol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_Editors = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_Count = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_Dop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lb1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            
            #line 16 "..\..\ЗаявкаОкно.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_Otch);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 17 "..\..\ЗаявкаОкно.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_All);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 18 "..\..\ЗаявкаОкно.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_Accept);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 19 "..\..\ЗаявкаОкно.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_Status);
            
            #line default
            #line hidden
            return;
            case 11:
            this.tb_Date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 21 "..\..\ЗаявкаОкно.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_Search);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

