using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Karate.SqLite.Services
{
	public class BadgeData
	{
		public static List<Badge> GetBadges()
		{
			List<Badge> badgeList = new List<Badge>();
			using (SQLiteCommand command = new SQLiteCommand(ScriptManager.ReadScript(ScriptItems.GetBadges), SqLiteConnectionInstance.Instance.GetConnection))
			{
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					badgeList.AddRange(ResourceBuilder.ParseReader<Badge>(reader));
				}
			}
			return badgeList;
		}

		public static List<MemberBadge> GetBadgesByMemberId(Member item)
		{
			List<MemberBadge> badgeList = new List<MemberBadge>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetBadgesByMemberId));
				sqlBuilder.ParseSql(item);
				command.CommandText = sqlBuilder.SQLText;
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						badgeList.AddRange(ResourceBuilder.ParseReader<MemberBadge>(reader));
					}
				}
			}
			return badgeList;
		}

		public static void InsertBadge(Badge badge)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertBadge));
				sqlBuilder.ParseSql(badge);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void DeleteBadge(Badge badge)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.DeleteBadge));
				sqlBuilder.ParseSql(badge);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}
	}
}

