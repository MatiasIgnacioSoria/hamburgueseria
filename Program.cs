using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pantalla3());
        }
    }
    
     abstract class Producto
    {
        private int id;
        static private int precio=15;
        
        public Producto(int id)
        {
            this.id = id;
        }

        abstract public double getPrecio();
        
       
             
    }
    class ClasicBurger : Producto
    {
        private int id;
       static private double precio;
        private string descripcion;
        

        public ClasicBurger(int id) : base(id)
        {
            this.id = id;
            precio =49;
            descripcion = "pan,medallon,lechuga,tomate,cebolla";
            
        }
        public override string ToString()
        {
            return "ClasicBurger      $49";
        }
       public override double getPrecio()
        {
            return precio;
        }
    }

    class CheeseBurger : Producto
    {
        private int id;
        private double precio;
        private string descripcion;


        public CheeseBurger(int id) : base(id)
        {
            this.id = id;
            precio = 49;
            descripcion = "pan,medallon y cheddar";
        }

        public override string ToString()
        {
            return "CheeseBurger      $49";
        }
        public override double getPrecio()
        {
            return precio;
        }
    }
    class DobleCheeseBurger : Producto
    {
        private int id;
        private double precio;
        private string descripcion;

        public DobleCheeseBurger(int id) : base(id)
        {
            this.id = id;
            precio = 59;
            descripcion = "pan,doble medallon y doble cheddar";

            
        }
        public override string ToString()
        {
            return "DobleCheeseBurger $59";
        }
        public  override double getPrecio()
        {
            return precio;
        }
    }

    class OnionCheeseBurger : Producto
    {
        private int id;
        private double precio;
        private string descripcion;
        public OnionCheeseBurger(int id ): base(id)
        {
            this.id = id;
            precio = 55;
            descripcion = "pan,medallon,cheddar y cebolla caramelizada";
        }
        public override string ToString()
        {
            return "OnionCheeseBurger $55";
        }
        public override double getPrecio()
        {
            return precio;
        }
    }
    class PapasRegulares : Producto
    {
        private int id;
        private double precio;
        private string descripcion;
        public PapasRegulares(int id) : base(id)
        {
            this.id = id;
            precio = 15;
            descripcion = "papas fritas y sal";
        }
        public override string ToString()
        {
            return "PapasRegulares    $15";
        }
        public  override double getPrecio()
        {
            return precio;
        }
    }
    class PapasGrandes : Producto
    {
        private int id;
        private double precio;
        private string descripcion;
        public PapasGrandes(int id) : base(id)
        {
            this.id = id;
            precio = 23;
            descripcion = "papas fritas y sal";
        }
        public override string ToString()
        {
            return "PapasGrandes      $23";
        }
        public  override double getPrecio()
        {
            return precio;
        }
    }
    class PapasConCheddar : Producto
    {
        private int id;
        private double precio;
        private string descripcion;
        public PapasConCheddar(int id) : base(id)
        {
            this.id = id;
            precio = 25;
            descripcion = "papas fritas y cheddar liquido";
        }
        public override string ToString()
        {
            return "PapasConCheddar   $25";
        }
        public  override double getPrecio()
        {
            return precio;
        }
    }

    class Agua : Producto
    {
        private int id;
        private double precio;
        
        public Agua(int id) : base(id)
        {

            this.id = id;
            precio= 15;
        }
        public override string ToString()
        {
            return "Agua              $15";
        }
        public  override double getPrecio()
        {
            return precio;
        }

    }
    class CocaCola : Producto
    {
        private int id;
        private double precio;
        
        public CocaCola(int id) : base(id)
        {

            this.id = id;
            precio = 10;
        }
        public override string ToString()
        {
            return "CocaCola          $10";
        }
        public  override double getPrecio()
        {
            return precio;
        }

    }
    class Sprite : Producto
    {
        private int id;
        private double precio;
        
        public Sprite(int id) : base(id)
        {

            this.id = id;
            precio = 10;
        }
        public override string ToString()
        {
            return "Sprite            $10";
        }
        public  override double getPrecio()
        {
            return precio;
        }

    }
    class Fanta : Producto
    {
        private int id;
        private double precio;
        
        public Fanta(int id) : base(id)
        {

            this.id = id;
            precio = 10;
        }
        public override string ToString()
        {
            return "Fanta             $10";
        }
        public override double getPrecio()
        {
            return precio;
        }

    }
}

