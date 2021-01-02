using System;
using System.Collections.Generic;
using System.Reflection;

namespace Karate.SqLite.Services
{
	internal class ResourceBuilder
	{

		public static List<T> ParseReader <T>(System.Data.SQLite.SQLiteDataReader sQLiteDataReader)
		{
			List<T> list = new List<T>();

			if (!sQLiteDataReader.IsClosed)
			{
				while (sQLiteDataReader.Read())
				{
					T o = (T)Activator.CreateInstance(typeof(T));

					for (int idx = 0; idx < sQLiteDataReader.FieldCount; idx++)
					{
						if (sQLiteDataReader.IsDBNull(idx))
							continue;

						string fieldName = sQLiteDataReader.GetName(idx);
						object value = sQLiteDataReader.GetValue(idx);

						Type type = o.GetType();
						PropertyInfo[] propertyInfos = type.GetProperties();

						bool fieldFound = false;
						foreach (var propInfo in propertyInfos)
						{
							if (propInfo.Name == fieldName)
							{
								fieldFound = true;
								switch (propInfo.PropertyType.UnderlyingSystemType.Name)
								{
									case "Int32":
										propInfo.SetValue(o, Int32.Parse(value.ToString()), null);
										break;
									case "String":
										propInfo.SetValue(o, value, null);
										break;
									case "Int16":
										propInfo.SetValue(o, Int16.Parse(value.ToString()), null);
										break;
									case "DateTime":
											propInfo.SetValue(o, DateTime.Parse(value.ToString()), null);
										break;
									case "Nullable`1":
										var propType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
										var dataType = propType.Name;
										if (!string.IsNullOrEmpty(value.ToString()))
										{
											switch (dataType)
											{
												case "Int32":
													propInfo.SetValue(o, Int32.Parse(value.ToString()), null);
													break;
												case "String":
													propInfo.SetValue(o, value, null);
													break;
												case "DateTime":
													propInfo.SetValue(o, DateTime.Parse(value.ToString()), null);
													break;
												default:
													break;
											}
										}
										break;
									default:
										break;
								}

							}
						}

						if (!fieldFound)
						{
							Console.WriteLine(string.Format("{0} not found", fieldName));
						}
					}

					list.Add(o);
				}
			}
			return list;
		}
	}
}
