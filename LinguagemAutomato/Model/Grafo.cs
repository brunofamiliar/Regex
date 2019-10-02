using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Model
{
    class Grafo
    {
        char estadoAtual;
        List<Transicao> transicoes = new List<Transicao>();

        public char EstadoAtual { get => estadoAtual; set => estadoAtual = value; }
        public List<Transicao> Transicoes { get => transicoes; }
    }
}
