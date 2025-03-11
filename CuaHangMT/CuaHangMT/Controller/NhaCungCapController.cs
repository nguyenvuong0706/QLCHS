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
	public class NhaCungCapController
	{
		private NhaCungCapController() { }
		private static NhaCungCapController instance;

		public static NhaCungCapController Instance
		{
			get { if (instance == null) instance = new NhaCungCapController(); return NhaCungCapController.instance; }
			private set { NhaCungCapController.instance = value; }
		}

		public DataTable GetAll()
		{
			DataTable data = new DataTable();

			string query = "select * from NhaCungCap";
			data = DataProvider.Instance.executeQuery(query);

			return data;
		}
		public List<NhaCungCapModel> getncc()
		{
			DataTable data = new DataTable();

			string query = "select * from NhaCungCap";
			data = DataProvider.Instance.executeQuery(query);


			List<NhaCungCapModel> list = new List<NhaCungCapModel>();
			foreach (DataRow row in data.Rows)
			{
				list.Add(new NhaCungCapModel(row));
			}

			return list;
		}
		public NhaCungCapModel Check(string ma)
		{
			DataTable data = new DataTable();
			string query = string.Format("select * from NhaCungCap where ma = '{0}'", ma);

			data = DataProvider.Instance.executeQuery(query);
			if (data.Rows.Count == 0) return null;

			NhaCungCapModel ncc = new NhaCungCapModel(data.Rows[0]);
			return ncc;
		}

		public bool Add(string ma, string ten, string diaChi, string soDienThoai, string email)
		{
			string query = string.Format("insert into NhaCungCap(Ma,Ten,DiaChi,SoDienThoai,Email) values('{0}',N'{1}',N'{2}','{3}','{4}')", ma, ten, diaChi, soDienThoai, email);
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

		public bool Edit(string ma, string ten, string diaChi, string soDienThoai, string email)
		{
			string query = string.Format("update  NhaCungCap set ten =N'{1}', diaChi = N'{2}', soDienThoai = '{3}', email = '{4}' where ma = '{0}'", ma, ten, diaChi, soDienThoai, email);
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
		public bool Del(string ma)
		{
			string query = string.Format("delete  NhaCungCap  where ma = '{0}'", ma);
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

			string query = string.Format("select * from NhaCungCap where ten like N'%{0}%' or diaChi like N'%{0}%' or soDienThoai  like '%{0}%' or email  like '%{0}%' or ma  like '%{0}%'", searchString);
			data = DataProvider.Instance.executeQuery(query);

			return data;
		}

	}
}
