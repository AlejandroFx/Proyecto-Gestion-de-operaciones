namespace GestionDeOperacionesTI
{
    partial class frmConsultaDepartamento
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
            this.dgwDepartamento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDepartamento
            // 
            this.dgwDepartamento.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwDepartamento.Location = new System.Drawing.Point(190, 180);
            this.dgwDepartamento.Name = "dgwDepartamento";
            this.dgwDepartamento.RowHeadersWidth = 82;
            this.dgwDepartamento.RowTemplate.Height = 33;
            this.dgwDepartamento.Size = new System.Drawing.Size(913, 446);
            this.dgwDepartamento.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del encargado";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(439, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTA DEPARTAMENTO";
            // 
            // frmConsultaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 808);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaDepartamento";
            this.Text = "frmfrmConsultaDepartamento";
            this.Load += new System.EventHandler(this.frmConsultaDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}