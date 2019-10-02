using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Model
{
    class Transicao
    {
        List<Grafo> proximoEstado;
        char elementoTransicao;

        public List<Grafo> ProximoEstado { get => proximoEstado; set => proximoEstado = value; }
        public char ElementoTransicao { get => elementoTransicao; set => elementoTransicao = value; }
    }
}
