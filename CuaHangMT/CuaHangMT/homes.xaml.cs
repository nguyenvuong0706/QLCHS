using CuaHangMT.Model;
using CuaHangMT.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CuaHangMT
{
	/// <summary>
	/// Interaction logic for homes.xaml
	/// </summary>
	public partial class homes : Window
	{
		public TaiKhoan acc;
		public homes(TaiKhoan acc)
		{
			this.acc = acc;

			InitializeComponent();
			if(acc.LoaiTaiKhoan != "admin") 
			{
				pq();
			}
			thongtincanhan.loadThongTin(acc);
			//xuat.thongtinxuat(acc);	
		}
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
				DragMove();
		}
		public void pq()
		{
			btnThongKe.Visibility=Visibility.Collapsed;
			btnThongKeXuat.Visibility=Visibility.Collapsed;
			btnTaiKhoan.Visibility=Visibility.Collapsed;	
		}
		private void btnMinimize_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		public void SetActiveUserControl(UserControl control)
		{
			thongtincanhan.Visibility = Visibility.Collapsed;
			nhap.Visibility = Visibility.Collapsed;
			xuat.Visibility = Visibility.Collapsed;
			khachhang.Visibility = Visibility.Collapsed;
			nhacungcap.Visibility = Visibility.Collapsed;
			maytinh.Visibility = Visibility.Collapsed; 
			danhmuc.Visibility = Visibility.Collapsed;
			thongkenhap.Visibility = Visibility.Collapsed;
			thongkexuat.Visibility = Visibility.Collapsed;
			taikhoan.Visibility = Visibility.Collapsed;

			control.Visibility = Visibility.Visible;
		}

		private void btnInfor_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(thongtincanhan);
		}

		private void btnXuat_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(xuat);
		}

		private void btnNhap_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(nhap);
		}

		private void btnKhachHang_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(khachhang);
		}

		private void btnDanhMuc_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(danhmuc);
		}

		private void btnNhaCungCap_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(nhacungcap);
		}

		private void btnMayTinh_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(maytinh);
		}

		private void btnThongKe_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(thongkenhap);
		}
		

		private void btnTaiKhoan_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(taikhoan);
		}

		private void btnThongKeXuat_Click(object sender, RoutedEventArgs e)
		{
			SetActiveUserControl(thongkexuat);
		}
	}
}
