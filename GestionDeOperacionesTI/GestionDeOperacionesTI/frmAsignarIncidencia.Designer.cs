namespace GestionDeOperacionesTI
{
    partial class frmAsignarIncidencia
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvTecnicos = new System.Windows.Forms.ListView();
            this.NameTec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIncidencias = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectTec = new System.Windows.Forms.Button();
            this.btnSelectIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(1122, 412);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(203, 80);
            this.btnAsignar.TabIndex = 16;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(590, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 56);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "ASIGNAR INCIDENCIA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtTecnico);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(943, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 145);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tecnico";
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(20, 66);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.ReadOnly = true;
            this.txtTecnico.Size = new System.Drawing.Size(502, 58);
            this.txtTecnico.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txtIncidencia);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(943, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 157);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID indicencia";
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Location = new System.Drawing.Point(20, 66);
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.ReadOnly = true;
            this.txtIncidencia.Size = new System.Drawing.Size(502, 58);
            this.txtIncidencia.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 56);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tecnicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 56);
            this.label2.TabIndex = 24;
            this.label2.Text = "Incidencias";
            // 
            // lvTecnicos
            // 
            this.lvTecnicos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvTecnicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameTec,
            this.Email,
            this.Cel});
            this.lvTecnicos.HideSelection = false;
            this.lvTecnicos.Location = new System.Drawing.Point(22, 119);
            this.lvTecnicos.Name = "lvTecnicos";
            this.lvTecnicos.Size = new System.Drawing.Size(890, 280);
            this.lvTecnicos.TabIndex = 25;
            this.lvTecnicos.UseCompatibleStateImageBehavior = false;
            this.lvTecnicos.View = System.Windows.Forms.View.Details;
            // 
            // NameTec
            // 
            this.NameTec.Text = "Nombre";
            this.NameTec.Width = 290;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 282;
            // 
            // Cel
            // 
            this.Cel.Text = "Número celular";
            this.Cel.Width = 213;
            // 
            // lvIncidencias
            // 
            this.lvIncidencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvIncidencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Prioridad,
            this.FechaIn,
            this.Desc,
            this.Tip});
            this.lvIncidencias.HideSelection = false;
            this.lvIncidencias.Location = new System.Drawing.Point(22, 487);
            this.lvIncidencias.Name = "lvIncidencias";
            this.lvIncidencias.Size = new System.Drawing.Size(890, 299);
            this.lvIncidencias.TabIndex = 26;
            this.lvIncidencias.UseCompatibleStateImageBehavior = false;
            this.lvIncidencias.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Prioridad
            // 
            this.Prioridad.Text = "Prioridad";
            this.Prioridad.Width = 114;
            // 
            // FechaIn
            // 
            this.FechaIn.Text = "Fecha de inicio";
            this.FechaIn.Width = 167;
            // 
            // Desc
            // 
            this.Desc.Text = "Descripcion del problema";
            this.Desc.Width = 344;
            // 
            // Tip
            // 
            this.Tip.Text = "Tipo de incidencia";
            this.Tip.Width = 203;
            // 
            // btnSelectTec
            // 
            this.btnSelectTec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelectTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTec.Location = new System.Drawing.Point(1090, 119);
            this.btnSelectTec.Name = "btnSelectTec";
            this.btnSelectTec.Size = new System.Drawing.Size(300, 79);
            this.btnSelectTec.TabIndex = 32;
            this.btnSelectTec.Text = "Seleccionar tecnico";
            this.btnSelectTec.UseVisualStyleBackColor = false;
            this.btnSelectTec.Click += new System.EventHandler(this.btnSelectTec_Click);
            // 
            // btnSelectIn
            // 
            this.btnSelectIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelectIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectIn.Location = new System.Drawing.Point(1090, 695);
            this.btnSelectIn.Name = "btnSelectIn";
            this.btnSelectIn.Size = new System.Drawing.Size(300, 77);
            this.btnSelectIn.TabIndex = 33;
            this.btnSelectIn.Text = "Seleccionar incidencia";
            this.btnSelectIn.UseVisualStyleBackColor = false;
            this.btnSelectIn.Click += new System.EventHandler(this.btnSelectIn_Click);
            // 
            // frmAsignarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 822);
            this.Controls.Add(this.btnSelectIn);
            this.Controls.Add(this.btnSelectTec);
            this.Controls.Add(this.lvIncidencias);
            this.Controls.Add(this.lvTecnicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAsignar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignarIncidencia";
            this.Text = "frmAsignarIncidencia";
            this.Load += new System.EventHandler(this.frmAsignarIncidencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvTecnicos;
        private System.Windows.Forms.ListView lvIncidencias;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Prioridad;
        private System.Windows.Forms.ColumnHeader FechaIn;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader NameTec;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Cel;
        private System.Windows.Forms.Button btnSelectTec;
        private System.Windows.Forms.Button btnSelectIn;
    }
}