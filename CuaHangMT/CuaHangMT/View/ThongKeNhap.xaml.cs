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
	/// Interaction logic for ThongKe.xaml
	/// </summary>
	public partial class ThongKeNhap : UserControl
	{
		public ThongKeNhap()
		{
			InitializeComponent();
			dateTuNgay.SelectedDate = new DateTime(2017, 1, 1);
			dateDenNgay.SelectedDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 28, 0, 0, 0);
			LoadDtgv();
		}

		private void LoadDtgv()
		{
			List<HoaDonNhapModel> DateNHap = HoaDonNhapController.Instance.GetByTime(dateTuNgay.SelectedDate.Value, dateDenNgay.SelectedDate.Value);
			this.lstThongKe.ItemsSource = DateNHap;
		}

		private void btnHuyBo_Click(object sender, RoutedEventArgs e)
		{
			HoaDonNhapModel selectedNhap = (HoaDonNhapModel)lstThongKe.SelectedItem;
			if (selectedNhap != null)
			{
				DateTime dateTimeValue = (DateTime)selectedNhap.NgayNhap;


				NhapController.Instance.DelByTime(dateTimeValue, dateDenNgay.SelectedDate.Value);
				LoadDtgv();
			}
		}

		private void lstThongKe_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (lstThongKe.SelectedItem != null)
			{
				// Lấy ListViewItem đã chọn
				HoaDonNhapModel selectedNhap = (HoaDonNhapModel)lstThongKe.SelectedItem;

				if (selectedNhap != null)
				{
					string columnValueByIndex = selectedNhap.TongTien.ToString();
					txtTongTien.Text = columnValueByIndex;
				}
			}
		}
	}
}
