namespace GestionDeOperacionesTI
{
    partial class frmMenuTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuTecnico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoDeRespuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retroalimentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemasConocidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.TabIndex = 0;
            // 
            // mnsMenu
            // 
            this.mnsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.incidenciasToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.problemasConocidosToolStripMenuItem1,
            this.cambioToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1250, 42);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(100, 38);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(155, 38);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiempoDeRespuestaToolStripMenuItem,
            this.liberacionToolStripMenuItem});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // tiempoDeRespuestaToolStripMenuItem
            // 
            this.tiempoDeRespuestaToolStripMenuItem.Name = "tiempoDeRespuestaToolStripMenuItem";
            this.tiempoDeRespuestaToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.tiempoDeRespuestaToolStripMenuItem.Text = "Asignadas";
            this.tiempoDeRespuestaToolStripMenuItem.Click += new System.EventHandler(this.tiempoDeRespuestaToolStripMenuItem_Click);
            // 
            // liberacionToolStripMenuItem
            // 
            this.liberacionToolStripMenuItem.Name = "liberacionToolStripMenuItem";
            this.liberacionToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.liberacionToolStripMenuItem.Text = "Liberacion ";
            this.liberacionToolStripMenuItem.Click += new System.EventHandler(this.liberacionToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retroalimentaciónToolStripMenuItem,
            this.actualizaciónCIToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(128, 38);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // retroalimentaciónToolStripMenuItem
            // 
            this.retroalimentaciónToolStripMenuItem.Name = "retroalimentaciónToolStripMenuItem";
            this.retroalimentaciónToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.retroalimentaciónToolStripMenuItem.Text = "Retroalimentación";
            this.retroalimentaciónToolStripMenuItem.Click += new System.EventHandler(this.retroalimentaciónToolStripMenuItem_Click_1);
            // 
            // actualizaciónCIToolStripMenuItem
            // 
            this.actualizaciónCIToolStripMenuItem.Name = "actualizaciónCIToolStripMenuItem";
            this.actualizaciónCIToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.actualizaciónCIToolStripMenuItem.Text = "Actualización CI";
            this.actualizaciónCIToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónCIToolStripMenuItem_Click);
            // 
            // problemasConocidosToolStripMenuItem1
            // 
            this.problemasConocidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.visualizaciónToolStripMenuItem});
            this.problemasConocidosToolStripMenuItem1.Name = "problemasConocidosToolStripMenuItem1";
            this.problemasConocidosToolStripMenuItem1.Size = new System.Drawing.Size(261, 38);
            this.problemasConocidosToolStripMenuItem1.Text = "Catalogo de servicios";
            this.problemasConocidosToolStripMenuItem1.Click += new System.EventHandler(this.problemasConocidosToolStripMenuItem1_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(286, 44);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // visualizaciónToolStripMenuItem
            // 
            this.visualizaciónToolStripMenuItem.Name = "visualizaciónToolStripMenuItem";
            this.visualizaciónToolStripMenuItem.Size = new System.Drawing.Size(286, 44);
            this.visualizaciónToolStripMenuItem.Text = "Visualización";
            this.visualizaciónToolStripMenuItem.Click += new System.EventHandler(this.visualizaciónToolStripMenuItem_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.panel2);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 60);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(1250, 703);
            this.pnContenido.TabIndex = 1;
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
            // cambioToolStripMenuItem
            // 
            this.cambioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarToolStripMenuItem,
            this.verCambiosToolStripMenuItem});
            this.cambioToolStripMenuItem.Name = "cambioToolStripMenuItem";
            this.cambioToolStripMenuItem.Size = new System.Drawing.Size(117, 38);
            this.cambioToolStripMenuItem.Text = "Cambio";
            // 
            // solicitarToolStripMenuItem
            // 
            this.solicitarToolStripMenuItem.Name = "solicitarToolStripMenuItem";
            this.solicitarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.solicitarToolStripMenuItem.Text = "Solicitar";
            this.solicitarToolStripMenuItem.Click += new System.EventHandler(this.solicitarToolStripMenuItem_Click);
            // 
            // verCambiosToolStripMenuItem
            // 
            this.verCambiosToolStripMenuItem.Name = "verCambiosToolStripMenuItem";
            this.verCambiosToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.verCambiosToolStripMenuItem.Text = "Ver Cambios";
            this.verCambiosToolStripMenuItem.Click += new System.EventHandler(this.verCambiosToolStripMenuItem_Click);
            // 
            // frmMenuTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 763);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuTecnico";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMenuTecnico_Load);
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
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoDeRespuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liberacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retroalimentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemasConocidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCambiosToolStripMenuItem;
    }
}