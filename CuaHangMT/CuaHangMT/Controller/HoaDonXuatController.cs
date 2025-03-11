using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class HoaDonXuatController
	{
		private HoaDonXuatController() { }

		private static HoaDonXuatController instance;

		public static HoaDonXuatController Instance
		{
			get { if (instance == null) instance = new HoaDonXuatController(); return HoaDonXuatController.instance; }
			private set { HoaDonXuatController.instance = value; }
		}
		private static int tong;
		/// <summary>
		/// get set tong của list
		/// </summary>
		public static int Tong
		{
			get { return HoaDonXuatController.tong; }
			set { HoaDonXuatController.tong = value; }
		}
		public List<HoaDonXuatModel> GetByTime(DateTime from, DateTime to)
		{
			DataTable data = new DataTable();
			List<HoaDonXuatModel> list = new List<HoaDonXuatModel>();
			string query = "uspGetHoaDonXuatByTime @fromDay , @toDay";
			data = DataProvider.Instance.executeQuery(query, new object[] { from, to });
			tong = 0;
			foreach (DataRow item in data.Rows)
			{
				list.Add(new HoaDonXuatModel(item));
				tong += int.Parse(item["TongTien"].ToString());
			}

			return list;
		}
		public List<HoaDonXuatModel> GetAll()
		{
			DataTable data = new DataTable();
			List<HoaDonXuatModel> list = new List<HoaDonXuatModel>();
			string query = "select Xuat.ID, Ten,NgayXuat,NguoiBanHang,TongTien from Xuat join (select IdXuat, sum(CTXuat.SoLuong*Gia) as 'TongTien' from CTXuat join MayTinh on CTXuat.MaMayTinh = MayTinh.Ma group by IdXuat) as tam on Xuat.ID = tam.IdXuat join KhachHang on Xuat.IdKhachHang = KhachHang.Cmtnd";
			data = DataProvider.Instance.executeQuery(query);
			tong = 0;
			foreach (DataRow item in data.Rows)
			{
				list.Add(new HoaDonXuatModel(item));
				tong += int.Parse(item["TongTien"].ToString());
			}

			return list;
		}
	}
}
