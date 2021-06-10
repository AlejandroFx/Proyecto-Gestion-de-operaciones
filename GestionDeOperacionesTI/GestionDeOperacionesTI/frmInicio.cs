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
    public partial class frmInicio : Form
    {
        private ManejaEmpleado AdmEmp;
        int IDEmp;
        public frmInicio(ManejaEmpleado AdmEmp, int IDEmp)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.IDEmp = IDEmp;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT E.Nombre,R.Nombre,ND.Nombre,E.Email,E.Celular,E.Direccion FROM EMPLEADO E " +
                "INNER JOIN EMPLEADO_DEPTO D ON E.ID = D.ID_Empleado " +
                "INNER JOIN DEPARTAMENTO ND ON D.ID_Depto = ND.ID " +
                "INNER JOIN ROL R ON E.ID_Rol = R.ID WHERE E.ID ="+IDEmp;

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
                    lblNombre.Text = Lector.GetValue(0).ToString();
                    lblRol.Text = Lector.GetValue(1).ToString();
                    lblDepto.Text = Lector.GetValue(2).ToString();
                    lblEmail.Text = Lector.GetValue(3).ToString();
                    lblNumCel.Text = Lector.GetValue(4).ToString();
                    lblDir.Text = Lector.GetValue(5).ToString();
                }
            }
            Connection.Close();
        }

    }

}
