using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.SqLite.Services
{
	public static class AddressData
	{
		public static Address GetAddressById(Address address)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(enumeration.ScriptItems.GetAddressById));
				sqlBuilder.ParseSql(address);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					address = ResourceBuilder.ParseReader<Address>(reader).Single();
				}
			}
			return address;
		}

		public static List<Address> GetAddresses()
		{
			List<Address> itemList = new List<Address>();

			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				command.CommandText = ScriptManager.ReadScript(enumeration.ScriptItems.GetAddresses);
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					itemList.AddRange(ResourceBuilder.ParseReader<Address>(reader));
				}
			}
			return itemList;
		}

		public static void UpdateAddress(Address item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.UpdateAddress));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static int InsertAddress(Address item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertAddress));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
				command.CommandText = "select last_insert_rowid()";
				var insertedMemberId = command.ExecuteScalar();
				return int.Parse(insertedMemberId.ToString());
			}
		}
	}
}
