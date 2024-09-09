namespace HW11
{
	public class TestClass
	{
		[Documentation("John Doe", "1.1", "Method writes info to console")]
		public void ShowInfo()
		{
            Console.WriteLine($"Info");
        }

		[Documentation("Buzz Lightyear", "2.1", "Showing warning in console")]
		public void ShowWarning()
		{
            Console.WriteLine($"Warning");
        }

		[Documentation("John Doe", "4.4")]
		public void ShowError()
		{
			Console.WriteLine($"Error");
		}
	}
}
