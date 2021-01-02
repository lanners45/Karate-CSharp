using Karate.SqLite.Services.enumeration;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Karate.SqLite.Services.Extensions
{
	internal static class EnumExtensions
	{
		public static string ToDescription<TEnum>(this ScriptItems EnumValue)
		{
			return GetEnumDescription((ScriptItems)(object)EnumValue);
		}

		private static string GetEnumDescription(ScriptItems value)
		{
			FieldInfo fi = value.GetType().GetField(value.ToString());

			DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

			if (attributes != null && attributes.Any())
			{
				return attributes.First().Description;
			}

			return value.ToString();
		}
	}
}
