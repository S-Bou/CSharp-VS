using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        public Actualiza(int elID)
        {
            InitializeComponent();

            z = elID;

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        SqlConnection miConexionSql;

        private int z;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE cliente SET nombre=@nombre WHERE Id = " + z;

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            this.Close();

        }
    }
}
