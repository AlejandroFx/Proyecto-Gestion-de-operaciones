namespace GestionDeOperacionesTI
{
    partial class frmEditaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditaPerfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCel = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumCel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1030, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpDatos.Controls.Add(this.lblDir);
            this.grpDatos.Controls.Add(this.lblNumCel);
            this.grpDatos.Controls.Add(this.txtContraseña);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtNumCel);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.lblEmail);
            this.grpDatos.Controls.Add(this.lblCel);
            this.grpDatos.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(94, 140);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(871, 495);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Información";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(67, 389);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(335, 58);
            this.txtContraseña.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtNumCel
            // 
            this.txtNumCel.Location = new System.Drawing.Point(61, 126);
            this.txtNumCel.Name = "txtNumCel";
            this.txtNumCel.Size = new System.Drawing.Size(335, 58);
            this.txtNumCel.TabIndex = 3;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(61, 255);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(516, 58);
            this.txtDir.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 208);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(137, 48);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Dirección:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(56, 71);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(208, 48);
            this.lblCel.TabIndex = 0;
            this.lblCel.Text = "Número celular:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(887, 684);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 80);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 56);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "CONFIGURACIÓN";
            // 
            // lblNumCel
            // 
            this.lblNumCel.AutoSize = true;
            this.lblNumCel.Location = new System.Drawing.Point(258, 71);
            this.lblNumCel.Name = "lblNumCel";
            this.lblNumCel.Size = new System.Drawing.Size(0, 48);
            this.lblNumCel.TabIndex = 7;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(189, 208);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(0, 48);
            this.lblDir.TabIndex = 8;
            // 
            // frmEditaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 860);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditaPerfil";
            this.Text = "frmEditaPerfil";
            this.Load += new System.EventHandler(this.frmEditaPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumCel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblNumCel;
    }
}