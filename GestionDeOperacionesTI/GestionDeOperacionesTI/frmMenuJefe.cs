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
   
    public partial class frmMenuJefe : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaIncidencia AdmIn;
        int IDEmp;
        public frmMenuJefe(ManejaEmpleado AdmEmp, int IDEmp, ManejaIncidencia AdmIn)
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

        private void frmMenuJefe_Load(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio(AdmEmp, IDEmp));

        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEditaPerfil(AdmEmp, IDEmp));
        }

        private void aprobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAprobarIncidencia(AdmIn));
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAsignarIncidencia(AdmIn));
        }

        private void actualizaciónCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmActualizacionCI());
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerCambios());
        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAutorizaCambios(AdmIn));
        }
    }
}
