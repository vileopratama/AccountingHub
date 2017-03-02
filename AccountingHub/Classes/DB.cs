using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountingHub.Classes
{
	class DB
	{
		public static SqlConnection conn = new SqlConnection();
		public static string SQL;
		public static SqlCommand cmd;
		private static string server;
		private static string database;
		public static string username;
		public static string password;
		public static bool is_connected = false;

		public static string Server
		{
			get{return server;}
			set{server = value;}
		}

		public static string Database
		{
			get { return database; }
			set { database = value; }
		}

		public static string Username
		{
			get { return username; }
			set { username = value; }
		}

		public static string Password
		{
			get { return password; }
			set { password = value; }
		}

		public static bool isConnected
		{
			get { return is_connected;}
			set { is_connected = value;}
		}

		public static void Connect()
		{
			conn.Close();
			try
			{
				conn.ConnectionString = "Server="+ Server +";" +
										"DataBase=AR;" +
										"User Id="+ Username +";" +
										"Password=" + Password + ";";
				conn.Open();
				isConnected = true;
			}
			catch (SqlException ex)
			{
				isConnected = false;
				//MessageBox.Show(ex.Message, "Database Connection");
			}
		}

		public void Disconnect()
		{
			conn.Close();
			conn.Dispose();
		}

	}
}
