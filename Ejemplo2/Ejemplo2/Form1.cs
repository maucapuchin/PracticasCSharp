using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables

        //int primerNumero, segundoNumero;
        //double resultado;

        #endregion

        #region Formulas

        private int sumar(int primerNumero, int segundoNumero) {
            return primerNumero + segundoNumero;
        }

        private int restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }

        private int multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }

        private double dividir (int primerNumero, int segundoNumero)
        {
            return primerNumero / segundoNumero;
        }
        #endregion


        #region Eventos

        private void btnSuma_Click(object sender, EventArgs e)
        {
            tBxResultado.Text = Convert.ToString(sumar(Convert.ToInt32(tBxPrimerNumero.Text), Convert.ToInt32(tBxSegundoNumero.Text)));
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            tBxResultado.Text = Convert.ToString(restar(Convert.ToInt32(tBxPrimerNumero.Text), Convert.ToInt32(tBxSegundoNumero.Text)));
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            tBxResultado.Text = Convert.ToString(multiplicar(Convert.ToInt32(tBxPrimerNumero.Text), Convert.ToInt32(tBxSegundoNumero.Text)));
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            tBxResultado.Text = Convert.ToString(dividir(Convert.ToInt32(tBxPrimerNumero.Text), Convert.ToInt32(tBxSegundoNumero.Text)));
        }

        #endregion



    }
}
