using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class RepositórioCaixa
    {
      Caixa[] caixas;

        public void iserirCaixa(Caixa caixa)
        {
            int posição = obterPosiçãoVazia();
            caixas[posição] = caixa;         
        }
        public int obterPosiçãoVazia()

        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                    return i;
            }
            return -1;   
        }
        public void editar(int númeroParaEditar, Caixa caixa)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i].numero == númeroParaEditar)
                {
                    caixas[i].numero = númeroParaEditar;
                    caixas[i] = caixa;

                    break;
                }
            }
        }
        public void excluir(int numeroSelecionado)
        {

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i].numero == numeroSelecionado)
                {
                    caixas[i] = null;
                    break;
                }
            }
        }
    }
}
