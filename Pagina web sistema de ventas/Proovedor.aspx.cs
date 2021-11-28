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
    public partial class Proovedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
             {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
                string Codigo_del_Proovedor;
                Codigo_del_Proovedor = (TextBox3.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Proveedores WHERE Codigo_del_Proovedor=@Codigo_del_Proovedor  ", conexion);

                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Codigo_del_Proovedor", Codigo_del_Proovedor);
                int i;
                i = Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show("El proveedor que quiere registar ya se encuentra registrado");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                }
                else
                {

                    string cadenaconsulta;

                    cadenaconsulta = "Insert into Proveedores (Id_Producto,Nombre_del_ProovedorCodigo_del_Proovedor,Cantidad,Direccion,Numero_de_Telefono,Departamento,Correo,Codigo_de_Pedido)values(@Id_Producto,@Nombre_del_Proovedor,@Codigo_del_Proovedor,@Cantidad,@Direccion,@Direccion,@Numero_de_Telefono,@Departamento,@Correo,@Codigo_de_Pedido)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_Producto", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nombre_del_Proovedor", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Codigo_del_Proovedor", TextBox3.Text);
                    consulta_agregar.Parameters.AddWithValue("@Cantidad", TextBox4.Text);
                    consulta_agregar.Parameters.AddWithValue("@Direccion", TextBox5.Text);
            
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Telefono", TextBox6.Text);
                    consulta_agregar.Parameters.AddWithValue("@Departamento", TextBox7.Text);
                    consulta_agregar.Parameters.AddWithValue("@Correo", TextBox8.Text);
                    consulta_agregar.Parameters.AddWithValue("@Direccion", TextBox9.Text);


                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el nuevo proovedor correctamente");

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            TextBox7.Text = "";
                            TextBox8.Text = "";
                            TextBox9.Text = "";

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

            string actualizar = "UPDATE Proveedores SET Id_Producto=@Id_Producto,Nombre_del_Proovedor=@Nombre_del_Proovedor, Codigo_del_Proovedor=@Codigo_del_Proovedor,Cantidad=@Cantidad, Direccion=@Direccion, Direccion=@Direccion,Numero_de_Telefono=@Numero_de_Telefono,Departamento=@Departamento, Correo=@Correo,Codigo_de_Pedido=@Codigo_de_Pedido WHERE Codigo_del_Proovedor=@Codigo_del_Proovedor";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion);

            cmd2.Parameters.AddWithValue("@Id_Producto", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Nombre_del_Proovedor", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@Codigo_del_Proovedor", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@Cantidad", TextBox4.Text);
            cmd2.Parameters.AddWithValue("@Direccion", TextBox5.Text);
            cmd2.Parameters.AddWithValue("@Numero_de_Telefono", TextBox6.Text);
            cmd2.Parameters.AddWithValue("@Departamento", TextBox7.Text);
            cmd2.Parameters.AddWithValue("@Correo", TextBox8.Text);
            cmd2.Parameters.AddWithValue("@Codigo_de_Pedido", TextBox9.Text);

            MessageBox.Show("Los datos fueron actualizados con exito");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");

            conexion.Open();
            string eliminar;

            eliminar = "DELETE FROM Empleados WHERE Codigo_del_Proovedor=@Codigo_del_Proovedor";

            SqlCommand cmd = new SqlCommand(eliminar, conexion);

            cmd.Parameters.AddWithValue("@Codigo_del_Proovedor", TextBox3.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" El Proovedor fue eliminado  con exito");
            TextBox3.Text = "";
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