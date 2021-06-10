namespace GestionDeOperacionesTI
{
    partial class frmVerCambios
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
            this.dgwCI = new System.Windows.Forms.DataGridView();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCI)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(377, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(563, 56);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "CONSULTA CAMBIOS SOLICITADOS";
            // 
            // dgwCI
            // 
            this.dgwCI.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.In,
            this.Cam,
            this.Est,
            this.FechSol,
            this.FechF});
            this.dgwCI.Location = new System.Drawing.Point(63, 127);
            this.dgwCI.Name = "dgwCI";
            this.dgwCI.RowHeadersWidth = 82;
            this.dgwCI.RowTemplate.Height = 33;
            this.dgwCI.Size = new System.Drawing.Size(1184, 506);
            this.dgwCI.TabIndex = 25;
            // 
            // In
            // 
            this.In.HeaderText = "Incidencia";
            this.In.MinimumWidth = 10;
            this.In.Name = "In";
            this.In.Width = 200;
            // 
            // Cam
            // 
            this.Cam.HeaderText = "Cambio solicitado ";
            this.Cam.MinimumWidth = 10;
            this.Cam.Name = "Cam";
            this.Cam.Width = 200;
            // 
            // Est
            // 
            this.Est.HeaderText = "Estatus";
            this.Est.MinimumWidth = 10;
            this.Est.Name = "Est";
            this.Est.Width = 200;
            // 
            // FechSol
            // 
            this.FechSol.HeaderText = "Fecha de solicitud";
            this.FechSol.MinimumWidth = 10;
            this.FechSol.Name = "FechSol";
            this.FechSol.Width = 200;
            // 
            // FechF
            // 
            this.FechF.HeaderText = "Fecha de solución";
            this.FechF.MinimumWidth = 10;
            this.FechF.Name = "FechF";
            this.FechF.Width = 200;
            // 
            // frmVerCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1503, 806);
            this.Controls.Add(this.dgwCI);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerCambios";
            this.Text = "frmVerCambios";
            this.Load += new System.EventHandler(this.frmVerCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgwCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechF;
    }
}