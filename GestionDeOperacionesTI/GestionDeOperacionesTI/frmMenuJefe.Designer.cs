namespace GestionDeOperacionesTI
{
    partial class frmMenuJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuJefe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.TabIndex = 0;
            // 
            // mnsMenu
            // 
            this.mnsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.incidenciaToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.cambiosToolStripMenuItem});
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
            // incidenciaToolStripMenuItem
            // 
            this.incidenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprobarToolStripMenuItem,
            this.asignarToolStripMenuItem});
            this.incidenciaToolStripMenuItem.Name = "incidenciaToolStripMenuItem";
            this.incidenciaToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.incidenciaToolStripMenuItem.Text = "Incidencia";
            // 
            // aprobarToolStripMenuItem
            // 
            this.aprobarToolStripMenuItem.Name = "aprobarToolStripMenuItem";
            this.aprobarToolStripMenuItem.Size = new System.Drawing.Size(234, 44);
            this.aprobarToolStripMenuItem.Text = "Aprobar";
            this.aprobarToolStripMenuItem.Click += new System.EventHandler(this.aprobarToolStripMenuItem_Click);
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(234, 44);
            this.asignarToolStripMenuItem.Text = "Asignar";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónCIToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(128, 38);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // actualizaciónCIToolStripMenuItem
            // 
            this.actualizaciónCIToolStripMenuItem.Name = "actualizaciónCIToolStripMenuItem";
            this.actualizaciónCIToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.actualizaciónCIToolStripMenuItem.Text = "Actualización CI";
            this.actualizaciónCIToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónCIToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(127, 38);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            // 
            // autorizarToolStripMenuItem
            // 
            this.autorizarToolStripMenuItem.Name = "autorizarToolStripMenuItem";
            this.autorizarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.autorizarToolStripMenuItem.Text = "Autorizar";
            this.autorizarToolStripMenuItem.Click += new System.EventHandler(this.autorizarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
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
            // frmMenuJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 763);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuJefe";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMenuJefe_Load);
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
        private System.Windows.Forms.ToolStripMenuItem aprobarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}