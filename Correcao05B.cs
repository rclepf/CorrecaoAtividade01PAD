class Program
	{
		public static void Main(string[] args)
		{
			char caractere;
			Console.Write("Digite um caractere: ");
			caractere = char.Parse(Console.ReadLine());
        	Console.WriteLine("Você digitou: " + caractere);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
