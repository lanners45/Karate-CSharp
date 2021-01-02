using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Karate.SqLite.Services
{
	public class ClassData
	{
		public static List<ClassItem> GetClassItems()
		{
			List<ClassItem> classItemList = new List<ClassItem>();
			using (SQLiteCommand command = new SQLiteCommand(ScriptManager.ReadScript(ScriptItems.GetClasses), SqLiteConnectionInstance.Instance.GetConnection))
			{
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var classItem = new ClassItem()
						{
							ClassId = reader.GetInt32(reader.GetOrdinal("ClassId")),
							Name = reader.GetString(reader.GetOrdinal("Name"))
						};

						classItemList.Add(classItem);
					}
				}
			}
			return classItemList;
		}

		public static void InsertClass(ClassItem classItem)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertClass));
				sqlBuilder.ParseSql(classItem);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void DeleteClass(ClassItem classItem)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.DeleteClass));
				sqlBuilder.ParseSql(classItem);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}
	}
}

