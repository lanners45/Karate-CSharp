using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Karate.SqLite.Services
{
	public static class LicenseData
	{
		public static List<Licence> GetLicenseByMember(Member member)
		{
			List<Licence> licenceList = new List<Licence>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetLicenceByMemberId));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					if (!reader.IsClosed)
					{
						while (reader.Read())
						{
							licenceList.AddRange(ResourceBuilder.ParseReader<Licence>(reader));
						}
					}
				}
			}
			return licenceList;
		}

		public static void InsertLicense(Licence Item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertLicense));
				sqlBuilder.ParseSql(Item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void UpdateLicense(Licence Item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.UpdateLicense));
				sqlBuilder.ParseSql(Item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}
	}
}
