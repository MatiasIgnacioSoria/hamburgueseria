using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_final
{
    

    public partial class Pantalla2 : Form
    {
        //Pantalla3 pantalla = new Pantalla3();
        //List<Producto> produtos = new List<Producto>();

        //List<string> nombrePedido = new List<string>();
        //List<double> precios = new List<double>();
        private double total = 0;
        private string linea;





        public Pantalla2()
        {
            InitializeComponent();
            
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //botones de las opciones del menu
        #region Productos
        private void cheeseburger_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new CheeseBurger(2));
            Datos.Precios.Add(49);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;
            
            //nombrePedido.Add("CheeseBurger  ");
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;

        }

        private void doblecheeseburger_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new DobleCheeseBurger(3));

            Datos.Precios.Add(59);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void ClasicBurger_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new ClasicBurger(1));
            Datos.Precios.Add(49);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;


            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void onioncheeseburger_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new OnionCheeseBurger(5));
            Datos.Precios.Add(55);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void papasRegulares_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new PapasRegulares(6));
            Datos.Precios.Add(15);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;


            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new PapasGrandes(7));
            Datos.Precios.Add(23);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void PapasconCheddar_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new PapasConCheddar(8));

            Datos.Precios.Add(25);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void CocaCola_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new CocaCola(10));

            Datos.Precios.Add(10);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void Sprite_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new Sprite(11));

            Datos.Precios.Add(10);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void Agua_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new Agua(9));

            Datos.Precios.Add(15);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }

        private void Fanta_Click(object sender, EventArgs e)
        {
            Datos.produtos.Add(new Fanta(12));
            

            Datos.Precios.Add(10);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;

            
            Pedido.DataSource = null;
            Pedido.DataSource = Datos.produtos;
        }
        #endregion

        private void Total_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (double x in Datos.Precios)
                {

                    total += x;
                }
                linea = total + string.Empty;
                label6.Text = "$" + linea;
                total = 0;
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("El numero es demaciado grande, se seteara total= 0");
                total = 0;
            }    
            
            //precios.Add(total);
            //Precio.DataSource = null;
            //Precio.DataSource = precios;
        }
        //boton para general el ticket
        private void Siguiente_Click(object sender, EventArgs e)
        {


            Datos.setPedido(true);
            Datos.final = total;
            Close();

        }
        

        //validaciones para los metodos de entrega

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.produtos.Clear();
            Datos.Precios.Clear();
            total = 0;
            Pedido.DataSource = null;
            label6.Text = null;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
