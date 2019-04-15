using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            SetNumero = Convert.ToString(0);
        }

        public Numero(double numero)
        {
            SetNumero = Convert.ToString(numero);
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        public static double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            int i;
            int contadorPuntos = 0;
            int contadorGuiones = 0;
            bool flag = true;
            for(i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] == '.' && contadorPuntos == 0)
                {
                    if (strNumero[i] == '.')
                    {
                        strNumero = strNumero.Replace('.', ',');
                    }
                    contadorPuntos = 1;
                    i++;
                }
                if (strNumero[i] == '-' && contadorGuiones == 0)
                {
                    contadorGuiones = 1;
                    i++;    
                }
                if (strNumero[i] < '0' || strNumero[i] > '9')
                {
                    retorno = 0;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Double.TryParse(strNumero, out retorno);
            }
            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero + n2.numero;
            return result;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero - n2.numero;
            return result;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero * n2.numero;
            return result;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero / n2.numero;
            return result;
        }

        public string BinarioDecimal(string binario)
        {
            string cadena = "";
            double result = 0;
            double potencia = 0;
            int i;
            bool flag = true;
            for (i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '0')
                {
                    potencia++;
                }
                else if (binario[i] == '1')
                {
                    result = result + (Math.Pow(2, potencia) * 1);
                    potencia++;
                }
                else
                {
                    cadena = "Valor invalido";
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                cadena = Convert.ToString(result);
            }
            return cadena;
        }

        public string DecimalBinario(double numero)
        {
            string cadena = "";
            int aux = (int)numero;
            if (aux > 0)
            {
                while (aux > 0)
                {
                    if (aux % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    aux = aux / 2;
                }
            }
            else
            {
                cadena = "Valor invalido";
            }
            return cadena;
        }

        public string DecimalBinario(string numero)
        {
            double convert;
            double.TryParse(numero, out convert);
            return DecimalBinario(convert);
        }
    }
}

