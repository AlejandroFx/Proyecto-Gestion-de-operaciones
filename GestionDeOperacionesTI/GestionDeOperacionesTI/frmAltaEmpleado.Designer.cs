namespace GestionDeOperacionesTI
{
    partial class frmAltaEmpleado
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(96, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 56);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "ALTA EMPLEADO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDepto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(95, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 686);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(42, 599);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(291, 52);
            this.cmbRol.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(40, 352);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(583, 55);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(40, 480);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(334, 55);
            this.txtCelular.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(40, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(456, 55);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(583, 55);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(1056, 709);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(209, 83);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departamento";
            // 
            // cmbDepto
            // 
            this.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(540, 599);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(309, 52);
            this.cmbDepto.TabIndex = 10;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 902);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEmpleado";
            this.Text = "frmAltaEmpleado";
            this.Load += new System.EventHandler(this.frmAltaEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepto;
    }
}