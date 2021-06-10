namespace GestionDeOperacionesTI
{
    partial class frmEvaluarIncidencia
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCalif = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.lvIndicencias = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Problema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1202, 370);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(203, 80);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 153);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentarios";
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(27, 57);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(425, 58);
            this.txtCom.TabIndex = 38;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(404, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(762, 56);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "EVALUAR SERVICIO DE SOLUCION A INCIDENCIA";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(859, 819);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 80);
            this.btnActualizar.TabIndex = 38;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.cmbCalif);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(567, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 153);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Califiación en base a metrica  de evaluación";
            // 
            // cmbCalif
            // 
            this.cmbCalif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalif.FormattingEnabled = true;
            this.cmbCalif.Items.AddRange(new object[] {
            "BUENA ",
            "MALA",
            "REGULAR",
            "EXCELENTE"});
            this.cmbCalif.Location = new System.Drawing.Point(75, 59);
            this.cmbCalif.Name = "cmbCalif";
            this.cmbCalif.Size = new System.Drawing.Size(417, 56);
            this.cmbCalif.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtIn);
            this.groupBox3.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1175, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 131);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(27, 48);
            this.txtIn.Name = "txtIn";
            this.txtIn.ReadOnly = true;
            this.txtIn.Size = new System.Drawing.Size(203, 58);
            this.txtIn.TabIndex = 0;
            // 
            // lvIndicencias
            // 
            this.lvIndicencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvIndicencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Problema,
            this.TipoIn,
            this.Prio,
            this.FechaIn,
            this.FechaT,
            this.TimeR});
            this.lvIndicencias.HideSelection = false;
            this.lvIndicencias.Location = new System.Drawing.Point(55, 97);
            this.lvIndicencias.Name = "lvIndicencias";
            this.lvIndicencias.Size = new System.Drawing.Size(1064, 383);
            this.lvIndicencias.TabIndex = 48;
            this.lvIndicencias.UseCompatibleStateImageBehavior = false;
            this.lvIndicencias.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Problema
            // 
            this.Problema.Text = "Descripcion del problema";
            this.Problema.Width = 263;
            // 
            // TipoIn
            // 
            this.TipoIn.Text = "Tipo de incidencia";
            this.TipoIn.Width = 202;
            // 
            // Prio
            // 
            this.Prio.Text = "Prioridad";
            this.Prio.Width = 121;
            // 
            // FechaIn
            // 
            this.FechaIn.Text = "Fecha de inicio";
            this.FechaIn.Width = 163;
            // 
            // FechaT
            // 
            this.FechaT.Text = "Fecha conclusion";
            this.FechaT.Width = 190;
            // 
            // TimeR
            // 
            this.TimeR.Text = "Tiempo de respuesta";
            this.TimeR.Width = 134;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.txtDesc);
            this.groupBox4.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(28, 720);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 285);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metrica de evaluación del servicio";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(18, 57);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(719, 197);
            this.txtDesc.TabIndex = 41;
            this.txtDesc.Text = "1. LLEGADA DEL TECNICO EN TIEMPO Y FORMA\n2. TRATO AMIGABLE DEL TECNICO \n3. LIMPIE" +
    "ZA DEL ESPACIO UTILIZADO POR EL TECNICO\n4. ORDENADO EL ESPACIO UTILIZADO POR EL " +
    "TECNICO\n\n";
            // 
            // frmEvaluarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1460, 1071);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lvIndicencias);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvaluarIncidencia";
            this.Load += new System.EventHandler(this.frmEvaluarIncidencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCalif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.ListView lvIndicencias;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Problema;
        private System.Windows.Forms.ColumnHeader TipoIn;
        private System.Windows.Forms.ColumnHeader Prio;
        private System.Windows.Forms.ColumnHeader FechaIn;
        private System.Windows.Forms.ColumnHeader FechaT;
        private System.Windows.Forms.ColumnHeader TimeR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}