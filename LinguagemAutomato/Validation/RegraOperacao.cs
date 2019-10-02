using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Validation
{
    class RegraOperacao : IRegras
    {
        public bool Validar(char caracter)
        {
            for (int i = 0; i < Model.Operadores.operandos.Length; i++)
            {
                if (caracter.Equals(Model.Operadores.operandos[i]))
                    return true;
            }

            return false;
        }
    }
}
