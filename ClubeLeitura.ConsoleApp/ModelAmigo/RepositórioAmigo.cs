using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class RepositórioAmigo
    {
        public Amigo[] amigos;

        public void Inserir(Amigo amigo)
        {
            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;
        }
        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }
            return -1;
        }
        public void Editar(int numeroSelecioando, Amigo amigo)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numeroAmigo == numeroSelecioando)
                {
                    amigos[i].numeroAmigo = numeroSelecioando;
                    amigos[i] = amigo;

                    break;
                }
            }
        }
        public void Excluir(int numeroSelecionado)

        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numeroAmigo == numeroSelecionado)
                {
                    amigos[i] = null;
                    break;
                }
            }
        }
        public int ObterQtdAmigos()
        {
            int numeroAmigos = 0;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                    numeroAmigos++;
            }

            return numeroAmigos;
        }
        public Amigo[] SelecionarTodos()
        {
            int quantidadeAmigos = ObterQtdAmigos();

            Amigo[] amigosInseridos = new Amigo[quantidadeAmigos];

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                   amigosInseridos[i] = amigos[i];
            }

            return amigosInseridos;
        }

    }
}
