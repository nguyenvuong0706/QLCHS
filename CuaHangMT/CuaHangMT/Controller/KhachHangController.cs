﻿using CuaHangMT.Model;
using CuaHangMT.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CuaHangMT.Controller
{
	public class KhachHangController
	{
		private KhachHangController() { }
		private static KhachHangController instance;

		public static KhachHangController Instance
		{
			get { if (instance == null) instance = new KhachHangController(); return KhachHangController.instance; }
			private set { KhachHangController.instance = value; }
		}

		public KhachHangModel Check(string cmtnd)
		{
			string query = string.Format("select * from KhachHang where Cmtnd = '{0}'", cmtnd);
			DataTable data = new DataTable();
			data = DataProvider.Instance.executeQuery(query);

			if (data.Rows.Count == 0)
				return null;
			else
			{
				KhachHangModel kh = new KhachHangModel(data.Rows[0]);
				return kh;
			}
		}

		public DataTable GetAll()
		{
			DataTable data = new DataTable();

			string query = "select * from KhachHang";
			data = DataProvider.Instance.executeQuery(query);

			return data;
		}

		public List<KhachHangModel> GetKhachHang()
		{
			DataTable data = new DataTable();

			string query = "select * from KhachHang";
			data = DataProvider.Instance.executeQuery(query);
			List<KhachHangModel> list = new List<KhachHangModel>();
			foreach (DataRow row in data.Rows)
			{
				list.Add(new KhachHangModel(row));
			}

			return list;
		}


		public bool Add(string cmtnd, string ten, int tuoi, string diaChi, string soDienThoai, string email)
		{
			string query = string.Format("insert into KhachHang(Cmtnd,Ten,Tuoi,DiaChi,SoDienThoai,Email) values('{0}',N'{1}',{2},N'{3}','{4}','{5}')", cmtnd, ten, tuoi, diaChi, soDienThoai, email);
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

		public bool Edit(string cmtnd, string ten, int tuoi, string diaChi, string soDienThoai, string email)
		{
			string query = string.Format("update  KhachHang set ten =N'{1}', tuoi = {2}, diaChi = N'{3}', soDienThoai = '{4}', email = '{5}' where cmtnd = '{0}'", cmtnd, ten, tuoi, diaChi, soDienThoai, email);
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
		public bool Del(string cmtnd)
		{
			string query = string.Format("delete  KhachHang  where cmtnd = '{0}'", cmtnd);
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

			string query = string.Format("select * from KhachHang where ten like N'%{0}%' or diaChi like N'%{0}%' or soDienThoai  like '%{0}%' or email  like '%{0}%' or cmtnd  like '%{0}%'", searchString);
			data = DataProvider.Instance.executeQuery(query);

			return data;
		}
	}
}
