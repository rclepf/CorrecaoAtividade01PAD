class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite o preço do produto: ");
	        double preco = double.Parse(Console.ReadLine());
	        Console.Write("Digite o desconto (em %): ");
	        double desconto = double.Parse(Console.ReadLine());
	        double precoFinal = preco - (preco * desconto / 100);
        	Console.WriteLine("Preço final com desconto: " + precoFinal);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
