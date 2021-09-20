using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
		
  /*       static FilmeRepositorio repositoriof = new FilmeRepositorio(); */
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					
					// Filmes;
	                /*  case "0":
						ListarFilme();
						break;

						case "01":
						InserirFilme();
						break;

						case "02":
						AtualizarFilme();
						break;

								case "03":
						ExcluirFilme();
						break;

							case "05":
						VisualizarFilme();
						break; */
//series
					case "1":
						ListarSeries();
					
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("\n \t Obrigado por utilizar nossos serviços!!!");
			Console.ReadLine();
        }

		//file
 /* private static void ExcluirFilme()
		{
			Console.Write("\n Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceFilme);
		}
		  private static void VisualizarFilme()
		{
			Console.Write("\n Digite o id da série: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorio.RetornaPorId(indiceFilme);

			Console.WriteLine(filme);
		}

 private static void AtualizarFilme()
		{
			Console.Write("\n Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("\n Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("\n Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("\n Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("\n Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Filme atualizaFilme = new Filme(id: indiceFilme,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceFilme, atualizaFilme);
		}
  private static void ListarFilmes()
		{	
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var filme in lista)
			{
                var excluido = filme.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		} */

// serie
        private static void ExcluirSerie()
		{
			Console.Write("\n Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("\n Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("\n Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("\n Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("\n Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("\n Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("\n Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{	
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
		    Console.WriteLine("--------------------------");
			Console.WriteLine("Inserir nova série");
 	        Console.WriteLine("--------------------------");
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("\n Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("\n Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("\n Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("\n Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
	        Console.WriteLine("-------------------------------------");
			Console.WriteLine("Bem-Vindo(a) ao Cadastro de Séries!!!");
		    Console.WriteLine("-------------------------------------");
			Console.WriteLine("\n Informe a opção desejada:");
           /*  Console.WriteLine("\n 0- Listar Filmes");
			   Console.WriteLine("--------------------------");
			   	Console.WriteLine("01- Inserir novo filme");
				    Console.WriteLine("--------------------------");
						Console.WriteLine("02- Atualizar filme");
				    Console.WriteLine("--------------------------");
					Console.WriteLine("03- Excluir filme");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("05- Visualizar filme");
				    Console.WriteLine("--------------------------"); */
			Console.WriteLine(" 1- Listar séries");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("2- Inserir nova série");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("3- Atualizar série");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("4- Excluir série");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("5- Visualizar série");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("C- Limpar Tela");
				    Console.WriteLine("--------------------------");
			Console.WriteLine("X- Sair");	    
			Console.WriteLine("--------------------------");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
