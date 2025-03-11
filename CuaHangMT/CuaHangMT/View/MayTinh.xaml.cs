using CuaHangMT.Controller;
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
	/// Interaction logic for MayTinh.xaml
	/// </summary>
	public partial class MayTinh : UserControl
	{
		public MayTinh()
		{
			InitializeComponent();
			loadMT();
			cbmt();

		}
		public void loadMT()
		{
			DataTable dt = MayTinhController.Instance.GetAll();
			dgvMT.ItemsSource = dt.DefaultView;
		}

		public void cbmt()
		{
			string query = "select TenDanhMuc from DanhMuc";
			DataTable dt = DataProvider.Instance.executeQuery(query);
			cbidDanhMuc.ItemsSource = dt.DefaultView;
			cbidDanhMuc.DisplayMemberPath = "TenDanhMuc";
		}


		private void btnThemMoi_Click(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtMaMT.Text, "Bắt buộc nhập vào mã"))
				return;
			if (!MyRegular.CheckRequired(txtTenMT.Text, "Bắt buộc nhập vào tên"))
				return;
			if (!MyRegular.CheckRequired(txtChiTietMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaNhapMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaXuatMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtSoLuongMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;

			string danhmuc = cbidDanhMuc.Text;

			if (MayTinhController.Instance.Add(txtMaMT.Text, txtTenMT.Text, int.Parse(cbidDanhMuc.Text), " ", int.Parse(txtGiaNhapMT.Text), int.Parse(txtGiaXuatMT.Text), int.Parse(txtSoLuongMT.Text), txtChiTietMT.Text))
			{
				MessageBox.Show("Thêm mới thành công");
			}
			else
			{
				MessageBox.Show("Thất bại. Vui lòng kiểm tra lại !!!");
			}
		}

		private void btnCapNhap_Click(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtMaMT.Text, "Bắt buộc nhập vào mã"))
				return;
			if (!MyRegular.CheckRequired(txtTenMT.Text, "Bắt buộc nhập vào tên"))
				return;
			if (!MyRegular.CheckRequired(txtChiTietMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaNhapMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaXuatMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtSoLuongMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;

			if (MayTinhController.Instance.Edit(txtMaMT.Text, txtTenMT.Text, int.Parse(cbidDanhMuc.Text), " ", int.Parse(txtGiaNhapMT.Text), int.Parse(txtGiaXuatMT.Text), int.Parse(txtSoLuongMT.Text), txtChiTietMT.Text))
			{
				MessageBox.Show("Cập nhật thành công");
			}
			else
			{
				MessageBox.Show("Thất bại. Vui lòng kiểm tra lại !!!");
			}
		}

		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{
			if (!MyRegular.CheckRequired(txtMaMT.Text, "Bắt buộc nhập vào mã"))
				return;
			if (!MyRegular.CheckRequired(txtTenMT.Text, "Bắt buộc nhập vào tên"))
				return;
			if (!MyRegular.CheckRequired(txtChiTietMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaNhapMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtGiaXuatMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (!MyRegular.CheckRequired(txtSoLuongMT.Text, "Bắt buộc nhập vào chi tiết hàng hóa"))
				return;
			if (MayTinhController.Instance.Del(txtMaMT.Text))
			{
				MessageBox.Show("Xóa thành công");
			}
			else
			{
				MessageBox.Show("Vui lòng xử lý hóa đơn trước");
			}
		}
		private void btnXem_Click_1(object sender, RoutedEventArgs e)
		{
			loadMT();
		}
    }
}
