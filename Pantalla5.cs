using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Pantalla5 : Form
    {
        public Pantalla5()
        {
            InitializeComponent();
        }
        
        private void numTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE ACEPTAN NUMEROS!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
            Datos.setMetodoTarjeta(true);

        }

        private void codTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE ACEPTAN NUMEROS!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
                

            }
            Datos.setMetodoTarjeta(true);
        }

        private void motEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("SOLO SE ACEPTAN NUMEROS!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                }
            Datos.setMetodoEfectivo(true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numTarjeta.Text == "" && codTarjeta.Text == "" && motEfectivo.Text == "")
                MessageBox.Show("DEBE ELEGIR UN METODO DE PAGO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Datos.getMetodoEfectivo()==true && Datos.getMetodoTarjeta()==true )
            {
                MessageBox.Show("SOLO PUEDE ELEGIR UN METODO DE PAGO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                motEfectivo.Text = null;
                codTarjeta.Text = null;
                numTarjeta.Text = null;
                Datos.setMetodoEfectivo(false);
                Datos.setMetodoTarjeta(false);

            }

            else
            {
                Datos.setMetodoPago(true);
                Datos.numerosTarjeta = numTarjeta.Text;
                Datos.codigoSeguridad = codTarjeta.Text;
                Datos.montoEfectivo = motEfectivo.Text;
                Close();
            }
            
                
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
