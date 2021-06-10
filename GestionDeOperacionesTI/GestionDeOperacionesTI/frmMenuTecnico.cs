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
    public partial class frmMenuTecnico : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaIncidencia AdmIn;
        int IDEmp;
        public frmMenuTecnico(ManejaEmpleado AdmEmp, int IDEmp, ManejaIncidencia AdmIn)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.IDEmp = IDEmp;
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

        private void frmMenuTecnico_Load(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp, IDEmp));
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEditaPerfil(AdmEmp, IDEmp));
        }

        private void tiempoDeRespuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmTiempoRespuestaIncidencia(AdmIn,IDEmp));
        }

        private void liberacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmLiberarIncidencia(AdmIn, IDEmp));
        }

        private void actualizaciónCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmActualizacionCI());
        }

        private void retroalimentaciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new frmRetroalimentacion(IDEmp));
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaProblemasConocidos());
        }

        private void visualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerProblemasConocidos());
        }

        private void problemasConocidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSolicitaCambio(IDEmp));
        }

        private void verCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmMisSolicitudesCambio(IDEmp));
        }
    }
}
