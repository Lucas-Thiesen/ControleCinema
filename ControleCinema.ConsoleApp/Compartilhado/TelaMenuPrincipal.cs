using ControleCinema.ConsoleApp.ModuloFuncionario;
using ControleCinema.ConsoleApp.ModuloGenero;
using ControleCinema.ConsoleApp.ModuloSala;
using ControleCinema.ConsoleApp.ModuloFilme;
using System;

namespace ControleCinema.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private IRepositorio<Funcionario> repositorioFuncionario;
        private TelaCadastroFuncionario telaCadastroFuncionario;

        private IRepositorio<Genero> repositorioGenero;
        private TelaCadastroGenero telaCadastroGenero;

        internal RepositorioSala RepositorioSala { get; }

        private TelaCadastroSala telaCadastroSala;

        internal RepositorioFilme RepositorioFilme { get; }

        private IRepositorio<Sala> repositorioSala;

        private  TelaCadastroFilme telaCadastroFilme;
        private IRepositorio<Filme> repositorioFilme;
        

      

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioFuncionario = new RepositorioFuncionario();
            telaCadastroFuncionario = new TelaCadastroFuncionario(repositorioFuncionario, notificador);

            repositorioGenero = new RepositorioGenero();
            telaCadastroGenero = new TelaCadastroGenero(repositorioGenero, notificador);

            RepositorioSala = new RepositorioSala();
            telaCadastroSala = new TelaCadastroSala(repositorioSala, notificador);

            RepositorioFilme = new RepositorioFilme();
            telaCadastroFilme = new TelaCadastroFilme(repositorioFilme, notificador);

        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Sessões de Cinema 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Funcionários");
            Console.WriteLine("Digite 2 para Gerenciar Gêneros de Filme");
            Console.WriteLine("Digite 3 para Gerenciar as salas");
            Console.WriteLine("Digite 4 para Gerenciar os Filmes");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela =  telaCadastroFuncionario;

            else if (opcao == "2")
                tela =  telaCadastroGenero;

            else if (opcao == "3")
                tela =  telaCadastroSala;

            else if (opcao == "4")
                tela =  telaCadastroFilme;

            else if (opcao == "5")
                tela =  null;

            return tela;
        }
    }
}
