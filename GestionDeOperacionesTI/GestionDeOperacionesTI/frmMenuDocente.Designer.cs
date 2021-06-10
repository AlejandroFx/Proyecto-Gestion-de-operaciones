namespace GestionDeOperacionesTI
{
    partial class frmMenuDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDocente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaIndicenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.mnsMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 60);
            this.panel1.TabIndex = 1;
            // 
            // mnsMenu
            // 
            this.mnsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.incidenciaToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1250, 40);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // incidenciaToolStripMenuItem
            // 
            this.incidenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaIndicenciaToolStripMenuItem,
            this.evaluarServicioToolStripMenuItem,
            this.misReportesToolStripMenuItem});
            this.incidenciaToolStripMenuItem.Name = "incidenciaToolStripMenuItem";
            this.incidenciaToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.incidenciaToolStripMenuItem.Text = "Incidencia";
            // 
            // altaIndicenciaToolStripMenuItem
            // 
            this.altaIndicenciaToolStripMenuItem.Name = "altaIndicenciaToolStripMenuItem";
            this.altaIndicenciaToolStripMenuItem.Size = new System.Drawing.Size(312, 44);
            this.altaIndicenciaToolStripMenuItem.Text = "Alta indicencia";
            this.altaIndicenciaToolStripMenuItem.Click += new System.EventHandler(this.altaIndicenciaToolStripMenuItem_Click);
            // 
            // evaluarServicioToolStripMenuItem
            // 
            this.evaluarServicioToolStripMenuItem.Name = "evaluarServicioToolStripMenuItem";
            this.evaluarServicioToolStripMenuItem.Size = new System.Drawing.Size(312, 44);
            this.evaluarServicioToolStripMenuItem.Text = "Evaluar servicio";
            this.evaluarServicioToolStripMenuItem.Click += new System.EventHandler(this.evaluarServicioToolStripMenuItem_Click);
            // 
            // misReportesToolStripMenuItem
            // 
            this.misReportesToolStripMenuItem.Name = "misReportesToolStripMenuItem";
            this.misReportesToolStripMenuItem.Size = new System.Drawing.Size(312, 44);
            this.misReportesToolStripMenuItem.Text = "Mis reportes";
            this.misReportesToolStripMenuItem.Click += new System.EventHandler(this.misReportesToolStripMenuItem_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.panel2);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 60);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(1250, 703);
            this.pnContenido.TabIndex = 2;
            this.pnContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContenido_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 703);
            this.panel2.TabIndex = 0;
            // 
            // frmMenuDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 763);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuDocente";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMenuDocente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem incidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaIndicenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misReportesToolStripMenuItem;
    }
}