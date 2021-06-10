namespace GestionDeOperacionesTI
{
    partial class frmAltaIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaIncidencia));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnRed = new System.Windows.Forms.RadioButton();
            this.rbnCI = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbnSO = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 66);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "TIPO DE INCIDENCIA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rbnSO);
            this.groupBox2.Controls.Add(this.rbnRed);
            this.groupBox2.Controls.Add(this.rbnCI);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(109, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 318);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione una opción";
            // 
            // rbnRed
            // 
            this.rbnRed.AutoSize = true;
            this.rbnRed.Location = new System.Drawing.Point(33, 148);
            this.rbnRed.Name = "rbnRed";
            this.rbnRed.Size = new System.Drawing.Size(252, 60);
            this.rbnRed.TabIndex = 23;
            this.rbnRed.TabStop = true;
            this.rbnRed.Text = "Falla en la red";
            this.rbnRed.UseVisualStyleBackColor = true;
            this.rbnRed.CheckedChanged += new System.EventHandler(this.rbnRed_CheckedChanged);
            // 
            // rbnCI
            // 
            this.rbnCI.AutoSize = true;
            this.rbnCI.Location = new System.Drawing.Point(33, 70);
            this.rbnCI.Name = "rbnCI";
            this.rbnCI.Size = new System.Drawing.Size(391, 60);
            this.rbnCI.TabIndex = 22;
            this.rbnCI.TabStop = true;
            this.rbnCI.Text = "Falla de elemento de CI";
            this.rbnCI.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSiguiente.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(607, 487);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(209, 78);
            this.btnSiguiente.TabIndex = 26;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // rbnSO
            // 
            this.rbnSO.AutoSize = true;
            this.rbnSO.Location = new System.Drawing.Point(33, 229);
            this.rbnSO.Name = "rbnSO";
            this.rbnSO.Size = new System.Drawing.Size(294, 60);
            this.rbnSO.TabIndex = 24;
            this.rbnSO.TabStop = true;
            this.rbnSO.Text = "Falla de software";
            this.rbnSO.UseVisualStyleBackColor = true;
            // 
            // frmAltaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaIncidencia";
            this.Text = "frmTipoIndicencia";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnRed;
        private System.Windows.Forms.RadioButton rbnCI;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbnSO;
    }
}