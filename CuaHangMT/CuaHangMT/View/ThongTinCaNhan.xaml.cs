using CuaHangMT.Controller;
using CuaHangMT.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuaHangMT.View
{
	/// <summary>
	/// Interaction logic for ThongTinCaNhan.xaml
	/// </summary>
	public partial class ThongTinCaNhan : UserControl
	{
		private TaiKhoan loginAccount;

		public ThongTinCaNhan()
		{
			InitializeComponent();
		}
		public void loadThongTin(TaiKhoan acc)
		{
			txtTaiKhoan.Text = acc.UserName;
			txttenhienthi.Text = acc.TenHienThi;
			loginAccount= acc;
		}

		private void btnCapnhap_Click(object sender, RoutedEventArgs e)
		{
			if (txtMatKhau.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập mật khẩu");
				return;
			}
			if (txtMatKhau.Text != loginAccount.Password)
			{
				MessageBox.Show("Mật khẩu không chính xác");
				return;
			}
			if (txttenhienthi.Text.Trim() == "")
			{
				MessageBox.Show("Bắt buộc phải nhập tên hiển thị");
				return;
			}
			if (txtMatKhauMoi.Text != txtNhapLai.Text)
			{
				MessageBox.Show("Mật khẩu mới không khớp");
				return;
			}
			string strNewPass = loginAccount.Password;
			if (txtMatKhauMoi.Text.Trim() != "")
				strNewPass = txtMatKhauMoi.Text;
			if (TaiKhoanController.Instance.Edit(loginAccount.UserName, strNewPass, txttenhienthi.Text))
			{
				MessageBox.Show("Cập nhật thành công");
			}
			else
			{
				MessageBox.Show("Thất bại. Xin lỗi vì sự cố đáng tiếc. Vui lòng gặp admin để sửa lỗi!!!");
			}
		}
	}
}
	
