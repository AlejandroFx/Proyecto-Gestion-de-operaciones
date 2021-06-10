namespace GestionDeOperacionesTI
{
    partial class frmSolicitaCambio
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbInc = new System.Windows.Forms.ComboBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(519, 725);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(203, 80);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.maskDate);
            this.groupBox1.Controls.Add(this.cmbInc);
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 564);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(607, 459);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(163, 58);
            this.txtID.TabIndex = 23;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(808, 393);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 48);
            this.lbl.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Identificador de la incidencia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha de solicitud YY/MM/DD";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(85, 459);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(257, 58);
            this.maskDate.TabIndex = 3;
            // 
            // cmbInc
            // 
            this.cmbInc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbInc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInc.FormattingEnabled = true;
            this.cmbInc.Location = new System.Drawing.Point(45, 292);
            this.cmbInc.Name = "cmbInc";
            this.cmbInc.Size = new System.Drawing.Size(639, 56);
            this.cmbInc.TabIndex = 10;
            this.cmbInc.SelectedIndexChanged += new System.EventHandler(this.cmbInc_SelectedIndexChanged);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(45, 143);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(800, 58);
            this.txtCambio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Incidencia a la que pertenece";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción de la solicitud";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(427, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 56);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "SOLICITAR CAMBIO";
            // 
            // frmSolicitaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 847);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSolicitaCambio";
            this.Text = "frmSolicitaCambio";
            this.Load += new System.EventHandler(this.frmSolicitaCambio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.ComboBox cmbInc;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtID;
    }
}