using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class RepositorioRevista
    {
        Revista[] revistas;
        Notificador notificador;

        public void inserirRevista(Revista revista)
        {
            int posição = obterPosiçãoVazia();
            revistas[posição] = revista;
        }
        public void editarRevista(int numeroRevista, Revista revista)
        {
            bool revistaExiste = false;
            do
            {
                revistaExiste = false;
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i].numeroRevista == numeroRevista)
                    {
                        revistaExiste = true;
                        break;
                    }
                }
                if (revistaExiste == false)
                {
                    notificador.ApresentarMensagem("Numero inválido", "Erro");
                }
            } while (revistaExiste);
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i].numeroRevista == numeroRevista)
                {
                     revistas[i].numeroRevista = numeroRevista;
                    revistas[i] = revista;
                    break;
                }
            }
        }
        public int obterPosiçãoVazia()
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i]==null)
                {
                    return i;
                }
            }
            return -1;

        }
        public void excluirRevista(int numeroRevista)
        {
            bool revistaExiste = false;
            do
            {
                revistaExiste = false;
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i].numeroRevista == numeroRevista)
                    {
                        revistaExiste = true;
                        break;
                    }
                }
                if (revistaExiste == false)
                {
                    notificador.ApresentarMensagem("Numero inválido", "Erro");
                }
            } while (revistaExiste);
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i].numeroRevista == numeroRevista)
                {
                    revistas[i] = null;
                    break;
                }
            }
        }
    }
}
