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
	/// Interaction logic for DanhMuc.xaml
	/// </summary>
	public partial class DanhMuc : UserControl
	{
		public DanhMuc()
		{
			InitializeComponent();
			List<DanhMucModel> danhSachDanhMuc = DanhMucController.Instance.GetAll();
			this.lstDanhMuc.ItemsSource = danhSachDanhMuc;

		}

		private void btnThemMoi_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
			{
				MessageBox.Show("Tên danh mục không được để trống");
				return;
			}

			if (DanhMucController.Instance.Add(txtTenDanhMuc.Text))
			{
				MessageBox.Show("Thêm mới thành công");
				List<DanhMucModel> danhSachDanhMuc = DanhMucController.Instance.GetAll();
				this.lstDanhMuc.ItemsSource = danhSachDanhMuc;
				txtTenDanhMuc.Clear();
			}
			else
			{
				MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại");
			}
		}
		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{

			if (DanhMucController.Instance.Del(int.Parse(txtMaDanhMuc.Text)))
			{
				MessageBox.Show("Xóa thành công");
				List<DanhMucModel> danhSachDanhMuc = DanhMucController.Instance.GetAll();
				this.lstDanhMuc.ItemsSource = danhSachDanhMuc;
				txtTenDanhMuc.Clear();
			}
			else
			{
				MessageBox.Show("Tồn tại Máy tính trong danh mục này");
			}
		}

		private void lstDanhMuc_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (lstDanhMuc.SelectedItem != null)
			{
				// Lấy mục đã chọn từ ListView
				DanhMucModel selectedDanhMuc = (DanhMucModel)lstDanhMuc.SelectedItem;

				// Hiển thị thông tin ID và Tên Danh Mục lên TextBox
				txtMaDanhMuc.Text = selectedDanhMuc.ID.ToString();
				txtTenDanhMuc.Text = selectedDanhMuc.TenDanhMuc;
			}
		}

		private void btnCapNhap_Click(object sender, RoutedEventArgs e)
		{
			if (DanhMucController.Instance.Edit(int.Parse(txtMaDanhMuc.Text), txtTenDanhMuc.Text))
			{
				MessageBox.Show("Cập nhật thành công");
				List<DanhMucModel> danhSachDanhMuc = DanhMucController.Instance.GetAll();
				this.lstDanhMuc.ItemsSource = danhSachDanhMuc;
				txtTenDanhMuc.Clear();
			}
			else
			{
				MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
			}
		}

		private void btnXem_Click(object sender, RoutedEventArgs e)
		{
			List<DanhMucModel> danhSachDanhMuc = DanhMucController.Instance.GetAll();
			this.lstDanhMuc.ItemsSource = danhSachDanhMuc;
			txtTenDanhMuc.Clear();
		}
	}
}
