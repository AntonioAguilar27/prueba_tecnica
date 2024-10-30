namespace prueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            vENTASToolStripMenuItem = new ToolStripMenuItem();
            rEPORTEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Items.AddRange(new ToolStripItem[] { pRODUCTOSToolStripMenuItem, vENTASToolStripMenuItem, rEPORTEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(86, 33);
            pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            pRODUCTOSToolStripMenuItem.Click += pRODUCTOSToolStripMenuItem_Click;
            // 
            // vENTASToolStripMenuItem
            // 
            vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            vENTASToolStripMenuItem.Size = new Size(60, 33);
            vENTASToolStripMenuItem.Text = "VENTAS";
            vENTASToolStripMenuItem.Click += vENTASToolStripMenuItem_Click;
            // 
            // rEPORTEToolStripMenuItem
            // 
            rEPORTEToolStripMenuItem.Name = "rEPORTEToolStripMenuItem";
            rEPORTEToolStripMenuItem.Size = new Size(66, 33);
            rEPORTEToolStripMenuItem.Text = "REPORTE";
            rEPORTEToolStripMenuItem.Click += rEPORTEToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(459, 294);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private ToolStripMenuItem vENTASToolStripMenuItem;
        private ToolStripMenuItem rEPORTEToolStripMenuItem;
    }
}
