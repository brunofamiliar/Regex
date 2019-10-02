using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemAutomato.Validation
{
    class RegraAlfabeto : IRegras
    {
        public bool Validar(char caracter)
        {
            
            for(int i = 0; i < Model.Alfabeto.letras.Length; i++)
            {
                if (caracter.Equals(Model.Alfabeto.letras[i]))
                    return true;
            }

            return false;
        }
    }
}
