class Program
	{
		public static void Main(string[] args)
		{
		Console.Write("Digite um caractere: ");
	        char caractere = Console.ReadKey().KeyChar;
	        Console.WriteLine("\nVocê digitou: " + caractere);
			
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		}
	}
