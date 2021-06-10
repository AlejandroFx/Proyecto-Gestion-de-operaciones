namespace GestionDeOperacionesTI
{
    partial class frmUpdateEmpleado
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtNumCel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1021, 589);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 80);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1030, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empleados";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(24, 181);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(202, 48);
            this.lblCel.TabIndex = 0;
            this.lblCel.Text = "Número celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 426);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 48);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Dirección";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(26, 477);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(535, 58);
            this.txtDir.TabIndex = 2;
            // 
            // txtNumCel
            // 
            this.txtNumCel.Location = new System.Drawing.Point(26, 232);
            this.txtNumCel.Name = "txtNumCel";
            this.txtNumCel.Size = new System.Drawing.Size(464, 58);
            this.txtNumCel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(535, 58);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(535, 58);
            this.txtNombre.TabIndex = 9;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpDatos.Controls.Add(this.lblDep);
            this.grpDatos.Controls.Add(this.cmbDep);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.lblRol);
            this.grpDatos.Controls.Add(this.cmbRol);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtNumCel);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.lblEmail);
            this.grpDatos.Controls.Add(this.lblCel);
            this.grpDatos.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(39, 99);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(799, 694);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Información";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(89, 554);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 48);
            this.lblRol.TabIndex = 11;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(32, 605);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(303, 56);
            this.cmbRol.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(52, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(402, 56);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "ACTUALIZAR EMPLEADO";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargado.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(906, 209);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(411, 56);
            this.cmbEncargado.TabIndex = 7;
            this.cmbEncargado.SelectedIndexChanged += new System.EventHandler(this.cmbEncargado_SelectedIndexChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(573, 554);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(0, 48);
            this.lblDep.TabIndex = 14;
            // 
            // cmbDep
            // 
            this.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDep.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(390, 605);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(383, 56);
            this.cmbDep.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 48);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento";
            // 
            // frmUpdateEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 895);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEncargado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateEmpleado";
            this.Text = "frmUpdateEmpleadocs";
            this.Load += new System.EventHandler(this.frmUpdateEmpleado_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtNumCel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.Label label6;
    }
}