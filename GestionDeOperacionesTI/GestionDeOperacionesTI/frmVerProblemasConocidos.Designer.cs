namespace GestionDeOperacionesTI
{
    partial class frmVerProblemasConocidos
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
            this.btnSelectTec = new System.Windows.Forms.Button();
            this.lvInci = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSol = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectTec
            // 
            this.btnSelectTec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelectTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTec.Location = new System.Drawing.Point(1041, 855);
            this.btnSelectTec.Name = "btnSelectTec";
            this.btnSelectTec.Size = new System.Drawing.Size(300, 79);
            this.btnSelectTec.TabIndex = 36;
            this.btnSelectTec.Text = "Seleccionar problema";
            this.btnSelectTec.UseVisualStyleBackColor = false;
            this.btnSelectTec.Click += new System.EventHandler(this.btnSelectTec_Click);
            // 
            // lvInci
            // 
            this.lvInci.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvInci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Desc,
            this.Sol,
            this.Tiem});
            this.lvInci.HideSelection = false;
            this.lvInci.Location = new System.Drawing.Point(25, 104);
            this.lvInci.Name = "lvInci";
            this.lvInci.Size = new System.Drawing.Size(793, 830);
            this.lvInci.TabIndex = 35;
            this.lvInci.UseCompatibleStateImageBehavior = false;
            this.lvInci.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Desc
            // 
            this.Desc.Text = "Descripción";
            this.Desc.Width = 244;
            // 
            // Sol
            // 
            this.Sol.Text = "Solución";
            this.Sol.Width = 310;
            // 
            // Tiem
            // 
            this.Tiem.Text = "Tiempo";
            this.Tiem.Width = 178;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(595, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(414, 56);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "CATALOGO DE SERVICIOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox2.Location = new System.Drawing.Point(846, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 738);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(186, 653);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(323, 65);
            this.txtTime.TabIndex = 42;
            this.txtTime.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiempo de respuesta";
            // 
            // txtSol
            // 
            this.txtSol.Location = new System.Drawing.Point(27, 282);
            this.txtSol.Name = "txtSol";
            this.txtSol.ReadOnly = true;
            this.txtSol.Size = new System.Drawing.Size(641, 327);
            this.txtSol.TabIndex = 39;
            this.txtSol.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 48);
            this.label3.TabIndex = 41;
            this.label3.Text = "Solución del problema";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(67, 56);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(559, 172);
            this.txtDesc.TabIndex = 40;
            this.txtDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion del problema";
            // 
            // frmVerProblemasConocidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1546, 1083);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSelectTec);
            this.Controls.Add(this.lvInci);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerProblemasConocidos";
            this.Text = "frmVerProblemasConocidos";
            this.Load += new System.EventHandler(this.frmVerProblemasConocidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTec;
        private System.Windows.Forms.ListView lvInci;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Sol;
        private System.Windows.Forms.ColumnHeader Tiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtSol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label2;
    }
}