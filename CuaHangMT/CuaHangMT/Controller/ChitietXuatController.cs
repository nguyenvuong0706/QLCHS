using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class ChiTietXuatController
	{
		private ChiTietXuatController() { }
		private static ChiTietXuatController instance;

		public static ChiTietXuatController Instance
		{
			get { if (instance == null) instance = new ChiTietXuatController(); return ChiTietXuatController.instance; }
			private set { ChiTietXuatController.instance = value; }
		}

		public List<ChiTietXuatModel> GetByIdXuat(int idXuat)
		{
			DataTable data = new DataTable();
			string query = "select * from CTXuat where IdXuat = " + idXuat;

			data = DataProvider.Instance.executeQuery(query);
			List<ChiTietXuatModel> list = new List<ChiTietXuatModel>();

			foreach (DataRow item in data.Rows)
			{
				list.Add(new ChiTietXuatModel(item));
			}

			return list;
		}

		public bool Add(int idXuat, string maMayTinh, int soLuong)
		{
			try
			{
				int result = DataProvider.Instance.executeNonQuery("uspAddChiTietXuat @idXuat , @maMayTinh , @soLuong ", new object[] { idXuat, maMayTinh, soLuong });

				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Del(int idChiTietXuat)
		{
			try
			{
				int result = DataProvider.Instance.executeNonQuery("uspDelChiTietXuat @id ", new object[] { idChiTietXuat });

				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
