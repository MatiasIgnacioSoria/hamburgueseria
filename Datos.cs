using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    internal class Datos
    {
        static public List<Producto> produtos = new List<Producto>();
        static public List<double> Precios = new List<double>();

        static public string direccion, numeracion, entreCalles, nombre, celular, numerosTarjeta, codigoSeguridad, montoEfectivo ;
        
        static public double final;
        static private bool inicioSesion=false, tomoPedido = false, metodoDelivery = false, metodoEntrega = false, metodoPago = false,metodoTake=false,metodoTarjeta=false,metodoEfectivo=false;

       
        static public void setInicio(bool t)
        {
            inicioSesion = t;
        }
        static public bool getInicio()
        {
            return inicioSesion;
        }
        
       
        static public void setPedido(bool t)
        {
            tomoPedido = t;
        }
        static public bool getpedido()
        {
            return tomoPedido;
        }
        static public void setMetodoDelivery(bool t)
        {
            metodoDelivery = t;
        }
        static public bool getMetodoDelivery()
        {
            return metodoDelivery;
        }
        static public void setMetodoEntrega(bool t)
        {
            metodoEntrega = t;
        }
        static public bool getMetodoEntrega()
        {
            return metodoEntrega;
        }
        static public void setMetodoPago(bool t)
        {
            metodoPago = t;
        }
        static public bool getMetodoPago()
        {
            return metodoPago;
        }
        static public void setMetodoTake(bool t)
        {
            metodoTake = t;
        }
        static public bool getMetodoTake()
        {
            return metodoTake;
        }
        static public void setMetodoTarjeta(bool t)
        {
            metodoTarjeta = t;
        }
        static public bool getMetodoTarjeta()
        {
            return metodoTarjeta;
        }
        static public void setMetodoEfectivo(bool t)
        {
            metodoEfectivo = t;
        }
        static public bool getMetodoEfectivo()
        {
            return metodoEfectivo;
        }
    }
}
