using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double primerNumero, segundoNumero, resultado;
            try
            {
                primerNumero = double.Parse(textBox1.Text);
                segundoNumero = double.Parse(textBox2.Text);
                resultado = primerNumero / segundoNumero;
                MessageBox.Show(resultado.ToString());
            }
            catch (DivideByZeroException ex)
            {
                //throw new Exception("No puedes dividir entre cero");
                MessageBox.Show("No puedes dividir entre cero", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(ex.Message);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor ingresa números"); 
            }
          
            /*finally
            {
                MessageBox.Show("Finalización de la Excepción");
            }*/

        }
    }
}
