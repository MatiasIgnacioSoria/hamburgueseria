using Proyecto_final;
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

namespace Proyecto_final
{
    public partial class Pantalla3 : Form
    {
        private Form formularioActivo = null;

        
        
        

        public Pantalla3()
        {
            InitializeComponent();
            Diseño();
        }

        private void Diseño()
        {
            PanelSubMenuSesion.Visible = false;
            PanelPedidos.Visible = false;

        }
        private void ocultarSubMenu()
        {
            if (PanelSubMenuSesion.Visible == true)
                PanelSubMenuSesion.Visible = false;
            if (PanelPedidos.Visible == true)
                PanelPedidos.Visible = false;

        }
        private void mostrarSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                ocultarSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void mostrarFormularios(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelForms.Controls.Add(formularioHijo);
            panelForms.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }
        #region menuSesion

        private void sesion_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelSubMenuSesion);
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Form1());

            ocultarSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.setInicio(false);

            ocultarSubMenu();

        }
        #endregion 


        #region menuPedidos


        private void pedidos_Click(object sender, EventArgs e)
        {
            if (Datos.getInicio() == true)
            {
                mostrarSubMenu(PanelPedidos);

            }
            else MessageBox.Show("DEBE INICIAR SESIÓN  ");

        }

        private void tomaPedidos_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Pantalla2());

            //ocultarSubMenu();

        }

        private void metodoEntrega_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Pantalla4());

            //ocultarSubMenu();

        }

        private void metodoPago_Click(object sender, EventArgs e)
        {

            mostrarFormularios(new Pantalla5());
            //ocultarSubMenu();

        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImprimirTicket();
        }
        private void ImprimirTicket()
        {
            Random r = new Random();
            Random r2 = new Random();
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");

            if (Datos.getpedido()== true && Datos.getMetodoPago()==true && Datos.getMetodoEntrega()==true)
            {
                StreamWriter text = new StreamWriter(@"Ticket.txt");

                text.WriteLine("SMART SOLUTIONS");
                text.WriteLine(" ");
                text.WriteLine(" ");
                text.WriteLine(" ");
                text.WriteLine("Ticket N°: " + "01-" + r.Next(1, 102) + "-" + r2.Next(1000, 9999));
                text.WriteLine("  ");
                text.WriteLine("Fecha: " + date + "      Hora: " + time);
                text.WriteLine(" ");
                text.WriteLine("-----------------------------------");

                foreach (Producto produto in Datos.produtos) text.WriteLine(produto);
                text.WriteLine("-----------------------------------");

                text.WriteLine("TOTAL: " + "           $" + Datos.final.ToString());
                text.WriteLine(" ");
                text.WriteLine("-----------------------------------");




                if (Datos.getMetodoDelivery() == true)
                {
                    text.WriteLine("DOMICILIO DE ENTREGA");
                    text.WriteLine("Direccion: " + Datos.direccion + "  " + "Numeracion: " + Datos.numeracion + "  " + "Entre Calles: " + Datos.entreCalles);
                }
                else
                {
                    text.WriteLine("DATOS PARA EL TAKE AWAY");
                    text.WriteLine("Nombre: " + Datos.nombre + "  " + "Celular: " + Datos.celular);
                }





                text.WriteLine("-----------------------------------");

                text.WriteLine("METODO DE PAGO");

                text.WriteLine("Tarjeta De Debito: " + Datos.numerosTarjeta + " Efectivo Abona con: $" + Datos.montoEfectivo);




                text.Close();



                Process.Start(@"Ticket.txt");
            }
            else MessageBox.Show("PRIMERO DEBE COMPLETAR TODOS LOS PASOS DEL PEDIDO, SI TENIA UN PEDIDO EN PROCESO ESTE FUE ELIMINADO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Datos.setMetodoTake(false);
            Datos.setMetodoDelivery(false);
            Datos.setMetodoPago(false);
            Datos.setMetodoEntrega(false);
            Datos.produtos.Clear();
            Datos.Precios.Clear();


        }
        
        private void NombreUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            //NombreUsuario.Text = Datos.nombreUsuario;
        }

        private void NombreUsuario_TextAlignChanged(object sender, EventArgs e)
        {
           // NombreUsuario.Text = Datos.nombreUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}

