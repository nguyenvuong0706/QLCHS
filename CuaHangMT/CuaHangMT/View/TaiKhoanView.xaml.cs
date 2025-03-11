using CuaHangMT.Controller;
using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuaHangMT.View
{
	/// <summary>
	/// Interaction logic for TaiKhoanView.xaml
	/// </summary>
	public partial class TaiKhoanView : UserControl
	{
		public TaiKhoanView()
		{
			InitializeComponent();
			LoadTK();
			
		}

		public void LoadTK()
		{
			List<TaiKhoan> danhSachTaiKhoan = TaiKhoanController.Instance.GetAll();
			this.dgvTaiKhoan.ItemsSource = danhSachTaiKhoan;
		}


		private void btnXem_Click(object sender, RoutedEventArgs e)
		{
			LoadTK();
		}

		private void btnThemMoi_Click(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtTaiKhoan.Text, "Bắt buộc nhập vào username"))
				return;
			if (!MyRegular.CheckRequired(txtTenHienThi.Text, "Bắt buộc nhập vào tên hiển thị"))
				return;


			if (TaiKhoanController.Instance.Add(txtTaiKhoan.Text, txtTenHienThi.Text, cbLoaiTK.SelectedIndex))
			{
				MessageBox.Show("Tạo tài khoản thành công\r\n " + txtTaiKhoan.Text + " mật khẩu: 12345 .\r\nVui lòng đăng nhập và đổi mật khẩu");
				LoadTK();
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra");
			}
		}

		private void btnCapNhap_Click(object sender, RoutedEventArgs e)
		{
			int taikhoan1 = 0;
			if(cbLoaiTK.SelectedIndex == 0)
			{
				taikhoan1 = 0;
			}
			else 
			{
				taikhoan1 = 1;
			} 



			if (!MyRegular.CheckRequired(txtTaiKhoan.Text, "Bắt buộc nhập vào username"))
				return;
			if (!MyRegular.CheckRequired(txtTenHienThi.Text, "Bắt buộc nhập vào tên hiển thị"))
				return;

			if (txtTaiKhoan.Text.Trim() == "")
			{
				MessageBox.Show("Username không được để trống");
				return;
			}
			
			if (TaiKhoanController.Instance.Update(txtTaiKhoan.Text, txtTenHienThi.Text, taikhoan1 ))
			{
				MessageBox.Show("Cập nhật thành công");
				LoadTK();
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra");
			}
		}

		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{

			if (txtTaiKhoan.Text.Trim() == "")
			{
				MessageBox.Show("Username không được để trống");
				return;
			}
			MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn xóa tài khoản này.\r\nCác giao dịch do tài khoản này sẽ không chứa thông tin tài khoản", "Xác nhận", MessageBoxButton.OKCancel);
			if (result == MessageBoxResult.Cancel)
			{
				return;
			}
			if (TaiKhoanController.Instance.Del(txtTaiKhoan.Text))
			{
				MessageBox.Show("Xóa thành công");
				LoadTK();
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra");
			}
		}
    }
}
