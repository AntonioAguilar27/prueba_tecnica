using MySql.Data.MySqlClient;
using PruebaTecnica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace prueba
{
    public partial class ventas : Form
    {
        private Dictionary<string, (string id, string precio)> productos;

        public ventas()
        {
            InitializeComponent();
            productos = new Dictionary<string, (string id, string precio)>();
        }

        private void tabla()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            string sql = "SELECT * FROM venta";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Aquí es donde vinculas el DataTable al DataGridView
            dataGridView1.DataSource = dt;

            conexionBD.Close(); // Asegúrate de cerrar la conexión
        }

        public void cargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            string sql = "SELECT id, codigo, nombre, descripcion, precio, existencias FROM productos"; 
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                string id = lector.GetString(0); 
                string nombre = lector.GetString(2); 
                string precio = lector.GetString(4); 

                comboProducto.Items.Add(nombre);
                productos[nombre] = (id, precio); 
            }
            conexionBD.Close();
        }

        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProducto.SelectedItem != null)
            {
                string productoSeleccionado = comboProducto.SelectedItem.ToString();

                if (productos.TryGetValue(productoSeleccionado, out var datosProducto))
                {
                    txtIdVenta.Text = datosProducto.id; 
                    txtPrecioVenta.Text = datosProducto.precio; 
                }
            }
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            cargarCombo();
            tabla();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtIdVenta.Text) || string.IsNullOrEmpty(txtCantidadVenta.Text))
                {
                    MessageBox.Show("Por favor, seleccione un producto y especifique la cantidad.");
                    return;
                }

                
                string productoId = txtIdVenta.Text;
                int cantidad = int.Parse(txtCantidadVenta.Text);
                decimal precio = decimal.Parse(txtPrecioVenta.Text);

                
                decimal total = precio * cantidad;

                
                DateTime fechaVenta = dateTimePicker1.Value;

                
                using (MySqlConnection conexionBD = Conexion.conexion())
                {
                    conexionBD.Open();

                    
                    string sql = "INSERT INTO venta (producto_id, cantidad, total, fecha_venta) VALUES (@producto_id, @cantidad, @total, @fecha_venta)";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexionBD))
                    {
                        
                        comando.Parameters.AddWithValue("@producto_id", productoId);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@total", total);
                        comando.Parameters.AddWithValue("@fecha_venta", fechaVenta);

                        
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta registrada exitosamente.");
                tabla();
                // Opcional: Limpiar los campos después de insertar
                txtIdVenta.Clear();
                txtPrecioVenta.Clear();
                txtCantidadVenta.Clear();
                comboProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }
    }
}
