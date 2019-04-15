using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retorno;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            else
            {
                retorno = "+";
            }
            return retorno;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result = 0;
            string aux;
            aux = Calculadora.ValidarOperador(operador);
            if (aux == "+")
            {
                result = num1 + num2;
            }
            else if (aux == "-")
            {
                result = num1 - num2;
            }
            else if (aux == "*")
            {
                result = num1 * num2;

            }
            else if (aux == "/")
            {
                result = num1 / num2;
                if (Double.IsInfinity(result))
                {
                    result = double.MinValue;
                }
            }
            return result;
        }
    }
}
