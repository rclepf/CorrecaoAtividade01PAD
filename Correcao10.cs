class Program
	{
		public static void Main(string[] args)
		{
		Console.Write("Digite o número da casa: ");
	        string numeroCasa = Console.ReadLine();
	        Console.Write("Digite a rua: ");
	        string rua = Console.ReadLine();
	        Console.Write("Digite o bairro: ");
	        string bairro = Console.ReadLine();
	        Console.Write("Digite a cidade: ");
	        string cidade = Console.ReadLine();
	        Console.Write("Digite o estado: ");
	        string estado = Console.ReadLine();
	        Console.WriteLine("Endereço: {0}, {1}, {2}, {3}/{4}", rua, numeroCasa, bairro, cidade, estado);
	        
        	Console.WriteLine("Endereço: " + rua + ", " + numeroCasa+ ", "+bairro+", "+cidade+"/"+estado);
				
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		}
	}
