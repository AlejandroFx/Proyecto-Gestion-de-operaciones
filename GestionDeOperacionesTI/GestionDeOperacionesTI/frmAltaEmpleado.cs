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
    public partial class frmAltaEmpleado : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaDepartamento AdmDepto;

        public frmAltaEmpleado(ManejaEmpleado AdmEmp, ManejaDepartamento AdmDepto)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmDepto = AdmDepto;
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
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

            string strComandoC = "SELECT Nombre FROM ROL";

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
                    cmbRol.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();

            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());
            SqlDataReader Lector2 = null;
            string strComandoC2 = "SELECT Nombre FROM DEPARTAMENTO WHERE Estatus=1";

            Lector2 = UsoBD.Consulta(strComandoC2, Connection2);
            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection2.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    cmbDepto.Items.Add(Lector2.GetValue(0).ToString());
                }
            }
            Connection2.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA AGREGAR ESTE EMPLEADO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if (Utileria.IsEmpty(txtNombre.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL NOMBRE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtEmail.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL EMAIL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtDireccion.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA DIRECCION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.ValidaTextoNum(txtCelular.Text))
            {
                MessageBox.Show("EN ESTE CAMPO SOLO SE ACEPTAN NUMEROS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Rol=AdmEmp.GetIDByNameRol(cmbRol.SelectedItem.ToString());

            if (AdmEmp.AddEmp(txtNombre.Text, txtEmail.Text, txtCelular.Text, txtDireccion.Text, Rol))
            {
                MessageBox.Show("EMPLEADO AGREGADO EXITOSAMENRE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int DepID = AdmDepto.GetID(cmbDepto.SelectedItem.ToString());
            int EmpID = AdmEmp.GetIDByName(txtNombre.Text);

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            string strComando = "INSERT INTO EMPLEADO_DEPTO(ID_Empleado,ID_Depto)";
            strComando += " VALUES(@ID_Empleado, @ID_Depto)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@ID_Empleado", EmpID);
            Insert.Parameters.AddWithValue("@ID_Depto", DepID);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();

            }

            Connection.Close();
        }
    }
}
