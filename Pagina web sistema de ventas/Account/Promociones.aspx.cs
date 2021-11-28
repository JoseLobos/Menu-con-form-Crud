using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pagina_web_sistema_de_ventas.Account
{
    public partial class Promociones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
                string Id_Producto;
                Id_Producto = (TextBox1.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Promociones WHERE  Id_Producto=@Id_Producto  ", conexion);

                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Id_Producto", Id_Producto);
                int i;
                i = Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show("La promocion que quiere registrar, ya se encuentra registrada");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    
                }
                else
                {

                    string cadenaconsulta;

                    cadenaconsulta = "Insert into Promociones (Fecha_de_inicio,Id_Venta,Id_Producto, Nombre_de_Producto,Porcentaje_de_descuento)values(@Fecha_de_inicio,@Id_Venta,@Id_Producto,@Nombre_de_Producto,@Porcentaje_de_descuento)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Fecha_de_inicio", TextBox9.Text);
                    consulta_agregar.Parameters.AddWithValue("@Id_Venta", TextBox10.Text);
                    consulta_agregar.Parameters.AddWithValue("@Id_Producto", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nombre_de_Producto", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Porcentaje_de_descuento", TextBox3.Text);
                    


                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se Registro la promocion correctamente");

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox9.Text = "";
                            TextBox10.Text = "";
                            

                        }



                        catch (SqlException j)
                        {
                            MessageBox.Show(j.ToString());
                        }


                    }
                }



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
            conexion.Open();

            string actualizar = "UPDATE Promociones SET Fecha_de_inicio=@Fecha_de_inicio,Id_Venta=@Id_Venta,Id_Producto=@Id_Producto, Nombre_de_Producto=@Nombre_de_Producto, Porcentaje_de_descuento=@Porcentaje_de_descuento WHERE Id_Producto=@Id_Producto";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion);


            cmd2.Parameters.AddWithValue("@Fecha_de_inicio", TextBox9.Text);
            cmd2.Parameters.AddWithValue("@Id_Venta", TextBox10.Text);
            cmd2.Parameters.AddWithValue("@Id_Producto", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Nombre_de_Producto", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@Porcentaje_de_descuento", TextBox3.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");

            conexion.Open();
            string eliminar;

            eliminar = "DELETE FROM Promociones WHERE Id_Producto=@Id_Producto";

            SqlCommand cmd = new SqlCommand(eliminar, conexion);

            cmd.Parameters.AddWithValue("@Id_Producto", TextBox1.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" El producto fue eliminado");
            TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Button3.Visible = false;
            Button5.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button3.Visible = false;
            Button6.Visible = false;
            Button5.Visible = false;
            Button2.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Visible = Visible;
            Button2.Visible = Visible;
            Button3.Visible = Visible;
            Button4.Visible = Visible;
            Button5.Visible = Visible;
            Button6.Visible = Visible;
        }
    }
}