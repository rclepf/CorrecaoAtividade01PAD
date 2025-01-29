class Program
	{
		public static void Main(string[] args)
		{
			bool respostaBool;
			string resposta;
			
			Console.Write("Digite 'sim' ou 'não': ");
			resposta = Console.ReadLine().ToLower();
			
			if (resposta == "sim")
				respostaBool = true;
			else
				respostaBool = false;
			
			Console.WriteLine("Você digitada foi {0} que é igual a {1}. ", resposta, respostaBool);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
