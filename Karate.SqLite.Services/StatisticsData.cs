using Karate.Common.Enum;
using Karate.Common.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Karate.SqLite.Services
{
	public class StatisticsData
	{
		public static Dictionary<Statistics, int> GetStats()
		{
			Dictionary<Statistics, int> statisticsData = new Dictionary<Statistics, int>();
			using (SQLiteCommand command = new SQLiteCommand(ScriptManager.ReadScript(enumeration.ScriptItems.GetStatistics), SqLiteConnectionInstance.Instance.GetConnection))
			{
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						string fieldName = reader.GetString(reader.GetOrdinal("Status"));
						int total = reader.GetInt32(reader.GetOrdinal("Total"));
						switch (fieldName)
						{
							case "TotalMembers":
								statisticsData.Add(Statistics.AllMembers, total);
								break;
							case "Active":
								statisticsData.Add(Statistics.ActiveMembers, total);
								break;
							case "Inactive":
								statisticsData.Add(Statistics.InActiveMembers, total);
								break;
							case "ExpiredLicence":
								statisticsData.Add(Statistics.ExpiredMembers, total);
								break;
						}
					}
				}
			}
			return statisticsData;
		}
	}
}

