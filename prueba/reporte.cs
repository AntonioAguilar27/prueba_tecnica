using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using PruebaTecnica;
using System.Data;
using System.Windows.Forms;

namespace prueba
{
    public partial class btnExportarPdf : Form
    {
        public btnExportarPdf()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void CargarVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (MySqlConnection conexionBD = Conexion.conexion())
                {
                    conexionBD.Open();

                    string sql = "SELECT * FROM venta WHERE fecha_venta BETWEEN @fechaInicio AND @fechaFin";
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Validar las fechas
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                return;
            }

            DateTime fechaFin = dateTimePicker2.Value.Date.AddDays(1); // Último instante del día

            // Cargar las ventas entre las fechas seleccionadas
            CargarVentas(dateTimePicker1.Value, dateTimePicker2.Value);
        }
        private void ExportarDataGridViewAPdf(string rutaArchivo)
        {
            using (Document doc = new Document())
            {
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Crear una tabla con el número de columnas del DataGridView
                PdfPTable tabla = new PdfPTable(dataGridView1.Columns.Count);

                // Agregar los encabezados
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    tabla.AddCell(new Phrase(columna.HeaderText));
                }

                // Agregar los datos
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null)
                        {
                            tabla.AddCell(new Phrase(celda.Value.ToString()));
                        }
                    }
                }

                // Agregar la tabla al documento
                doc.Add(tabla);
                doc.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define la ruta del archivo PDF
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "reporte_ventas.pdf");

            try
            {
                ExportarDataGridViewAPdf(rutaArchivo);
                MessageBox.Show("PDF generado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}");
            }
        }
    }
}
