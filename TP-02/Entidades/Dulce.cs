﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Dulce(EMarca marca, string codigo, ConsoleColor color) : base(codigo, marca, color)
        {
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        /// <summary>
        /// Devuelve un string con los datos de la clase base y la clase Dulce usando el metodo ToString.
        /// </summary>
        /// <param name="sb">Variable donde se guarda las cadenas</param>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
