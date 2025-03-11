﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Model
{
	public class DanhMucModel
	{
		private int iD;
		private string tenDanhMuc;

		public DanhMucModel(DataRow row)
		{
			this.ID = int.Parse(row["ID"].ToString());
			this.TenDanhMuc = row["TenDanhMuc"].ToString();
		}

		public string TenDanhMuc
		{
			get { return tenDanhMuc; }
			set { tenDanhMuc = value; }
		}

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	}
}
