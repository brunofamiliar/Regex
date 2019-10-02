using LinguagemAutomato.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Helpers
{
    class OperacoesAutomatoHelper
    {
        static public void Uniao()
        {
            //ADICIONAR UMA PALAVRA VAZIA AO DICIONARIO
            Automato.Instance.dicionario.Add((char)Simbolo.PALAVRA_VAZIA, new List<Grafo> {
                new Grafo
                {
                    EstadoAtual = (char)Simbolo.ESTADO_INICIAL
                }
            });

            //DETERMINAR A QUANTIDADE DE ESTADOS DO AUTOMATO
            const int quantidadeEstados = 6;

            //PEGAR TODAS AS LETRAS DIGITADAS
            List<char> letras = ObterLetras();

            //INDICE GRAFO INICIAL
            int primeiroElemento = 0;

            //PERCORER CADA ESTADO DO AUTOMATO
            for(int estado = 0; estado < quantidadeEstados; estado++)
            {
                var elementoTransicao = Automato.Instance.automato[Simbolo.UNIAO][primeiroElemento].Transicoes[primeiroElemento].ElementoTransicao;

                if(elementoTransicao == (char)Simbolo.PALAVRA_VAZIA)
                {

                }
            }
        }

        static public void Concatenacao()
        {

        }

        static List<char> ObterLetras() {
            List<char> letras = new List<char>();

            foreach (KeyValuePair<char, List<Grafo>> caracter in Automato.Instance.dicionario)
            {
                letras.Add(caracter.Key);
            }

            return letras;
        }
    }
}
