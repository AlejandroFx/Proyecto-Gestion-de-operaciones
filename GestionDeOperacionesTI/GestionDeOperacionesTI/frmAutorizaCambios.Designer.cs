namespace GestionDeOperacionesTI
{
    partial class frmAutorizaCambios
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lvCam = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.Inc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(428, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 56);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "CAMBIOS SOLICITADOS";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1231, 167);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(203, 80);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lvCam
            // 
            this.lvCam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvCam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Inc,
            this.Sol,
            this.Fec});
            this.lvCam.HideSelection = false;
            this.lvCam.Location = new System.Drawing.Point(76, 122);
            this.lvCam.Name = "lvCam";
            this.lvCam.Size = new System.Drawing.Size(1073, 378);
            this.lvCam.TabIndex = 35;
            this.lvCam.UseCompatibleStateImageBehavior = false;
            this.lvCam.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 153);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentarios";
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(20, 57);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(441, 58);
            this.txtCom.TabIndex = 16;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(242, 751);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(203, 80);
            this.btnAprobar.TabIndex = 32;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.maskDate);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F);
            this.groupBox2.Location = new System.Drawing.Point(709, 546);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 153);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de respuesta YY/MM/DD";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(89, 66);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(257, 58);
            this.maskDate.TabIndex = 21;
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(798, 751);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(203, 80);
            this.btnRechazar.TabIndex = 37;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // Inc
            // 
            this.Inc.Text = "Incidencia perteneciente";
            this.Inc.Width = 300;
            // 
            // Sol
            // 
            this.Sol.Text = "Descripción de la solicitud ";
            this.Sol.Width = 372;
            // 
            // Fec
            // 
            this.Fec.Text = "Fecha de solicitud";
            this.Fec.Width = 265;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1169, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 131);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solicitud seleccionada";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(70, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(195, 58);
            this.txtID.TabIndex = 16;
            // 
            // frmAutorizaCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 941);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lvCam);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutorizaCambios";
            this.Text = "frmCambios";
            this.Load += new System.EventHandler(this.frmAutorizaCambios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lvCam;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.ColumnHeader Inc;
        private System.Windows.Forms.ColumnHeader Sol;
        private System.Windows.Forms.ColumnHeader Fec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtID;
    }
}