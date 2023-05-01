using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_final
{
    
    public partial class Form1 : Form
    {
        //Pantalla2 ventana = new Pantalla2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == "" && Contraseña.Text == "")
            {

                Datos.setInicio(true);
                Close();
                
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }

            //Datos.nombreUsuario = Usuario.Text;
            
        }
    }
}
