using MySql.Data.MySqlClient;
using PruebaTecnica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class producto : Form
    {
        public producto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio = double.Parse(txtPrecio.Text);
            int existencias = int.Parse(txtExistencia.Text);



            string sql = "INSERT INTO productos (codigo, nombre, descripcion, precio, existencias) VALUES ('" + codigo + "','" + nombre + "','" + descripcion + "','" + precio + "','" + existencias + "')";


            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro realizado");
                limpiar();
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT id, codigo, nombre, descripcion, precio, existencias FROM productos WHERE codigo LIKE '" + codigo + "' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtCodigo.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtDescripcion.Text = reader.GetString(3);
                        txtPrecio.Text = reader.GetString(4);
                        txtExistencia.Text = reader.GetString(5);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio = double.Parse(txtPrecio.Text);
            int existencias = int.Parse(txtExistencia.Text);



            string sql = "UPDATE productos SET codigo='" + codigo + "', nombre='" + nombre + "', descripcion='" + descripcion + "', precio='" + precio + "', existencias='" + existencias + "'WHERE id='" + id + "'";


            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("registro modificado");
                limpiar();
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio = double.Parse(txtPrecio.Text);
            int existencias = int.Parse(txtExistencia.Text);



            string sql = "DELETE FROM productos Where id='" + id + "'";


            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("registro eliminado");
                limpiar();
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtExistencia.Text = "";
            txtPrecio.Text = "";
        }

        private void tabla()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            string sql = "SELECT * FROM productos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Aquí es donde vinculas el DataTable al DataGridView
            dataGridView1.DataSource = dt;

            conexionBD.Close(); // Asegúrate de cerrar la conexión
        }

        private void producto_Load(object sender, EventArgs e)
        {
            tabla();
        }

    }



}