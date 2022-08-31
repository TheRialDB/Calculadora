using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    public class Calculadora
    {
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public decimal res { get; set; }

        public decimal Calcular(string operacion)
        {
            if (operacion == "+")
            {
                res = num1 + num2;
                return res;
            }
            else if (operacion == "-")
            {
                res = num1 - num2;
                return res;
            }
            else if (operacion == "*")
            {
                res = num1 * num2;
                return res;
            }
            else if (operacion == "/")
            {
                res = num1 / num2;
                return res;
            }
            else
            {
                return 0;
            }
        }
    }
}
