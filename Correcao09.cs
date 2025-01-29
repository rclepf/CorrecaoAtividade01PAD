class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
	        string palavra = Console.ReadLine();
	        Console.WriteLine("O comprimento da palavra " + palavra +" é: " + palavra.Length);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
