using CuaHangMT.Controller;
using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	/// Interaction logic for KhachHang.xaml
	/// </summary>
	public partial class KhachHang : UserControl
	{
		public KhachHang()
		{
			InitializeComponent();
			loadKH();

		}
		public void loadKH()
		{
			List<KhachHangModel> danhSachKH = KhachHangController.Instance.GetKhachHang();
			this.dgvKhachHang.ItemsSource = danhSachKH;

		}

		private void btnTimKiem_Click(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtCCCD.Text, "Bạn hãy nhập vào từ khóa tìm kiếm"))
				return;
			DataTable ketQuaTimKiem = KhachHangController.Instance.Find(txtTimKiem.Text);
			dgvKhachHang.ItemsSource = ketQuaTimKiem.DefaultView;
		}

		private void btnThemMoi_Click_1(object sender, RoutedEventArgs e)
		{

			if (!MyRegular.CheckRequired(txtCCCD.Text, "Bắt buộc nhập vào Cmtnd"))
				return;
			if (!MyRegular.CheckRequired(txtDiaChi.Text, "Bắt buộc nhập vào địa chỉ"))
				return;
			if (!MyRegular.CheckRequired(txtTenKH.Text, "Bắt buộc nhập vào tên"))
				return;

			if (!MyRegular.CheckEmail(txtEmail.Text))
				return;
			if (!MyRegular.CheckPhoneNumber(txtSdt.Text))
				return;
			if (!MyRegular.CheckCMTND(txtCCCD.Text))
				return;


			if (KhachHangController.Instance.Add(txtCCCD.Text, txtTenKH.Text, (int)txttuoi.Value, txtDiaChi.Text, txtSdt.Text, txtEmail.Text))
			{
				MessageBox.Show("Thêm mới thành công");
				loadKH();

			}
			else
			{
				MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại");
			}
		}

		private void btnCapNhap_Click_1(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtCCCD.Text, "Bắt buộc nhập vào Cmtnd"))
				return;
			if (!MyRegular.CheckRequired(txtDiaChi.Text, "Bắt buộc nhập vào địa chỉ"))
				return;
			if (!MyRegular.CheckRequired(txtTenKH.Text, "Bắt buộc nhập vào tên"))
				return;

			if (!MyRegular.CheckEmail(txtEmail.Text))
				return;
			if (!MyRegular.CheckPhoneNumber(txtSdt.Text))
				return;
			if (!MyRegular.CheckCMTND(txtCCCD.Text))
				return;

			if (txtCCCD.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập vào cmtnd");
				return;
			}
			if (KhachHangController.Instance.Edit(txtCCCD.Text, txtTenKH.Text, (int)txttuoi.Value, txtDiaChi.Text, txtSdt.Text, txtEmail.Text))
			{
				MessageBox.Show("Cập nhật thành công");
				loadKH();
			}
			else
			{
				MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
			}
		}

		private void btnXoa_Click_1(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtCCCD.Text, "Bắt buộc nhập vào Cmtnd"))
				return;
			if (txtCCCD.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập vào cmtnd");
				return;
			}
			if (KhachHangController.Instance.Del(txtCCCD.Text))
			{
				MessageBox.Show("Xóa thành công");
				loadKH();

			}
			else
			{
				MessageBox.Show("Không thể xóa khách hàng này. Hóa đơn cần thông tin của Khách hàng này!!!");
			}
		}

		private void btnXem_Click_1(object sender, RoutedEventArgs e)
		{
			loadKH();
		}
	}




}

