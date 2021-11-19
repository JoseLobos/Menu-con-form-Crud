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
    public partial class formulario_registro_empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
                string nombres;
                nombres = (TextBox2.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Empleados WHERE  Nombres=@Nombres  ", conexion);

                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Nombres", nombres);
                int i;
                i = Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show("El Nombre de empleado ingresado ya esta en uso");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    DropDownList1.Text = "";
                    DropDownList2.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    TextBox15.Text = "";
                    DropDownList3.Text = "";
                    DropDownList4.Text = "";
                    conexion.Close();
                }
                else
                {

                    string cadenaconsulta;

                    cadenaconsulta = "Insert into Empleados (Id_Empleado,Nombres,Apellidos,Fecha_de_Nacimiento,Telefono,Direccion,Genero,Departamento,Nivel_laboral,Sueldo,Observaciones,Correo,Numero_de_Dui,Numero_de_Nit,Numero_de_Afp,Fecha_de_Ingreso,Jefatura)values(@Id_Empleado,@Nombres,@Apellidos,@Fecha_de_Nacimiento,@Telefono,@Direccion,@Genero,@Departamento,@Nivel_laboral,@Sueldo,@Observaciones,@Correo,@Numero_de_Dui,@Numero_de_Nit,@Numero_de_Afp,@Fecha_de_Ingreso,@Jefatura)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_Empleado", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nombres", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Apellidos", TextBox3.Text);
                    consulta_agregar.Parameters.AddWithValue("@Fecha_de_Nacimiento", TextBox4.Text);
                    consulta_agregar.Parameters.AddWithValue("@Telefono", TextBox5.Text);
                    consulta_agregar.Parameters.AddWithValue("@Direccion", TextBox6.Text);
                    consulta_agregar.Parameters.AddWithValue("@Genero", DropDownList1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Departamento", DropDownList2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nivel_laboral", DropDownList4.Text);
                    consulta_agregar.Parameters.AddWithValue("@Sueldo", TextBox9.Text);
                    consulta_agregar.Parameters.AddWithValue("@Observaciones", TextBox10.Text);
                    consulta_agregar.Parameters.AddWithValue("@Correo", TextBox11.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Dui", TextBox12.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Nit", TextBox13.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Afp", TextBox14.Text);
                    consulta_agregar.Parameters.AddWithValue("@Fecha_de_Ingreso", TextBox15.Text);
                    consulta_agregar.Parameters.AddWithValue("@Jefatura", DropDownList3.Text);


                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el nuevo empleado correctamente");

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            DropDownList1.Text = "Seleccione el genero";
                            DropDownList2.Text = "";
                            TextBox9.Text = "";
                            TextBox10.Text = "";
                            TextBox11.Text = "";
                            TextBox12.Text = "";
                            TextBox13.Text = "";
                            TextBox14.Text = "";
                            TextBox15.Text = "";
                            DropDownList3.Text = "";
                            DropDownList4.Text = "";
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

            string actualizar = "UPDATE Empleados SET Id_Empleado=@Id_Empleado,Nombres=@Nombres, Apellidos=@Apellidos, Fecha_de_Nacimiento=@Fecha_de_Nacimiento, Telefono=@Telefono, Direccion=@Direccion,Genero=@Genero,Departamento=@Departamento, Nivel_laboral=@Nivel_laboral,Sueldo=@Sueldo,Observaciones=@Observaciones,Correo=@Correo,Numero_de_Dui=@Numero_de_Dui,Numero_de_Nit=@Numero_de_Nit,Numero_de_Afp=@Numero_de_Afp,Fecha_de_Ingreso=@Fecha_de_Ingreso,Jefatura=@Jefatura WHERE Id_Empleado=@Id_Empleado";
            SqlCommand cmd2 = new SqlCommand(actualizar, conexion);

            cmd2.Parameters.AddWithValue("@Id_Empleado", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@Nombres", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@Apellidos", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@Fecha_de_Nacimiento", TextBox4.Text);
            cmd2.Parameters.AddWithValue("@Telefono", TextBox5.Text);
            cmd2.Parameters.AddWithValue("@Direccion", TextBox6.Text);
            cmd2.Parameters.AddWithValue("@Genero", DropDownList1.Text);
            cmd2.Parameters.AddWithValue("@Departamento", DropDownList2.Text);
            cmd2.Parameters.AddWithValue("@Nivel_laboral", DropDownList4.Text);
            cmd2.Parameters.AddWithValue("@Sueldo", TextBox9.Text);
            cmd2.Parameters.AddWithValue("@Observaciones", TextBox10.Text);
            cmd2.Parameters.AddWithValue("@Correo", TextBox11.Text);
            cmd2.Parameters.AddWithValue("@Numero_de_Dui", TextBox12.Text);
            cmd2.Parameters.AddWithValue("@Numero_de_Nit", TextBox13.Text);
            cmd2.Parameters.AddWithValue("@Numero_de_Afp", TextBox14.Text);
            cmd2.Parameters.AddWithValue("@Fecha_de_Ingreso", TextBox15.Text);
            cmd2.Parameters.AddWithValue("@Jefatura", DropDownList3.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "Seleccione el genero";
            DropDownList2.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            DropDownList3.Text = "";
            DropDownList4.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");

            conexion.Open();
            string eliminar;

            eliminar = "DELETE FROM Empleados WHERE ID_EMPLEADO=@ID_EMPLEADO";

            SqlCommand cmd = new SqlCommand(eliminar, conexion);

            cmd.Parameters.AddWithValue("@Id_Empleado", TextBox1.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" El empleado fue eliminado  con exito");
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