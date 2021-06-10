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
    public partial class Login : Form
    {
        public static ManejaEmpleado AdmEmp;
        public ManejaDepartamento AdmDepto;
        public ManejaIncidencia AdmInci;
        public ManejaCI AdmCI;
        public ManejaProveedor AdmProv;
        public Login()
        {
            InitializeComponent();
            AdmEmp = new ManejaEmpleado();
            AdmDepto = new ManejaDepartamento();
            AdmInci = new ManejaIncidencia();
            AdmCI = new ManejaCI();
            AdmProv = new ManejaProveedor();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Email = txtUsuario.Text;
            int ID = AdmEmp.GetID(Email.ToString());
            int Rol = AdmEmp.GetIDRol(ID);

            if (Utileria.IsEmpty(Email))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL EMAIL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtContraseña.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ID == 0)
            {
                MessageBox.Show("EL EMAIL INGRESADO ES INCORRECTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(AdmEmp.CheckPass(Email, txtContraseña.Text)))
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (Rol)
            {
                case 1:
                    frmMenuAdministrador frmMenuAdmi = new frmMenuAdministrador(AdmEmp, AdmDepto, AdmCI, AdmProv, ID);
                    frmMenuAdmi.ShowDialog();
                    break;
                case 2:
                    frmMenuJefe frmMenuJefeTaller = new frmMenuJefe(AdmEmp,ID,AdmInci);
                    frmMenuJefeTaller.ShowDialog();
                    break;
                case 3:
                    frmMenuTecnico frmMenuTec = new frmMenuTecnico(AdmEmp,ID,AdmInci);
                    frmMenuTec.ShowDialog();
                    break;
                case 4:
                    frmMenuDocente frmMenuDoc = new frmMenuDocente(AdmEmp,ID,AdmCI,AdmInci);
                    frmMenuDoc.ShowDialog();
                    break;
            }
        }
        
    }
}
