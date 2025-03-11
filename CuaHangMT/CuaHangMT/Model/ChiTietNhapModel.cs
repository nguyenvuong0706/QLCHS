using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Model
{
	public class ChiTietNhapModel
	{
		private int iD;
		private int iDNhap;
		private string maMayTinh;
		private int soLuong;

		public ChiTietNhapModel(DataRow row)
		{
			this.ID = int.Parse(row["ID"].ToString());
			this.IDNhap = int.Parse(row["IdNhap"].ToString());
			this.MaMayTinh = row["MaMayTinh"].ToString();
			this.SoLuong = int.Parse(row["SoLuong"].ToString());
		}

		public int SoLuong
		{
			get { return soLuong; }
			set { soLuong = value; }
		}

		public string MaMayTinh
		{
			get { return maMayTinh; }
			set { maMayTinh = value; }
		}

		public int IDNhap
		{
			get { return iDNhap; }
			set { iDNhap = value; }
		}

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	}
}
