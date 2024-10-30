namespace prueba
{
    partial class ventas
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
            comboProducto = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCantidadVenta = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnVenta = new Button();
            txtPrecioVenta = new TextBox();
            txtIdVenta = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboProducto
            // 
            comboProducto.FormattingEnabled = true;
            comboProducto.Location = new Point(103, 66);
            comboProducto.Name = "comboProducto";
            comboProducto.Size = new Size(242, 23);
            comboProducto.TabIndex = 0;
            comboProducto.SelectedIndexChanged += comboProducto_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Location = new Point(298, 20);
            label6.Name = "label6";
            label6.Size = new Size(115, 14);
            label6.TabIndex = 1003;
            label6.Text = "REGISTRO VENTAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1004;
            label1.Text = "PRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1005;
            label2.Text = "CANTIDAD";
            // 
            // txtCantidadVenta
            // 
            txtCantidadVenta.Location = new Point(103, 111);
            txtCantidadVenta.Name = "txtCantidadVenta";
            txtCantidadVenta.Size = new Size(121, 23);
            txtCantidadVenta.TabIndex = 1006;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 1007;
            label3.Text = "FECHA VENTA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1008;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 173);
            dataGridView1.TabIndex = 1009;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(12, 212);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(75, 23);
            btnVenta.TabIndex = 1010;
            btnVenta.Text = "ENVIAR";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(438, 108);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(121, 23);
            txtPrecioVenta.TabIndex = 1011;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(438, 69);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(121, 23);
            txtIdVenta.TabIndex = 1012;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 111);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 1013;
            label4.Text = "PRECIO";
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(694, 444);
            Controls.Add(label4);
            Controls.Add(txtIdVenta);
            Controls.Add(txtPrecioVenta);
            Controls.Add(btnVenta);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtCantidadVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(comboProducto);
            Name = "ventas";
            Text = "ventas";
            Load += ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProducto;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox txtCantidadVenta;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btnVenta;
        private TextBox txtPrecioVenta;
        private TextBox txtIdVenta;
        private Label label4;
    }
}