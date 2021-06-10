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
    public partial class frmEditaPerfil : Form
    {
        private ManejaEmpleado AdmEmp;
        int IDEmp;
        public frmEditaPerfil(ManejaEmpleado AdmEmp, int IDEmp)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.IDEmp = IDEmp;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA GUARDAR LOS CAMBIOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            string NumCel = txtNumCel.Text;
            string Dir = txtDir.Text;
            string Cont = txtContraseña.Text;

            if (Utileria.ValidaTextoNum(NumCel))
            {
                MessageBox.Show("EN ESTE CAMPO SOLO SE ACEPTAN NUMEROS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(Utileria.IsEmpty(NumCel)))
            {
                AdmEmp.UpdateCel(IDEmp, NumCel);
                MessageBox.Show("NÚMERO CELULAR ACTUALIZADO", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!(Utileria.IsEmpty(Dir)))
            {
                AdmEmp.UpdateDir(IDEmp, Dir);
                MessageBox.Show("DIRECCIÓN ACTUALIZADA", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!(Utileria.IsEmpty(Cont)))
            {
                AdmEmp.UpdatePass(IDEmp, Cont);
                MessageBox.Show("CONTRASEÑA ACTUALIZADA", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            Limpiar();
            
        }
        private void Limpiar()
        {
            txtNumCel.Text = "";
            txtDir.Text = "";
            txtContraseña.Text = "";
        }

        private void frmEditaPerfil_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Celular,Direccion FROM EMPLEADO WHERE ID =" + IDEmp;

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    lblNumCel.Text = Lector.GetValue(0).ToString();
                    lblDir.Text = Lector.GetValue(1).ToString();

                }
            }
            Connection.Close();
        }
    }
}
