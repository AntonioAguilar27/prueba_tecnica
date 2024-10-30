namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmOpen = Application.OpenForms["producto"];

            if (FrmOpen == null)
            {
                producto producto = new producto();
                producto.Show();
            }

        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmOpen = Application.OpenForms["ventas"];

            if (FrmOpen == null)
            {
                ventas venta = new ventas();
                venta.Show();
            }
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmOpen = Application.OpenForms["REPORTE"];

            if (FrmOpen == null)
            {
                btnExportarPdf reporte = new btnExportarPdf();
                reporte.Show();
            }
        }
    }
}
