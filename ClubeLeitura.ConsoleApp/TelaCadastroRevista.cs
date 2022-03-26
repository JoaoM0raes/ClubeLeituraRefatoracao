using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    public class TelaCadastroRevista
    {
        
        public int numeroRevista = 0;
        Notificador notificador = new Notificador();
        RepositorioRevista repositorioRevista = new RepositorioRevista();
        

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Caixas");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaRevista()
        {
            Console.WriteLine("Inserindo Nova Revista");
            Revista revista= iserirRevista();
            repositorioRevista.inserirRevista(revista);

        }
        public Revista iserirRevista()
        {
            string digitado = "";
            Revista novaRevista=new Revista();
            Console.WriteLine("Escreva o nome da revista");
            digitado=Console.ReadLine();
            novaRevista.nomeRevista = digitado;
            novaRevista.numeroRevista = ++numeroRevista;
            return novaRevista; 
        }
        public void EditarRevista()
        {

            Console.WriteLine("Digite o número da revista para editar");
            int a = Convert.ToInt32(Console.ReadLine());
          
            Revista revista=iserirRevista();
            repositorioRevista.editarRevista(a,revista);
            
        }
        public void ExcluirRevista()
        {
            Console.WriteLine("Escreva o numero da revista para exluir");       
            int a = Convert.ToInt32(Console.ReadLine());
            repositorioRevista.excluirRevista(a);   
        }
        
        public void VisualizarRevistas()
        {
        }
    }
}
