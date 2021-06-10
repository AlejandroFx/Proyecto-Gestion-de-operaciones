namespace GestionDeOperacionesTI
{
    partial class frmAltaCI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Formulario = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTA ELEMENTO DE CONFIGURACIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.groupBox1.Controls.Add(this.txtNumSerie);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 721);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de elemento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(376, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha adquisición YY/MM/DD";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(706, 631);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(291, 58);
            this.maskDate.TabIndex = 3;
            // 
            // nudPlanta
            // 
            this.nudPlanta.Location = new System.Drawing.Point(792, 489);
            this.nudPlanta.Name = "nudPlanta";
            this.nudPlanta.ReadOnly = true;
            this.nudPlanta.Size = new System.Drawing.Size(116, 58);
            this.nudPlanta.TabIndex = 19;
            this.nudPlanta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescUbicacion
            // 
            this.txtDescUbicacion.Location = new System.Drawing.Point(37, 631);
            this.txtDescUbicacion.Name = "txtDescUbicacion";
            this.txtDescUbicacion.Size = new System.Drawing.Size(517, 58);
            this.txtDescUbicacion.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 48);
            this.label10.TabIndex = 16;
            this.label10.Text = "Drescripción de la ubicación del CI";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(37, 489);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(487, 58);
            this.txtUbicacion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(445, 48);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descripción para localizar el edificio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(737, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 48);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número de planta";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(658, 217);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(339, 56);
            this.cmbEncargado.TabIndex = 11;
            // 
            // cmbEdificio
            // 
            this.cmbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdificio.FormattingEnabled = true;
            this.cmbEdificio.Location = new System.Drawing.Point(658, 356);
            this.cmbEdificio.Name = "cmbEdificio";
            this.cmbEdificio.Size = new System.Drawing.Size(342, 56);
            this.cmbEdificio.TabIndex = 10;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(643, 90);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(386, 56);
            this.cmbProveedor.TabIndex = 9;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(37, 356);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(487, 58);
            this.txtNumSerie.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(37, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(531, 58);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(495, 58);
            this.txtNombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "Encargado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(784, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Edificio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(1317, 770);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 90);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F);
            this.groupBox2.Location = new System.Drawing.Point(1192, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 147);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de CI";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Computadora",
            "Impresora",
            "Proyector",
            "Teléfono",
            "Switch",
            "Router"});
            this.comboBox1.Location = new System.Drawing.Point(31, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 56);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Formulario
            // 
            this.Formulario.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario.Location = new System.Drawing.Point(1156, 303);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(475, 437);
            this.Formulario.TabIndex = 27;
            this.Formulario.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1165, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(466, 43);
            this.label12.TabIndex = 28;
            this.label12.Text = "FORMATO DE LLENADO DE DESCRIPCIÓN";
            // 
            // frmAltaCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1700, 934);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaCI";
            this.Text = "frmAltaCI";
            this.Load += new System.EventHandler(this.frmAltaCI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.ComboBox cmbEdificio;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescUbicacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.NumericUpDown nudPlanta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox Formulario;
        private System.Windows.Forms.Label label12;
    }
}