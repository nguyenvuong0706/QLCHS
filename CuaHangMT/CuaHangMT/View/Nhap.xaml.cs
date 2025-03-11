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
	/// Interaction logic for Nhap.xaml
	/// </summary>
	public partial class Nhap : UserControl
	{
		private NhaCungCapModel currNcc;
		private int currIdNhap = NhapController.Instance.GetMaxId();
		public Nhap()
		{
			InitializeComponent();

			txtSoLuongMT.IsReadOnly = true;
			txtMaMT.IsReadOnly = true;

		}
		public void LoadListView()
		{
			List<ChiTietNhapModel> danhSachNhap = ChiTietNhapController.Instance.GetByIDNhap(currIdNhap);
			this.dgvNhap.ItemsSource = danhSachNhap;
		}
		public void LoadTxtThanhTien()
		{
			txtThanhTienMT.Text = NhapController.Instance.GetTotalPriceById(currIdNhap).ToString();
		}

		private void btnXacThucNCC_Click(object sender, RoutedEventArgs e)
		{
			if (txtXacThucNCC.Text == "")
			{
				MessageBox.Show("Mã không được để trống");
				dgvNhap.Items.Clear();
				return;

			}

			currNcc = NhaCungCapController.Instance.Check(txtXacThucNCC.Text);


			if (currNcc == null)
			{
				MessageBox.Show("Kiểm tra lại");

				return;
			}
			else
			{
				MessageBox.Show("Xác nhận thành công");
				txtMaMT.IsReadOnly = false;
				txtSoLuongMT.IsReadOnly = false;

				LoadListView();
			}

		}

		private void btnNhapHang_Click(object sender, RoutedEventArgs e)
		{
			if (txtMaMT.Text.Trim() == "")
			{
				MessageBox.Show("Không được bỏ trống mã máy tính");
				return;
			}
			if (ChiTietNhapController.Instance.Add(currIdNhap, txtMaMT.Text, int.Parse(txtSoLuongMT.Text)))
			{
				MessageBox.Show("Thêm thành công");
				LoadListView();
				LoadTxtThanhTien();
			}
			else
			{
				MessageBox.Show("Hết hàng");
			}
		}

		private void dgvNhap_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgvNhap.SelectedItem != null)
			{
				// Lấy mục đã chọn từ ListView
				ChiTietNhapModel selectedNhap = (ChiTietNhapModel)dgvNhap.SelectedItem;

				// Hiển thị thông tin ID và Tên Danh Mục lên TextBox
				txtMaMT.Text = selectedNhap.MaMayTinh.ToString();
				txtSoLuongMT.Text = selectedNhap.SoLuong.ToString();
				txtThanhTienMT.Text = NhapController.Instance.GetTotalPriceById(selectedNhap.IDNhap).ToString();
			}
		}
		private void btnHuyBoNhap_Click(object sender, RoutedEventArgs e)
		{
			int id = ((ChiTietNhapModel)dgvNhap.SelectedItem).IDNhap;
			if (NhapController.Instance.Del(id))
			{
				MessageBox.Show("Xóa thành công");
				LoadListView();
				LoadTxtThanhTien();

			}
			else
			{
				MessageBox.Show("Tồn tại Máy tính trong danh mục này");
			}
		}

		private void btnThanhToanNhap_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Thành tiền : " + txtThanhTienMT.Text + "\r\n Thanh toán:", "Xác nhận", MessageBoxButton.OKCancel);

			if (result == MessageBoxResult.OK)
			{
				return;

			}

		}

	}
}
