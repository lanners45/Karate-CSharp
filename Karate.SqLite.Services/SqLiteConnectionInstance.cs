using System.Data.SQLite;
using System.Data;

namespace Karate.SqLite.Services
{
	public sealed class SqLiteConnectionInstance
	{
		private const string dataBaseConnection = "Data Source=IrukaKarate.db";
		private static SQLiteConnection _sqlConnection;

		static SqLiteConnectionInstance()
		{
		}

		private SqLiteConnectionInstance()
		{
		}

		public SQLiteConnection GetConnection
		{
			get
			{

				if (_sqlConnection == null)
				{
					_sqlConnection = new SQLiteConnection(dataBaseConnection);
					_sqlConnection.Open();
				}

				if (_sqlConnection.State == ConnectionState.Closed)
				{
					_sqlConnection.Open();
				}

				return _sqlConnection;
			}
		}
		public static SqLiteConnectionInstance Instance { get; } = new SqLiteConnectionInstance();
	}
}