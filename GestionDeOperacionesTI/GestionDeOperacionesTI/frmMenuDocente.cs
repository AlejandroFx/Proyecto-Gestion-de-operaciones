using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeOperacionesTI
{
    public partial class frmMenuDocente : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaCI AdmCI;
        private ManejaIncidencia AdmIn;

        int IDEmp;
        public frmMenuDocente(ManejaEmpleado AdmEmp, int IDEmp, ManejaCI AdmCI, ManejaIncidencia AdmIn)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.IDEmp = IDEmp;
            this.AdmCI = AdmCI;
            this.AdmIn = AdmIn;
        }
        private void AbrirForm(object formP)
        {
            if (this.pnContenido.Controls.Count > 0)
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp, IDEmp));
        }

        private void frmMenuDocente_Load(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp, IDEmp));
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEditaPerfil(AdmEmp, IDEmp));
        }

        private void altaIndicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaIncidencia(AdmCI,AdmIn, IDEmp));
        }

        private void evaluarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEvaluarIncidencia(AdmIn, IDEmp));
        }

        private void misReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmMisReportes(IDEmp));
        }

        private void pnContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
