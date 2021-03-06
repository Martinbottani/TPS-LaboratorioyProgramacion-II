﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numDecimal = new Numero(0);
            lblResultado.Text = numDecimal.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numBinario = new Numero(10);
            lblResultado.Text = numBinario.BinarioDecimal(lblResultado.Text);
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double result;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            result = Calculadora.Operar(num1, num2, operador);
            return result;
        }
    }
}
