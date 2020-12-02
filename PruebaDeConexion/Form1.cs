using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeConexion
{
    public partial class Form1 : Form
    {

        private SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConexion = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = PruebaDeConexion; Integrated Security = True";
            con = new SqlConnection(strConexion);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Probar a abrir la conexión
                con.Open();
                TxtVersion.Text = "Versión del servidor: " + con.ServerVersion;
                TxtEstadoConexion.Text = "La conexion está: ";
                TxtEstadoConexion.Text += con.State.ToString();
                TxtEstadoConexion.Text += "\nSe accede a la base de datos";
            }
            catch (Exception ex)
            {
                TxtEstadoConexion.Text = "Error al acceder a la base de datos. "
                + ex.Message;
            }
            finally
            {
                con.Close();
                TxtEstadoConexion.Text += "\nAhora la conexion está: " +
                con.State.ToString();
            }
        }
    }
}
