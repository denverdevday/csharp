using MyThing = string;

internal class Program
{
	private static void Main(string[] args)
	{
		var f1 = (int i) => i++;
		Console.WriteLine(f1(1));

		var f2 = (int? i = 1) => i++;
		Console.WriteLine(f2()); // 1
	}
}

