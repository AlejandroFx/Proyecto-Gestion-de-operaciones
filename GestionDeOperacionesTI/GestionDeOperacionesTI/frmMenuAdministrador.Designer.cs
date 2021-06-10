namespace GestionDeOperacionesTI
{
    partial class frmMenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdministrador));
            this.pn1 = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosCIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosCIToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actualizacionesCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn1.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pn1.Controls.Add(this.msMenu);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1383, 60);
            this.pn1.TabIndex = 1;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.actualizaciónToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1383, 42);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
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
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click_1);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.elementosToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(76, 38);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(313, 44);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(313, 44);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // elementosToolStripMenuItem
            // 
            this.elementosToolStripMenuItem.Name = "elementosToolStripMenuItem";
            this.elementosToolStripMenuItem.Size = new System.Drawing.Size(313, 44);
            this.elementosToolStripMenuItem.Text = "Elementos CI";
            this.elementosToolStripMenuItem.Click += new System.EventHandler(this.elementosToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.elementosCIToolStripMenuItem});
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(79, 38);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(303, 44);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(303, 44);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // elementosCIToolStripMenuItem
            // 
            this.elementosCIToolStripMenuItem.Name = "elementosCIToolStripMenuItem";
            this.elementosCIToolStripMenuItem.Size = new System.Drawing.Size(303, 44);
            this.elementosCIToolStripMenuItem.Text = "Elementos CI";
            this.elementosCIToolStripMenuItem.Click += new System.EventHandler(this.elementosCIToolStripMenuItem_Click);
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem1,
            this.departamentoToolStripMenuItem1,
            this.elementosCIToolStripMenuItem1});
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.actualizaciónToolStripMenuItem.Text = "Actualización";
            // 
            // empleadoToolStripMenuItem1
            // 
            this.empleadoToolStripMenuItem1.Name = "empleadoToolStripMenuItem1";
            this.empleadoToolStripMenuItem1.Size = new System.Drawing.Size(303, 44);
            this.empleadoToolStripMenuItem1.Text = "Empleado";
            this.empleadoToolStripMenuItem1.Click += new System.EventHandler(this.empleadoToolStripMenuItem1_Click);
            // 
            // departamentoToolStripMenuItem1
            // 
            this.departamentoToolStripMenuItem1.Name = "departamentoToolStripMenuItem1";
            this.departamentoToolStripMenuItem1.Size = new System.Drawing.Size(303, 44);
            this.departamentoToolStripMenuItem1.Text = "Departamento";
            this.departamentoToolStripMenuItem1.Click += new System.EventHandler(this.departamentoToolStripMenuItem1_Click);
            // 
            // elementosCIToolStripMenuItem1
            // 
            this.elementosCIToolStripMenuItem1.Name = "elementosCIToolStripMenuItem1";
            this.elementosCIToolStripMenuItem1.Size = new System.Drawing.Size(303, 44);
            this.elementosCIToolStripMenuItem1.Text = "Elementos CI";
            this.elementosCIToolStripMenuItem1.Click += new System.EventHandler(this.elementosCIToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.departamentosToolStripMenuItem1,
            this.elementosCIToolStripMenuItem2,
            this.actualizacionesCIToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(128, 38);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // departamentosToolStripMenuItem1
            // 
            this.departamentosToolStripMenuItem1.Name = "departamentosToolStripMenuItem1";
            this.departamentosToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.departamentosToolStripMenuItem1.Text = "Departamentos";
            this.departamentosToolStripMenuItem1.Click += new System.EventHandler(this.departamentosToolStripMenuItem1_Click);
            // 
            // elementosCIToolStripMenuItem2
            // 
            this.elementosCIToolStripMenuItem2.Name = "elementosCIToolStripMenuItem2";
            this.elementosCIToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.elementosCIToolStripMenuItem2.Text = "Elementos CI";
            this.elementosCIToolStripMenuItem2.Click += new System.EventHandler(this.elementosCIToolStripMenuItem2_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.BackColor = System.Drawing.SystemColors.Control;
            this.pnContenido.Controls.Add(this.panel1);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 60);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(1383, 849);
            this.pnContenido.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 849);
            this.panel1.TabIndex = 0;
            // 
            // actualizacionesCIToolStripMenuItem
            // 
            this.actualizacionesCIToolStripMenuItem.Name = "actualizacionesCIToolStripMenuItem";
            this.actualizacionesCIToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.actualizacionesCIToolStripMenuItem.Text = "Actualizaciones CI";
            this.actualizacionesCIToolStripMenuItem.Click += new System.EventHandler(this.actualizacionesCIToolStripMenuItem_Click);
            // 
            // frmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 909);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.pn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenuAdministrador";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMenuAdministrador_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementosCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementosCIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementosCIToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actualizacionesCIToolStripMenuItem;
    }
}