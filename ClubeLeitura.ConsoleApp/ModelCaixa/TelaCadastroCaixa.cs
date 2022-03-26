
using System;

namespace ClubeLeitura.ConsoleApp
{
    public class TelaCadastroCaixa
    {
        public Caixa[] caixas;
        public int numeroCaixa;
        public Notificador notificador;
        RepositórioCaixa repositórioCaixa;

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

        public void InserirNovaCaixa()
        {
            MostrarTitulo("Inserindo nova Caixa");
              Caixa caixa = ObterCaixa();
            bool caixaExiste = false;
            string etiqueta=caixa.etiqueta ;
            do
            {
                caixaExiste = false;
               for (int i = 0; i < caixas.Length; i++)
			   {
                if (caixas[i]!=null && caixas[i].etiqueta == etiqueta)
                {
                    caixaExiste=true;
                    break;
                }
                    
			    }
            if (caixaExiste)
            {
                notificador.ApresentarMensagem("Etiqueta ja utilizada","Erro")   ;
                     Console.Write("Digite a etiqueta: ");
                    etiqueta = Console.ReadLine();
            }

            }while (caixaExiste);
          
           
             repositórioCaixa.iserirCaixa(caixa);
            caixa.numero = ++numeroCaixa;


            notificador.ApresentarMensagem("Caixa inserida com sucesso!", "Sucesso");
        }

        private Caixa ObterCaixa()
        {
            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine();

            Console.Write("Digite a etiqueta: ");
            string etiqueta = Console.ReadLine();

            Caixa caixa = new Caixa();

            caixa.etiqueta = etiqueta;
            caixa.cor = cor;

            return caixa;
        }

        public void EditarCaixa()
        {
            MostrarTitulo("Editando Caixa");
            bool temCaixa=VisualizarCaixas("pesquisando");
            if (temCaixa == false)
            {
                  notificador.ApresentarMensagem("Nenhuma caixa cadastrada para editar ","Atencao");
                return;
            }
            

            Console.Write("Digite o número da caixa que deseja editar: ");
            int numeroCaixa = Convert.ToInt32(Console.ReadLine());
            bool numeroCaixas = false;
            do
            {
                numeroCaixas = false;
                for (int i = 0; i < caixas.Length; i++)
                {
                    if (caixas[i] != null)
                    {
                        if (caixas[i].numero == numeroCaixa)
                        {
                            numeroCaixas = true;
                            break;
                        }
                    }
                }
                if (numeroCaixas == false)
                {
                    notificador.ApresentarMensagem("Numero inválido", "Erro");
                }
            } while (numeroCaixas);
          

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i].numero == numeroCaixa)
                {
                    Caixa caixa = ObterCaixa();

                    caixas[i].numero = numeroCaixa;
                    caixas[i] = caixa;

                    break;
                }
            }

            notificador.ApresentarMensagem("Caixa editada com sucesso", "Sucesso");
        }

        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public void ExcluirCaixa()
        {
            MostrarTitulo("Excluindo Caixa");

             bool temCaixa=VisualizarCaixas("pesquisando");
            if (temCaixa == false)
            {
                 notificador.ApresentarMensagem("Nenhuma caixa cadastrada para excluir ","Atencao");
                return;
            }

            Console.Write("Digite o número da caixa que deseja excluir: ");
            int numeroCaixa = Convert.ToInt32(Console.ReadLine());
            repositórioCaixa.excluir(numeroCaixa);

            notificador.ApresentarMensagem("Caixa excluída com sucesso", "Sucesso");
        }

        public bool VisualizarCaixas(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Revistas");

            
            int quantidadeCaixasRegistradas = 0;
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    quantidadeCaixasRegistradas++;
                }
            }
            if (quantidadeCaixasRegistradas == 0)
            {

                return false;
            }

            for (int i = 0; i < caixas.Length; i++)
            {
                Caixa c = caixas[i];
                if (caixas[i] == null)
                    continue;

          

                Console.WriteLine("Número: " + c.numero);
                Console.WriteLine("Cor: " + c.cor);
                Console.WriteLine("Etiqueta: " + c.etiqueta);

                Console.WriteLine();
                
            }
            return true;
        }

        

        
    }
}