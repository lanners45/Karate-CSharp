using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Karate.SqLite.Services
{
	public class StyleData
	{
		public static List<StyleItem> GetStyles()
		{
			List<StyleItem> ItemList = new List<StyleItem>();
			using (SQLiteCommand command = new SQLiteCommand(ScriptManager.ReadScript(ScriptItems.GetStyles), SqLiteConnectionInstance.Instance.GetConnection))
			{
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var gradeItem = new StyleItem()
						{
							StyleId = reader.GetInt32(reader.GetOrdinal("StyleId")),
							Name = reader.GetString(reader.GetOrdinal("Name"))
						};

						ItemList.Add(gradeItem);
					}
				}
			}
			return ItemList;
		}

		public static void InsertStyle(StyleItem item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertStyle));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void DeleteStyle(StyleItem item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.DeleteStyle));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}
	}
}

