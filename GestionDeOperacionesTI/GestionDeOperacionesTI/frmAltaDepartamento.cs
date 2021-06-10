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
    public partial class frmAltaDepartamento : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaDepartamento AdmDept;

        public frmAltaDepartamento(ManejaEmpleado AdmEmp, ManejaDepartamento AdmDept)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmDept = AdmDept;
        }

        private void frmAltaDepartamento_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                return;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Nombre FROM EMPLEADO WHERE Estatus=1";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    cmbEncargado.Items.Add(Lector.GetValue(0).ToString());
                }
            }
             Connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA AGREGAR ESTE DEPARTAMENTO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if (Utileria.IsEmpty(txtNombre.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL NOMBRE DEL DEPARTAMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Rol = AdmEmp.GetIDNameByRol(cmbEncargado.SelectedItem.ToString());
            if (AdmDept.AddDepto(txtNombre.Text,Rol))
            {
                MessageBox.Show("DEPARTAMENTO AGREGADO EXITOSAMENRE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
