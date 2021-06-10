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
    public partial class frmAltaIncidenciaSO : Form
    {
        private ManejaIncidencia AdmIn;
        private int Tipo, IDEmp;
        public frmAltaIncidenciaSO(ManejaIncidencia AdmIn, int TipoIn, int IDEmp)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
            Tipo = TipoIn;
            this.IDEmp = IDEmp;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA AGREGAR ESTE ELEMENTO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if (Utileria.IsEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA DESCRIPCION DEL PROBLEMA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdmIn.AddInSO(txtDescripcion.Text, maskDate.Text, Tipo, IDEmp);
        }
    }
}
