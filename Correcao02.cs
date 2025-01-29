class Program
	{
		public static void Main(string[] args)
		{
		Console.Write("Digite um número real: ");
	        double numeroReal = double.Parse(Console.ReadLine());
	        Console.WriteLine("Você digitou: " + numeroReal);
			
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		}
	}
