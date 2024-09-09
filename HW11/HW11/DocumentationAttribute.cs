namespace HW11
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class DocumentationAttribute(string authorName, string version, string description = "") : Attribute
	{
		public string Author { get; set; } = authorName;
		public string Version { get; set; } = version;
		public string Description { get; set; } = description;
	}
}
