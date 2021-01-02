using System;
using System.Reflection;

namespace Karate.SqLite.Services
{
	internal class SqlBuilder
	{
		public string SQLText { get; private set; }
		public SqlBuilder(string sqlText)
		{
			SQLText = sqlText;

		}
		public void ParseSql<T>(T data)
		{
			Type type = data.GetType();
			PropertyInfo[] propertyInfos = type.GetProperties();
			foreach (var propInfo in propertyInfos)
			{
				object value = propInfo.GetValue(data, null);
				if (value != null)
				{
					SQLText = SQLText.Replace(string.Format("%{0}%", propInfo.Name), value.ToString());
				}
			}
		}
	}
}
