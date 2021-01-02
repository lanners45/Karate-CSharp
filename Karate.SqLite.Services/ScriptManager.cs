using Karate.SqLite.Services.enumeration;
using Karate.SqLite.Services.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Karate.SqLite.Services
{
	internal class ScriptManager
	{
		const string scriptPath = "Karate.SqLite.Services.Scripts";
		public static string ReadScript(ScriptItems script)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			string resourceName = string.Format("{0}.{1}", scriptPath, script.ToDescription<ScriptItems>());

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			{
				using (StreamReader sw = new StreamReader(stream))
				{
					return sw.ReadToEnd();
				}
			}
		}

	}
}
