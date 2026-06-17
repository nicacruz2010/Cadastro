using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locadora_de_VHs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 10)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"          

░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

                Console.ResetColor();
                Console.WriteLine("\n Seja muito bem vindo !\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastro de Animes");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 2 - Cadastro de Supers");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 3 - Cadastro de séries");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Cadastro de locadora de VHS");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 5 - Cadastro de oficina mecânica");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 6 - Cadastro de livros");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 7 - Cadastro de restaurante cardapio");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 8 - Cadastro de jogos");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 9 - Cadastro de músicas");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 10 - SAIR");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastroAnimes();
                        break;
                    case 2:
                        cadastroSupers();
                        break;
                    case 3:
                        cadastroSeries();
                        break;

                    case 4:
                      cadastroLocadoraVHS();
                        break;

                    case 5:
                      Cadastrooficinamecânica();
                        break;

                    case 6:
                        Cadastrolivros();
                        break;

                    case 7:
                       Cadastrorestaurantecardapio();
                        break;

                    case 8:
                        CadastroJogos();
                        break;

                    case 9:
                        CadastroMusicas();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();    
                        Console.WriteLine(@"
░██████╗░█████╗░██╗██████╗░
██╔════╝██╔══██╗██║██╔══██╗
╚█████╗░███████║██║██████╔╝
░╚═══██╗██╔══██║██║██╔══██╗
██████╔╝██║░░██║██║██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝");



                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        static void cadastroAnimes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ▄▀█ █▄░█ █ █▀▄▀█ █▀▀ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀█ █░▀█ █ █░▀░█ ██▄ ▄█
");

            Console.WriteLine("\n Digite o título do anime: ");
            string tituloAnimes = Console.ReadLine();

            Console.WriteLine("\n Digite a qnt de episodios: ");
            double qntAnimes = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o ano do anime: ");
            string anoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite o personagem principal: ");
            string personagemAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a clasificacao do anime: ");
            string classificacaoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a categoria: ");
            string categoriaAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a avaliacao do anime: ");
            string avaliacaoAnime = Console.ReadLine();
        }
        static void cadastroSupers()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀ █░█ █▀█ █▀▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   ▄█ █▄█ █▀▀ ██▄ █▀▄ ▄█
");

            Console.WriteLine("\n Digite o nome poder: ");
            string nomeSupers = Console.ReadLine();

            Console.WriteLine("\n Digite o apelido do poder: ");
            string apelidoSupers = Console.ReadLine();

            Console.WriteLine("\n Digite a data de nascimento: ");
            string nascimentoSupers = Console.ReadLine();

            Console.WriteLine("\n Digite a altura : ");
            string alturaSupers = Console.ReadLine();

            Console.WriteLine("\n Digite o peso: ");
            string pesoSupers = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
            string gêneroSupers = Console.ReadLine();

            Console.WriteLine("\n Digite a habilidade: ");
            string habilidadeSupers = Console.ReadLine();

                 }
        static void cadastroSeries()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀ █▀▀ █▀█ █ █▀▀ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   ▄█ ██▄ █▀▄ █ ██▄ ▄█");

            Console.WriteLine("\n Digite o nome : ");
            string nomeSeries = Console.ReadLine();

            Console.WriteLine("\n Digite o apelido : ");
            string apelidoSerie = Console.ReadLine();

            Console.WriteLine("\n Digite a classificacao : ");
            string classificacaoSeries = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
           string gêneroSerie = Console.ReadLine();


        }
        static void cadastroLocadoraVHS()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █░░ █▀█ █▀▀ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █░█ █░█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   ▀▄▀ █▀█ ▄█");

            Console.WriteLine("\n Digite o nome: ");
            string nomeVhs = Console.ReadLine();

            Console.WriteLine("\n Digite a data do VHs: ");
            string dataVhs = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo: ");
            string codigoVhs = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
            string gêneroVhs = Console.ReadLine();

            Console.WriteLine("\n Digite a habilidade: ");
            string habilidadeVhs = Console.ReadLine();

        }
        static void Cadastrooficinamecânica()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀█ █▀▀ █ █▀▀ █ █▄░█ ▄▀█   █▀▄▀█ █▀▀ █▀▀ ▄▀█ █▄░█ █ █▀▀ ▄▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄█ █▀░ █ █▄▄ █ █░▀█ █▀█   █░▀░█ ██▄ █▄▄ █▀█ █░▀█ █ █▄▄ █▀█");

            Console.WriteLine("\n Digite o nome: ");
            string nomeOficina = Console.ReadLine();

            Console.WriteLine("\n Digite a peça: ");
            string peçaOficina = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo: ");
            string codigoOficina = Console.ReadLine();

            Console.WriteLine("\n Digite o valor: ");
            string valorOficina = Console.ReadLine();

                   }
        static void Cadastrolivros()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █░░ █ █░█ █▀█ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █ ▀▄▀ █▀▄ █▄█ ▄█");

            Console.WriteLine("\n Digite o nome: ");
            string nomeLivros = Console.ReadLine();

            Console.WriteLine("\n Digite a data do VHs: ");
            string dataLivros = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo: ");
            string codigoLivros = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
            string gêneroLivros = Console.ReadLine();

          
        }
        static void Cadastrorestaurantecardapio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀▀ █▀ ▀█▀ ▄▀█ █░█ █▀█ ▄▀█ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▄ ██▄ ▄█ ░█░ █▀█ █▄█ █▀▄ █▀█ █░▀█ ░█░ ██▄");

            Console.WriteLine("\n Digite o nome: ");
            string nomeRestaurante = Console.ReadLine();

            Console.WriteLine("\n Digite a data do VHs: ");
            string mesaRestaurante = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo pedido: ");
            string codigopedidoRestaurante = Console.ReadLine();

        }
        static void CadastroJogos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ░░█ █▀█ █▀▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▄█ █▄█ █▄█ ▄█");

            Console.WriteLine("\n Digite o nome: ");
            string nomeJogos = Console.ReadLine();

            Console.WriteLine("\n Digite a data dos jogos: ");
            string dataJogos = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo: ");
            string codigoJogos = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
            string gêneroJogos = Console.ReadLine();

            Console.WriteLine("\n Digite a habilidade: ");
            string habilidadeJogos = Console.ReadLine();


        }
        static void CadastroMusicas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▄▀█ █░█ █▀ █ █▀▀ ▄▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █░▀░█ █▄█ ▄█ █ █▄▄ █▀█ ▄█");

            Console.WriteLine("\n Digite o nome: ");
            string nomeMusica = Console.ReadLine();

            Console.WriteLine("\n Digite a data: ");
            string dataMusica = Console.ReadLine();

            Console.WriteLine("\n Digite o codigo: ");
            string codigoMusica = Console.ReadLine();

            Console.WriteLine("\n Digite o gênero: ");
            string gêneroMusica = Console.ReadLine();

            
        }
    }
}
