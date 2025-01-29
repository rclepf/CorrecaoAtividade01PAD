class Program
	{
		public static void Main(string[] args)
		{
		Console.Write("Digite 'sim' ou 'não': ");
	        bool respostaBool = Console.ReadLine().ToLower() == "sim";
	        Console.WriteLine("Você digitou: " + respostaBool);
			
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		}
	}
