using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.App
{
    public class CalculadoraImp
    {
        
        public int Somar(int num1, int num2)
        
        {
            int res = num1 + num2;
            return res;
        }

         public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            return res;
        }

       
    }
}
    
