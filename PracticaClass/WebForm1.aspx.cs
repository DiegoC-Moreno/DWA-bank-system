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
            Session["Data"] = (DataTable) dt;
            Session["Datos"] = cuenta as Cuenta;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(this.TextBox3.Text);
            int year = Convert.ToInt32(this.TextBox4.Text);
            DateTime fVencimiento = new DateTime(year, mes, 01);
            this.cuenta.Nombre = this.TextBox1.Text;
            this.cuenta.NCuenta  = this.TextBox2.Text;
            this.cuenta.Saldo  = Convert.ToInt32(this.TextBox5.Text);
            this.cuenta.FechaExp = fVencimiento;
            //this.cuenta = new Cuenta
            //{
            //    Nombre = this.TextBox1.Text,
            //    NCuenta = this.TextBox2.Text,
            //    Saldo = Convert.ToInt32(this.TextBox5.Text),
            //    FechaExp = fVencimiento
            //};
            // this.Label2.Text = cuenta.nombre;
            Session["Datos"] = (Cuenta) cuenta;
        }

        public void RetiroBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Session["Datos"]);
            this.Label2.Text = this.cuenta.nombre;
        }

        public void AbonoBtn_Click(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            this.Label2.Text = this.cuenta.nombre;
        }
    }
}