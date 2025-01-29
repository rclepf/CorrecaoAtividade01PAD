class Program
	{
		public static void Main(string[] args)
		{
		Console.Write("Digite um número decimal: ");
	        decimal numeroDecimal = decimal.Parse(Console.ReadLine());
	        Console.WriteLine("Você digitou: " + numeroDecimal);
			
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
			
		//O tipo decimal no C# é um tipo de dado numérico de alta precisão, utilizado principalmente para cálculos financeiros e monetários, onde a precisão é essencial para evitar erros de arredondamento.
			
		//Tipo	Tamanho (bits)	Precisão		Indicado para
		//float		32			~7 dígitos		Gráficos, jogos, simulações
		//double		64		~15-16 dígitos	Cálculos científicos, matemática complexa
		//decimal		128		~28-29 dígitos	Cálculos financeiros, contabilidade
		}
	}
