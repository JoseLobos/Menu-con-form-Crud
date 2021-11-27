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
    }
}