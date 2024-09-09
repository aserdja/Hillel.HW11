using HW11;
using System.Reflection;

Type classType = typeof(TestClass);
var methods = classType.GetMethods();


MethodFilter.DoMatchedMethods(methods, "John Doe");

foreach (var method in MethodFilter.GetMethodsAttributeInfo(methods))
{
    Console.WriteLine(method);
}


