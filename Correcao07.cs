class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite seu nome: ");
	        string nome = Console.ReadLine();
	        Console.Write("Digite sua idade: ");
	        int idade = int.Parse(Console.ReadLine());
	        Console.WriteLine("Nome: {0}, Idade: {1}", nome, idade);
	        Console.WriteLine("Nome: " + nome + ", Idade: " + idade);
	        Console.WriteLine($"Nome: {nome}, Idade: {idade}");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
