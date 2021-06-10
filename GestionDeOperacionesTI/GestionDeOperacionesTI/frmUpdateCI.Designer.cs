namespace GestionDeOperacionesTI
{
    partial class frmUpdateCI
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.nudPlanta = new System.Windows.Forms.NumericUpDown();
            this.txtDescUbicacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.cmbEdificio = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtxNumSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(16, 102);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(338, 51);
            this.cmbNombre.TabIndex = 12;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbEncargado_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(720, 56);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "ACTUALIZAR ELEMENTO DE CONFIGURACIÓN";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1072, 525);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 80);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.lblEncargado);
            this.groupBox1.Controls.Add(this.lblEdificio);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.maskDate);
            this.groupBox1.Controls.Add(this.nudPlanta);
            this.groupBox1.Controls.Add(this.txtDescUbicacion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbEncargado);
            this.groupBox1.Controls.Add(this.cmbEdificio);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 674);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de CI";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(690, 57);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(0, 43);
            this.lblProveedor.TabIndex = 25;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.Location = new System.Drawing.Point(504, 249);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(0, 43);
            this.lblEncargado.TabIndex = 24;
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Location = new System.Drawing.Point(742, 394);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(0, 48);
            this.lblEdificio.TabIndex = 23;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(248, 486);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 48);
            this.lblDate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 48);
            this.label4.TabIndex = 21;
            this.label4.Text = "YY/MM/DD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha adquisición:";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(70, 549);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(291, 58);
            this.maskDate.TabIndex = 3;
            // 
            // nudPlanta
            // 
            this.nudPlanta.Location = new System.Drawing.Point(671, 581);
            this.nudPlanta.Name = "nudPlanta";
            this.nudPlanta.Size = new System.Drawing.Size(116, 58);
            this.nudPlanta.TabIndex = 19;
            // 
            // txtDescUbicacion
            // 
            this.txtDescUbicacion.Location = new System.Drawing.Point(28, 394);
            this.txtDescUbicacion.Name = "txtDescUbicacion";
            this.txtDescUbicacion.Size = new System.Drawing.Size(465, 58);
            this.txtDescUbicacion.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 48);
            this.label10.TabIndex = 16;
            this.label10.Text = "Drescripción de la ubicación";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(28, 243);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(427, 58);
            this.txtUbicacion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 48);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ubicación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 48);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número de planta";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(576, 299);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(339, 56);
            this.cmbEncargado.TabIndex = 11;
            // 
            // cmbEdificio
            // 
            this.cmbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdificio.FormattingEnabled = true;
            this.cmbEdificio.Location = new System.Drawing.Point(555, 445);
            this.cmbEdificio.Name = "cmbEdificio";
            this.cmbEdificio.Size = new System.Drawing.Size(342, 56);
            this.cmbEdificio.TabIndex = 10;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(555, 112);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(386, 56);
            this.cmbProveedor.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(28, 110);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(465, 58);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "Encargado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Edificio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción del elemento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtxNumSerie);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbNombre);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(996, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 312);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elementos de configuración";
            // 
            // txtxNumSerie
            // 
            this.txtxNumSerie.Location = new System.Drawing.Point(16, 228);
            this.txtxNumSerie.Name = "txtxNumSerie";
            this.txtxNumSerie.ReadOnly = true;
            this.txtxNumSerie.Size = new System.Drawing.Size(339, 52);
            this.txtxNumSerie.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 43);
            this.label2.TabIndex = 14;
            this.label2.Text = "Número de serie";
            // 
            // frmUpdateCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateCI";
            this.Text = "frmUpdateCI";
            this.Load += new System.EventHandler(this.frmUpdateCI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.NumericUpDown nudPlanta;
        private System.Windows.Forms.TextBox txtDescUbicacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.ComboBox cmbEdificio;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtxNumSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblEdificio;
    }
}