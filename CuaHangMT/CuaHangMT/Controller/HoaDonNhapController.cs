using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class HoaDonNhapController
	{
		private HoaDonNhapController() { }
		private static HoaDonNhapController instance;

		public static HoaDonNhapController Instance
		{
			get { if (instance == null) instance = new HoaDonNhapController(); return HoaDonNhapController.instance; }
			private set { HoaDonNhapController.instance = value; }
		}
		private static int tong;
		/// <summary>
		/// Get Tong Danh Sach
		/// </summary>
		public static int Tong
		{
			get { return HoaDonNhapController.tong; }
			set { HoaDonNhapController.tong = value; }
		}
		public List<HoaDonNhapModel> GetByTime(DateTime from, DateTime to)
		{
			DataTable data = new DataTable();
			List<HoaDonNhapModel> list = new List<HoaDonNhapModel>();
			string query = "uspGetHoaDonNhapByTime @fromDay , @toDay";
			data = DataProvider.Instance.executeQuery(query, new object[] { from, to });
			tong = 0;
			foreach (DataRow item in data.Rows)
			{
				list.Add(new HoaDonNhapModel(item));
				tong += int.Parse(item["TongTien"].ToString());
			}

			return list;
		}
		public List<HoaDonNhapModel> GetAll()
		{

			DataTable data = new DataTable();
			List<HoaDonNhapModel> list = new List<HoaDonNhapModel>();
			string query = "select Nhap.ID, MaNhaCungCap,NgayNhap,NguoiNhapHang,TongTien from Nhap join(select IdNhap, sum(CTNhap.SoLuong*Gia) as 'TongTien' from CTNhap join MayTinh on CTNhap.MaMayTinh = MayTinh.Ma group by IdNhap) as tam on Nhap.ID = tam.IdNhap";
			data = DataProvider.Instance.executeQuery(query);
			tong = 0;
			foreach (DataRow item in data.Rows)
			{
				list.Add(new HoaDonNhapModel(item));
				tong += int.Parse(item["TongTien"].ToString());
			}

			return list;
		}
	}
}
