namespace GestionDeOperacionesTI
{
    partial class frmRetroalimentacion
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
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(367, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(551, 56);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "MIS INCIDENCIAS SOLUCIONADAS";
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DescP,
            this.Tip,
            this.FechaIn,
            this.FechaF,
            this.TiempoR,
            this.Cali,
            this.Ret});
            this.dgvIncidencias.Location = new System.Drawing.Point(103, 183);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.RowHeadersWidth = 82;
            this.dgvIncidencias.RowTemplate.Height = 33;
            this.dgvIncidencias.Size = new System.Drawing.Size(1078, 455);
            this.dgvIncidencias.TabIndex = 41;
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
            // TiempoR
            // 
            this.TiempoR.HeaderText = "Tiempo de respuesta";
            this.TiempoR.MinimumWidth = 10;
            this.TiempoR.Name = "TiempoR";
            this.TiempoR.Width = 200;
            // 
            // Cali
            // 
            this.Cali.HeaderText = "Calificación";
            this.Cali.MinimumWidth = 10;
            this.Cali.Name = "Cali";
            this.Cali.Width = 200;
            // 
            // Ret
            // 
            this.Ret.HeaderText = "Comentario";
            this.Ret.MinimumWidth = 10;
            this.Ret.Name = "Ret";
            this.Ret.Width = 200;
            // 
            // frmRetroalimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 855);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetroalimentacion";
            this.Text = "frmRetroalimentacion";
            this.Load += new System.EventHandler(this.frmRetroalimentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cali;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ret;
    }
}