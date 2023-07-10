using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace holasisi
{
    public partial class Form1 : Form
    {
        static string cadena = "Data Source=.;Initial Catalog=systemcft;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cadena);
        SqlCommand com = new SqlCommand();
        SqlDataReader datos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            com.Connection = cn;
            com.CommandType = CommandType.Text;
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            com.CommandText = "select nombre from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true) {
                while (datos.Read()) {
                    this.listBox1.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox1.Items.Add("Sin resultados");

            }
            datos.Close();
            //

            com.CommandText = "select apellido from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    this.listBox2.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox2.Items.Add("Sin resultados");

            }
            datos.Close();
            //

            com.CommandText = "select rut from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    this.listBox3.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox3.Items.Add("Sin resultados");

            }
            datos.Close();
            //

            com.CommandText = "select direccion from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    this.listBox4.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox4.Items.Add("Sin resultados");

            }
            datos.Close();
            //

            com.CommandText = "select email from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    this.listBox5.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox5.Items.Add("Sin resultados");

            }
            datos.Close();
            //

            com.CommandText = "select edad from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    int edad = datos.GetInt32(0);
                    string edadStr = edad.ToString();
                    this.listBox6.Items.Add(datos.GetInt32(0));
                }
            }
            else
            {
                this.listBox6.Items.Add("Sin resultados");

            }
            datos.Close();
            com.CommandText = "select fechanacimiento from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    DateTime fechaNacimiento = datos.GetDateTime(0);
                    string fechaNacimientoStr = fechaNacimiento.ToString("dd/MM/yyyy");

                    this.listBox7.Items.Add(datos.GetDateTime(0));
                }
            }
            else
            {
                this.listBox7.Items.Add("Sin resultados");

            }
            datos.Close();
            com.CommandText = "select contraseña from Estudiante2 where id='" + this.textBox1.Text + "'";
            datos = com.ExecuteReader();
            if (datos.HasRows == true)
            {
                while (datos.Read())
                {
                    this.listBox8.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox8.Items.Add("Sin resultados");

            }
            datos.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
