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
    public partial class frmAltaIncidencia : Form
    {
        private ManejaCI AdmCI;
        private ManejaIncidencia AdmIn;
        private int Tipo, IDEmp;

        public frmAltaIncidencia(ManejaCI AdmCI, ManejaIncidencia AdmIn, int IDEmp)
        {
            InitializeComponent();
            this.AdmCI = AdmCI;
            this.AdmIn = AdmIn;
            this.IDEmp = IDEmp;
        }

        private void rbnRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rbnCI.Checked)
            {
                Tipo = 1;
                frmAltaIncidenciaCI frmIncidenciaCI = new frmAltaIncidenciaCI(AdmCI,AdmIn,Tipo,IDEmp);
                frmIncidenciaCI.ShowDialog();
            }
            if (rbnRed.Checked)
            {
                Tipo = 2;
                frmAltaIncidenciaRed frmIncidenciaRed = new frmAltaIncidenciaRed(AdmIn,Tipo, IDEmp);
                frmIncidenciaRed.ShowDialog();
            }
            if (rbnSO.Checked)
            {
                Tipo = 3;
                frmAltaIncidenciaSO frmIncidenciaSO = new frmAltaIncidenciaSO(AdmIn, Tipo, IDEmp);
                frmIncidenciaSO.ShowDialog();
            }
        }

       
    }
}
