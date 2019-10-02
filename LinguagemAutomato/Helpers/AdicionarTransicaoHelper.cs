using LinguagemAutomato.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Helpers
{
    class AdicionarTransicaoHelper
    {
        public static void Adicionar(Simbolo simbolo)
        {
            Automato.Instance.automato[simbolo][0].Transicoes.Add(new Transicao()
            {
                ElementoTransicao = (char)Simbolo.PALAVRA_VAZIA,
                ProximoEstado = new List<Grafo>
                {
                    new Grafo
                    {
                        EstadoAtual = (char)Simbolo.PALAVRA_VAZIA
                    }
                }
            });
        }
    }
}
