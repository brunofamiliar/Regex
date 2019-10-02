using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Validation
{
    class RegraParentese : IRegras
    {
        public bool Validar(char caracter)
        {
            if (caracter.Equals('(') || caracter.Equals(')'))
                return true;
            return false;
        }
    }
}
