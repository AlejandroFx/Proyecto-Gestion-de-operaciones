namespace GestionDeOperacionesTI
{
    partial class frmAltaIncidenciaCI
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
            this.label11 = new System.Windows.Forms.Label();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbNumCI = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(256, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(562, 56);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "ALTA INCIDENCIA ELEMENTO DE CI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.maskDate);
            this.groupBox1.Controls.Add(this.cmbNumCI);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 535);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del problema";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(371, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha del reporte YY/MM/DD";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(85, 308);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(257, 58);
            this.maskDate.TabIndex = 3;
            // 
            // cmbNumCI
            // 
            this.cmbNumCI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNumCI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNumCI.FormattingEnabled = true;
            this.cmbNumCI.Location = new System.Drawing.Point(482, 310);
            this.cmbNumCI.Name = "cmbNumCI";
            this.cmbNumCI.Size = new System.Drawing.Size(363, 56);
            this.cmbNumCI.TabIndex = 10;
            this.cmbNumCI.SelectedIndexChanged += new System.EventHandler(this.cmbNumCI_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(45, 133);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(800, 58);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre de CI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción del problema";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(428, 708);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(203, 80);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Número de serie del CI : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(343, 416);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 48);
            this.lbl.TabIndex = 22;
            // 
            // frmAltaIncidenciaCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 876);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAltaIncidenciaCI";
            this.Load += new System.EventHandler(this.frmAltaIncidenciaCI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.ComboBox cmbNumCI;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
    }
}