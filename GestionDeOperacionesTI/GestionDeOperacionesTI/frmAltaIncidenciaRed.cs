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
    public partial class frmAltaIncidenciaRed : Form
    {
        private ManejaIncidencia AdmIn;
        private int Tipo, IDEmp;
        public frmAltaIncidenciaRed(ManejaIncidencia AdmIn, int TipoIn, int IDEmp)
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
            if (Utileria.IsEmpty(txtDescUbicacion.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA UBICACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdmIn.AddInRed(txtDescripcion.Text, maskDate.Text,txtDescUbicacion.Text,Tipo, IDEmp);
        }
    }
}
