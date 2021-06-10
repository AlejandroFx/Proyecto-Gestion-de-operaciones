namespace GestionDeOperacionesTI
{
    partial class frmActualizacionCI
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCI = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(256, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSULTA ELEMENTOS DE CONFIGURACIÓN";
            // 
            // dgwCI
            // 
            this.dgwCI.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Esta});
            this.dgwCI.Location = new System.Drawing.Point(75, 107);
            this.dgwCI.Name = "dgwCI";
            this.dgwCI.RowHeadersWidth = 82;
            this.dgwCI.RowTemplate.Height = 33;
            this.dgwCI.Size = new System.Drawing.Size(1096, 537);
            this.dgwCI.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Identificador CI";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.Width = 200;
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
            this.Column2.HeaderText = "Descripción";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Número de serie";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de adquisición";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edificio";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Encargado";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Proveedor";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Esta
            // 
            this.Esta.HeaderText = "Estatus";
            this.Esta.MinimumWidth = 10;
            this.Esta.Name = "Esta";
            this.Esta.Width = 200;
            // 
            // frmActualizacionCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 851);
            this.Controls.Add(this.dgwCI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizacionCI";
            this.Text = "frmActualizacionCI";
            this.Load += new System.EventHandler(this.frmActualizacionCI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esta;
    }
}