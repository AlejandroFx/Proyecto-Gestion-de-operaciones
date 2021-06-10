using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace GestionDeOperacionesTI
{
    public partial class frmMenuAdministrador : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaDepartamento AdmDept;
        private ManejaCI AdmCI;
        private ManejaProveedor AdmProv;
        int IDEmp;
        public frmMenuAdministrador(ManejaEmpleado AdmEmp, ManejaDepartamento AdmDepto, ManejaCI AdmCI, ManejaProveedor AdmProv, int IDEmp)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmDept = AdmDepto;
            this.AdmCI = AdmCI;
            this.AdmProv = AdmProv;
            this.IDEmp = IDEmp;
        }

        private void AbrirForm(object formP)
        {
            if(this.pnContenido.Controls.Count > 0)
            {
                this.pnContenido.Controls.Clear();
                Form frm = formP as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.pnContenido.Controls.Add(frm);
                this.pnContenido.Tag = frm;
                frm.Show();
            }
        }

        private void editarPerfilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new frmEditaPerfil(AdmEmp,IDEmp));
        }

        private void frmMenuAdministrador_Load(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp, IDEmp));
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp,IDEmp));
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaEmpleado(AdmEmp,AdmDept));
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaDepartamento(AdmEmp,AdmDept));
        }

        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaCI(AdmEmp,AdmCI,AdmProv));
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmBajaEmpleado(AdmEmp,AdmDept));
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmBajaDepartamento(AdmDept));
        }

        private void elementosCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmBajaCI(AdmCI));
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUpdateEmpleado(AdmEmp,AdmDept));
        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUpdateDepartamento(AdmDept,AdmEmp));
        }

        private void elementosCIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUpdateCI(AdmCI,AdmProv,AdmEmp));
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmConsultaEmpleado());
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmConsultaDepartamento());
        }

        private void elementosCIToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmConsultaCI());
        }

        private void actualizacionesCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmActualizacionCI());
        }
    }
}
