﻿#pragma checksum "..\..\..\View\TaiKhoanView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C31C839B7283060D70413E041D8B885817B21D26C489F4B9EBE3A8ED79C9BE1E"
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
using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
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
    /// TaiKhoanView
    /// </summary>
    public partial class TaiKhoanView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTimKiem;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTimKiem;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dgvTaiKhoan;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThemMoi;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapNhap;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXoa;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenHienThi;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXem;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLoaiTK;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\View\TaiKhoanView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTaiKhoan;
        
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
            System.Uri resourceLocater = new System.Uri("/CuaHangMT;component/view/taikhoanview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TaiKhoanView.xaml"
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
            this.txtTimKiem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnTimKiem = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.dgvTaiKhoan = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.btnThemMoi = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\View\TaiKhoanView.xaml"
            this.btnThemMoi.Click += new System.Windows.RoutedEventHandler(this.btnThemMoi_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCapNhap = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\..\View\TaiKhoanView.xaml"
            this.btnCapNhap.Click += new System.Windows.RoutedEventHandler(this.btnCapNhap_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnXoa = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\View\TaiKhoanView.xaml"
            this.btnXoa.Click += new System.Windows.RoutedEventHandler(this.btnXoa_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTenHienThi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnXem = ((System.Windows.Controls.Button)(target));
            
            #line 209 "..\..\..\View\TaiKhoanView.xaml"
            this.btnXem.Click += new System.Windows.RoutedEventHandler(this.btnXem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbLoaiTK = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.txtTaiKhoan = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

