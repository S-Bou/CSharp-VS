﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

            MuestraTodosPedidos();
        }

        //public System.Windows.WindowStartupLocation WindowStartupLocation { get; set; }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptador = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptador)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptador.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTabla.DefaultView;

                }
            }catch(Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraPedidos()
        {
            try
            {
                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON  C.Id = P.cCliente" + 
                    " WHERE C.Id = @ClienteId";

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptador = new SqlDataAdapter(sqlComando);

                using (miAdaptador)
                {

                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                    DataTable pedidosTabla = new DataTable();

                    miAdaptador.Fill(pedidosTabla);

                    pedidosCliente.DisplayMemberPath = "fechaPedido";
                    pedidosCliente.SelectedValuePath = "Id";
                    pedidosCliente.ItemsSource = pedidosTabla.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT(cCliente, ' ' , fechaPedido, ' ' , formaPago) AS INFOCOMPLETA FROM PEDIDO";

                SqlDataAdapter miAdapatadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using(miAdapatadorSql)
                {
                    DataTable pedidosTabla = new DataTable(); 

                    miAdapatadorSql.Fill(pedidosTabla);

                    todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        SqlConnection miConexionSql;

       /* private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());

            string consulta = "DELETE FROM PEDIDO WHERE ID = @PEDIDOID";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            insertaCliente.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM CLIENTE WHERE ID = @CLIENTEID";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);


            try
            {
                string consulta = "SELECT nombre FROM CLIENTE where Id = @ClId";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptador = new SqlDataAdapter(miSqlCommand);

                using (miAdaptador)
                {
                    miSqlCommand.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);

                    DataTable clientesTabla = new DataTable();

                    miAdaptador.Fill(clientesTabla);

                    ventanaActualizar.cuadroActualiza.Text = clientesTabla.Rows[0]["nombre"].ToString();

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }

            ventanaActualizar.ShowDialog();

            MuestraClientes();
        }
    }
}
