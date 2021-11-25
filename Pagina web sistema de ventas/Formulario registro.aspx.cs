﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pagina_web_sistema_de_ventas
{
    public partial class Formulario_registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button3.Visible = false;
            Button6.Visible = false;
            Button5.Visible = false;
            Button2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Login;Integrated Security=True");
                string usuario;
                usuario = (TextBox1.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Usuarios WHERE Usuario=@Usuario  ", conexion);
                
                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Usuario", usuario);
                int i;
                i= Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show ("El Nombre de usuario ingresado ya esta en uso");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    conexion.Close();
                }
                else
                {
                    
                    string cadenaconsulta;
                   
                    cadenaconsulta = "Insert into usuarios (Id_usuario,Usuario,Clave,Nivel,Correo,Direccion) values (@Id_usuario,@usuario,@clave,@nivel,@correo,@direccion)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_usuario", TextBox4.Text);
                    consulta_agregar.Parameters.AddWithValue("@usuario", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Clave", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nivel", Convert.ToInt32( TextBox3.Text));
                    consulta_agregar.Parameters.AddWithValue("@correo", TextBox5.Text);
                    consulta_agregar.Parameters.AddWithValue("@direccion", TextBox6.Text);

                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el nuevo usuario correctamente");
                           
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                        }



                        catch (SqlException j)
                        {
                            MessageBox.Show(j.ToString());
                        }


                    }
                }



            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Visible = Visible;
            Button2.Visible = Visible;
            Button3.Visible = Visible;
            Button4.Visible = Visible;
            Button5.Visible = Visible;
            Button6.Visible = Visible;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Login;Integrated Security=True");

            conexion.Open();
            string eliminar;

            eliminar = "DELETE FROM Usuarios WHERE Id_usuario=@Id_usuario";

            SqlCommand cmd = new SqlCommand(eliminar, conexion);

            cmd.Parameters.AddWithValue("@Id_Usuario", TextBox4.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" El usuario fue eliminado");
            TextBox4.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Login;Integrated Security=True");
            conexion.Open();

            string actualizar = "UPDATE Usuarios SET Id_usuario=@Id_usuario,Usuario=@Usuario,Clave=@Clave, Correo=@Correo, Nivel=@Nivel, Direccion=@Direccion WHERE Id_usuario=@Id_usuario";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion);

            cmd2.Parameters.AddWithValue("@Id_usuario", TextBox4.Text);
            cmd2.Parameters.AddWithValue("@Usuario", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Clave", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@Correo", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@Nivel", TextBox5.Text);
            cmd2.Parameters.AddWithValue("@Direccion", TextBox6.Text);
            

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            

        }
    }
}