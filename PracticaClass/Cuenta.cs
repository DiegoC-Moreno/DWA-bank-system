using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaClass
{
    public class Cuenta
    {
        public string nombre;
        private string nCuenta;
        private DateTime fExpiracion;
        private double saldo,cantidadRetirado;
        public bool activaCuenta;
        public Dictionary<DateTime, string> historial;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre  =  value;
            }
        }
        public string NCuenta
        {
            get
            {
                return nCuenta;
            }
            set
            {
                nCuenta = value;
            }
        }
        public DateTime FechaExp
        {
            get
            {
                return fExpiracion;
            }
            set
            {
                fExpiracion = value;
            }
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public double CantidadRetirado
        {
            get
            {
                return cantidadRetirado;
            }
            set
            {
                cantidadRetirado = value;
            }
        }
       // protected string password;
      
        public Cuenta()
        {

        }

        //public Cuenta(string nombre, string nCuenta, DateTime fExpiracion, double saldo) {
        //    this.nombre = nombre;
        //    this.nCuenta = nCuenta;
        //    this.fExpiracion = fExpiracion;
        //    this.saldo = saldo;
        //    this.historial = new Dictionary<DateTime, string>();
        //}

        public void retiro(double cantidad, DateTime fecha) {
            if (fecha < DateTime.Now)
            {
                if (cantidad < 400 && cantidad < saldo)
                {
                    if (cantidad < 1)
                    {
                        if (cantidadRetirado <= 1000)
                        {
                            this.saldo -= cantidad;
                            historial.Add(DateTime.Now, "Se realizo un retiro de: $" + cantidad);
                            this.cantidadRetirado += cantidad;
                        }
                        Console.WriteLine("Quiere Proceder que se le quede innactivo su cuenta?");
                    }
                }
            }
            else
            {
                Console.WriteLine("su tarjeta esta vencida");
            }
        }

        public void abono(double cantidad, DateTime fecha)
        {
            if (fecha < DateTime.Now && activaCuenta)
            {
                this.saldo += cantidad;
                historial.Add(DateTime.Now, "Se realizo un abono de: $" + cantidad);
            }   
            else
            {
                Console.WriteLine("su tarjeta esta vencida");
            }
        }

        public String CalcInteres(int dias, int interes)
        {
            if (activaCuenta == true)
            {
                return (((saldo * interes * dias) / 365) / 12).ToString();
            }
            else {
                return "su cuenta no esta activa";
            }
        }

        public String Transacciones(string tipo, double monto)
        {
            if (activaCuenta) {
                switch (tipo)
                {
                    case "cobro de cheques":
                        this.saldo += monto;
                        this.historial.Add(DateTime.Now, "Se realizo un cobro de cheques de un total de $" + monto);
                        break;
                    case "pago a cuenta de luz":
                        this.saldo += monto;
                        this.historial.Add(DateTime.Now, "Se realizo un pago a cuenta de luz de un total de $" + monto);
                        break;
                    case "transferencia":
                        if (saldo > monto)
                        {
                            this.saldo -= monto;
                            this.historial.Add(DateTime.Now, "Se realizo un transferencia de un total de $" + monto);
                        }
                        break;

                }
                return "Transaccion realizada";
            }
            else
            {
                return "Su Cuenta no se encuentra activa";
            }
        } 
    }
}