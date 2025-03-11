using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class DataProvider
	{
		private static DataProvider instance;

		public static DataProvider Instance
		{
			get
			{
				if (instance == null)
					instance = new DataProvider();
				return DataProvider.instance;
			}
			private set { DataProvider.instance = value; }
		}

		private DataProvider() { }

		private string connectionString = " Data Source=VIET;Initial Catalog=QLCHMT;User ID=sa;Password=123456 ";

		public DataTable executeQuery(string query, object[] paras = null)
		{
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				int i = 0;
				if (paras != null)
				{
					string[] listPara = query.Split(' ');
					foreach (var item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, paras[i]);
							i++;
						}
					}
				}
				SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
				dataAdapter.Fill(data);

				connection.Close();
			}

			return data;

		}

		public int executeNonQuery(string query, object[] paras = null)
		{
			int data = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				int i = 0;
				if (paras != null)
				{
					string[] listPara = query.Split(' ');
					foreach (var item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, paras[i]);
							i++;
						}
					}
				}

				data = command.ExecuteNonQuery();

				connection.Close();
			}

			return data;
		}
	}
}
