namespace GestionDeOperacionesTI
{
    partial class frmLiberarIncidencia
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
            this.btnAct = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvIndicencias = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Problema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.Location = new System.Drawing.Point(701, 593);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(222, 90);
            this.btnAct.TabIndex = 40;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(530, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(384, 56);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "TERMINAR INCIDENCIA";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(50, 48);
            this.maskDate.Mask = "0000/00/00";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(318, 58);
            this.maskDate.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.maskDate);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(123, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 135);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de solución YY/MM/DD";
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
            this.TimeRes});
            this.lvIndicencias.HideSelection = false;
            this.lvIndicencias.Location = new System.Drawing.Point(23, 129);
            this.lvIndicencias.Name = "lvIndicencias";
            this.lvIndicencias.Size = new System.Drawing.Size(1026, 407);
            this.lvIndicencias.TabIndex = 44;
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
            // TimeRes
            // 
            this.TimeRes.Text = "Tiempo de respuesta";
            this.TimeRes.Width = 231;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1129, 401);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(214, 79);
            this.btnSelect.TabIndex = 45;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txtIn);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1073, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 129);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incidencia";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(35, 48);
            this.txtIn.Name = "txtIn";
            this.txtIn.ReadOnly = true;
            this.txtIn.Size = new System.Drawing.Size(248, 58);
            this.txtIn.TabIndex = 0;
            // 
            // frmLiberarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lvIndicencias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLiberarIncidencia";
            this.Text = "frmLiberarIncidencia";
            this.Load += new System.EventHandler(this.frmLiberarIncidencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvIndicencias;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Problema;
        private System.Windows.Forms.ColumnHeader TipoIn;
        private System.Windows.Forms.ColumnHeader Prio;
        private System.Windows.Forms.ColumnHeader FechaIn;
        private System.Windows.Forms.ColumnHeader TimeRes;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIn;
    }
}