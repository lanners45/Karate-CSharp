using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Karate.SqLite.Services
{
	public class GradeData
	{
		public static List<GradeItem> GetGradesByStyle(StyleItem style)
		{
			List<GradeItem> itemList = new List<GradeItem>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetGradesByStyle));
				sqlBuilder.ParseSql(style);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var item = new GradeItem()
						{
							GradeId = reader.GetInt32(reader.GetOrdinal("GradeId")),
							StyleId = reader.GetInt32(reader.GetOrdinal("StyleId")),
							Grade = reader.GetString(reader.GetOrdinal("Grade")),
							BeltDescription = reader.GetString(reader.GetOrdinal("BeltDescription"))
						};

						itemList.Add(item);
					}
				}
			}
			return itemList;
		}

		public static List<GradingItem> GetGradesByMemberId(Member item)
		{
			List<GradingItem> itemList = new List<GradingItem>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetGradesByMemberId));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						while (reader.Read())
						{
							itemList.Add(ResourceBuilder.ParseReader<GradingItem>(reader).Single());
						}
					}
				}
			}
			return itemList;
		}

		
		public static void InsertGrade(GradeItem Item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertGrade));
				sqlBuilder.ParseSql(Item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void DeleteGrade(GradeItem Item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.DeleteGrade));
				sqlBuilder.ParseSql(Item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void InsertMemberGrading(GradingItem item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertMemberGrading));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void DeleteMemberGrading(GradingItem Item)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.DeleteMemberGrading));
				sqlBuilder.ParseSql(Item);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}
	}
}

