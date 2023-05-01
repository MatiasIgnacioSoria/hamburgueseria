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
    public partial class Pantalla4 : Form
    {
        public Pantalla4()
        {
            InitializeComponent();
        }
        //direccion.Text !="" && numeracion.Text!="" && entreCalles.Text!="" && nombre.Text !=""&&celular.Text != "" && 
        #region text

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pantalla4_Load(object sender, EventArgs e)
        {

        }

        private void entreCalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void celular_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void guardarEntrega_Click(object sender, EventArgs e)
        {
            if(Datos.getMetodoDelivery()==true && Datos.getMetodoTake()==true)
            {
                MessageBox.Show("SOLO PUEDE COMPLETAR UN METODO DE ENTREGA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                direccion.Text = null;
                numeracion.Text = null;
                entreCalles.Text = null;
                nombre.Text = null;
                celular.Text = null;
                Datos.setMetodoDelivery(false);
                Datos.setMetodoTake(false);
            }
            else if(direccion.Text == "" && numeracion.Text == "" && entreCalles.Text == "" && nombre.Text == "" && celular.Text == "")
                MessageBox.Show("DEBE COMPLETAR UN METODO DE ENTREGA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Datos.setMetodoEntrega(true);
                Datos.direccion = direccion.Text;
                Datos.numeracion = numeracion.Text;
                Datos.entreCalles = entreCalles.Text;
                Datos.nombre = nombre.Text;
                Datos.celular = celular.Text;
                Close();
            }
            
            
        }
        

        private void direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
                if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    MessageBox.Show("SOLO SE ACEPTAN LETRAS!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                }
           
            
             Datos.setMetodoDelivery(true);


        }

        private void numeracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("SOLO SE ACEPTAN NUMEROS!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                }
            

            
             Datos.setMetodoDelivery(true);




        }

        private void entreCalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            //{
            //    MessageBox.Show("SOLO SE ACEPTAN LETRAS!!!");
            //    e.Handled = true;
            //    return;
            //}
            
             Datos.setMetodoDelivery(true);

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    MessageBox.Show("SOLO SE ACEPTAN LETRAS!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                }
                
            
                
             Datos.setMetodoTake(true);


        }

        private void celular_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE ACEPTAN NUMEROS!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

                
            }

            
             Datos.setMetodoTake(true);

        }

        private void salir_Click(object sender, EventArgs e)
        {
           
            Close();
        }
    }
}
