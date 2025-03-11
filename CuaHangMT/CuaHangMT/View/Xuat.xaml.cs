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
	/// Interaction logic for Xuat.xaml
	/// </summary>
	public partial class Xuat : UserControl
	{

		private KhachHangModel currKh;
		private TaiKhoan acc;
		private int currIDXuat = XuatController.Instance.GetMaxID();
		public Xuat()
		{
			InitializeComponent();
			txtMaMayTinh.IsReadOnly = true;
			txtSoLuong.IsReadOnly = true;
		}
		public void LoadListView()
		{
			List<ChiTietXuatModel> danhSachXuat = ChiTietXuatController.Instance.GetByIdXuat(currIDXuat);
			this.lstXuat.ItemsSource = danhSachXuat;
		}
		public void LoadTxtThanhTien()
		{
			txtThanhTien.Text = XuatController.Instance.GetTotalPriceById(currIDXuat).ToString();
		}
		private event EventHandler myEvent;
		public event EventHandler MyEvent
		{
			add
			{
				myEvent += value;
			}
			remove
			{
				myEvent -= value;
			}
		}

		private event EventHandler dangBanHang;
		public event EventHandler DangBanHang
		{
			add
			{
				dangBanHang += value;
			}
			remove
			{
				dangBanHang -= value;
			}
		}
		private event EventHandler daBanHang;
		public event EventHandler DaBanHang
		{
			add
			{
				daBanHang += value;
			}
			remove
			{
				daBanHang -= value;
			}
		}
		private void btnCheck_Click(object sender, RoutedEventArgs e)
		{
			if (txtCMTND.Text == "")
			{
				MessageBox.Show("Mã không được để trống");
				lstXuat.Items.Clear();
				return;

			}

			currKh = KhachHangController.Instance.Check(txtCMTND.Text);


			if (currKh == null)
			{
				MessageBox.Show("Kiểm tra lại");

				return;
			}
			else
			{
				MessageBox.Show("Xác nhận thành công");
				txtMaMayTinh.IsReadOnly = false;
				txtSoLuong.IsReadOnly = false;
				LoadListView();
			}

		}

		private void btnBanHang_Click(object sender, RoutedEventArgs e)
		{
			if (txtMaMayTinh.Text.Trim() == "")
			{
				MessageBox.Show("Không được bỏ trống mã máy tính");
				return;
			}
			if (ChiTietXuatController.Instance.Add(currIDXuat, txtMaMayTinh.Text, int.Parse(txtSoLuong.Text)))
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

		private void lstXuat_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (lstXuat.SelectedItem != null)
			{
				// Lấy mục đã chọn từ ListView
				ChiTietXuatModel selectedXuat = (ChiTietXuatModel)lstXuat.SelectedItem;

				// Hiển thị thông tin ID và Tên Danh Mục lên TextBox
				txtMaMayTinh.Text = selectedXuat.MaMayTinh.ToString();
				txtSoLuong.Text = selectedXuat.SoLuong.ToString();
				txtThanhTien.Text = XuatController.Instance.GetTotalPriceById(selectedXuat.IdXuat).ToString();
			}
		}
		private void btnHuyBo_Click(object sender, RoutedEventArgs e)
		{
			int IdXoa = ((ChiTietXuatModel)lstXuat.SelectedItem).IdXuat;
			if (XuatController.Instance.Del(IdXoa))
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

		private void btnThanhToan_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Thành tiền : " + txtThanhTien.Text + "\r\n Thanh toán:", "Xác nhận", MessageBoxButton.OKCancel);

			if (result == MessageBoxResult.OK)
			{
				daBanHang(this, e);
			}

		}
	}
}
