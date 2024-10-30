namespace prueba
{
    partial class producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtExistencia = new TextBox();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            btnLimpiar = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(91, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(74, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1000;
            label1.Text = "CODIGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 300;
            label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 100;
            label3.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(91, 153);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(245, 71);
            txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 70);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 700;
            label4.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(446, 67);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 109);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 900;
            label5.Text = "EXISTENCIAS";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(446, 106);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(143, 23);
            txtExistencia.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(521, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(210, 66);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(427, 233);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(336, 233);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(402, 153);
            txtId.Name = "txtId";
            txtId.Size = new Size(143, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(602, 233);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(665, 291);
            dataGridView1.TabIndex = 1001;
            // 
            // label6
            // 
            label6.Location = new Point(273, 9);
            label6.Name = "label6";
            label6.Size = new Size(200, 15);
            label6.TabIndex = 1002;
            label6.Text = "REGISTRO PRODUCTOS\r\n";
            // 
            // producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(691, 588);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpiar);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtExistencia);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Name = "producto";
            Text = "producto";
            Load += producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtExistencia;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtId;
        private Button btnLimpiar;
        private DataGridView dataGridView1;
        private Label label6;
    }
}