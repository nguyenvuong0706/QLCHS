﻿#pragma checksum "..\..\..\View\ThongTinCaNhan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52692A76208BC4B8D143939E6635CF82DE597190394EB9CAE791B71AD3C9D232"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CuaHangMT.View;
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


namespace CuaHangMT.View {
    
    
    /// <summary>
    /// ThongTinCaNhan
    /// </summary>
    public partial class ThongTinCaNhan : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTaiKhoan;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapnhap;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMatKhau;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttenhienthi;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMatKhauMoi;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\View\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNhapLai;
        
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
            System.Uri resourceLocater = new System.Uri("/CuaHangMT;component/view/thongtincanhan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ThongTinCaNhan.xaml"
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
            this.txtTaiKhoan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnCapnhap = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\View\ThongTinCaNhan.xaml"
            this.btnCapnhap.Click += new System.Windows.RoutedEventHandler(this.btnCapnhap_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtMatKhau = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txttenhienthi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtMatKhauMoi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNhapLai = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

