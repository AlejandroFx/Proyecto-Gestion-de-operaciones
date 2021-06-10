namespace GestionDeOperacionesTI
{
    partial class frmAltaProblemasConocidos
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
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSol = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox1.Location = new System.Drawing.Point(47, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 742);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la incidencia";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(35, 640);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(323, 68);
            this.txtTime.TabIndex = 42;
            this.txtTime.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiempo de respuesta";
            // 
            // txtSol
            // 
            this.txtSol.Location = new System.Drawing.Point(35, 318);
            this.txtSol.Name = "txtSol";
            this.txtSol.Size = new System.Drawing.Size(961, 243);
            this.txtSol.TabIndex = 39;
            this.txtSol.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 48);
            this.label3.TabIndex = 41;
            this.label3.Text = "Solución del problema";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(35, 113);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(755, 132);
            this.txtDesc.TabIndex = 40;
            this.txtDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion del problema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROBLEMAS CONOCIDOS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(1133, 720);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 85);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAltaProblemasConocidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 897);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaProblemasConocidos";
            this.Text = "frmProblemasConocidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSol;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.Label label4;
    }
}