namespace GestionDeOperacionesTI
{
    partial class frmAprobarIncidencia
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
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lvIndicencias = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Problema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtIncidencia);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 153);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID incidencia";
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Location = new System.Drawing.Point(20, 57);
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.ReadOnly = true;
            this.txtIncidencia.Size = new System.Drawing.Size(441, 58);
            this.txtIncidencia.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(368, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 56);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "APROBAR INCIDENCIA";
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(450, 711);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(203, 80);
            this.btnAprobar.TabIndex = 25;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.cmbPrioridad);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F);
            this.groupBox2.Location = new System.Drawing.Point(645, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 153);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(46, 60);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(411, 51);
            this.cmbPrioridad.TabIndex = 12;
            // 
            // lvIndicencias
            // 
            this.lvIndicencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvIndicencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FechaIn,
            this.Problema,
            this.TipoIn});
            this.lvIndicencias.HideSelection = false;
            this.lvIndicencias.Location = new System.Drawing.Point(41, 107);
            this.lvIndicencias.Name = "lvIndicencias";
            this.lvIndicencias.Size = new System.Drawing.Size(1073, 378);
            this.lvIndicencias.TabIndex = 30;
            this.lvIndicencias.UseCompatibleStateImageBehavior = false;
            this.lvIndicencias.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FechaIn
            // 
            this.FechaIn.Text = "Fecha de inicio";
            this.FechaIn.Width = 196;
            // 
            // Problema
            // 
            this.Problema.Text = "Descripcion del problema";
            this.Problema.Width = 484;
            // 
            // TipoIn
            // 
            this.TipoIn.Text = "Tipo de incidencia";
            this.TipoIn.Width = 250;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1150, 241);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(203, 80);
            this.btnSelect.TabIndex = 31;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmAprobarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 870);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lvIndicencias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAprobar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAprobarIncidencia";
            this.Text = "frmAprobarIncidencia";
            this.Load += new System.EventHandler(this.frmAprobarIncidencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ListView lvIndicencias;
        private System.Windows.Forms.ColumnHeader FechaIn;
        private System.Windows.Forms.ColumnHeader Problema;
        private System.Windows.Forms.ColumnHeader TipoIn;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader ID;
    }
}