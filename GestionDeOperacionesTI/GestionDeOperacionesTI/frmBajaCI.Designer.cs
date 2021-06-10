namespace GestionDeOperacionesTI
{
    partial class frmBajaCI
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCI = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaAdqui = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localizacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encargado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(608, 655);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 68);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "BAJA ELEMENTO DE CONFIGURACIÓN";
            // 
            // lvCI
            // 
            this.lvCI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvCI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Descripcion,
            this.NumSerie,
            this.FechaAdqui,
            this.Localizacion,
            this.Encargado,
            this.Proveedor});
            this.lvCI.HideSelection = false;
            this.lvCI.Location = new System.Drawing.Point(89, 137);
            this.lvCI.Name = "lvCI";
            this.lvCI.Size = new System.Drawing.Size(1227, 472);
            this.lvCI.TabIndex = 3;
            this.lvCI.UseCompatibleStateImageBehavior = false;
            this.lvCI.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 87;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripción";
            this.Descripcion.Width = 88;
            // 
            // NumSerie
            // 
            this.NumSerie.Text = "Número de serie";
            this.NumSerie.Width = 91;
            // 
            // FechaAdqui
            // 
            this.FechaAdqui.Text = "Fecha de aquisición";
            this.FechaAdqui.Width = 112;
            // 
            // Localizacion
            // 
            this.Localizacion.Text = "Localización";
            this.Localizacion.Width = 88;
            // 
            // Encargado
            // 
            this.Encargado.Text = "Encargado";
            this.Encargado.Width = 88;
            // 
            // Proveedor
            // 
            this.Proveedor.Text = "Proveedor";
            this.Proveedor.Width = 88;
            // 
            // frmBajaCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 847);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaCI";
            this.Text = "frmBajaCI";
            this.Load += new System.EventHandler(this.frmBajaCI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCI;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader NumSerie;
        private System.Windows.Forms.ColumnHeader FechaAdqui;
        private System.Windows.Forms.ColumnHeader Localizacion;
        private System.Windows.Forms.ColumnHeader Encargado;
        private System.Windows.Forms.ColumnHeader Proveedor;
    }
}