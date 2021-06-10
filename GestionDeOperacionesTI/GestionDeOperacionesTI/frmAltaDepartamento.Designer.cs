namespace GestionDeOperacionesTI
{
    partial class frmAltaDepartamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTA DEPARTAMENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cmbEncargado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox1.Location = new System.Drawing.Point(94, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 507);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Encargado del departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del departamento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(1019, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(551, 57);
            this.txtNombre.TabIndex = 2;
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(53, 322);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(551, 56);
            this.cmbEncargado.TabIndex = 3;
            // 
            // frmAltaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 826);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaDepartamento";
            this.Text = "frmAltaDepartamento";
            this.Load += new System.EventHandler(this.frmAltaDepartamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.TextBox txtNombre;
    }
}