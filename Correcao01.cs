class Program
	{
		public static void Main(string[] args)
		{
			int numero;
			
			Console.Write("Digite um número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("O numero Digitado foi: {0}.", numero);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
