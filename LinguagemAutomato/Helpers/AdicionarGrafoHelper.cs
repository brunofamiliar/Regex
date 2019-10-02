using LinguagemAutomato.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Helpers
{
    class AdicionarGrafoHelper
    {
        static AdicionarGrafoHelper() { }
        public static void Adicionar(Simbolo simbolo)
        {
            Automato.Instance.automato.Add(simbolo, new List<Grafo> {
                new Grafo()
                {
                    EstadoAtual = (char)Simbolo.ESTADO_INICIAL,
                }
            });

        }
    }
}
