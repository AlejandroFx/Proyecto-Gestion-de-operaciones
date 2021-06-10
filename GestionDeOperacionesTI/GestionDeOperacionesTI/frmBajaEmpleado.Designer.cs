namespace GestionDeOperacionesTI
{
    partial class frmBajaEmpleado
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
            this.lvEmpleados = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Celular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmpleados
            // 
            this.lvEmpleados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Email,
            this.Celular,
            this.Direccion,
            this.Rol});
            this.lvEmpleados.HideSelection = false;
            this.lvEmpleados.Location = new System.Drawing.Point(216, 153);
            this.lvEmpleados.Name = "lvEmpleados";
            this.lvEmpleados.Size = new System.Drawing.Size(944, 445);
            this.lvEmpleados.TabIndex = 0;
            this.lvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 90;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 90;
            // 
            // Celular
            // 
            this.Celular.Text = "Número celular";
            this.Celular.Width = 90;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Dirección";
            this.Direccion.Width = 90;
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            this.Rol.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAJA EMPLEADO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(592, 640);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(232, 80);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmBajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 876);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaEmpleado";
            this.Text = "frmBajaEmpleado";
            this.Load += new System.EventHandler(this.frmBajaEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmpleados;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Celular;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}