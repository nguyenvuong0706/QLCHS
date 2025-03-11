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
	/// Interaction logic for NhaCungCap.xaml
	/// </summary>
	public partial class NhaCungCap : UserControl
	{
		public NhaCungCap()
		{
			InitializeComponent();
			List<NhaCungCapModel> danhSachNcc = NhaCungCapController.Instance.getncc();
			this.dgvNcc.ItemsSource = danhSachNcc;
		}
		private void btnThemMoi_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
			{
				MessageBox.Show("Tên Nhà cung cấp không được để trống");
				return;
			}

			if (NhaCungCapController.Instance.Add(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSoDienThoaiNCC.Text, txtEmailNCC.Text))
			{
				MessageBox.Show("Thêm mới thành công");
				List<NhaCungCapModel> danhSachNcc = NhaCungCapController.Instance.getncc();
				this.dgvNcc.ItemsSource = danhSachNcc;
				txtMaNCC.Clear();
				txtTenNCC.Clear();
				txtDiaChiNCC.Clear();
				txtSoDienThoaiNCC.Clear();
				txtEmailNCC.Clear();
			}
			else
			{
				MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại");
			}
		}

		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{

			if (NhaCungCapController.Instance.Del(txtMaNCC.Text))
			{
				MessageBox.Show("Xóa thành công");
				List<NhaCungCapModel> danhSachNcc = NhaCungCapController.Instance.getncc();
				this.dgvNcc.ItemsSource = danhSachNcc;
				txtMaNCC.Clear();
				txtTenNCC.Clear();
				txtDiaChiNCC.Clear();
				txtSoDienThoaiNCC.Clear();
				txtEmailNCC.Clear();
			}
			else
			{
				MessageBox.Show("Tồn tại Nhà cung cấp trong danh mục này");
			}
		}

		private void dgvNcc_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgvNcc.SelectedItem != null)
			{
				// Lấy mục đã chọn từ ListView
				NhaCungCapModel selectedNCC = (NhaCungCapModel)dgvNcc.SelectedItem;

				// Hiển thị thông tin ID và Tên Danh Mục lên TextBox
				txtMaNCC.Text = selectedNCC.Ma.ToString();
				txtTenNCC.Text = selectedNCC.Ten.ToString();
				txtDiaChiNCC.Text = selectedNCC.DiaChi.ToString();
				txtSoDienThoaiNCC.Text = selectedNCC.SoDienThoai.ToString();
				txtEmailNCC.Text = selectedNCC.Email.ToString();
			}
		}

		private void btnCapNhat_Click(object sender, RoutedEventArgs e)
		{
			if (NhaCungCapController.Instance.Edit(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSoDienThoaiNCC.Text, txtEmailNCC.Text))
			{
				MessageBox.Show("Cập nhật thành công");
				List<NhaCungCapModel> danhSachNcc = NhaCungCapController.Instance.getncc();
				this.dgvNcc.ItemsSource = danhSachNcc;
				txtMaNCC.Clear();
				txtTenNCC.Clear();
				txtDiaChiNCC.Clear();
				txtSoDienThoaiNCC.Clear();
				txtEmailNCC.Clear();
			}
			else
			{
				MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
			}
		}

		private void btnXem_Click(object sender, RoutedEventArgs e)
		{
			List<NhaCungCapModel> danhSachNcc = NhaCungCapController.Instance.getncc();
			this.dgvNcc.ItemsSource = danhSachNcc;
			txtMaNCC.Clear();
			txtTenNCC.Clear();
			txtDiaChiNCC.Clear();
			txtSoDienThoaiNCC.Clear();
			txtEmailNCC.Clear();
		}
	}
}
