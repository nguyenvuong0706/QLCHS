using CuaHangMT.Model;
using CuaHangMT.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class DanhMucController
	{
		private DanhMucController() { }
		private static DanhMucController instance;

		public static DanhMucController Instance
		{
			get { if (instance == null) instance = new DanhMucController(); return DanhMucController.instance; }
			private set { DanhMucController.instance = value; }
		}

		public List<DanhMucModel> GetAll()
		{
			DataTable data = new DataTable();

			string query = "select * from DanhMuc";
			data = DataProvider.Instance.executeQuery(query);

			List<DanhMucModel> list = new List<DanhMucModel>();
			foreach (DataRow row in data.Rows)
			{
				list.Add(new DanhMucModel(row));
			}

			return list;
		}
		//đang làm đến đây
		public bool Add(string tenDanhMuc)
		{
			string query = string.Format("insert into DanhMuc(TenDanhMuc) values(N'{0}')", tenDanhMuc);
			try
			{
				int result = DataProvider.Instance.executeNonQuery(query);
				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}

		}

		public bool Edit(int id, string ten)
		{

			string query = string.Format("update  DanhMuc set tenDanhMuc =N'{1}' where id = {0}", id, ten);
			try
			{
				int result = DataProvider.Instance.executeNonQuery(query);
				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}

		}
		public bool Del(int id)
		{

			string query = string.Format("delete  DanhMuc  where id = '{0}'", id);
			try
			{
				int result = DataProvider.Instance.executeNonQuery(query);
				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}

		}


		public DataTable Find(string searchString)
		{
			DataTable data = new DataTable();

			string query = string.Format("select * from DanhMuc where tenDanhMuc like N'%{0}%' or id = {0}", searchString);
			data = DataProvider.Instance.executeQuery(query);

			return data;
		}
	}
}
