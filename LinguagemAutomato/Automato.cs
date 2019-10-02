using LinguagemAutomato.Model;
using LinguagemAutomato.Validation;
using LinguagemAutomato.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato
{
    class Automato
    {
        private static readonly Automato instance = new Automato();
        public Dictionary<char,List<Grafo>> dicionario = new Dictionary<char, List<Grafo>>();
        public Dictionary<Simbolo, List<Grafo>> automato = new Dictionary<Simbolo, List<Grafo>>();
        public Stack<char> operadores = new Stack<char>();


       //Implementação do padrão Singleton
        static Automato()
        {
            AdicionarGrafoHelper.Adicionar(Simbolo.UNIAO);
            AdicionarGrafoHelper.Adicionar(Simbolo.CONCATENACAO);
            AdicionarGrafoHelper.Adicionar(Simbolo.FECHO);

            AdicionarTransicaoHelper.Adicionar(Simbolo.UNIAO);
            AdicionarTransicaoHelper.Adicionar(Simbolo.CONCATENACAO);
            AdicionarTransicaoHelper.Adicionar(Simbolo.FECHO);
        }
        private Automato()
        { 
        }
        public static Automato Instance
        {
            get
            {
                return instance;
            }
        }

        public Dictionary<char, List<Grafo>> Gerar(string expressao)
        {
            LimparEstruturaDados();

            List<IRegras> regrasValidarExpressao = new List<IRegras> {
                new RegraParentese(),
                new RegraOperacao(),
                new RegraAlfabeto()
            };

            for(int i = 0; i < expressao.Length; i++)
            {
                foreach(var regra in regrasValidarExpressao)
                {
                    var caracter = expressao[i];

                    if (regra.Validar(caracter))
                    {
                        if (regra.GetType().Equals(typeof(RegraParentese)) || regra.GetType().Equals(typeof(RegraOperacao)))
                        {
                            if (!expressao[i].Equals((char)Simbolo.FECHA_PARENTESE))
                                operadores.Push(expressao[i]);
                            else
                            {
                                char operador = '\0';
                                operador = operadores.Pop();
                                CriarAutomato(operador);
                            }
                        }
                        else if (regra.GetType().Equals(typeof(RegraAlfabeto)))
                        {


                            if (dicionario.ContainsKey(caracter))
                            {
                                dicionario[caracter].Add(new Grafo {
                                    EstadoAtual = (char)Simbolo.ESTADO_INICIAL
                                });
                            }
                            else
                            {
                                dicionario.Add(caracter, new List<Grafo> {
                                    new Grafo
                                    {
                                        EstadoAtual = (char)Simbolo.ESTADO_INICIAL,
                                    }
                                });
                            }

                            int quantidadeGrafos = dicionario[caracter].Count;

                            dicionario[caracter][quantidadeGrafos-1].Transicoes.Add(new Transicao()
                            {
                                ElementoTransicao = expressao[i],
                                ProximoEstado = new List<Grafo>
                                {
                                    new Grafo
                                    {
                                        EstadoAtual = (char)Simbolo.ESTADO_FINAL
                                    }
                                }
                            });
                        }
                    }
                }
            }

            return dicionario;
        }

        private void CriarAutomato(char operador)
        {
            switch (operador)
            {
                case (char)Simbolo.UNIAO:
                    OperacoesAutomatoHelper.Uniao();
                    LimparEstruturaDados();
                    break;
                case (char)Simbolo.CONCATENACAO:
                    OperacoesAutomatoHelper.Concatenacao();
                    LimparEstruturaDados();
                    break;
                case (char)Simbolo.FECHO:
                    break;
            }
        }

        private void LimparEstruturaDados()
        {
            while (operadores.Count != 0)
            {
                operadores.Pop();
            }

            if (dicionario.Count != 0)
                dicionario.Clear();
        }
    }
}
