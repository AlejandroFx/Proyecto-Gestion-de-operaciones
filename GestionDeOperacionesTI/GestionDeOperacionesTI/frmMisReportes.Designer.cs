namespace GestionDeOperacionesTI
{
    partial class frmMisReportes
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
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DescP,
            this.Tip,
            this.Stat,
            this.FechaIn,
            this.FechaF});
            this.dgvIncidencias.Location = new System.Drawing.Point(103, 160);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.RowHeadersWidth = 82;
            this.dgvIncidencias.RowTemplate.Height = 33;
            this.dgvIncidencias.Size = new System.Drawing.Size(1078, 455);
            this.dgvIncidencias.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(367, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 56);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "MIS REPORTES DE INCIDENCIAS";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.Width = 200;
            // 
            // DescP
            // 
            this.DescP.HeaderText = "Descripción del problema";
            this.DescP.MinimumWidth = 10;
            this.DescP.Name = "DescP";
            this.DescP.Width = 200;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tipo de incidencia";
            this.Tip.MinimumWidth = 10;
            this.Tip.Name = "Tip";
            this.Tip.Width = 200;
            // 
            // Stat
            // 
            this.Stat.HeaderText = "Estatus ";
            this.Stat.MinimumWidth = 10;
            this.Stat.Name = "Stat";
            this.Stat.Width = 200;
            // 
            // FechaIn
            // 
            this.FechaIn.HeaderText = "Fecha de inicio";
            this.FechaIn.MinimumWidth = 10;
            this.FechaIn.Name = "FechaIn";
            this.FechaIn.Width = 200;
            // 
            // FechaF
            // 
            this.FechaF.HeaderText = "Fecha de terminación";
            this.FechaF.MinimumWidth = 10;
            this.FechaF.Name = "FechaF";
            this.FechaF.Width = 200;
            // 
            // frmMisReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 784);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisReportes";
            this.Text = "frmMisReportes";
            this.Load += new System.EventHandler(this.frmMisReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaF;
    }
}