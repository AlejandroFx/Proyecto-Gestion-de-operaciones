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
    public partial class frmUpdateDepartamento : Form
    {
        private ManejaDepartamento AdmDep;
        private ManejaEmpleado AdmEmp;
        public frmUpdateDepartamento(ManejaDepartamento AdmDep, ManejaEmpleado AdmEmp)
        {
            InitializeComponent();
            this.AdmDep = AdmDep;
            this.AdmEmp = AdmEmp;
        }

        private void frmUpdateDepartamento_Load(object sender, EventArgs e)
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

            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection2 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
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
                    cmbDepartamentos.Items.Add(Lector2.GetValue(0).ToString());
                }
            }

            Connection.Close();
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Dep = cmbDepartamentos.SelectedItem.ToString();
            int DepID = AdmDep.GetID(Dep);
            lblEnc.Text = AdmDep.EncDep(DepID);
            lblDepto.Text = cmbDepartamentos.SelectedItem.ToString();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Dep = cmbDepartamentos.SelectedItem.ToString();
            int DepID = AdmDep.GetID(Dep);
            string Nom = txtNombre.Text;

            if (!(Utileria.IsEmpty(Nom)))
            {
                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando = "UPDATE DEPARTAMENTO SET Nombre=@Nombre WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando, Connection);

                Update.Parameters.AddWithValue("@Nombre", Nom);
                Update.Parameters.AddWithValue("@ID", DepID);

                try
                {
                    Update.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Connection.Close();
                    return;
                }
                Connection.Close();
            }
            if (cmbEncargado.SelectedIndex >= 0)
            {
                string Enc = cmbEncargado.SelectedItem.ToString();
                int EncID = AdmEmp.GetIDByName(Enc);
                AdmDep.UpdateEnc(EncID, DepID);
            }
            MessageBox.Show("DEPARTAMENTO ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
