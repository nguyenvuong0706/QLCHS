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
	/// Interaction logic for ThongKeXuat.xaml
	/// </summary>
	public partial class ThongKeXuat : UserControl
	{
		public ThongKeXuat()
		{
			InitializeComponent();
			dateTuNgay.SelectedDate = new DateTime(2017, 1, 1);
			dateDenNgay.SelectedDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 28, 0, 0, 0);
			LoadDtgv();
		}
		private void LoadDtgv()
		{
			List<HoaDonXuatModel> DateXuat = HoaDonXuatController.Instance.GetByTime(dateTuNgay.SelectedDate.Value, dateDenNgay.SelectedDate.Value);
			this.lstThongKe.ItemsSource = DateXuat;
		}
		private void btnHuyBo_Click(object sender, RoutedEventArgs e)
		{
			HoaDonXuatModel selectedXuat = (HoaDonXuatModel)lstThongKe.SelectedItem;
			if (selectedXuat != null)
			{
				DateTime dateTimeValue = (DateTime)selectedXuat.NgayXuat;
				NhapController.Instance.DelByTime(dateTimeValue, dateDenNgay.SelectedDate.Value);
				LoadDtgv();
			}
		}
	}
}
