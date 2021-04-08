using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace PracticaClass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Cuenta cuenta = new Cuenta();
        DataTable dt = new DataTable();
        
        
        public void mostrar_datos()
        {
            dt = (DataTable)Session["Data"];
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
        public void Page_Load(object sender, EventArgs e)
        {
            
            if(Session["Data"] == null)
            {
                dt.Columns.AddRange(
                    new DataColumn[2]
                    {
                        new DataColumn("Fecha y hora", typeof(DateTime)),
                        new DataColumn("accion", typeof(string))
                    }
                );
            }

            if(Session["cuentaCliente"] == null)
            {
                Session["Datos"] =   cuenta;
            }
            Session["Data"] = dt;
           
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(this.TextBox3.Text);
            int year = Convert.ToInt32(this.TextBox4.Text);
            
            if(mes > 0 && mes <= 12)
            {
                DateTime fVencimiento = new DateTime(year, mes, 01);
                this.cuenta.Nombre = this.TextBox1.Text;
                this.cuenta.NCuenta = this.TextBox2.Text;
                this.cuenta.Saldo = Convert.ToInt32(this.TextBox5.Text);
                this.cuenta.FechaExp = fVencimiento;
                this.Label2.Text = cuenta.Nombre;
                this.saldo.Text = "$" + cuenta.Saldo.ToString();
                Session["cuentaCliente"] = cuenta;
                this.Cuentalbl.Text = this.TextBox2.Text;
                this.fechaVencimiento.Text = fVencimiento.ToString("MM/yyyy");
                this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.TextBox3.Text = "";
                this.TextBox4.Text = "";
                this.TextBox5.Text = "";
            }
            else
            {
                mes = 1;
                year = 1;
            }
            //this.cuenta = new Cuenta
            //{
            //    Nombre = this.TextBox1.Text,
            //    NCuenta = this.TextBox2.Text,
            //    Saldo = Convert.ToInt32(this.TextBox5.Text),
            //    FechaExp = fVencimiento
            //};
            // this.Label2.Text = cuenta.nombre;
            
        }

        public void RetiroBtn_Click(object sender, EventArgs e)
        {
            dt = (DataTable) Session["Data"];
            cuenta = (Cuenta) Session["cuentaCliente"];
            cuenta.retiro(Convert.ToDouble(this.monto.Text));
            //this.Label2.Text = cuenta.CantidadRetirado.ToString();
            this.saldo.Text = "$" + cuenta.Saldo.ToString();
           // dt.Rows.Add(DateTime.Now, "Se realizo un retiro de: $" + this.monto.Text);
            Session["Data"] = dt;
            Session["cuentaCliente"] = cuenta;
           // mostrar_datos();
        }

        public void AbonoBtn_Click(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            cuenta = (Cuenta)Session["cuentaCliente"];
            cuenta.Transacciones(this.transacciones.SelectedValue, Convert.ToDouble(this.monto.Text));
            this.saldo.Text = "$" + cuenta.Saldo.ToString();
            string texto = "Se realizo un " + this.transacciones.SelectedValue + " de: $" + this.monto.Text;
            //DateTime fecha = DateTime.Now;
           // dt.Rows.Add(fecha, texto);
            //mostrar_datos();
            Session["Data"] = dt;
            Session["cuentaCliente"] = cuenta;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cuenta = (Cuenta)Session["cuentaCliente"];
            string tipo = this.tiempo.SelectedValue;
            switch (tipo)   
            {
                case "dia":
                    string interes = cuenta.CalcInteres(Convert.ToInt32(this.cantidadDays.Text),Convert.ToInt32(this.Interes.Text), Convert.ToDouble(this.montoInteres.Text));
                    this.calcInteres.Text = "Calculo de interes es de: $" + interes;
                    break;
                case "mes":
                    int mes = Convert.ToInt32(this.cantidadDays.Text) * 30;
                    string interesMes = cuenta.CalcInteres(mes, Convert.ToInt32(this.Interes.Text), Convert.ToDouble(this.montoInteres.Text));
                    this.calcInteres.Text = "Calculo de interes es de: $" + interesMes;
                    break;
                case "año":
                    int year = Convert.ToInt32(this.cantidadDays.Text) * 365;
                    string interesYear = cuenta.CalcInteres(year, Convert.ToInt32(this.Interes.Text), Convert.ToDouble(this.montoInteres.Text));
                    this.calcInteres.Text = "Calculo de interes es de: $" + interesYear;
                    break;
            }
            Session["cuentaCliente"] = cuenta;
        }

        protected void AbonoBtn_Click1(object sender, EventArgs e)
        {
            cuenta = (Cuenta)Session["cuentaCliente"];
            cuenta.abono(Convert.ToDouble(this.monto.Text));
            this.saldo.Text = "$" + cuenta.Saldo.ToString();
            //dt.Rows.Add(DateTime.Now, "Se realizo un abono de: $" + this.monto.Text);
            //mostrar_datos();
            //Session["Data"] = dt;
            Session["cuentaCliente"] = cuenta;
        }
    }
}