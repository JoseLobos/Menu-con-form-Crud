using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pagina_web_sistema_de_ventas
{
    public partial class registro_de_ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
            conexion.Open();

            string actualizar = "UPDATE Ventas SET Id_Usuario=@Id_Usuario,Id_Producto=@Id_Producto, Fecha_de_Venta=@Fecha_de_Venta, Hora_Venta=@Hora_Venta, Total_Venta=@Total_Venta, Efectivo=@Efectivo,Vuelto=@Vuelto,Cantidad=@Cantidad WHERE Id_Usuario=@Id_Usuario";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion);

            cmd2.Parameters.AddWithValue("@Id_Usuario", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Id_Producto", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@Fecha_de_Venta", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@Hora_Venta", TextBox4.Text);
            cmd2.Parameters.AddWithValue("@Total_Venta", TextBox5.Text);
            cmd2.Parameters.AddWithValue("@Efectivo", TextBox6.Text);
            cmd2.Parameters.AddWithValue("@Vuelto", TextBox7.Text);
            cmd2.Parameters.AddWithValue("@Cantidad", TextBox8.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox6.Text = "";
            TextBox6.Text = "";

        }
    }
}