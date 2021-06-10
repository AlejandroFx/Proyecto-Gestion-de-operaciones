namespace GestionDeOperacionesTI
{
    partial class frmUpdateDepartamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblEnc = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblDepto);
            this.groupBox1.Controls.Add(this.lblEnc);
            this.groupBox1.Controls.Add(this.cmbEncargado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox1.Location = new System.Drawing.Point(87, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 492);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del departamento";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(53, 398);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(551, 56);
            this.cmbEncargado.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 197);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(551, 57);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Encargado del departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del departamento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(77, 77);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(493, 56);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "ACTUALIZAR DEPARTAMENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(978, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 48);
            this.label1.TabIndex = 16;
            this.label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(916, 293);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(346, 56);
            this.cmbDepartamentos.TabIndex = 15;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(986, 503);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 80);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblEnc
            // 
            this.lblEnc.AutoSize = true;
            this.lblEnc.Location = new System.Drawing.Point(45, 334);
            this.lblEnc.Name = "lblEnc";
            this.lblEnc.Size = new System.Drawing.Size(0, 48);
            this.lblEnc.TabIndex = 4;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(45, 146);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(0, 48);
            this.lblDepto.TabIndex = 5;
            // 
            // frmUpdateDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 918);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateDepartamento";
            this.Text = "frmUpdateDepartamento";
            this.Load += new System.EventHandler(this.frmUpdateDepartamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblEnc;
    }
}