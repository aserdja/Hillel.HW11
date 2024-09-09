using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW11
{
	public static class MethodFilter
	{
		public static IEnumerable<string> GetMethodsAttributeInfo(MethodInfo[] methods)
		{
			foreach (var method in methods)
			{
				if (method.IsDefined(typeof(DocumentationAttribute), false))
				{
					var attributeInfo = method.GetCustomAttribute<DocumentationAttribute>();
					yield return $"Method: {method.Name}; Created by: {attributeInfo?.Author}; Version: {attributeInfo?.Version}; Description: {attributeInfo?.Description}";
				}
			}
		}

		public static void DoMatchedMethods(MethodInfo[] methods, string author)
		{
			foreach (var method in methods)
			{
				if (method.GetCustomAttribute<DocumentationAttribute>()?.Author == author)
				{
					method.Invoke(new TestClass(), null);
				}
			}
		}
	}
}
