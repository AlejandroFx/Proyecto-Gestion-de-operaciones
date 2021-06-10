namespace GestionDeOperacionesTI
{
    partial class frmBajaDepartamento
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
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encargado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDepartamentos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(571, 641);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 65);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "BAJA DEPARTAMENTO";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre del Departamento";
            this.Nombre.Width = 250;
            // 
            // Encargado
            // 
            this.Encargado.Text = "Encargado del Departamento";
            this.Encargado.Width = 349;
            // 
            // lvDepartamentos
            // 
            this.lvDepartamentos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Encargado});
            this.lvDepartamentos.HideSelection = false;
            this.lvDepartamentos.Location = new System.Drawing.Point(162, 126);
            this.lvDepartamentos.Name = "lvDepartamentos";
            this.lvDepartamentos.Size = new System.Drawing.Size(1024, 472);
            this.lvDepartamentos.TabIndex = 3;
            this.lvDepartamentos.UseCompatibleStateImageBehavior = false;
            this.lvDepartamentos.View = System.Windows.Forms.View.Details;
            // 
            // frmBajaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 850);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDepartamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaDepartamento";
            this.Text = "frmBajaDepartamento";
            this.Load += new System.EventHandler(this.frmBajaDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Encargado;
        private System.Windows.Forms.ListView lvDepartamentos;
    }
}