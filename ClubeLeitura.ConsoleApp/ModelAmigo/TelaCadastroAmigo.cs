using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class TelaCadastroAmigo
    {
       public Amigo[] arrayAmigo;
        public int numeroAmigo;
        public Notificador notificador;
        public RepositórioAmigo repositorioAmigo;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Amigos");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
        private Amigo ObterAmigo()
        {
            Console.Write("Digite o nome do Amigo: ");
            string cor = Console.ReadLine();

            Console.Write("Digite o endereço do amigo: ");
            string etiqueta = Console.ReadLine();

            Amigo amigo = new Amigo();

            amigo.nomeAmigo = etiqueta;
            amigo.endereçoAmgio = cor;

            return amigo;
        }
        public void InserirNovoAmigo()
        {
            MostrarTitulo("Inserindo nova Caixa");

            Amigo novoAmigo = ObterAmigo();

            repositorioAmigo.Inserir(novoAmigo);

            notificador.ApresentarMensagem("Caixa inserida com sucesso!", "Sucesso");
        }
       
        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }
        public void EditarAmigo()
        {
            MostrarTitulo("Editando Amigo");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número do amigo que deseja editar: ");
            int numeroAmigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrayAmigo.Length; i++)
            {
                if (arrayAmigo[i].numeroAmigo == numeroAmigo)
                {
                    Amigo amigo = ObterAmigo();

                    
                    arrayAmigo[i] = amigo;
                    arrayAmigo[i].numeroAmigo = numeroAmigo;

                    break;
                }
            }

        }
        public void ExcluirAmigo()
        {
            MostrarTitulo("Excluindo Amigo");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número da caixa que deseja excluir: ");
            int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

            repositorioAmigo.Excluir(numeroSelecionado);

            notificador.ApresentarMensagem("Caixa excluída com sucesso", "Sucesso");
        }
        public void VisualizarAmigo(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Revistas");

            for (int i = 0; i < arrayAmigo.Length; i++)
            {
                if (arrayAmigo[i] == null)
                    continue;

                Amigo c = arrayAmigo[i];

                Console.WriteLine("Nome: " + c.nomeAmigo);
                Console.WriteLine("Endereço: " + c.endereçoAmgio);
                Console.WriteLine("Número: " +c.numeroAmigo);


                Console.WriteLine();
            }
        }
    }
}
