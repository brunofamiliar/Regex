using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato
{
    enum Simbolo
    {
        ABRE_PARENTESE = '(',
        FECHA_PARENTESE = ')',
        UNIAO = '+',
        CONCATENACAO = '.',
        FECHO = '*',
        PALAVRA_VAZIA = '@',
        ESTADO_INICIAL = '0',
        ESTADO_FINAL = 'F'
    }
}
