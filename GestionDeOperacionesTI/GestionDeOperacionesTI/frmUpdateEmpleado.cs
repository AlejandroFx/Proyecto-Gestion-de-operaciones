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
    public partial class frmUpdateEmpleado : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaDepartamento AdmDept;
        public frmUpdateEmpleado(ManejaEmpleado AdmEmp, ManejaDepartamento AdmDept)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmDept = AdmDept;
        }
        private void frmUpdateEmpleado_Load(object sender, EventArgs e)
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

            string strComandoC2 = "SELECT Nombre FROM ROL";

            Lector2 = UsoBD.Consulta(strComandoC2, Connection2);
            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    cmbRol.Items.Add(Lector2.GetValue(0).ToString());
                }
            }
            Connection2.Close();

            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection3 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector3 = null;

            string strComandoC3 = "SELECT Nombre FROM DEPARTAMENTO WHERE Estatus=1";

            Lector3 = UsoBD.Consulta(strComandoC3, Connection3);
            if (Lector3 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection3.Close();
                return;
            }
            if (Lector3.HasRows)
            {
                while (Lector3.Read())
                {
                    cmbDep.Items.Add(Lector3.GetValue(0).ToString());
                }
            }
            Connection3.Close();
        }
        private void cmbEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = AdmEmp.GetIDName(cmbEncargado.SelectedItem.ToString());
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT E.Nombre,E.Celular,E.Email,E.Direccion,D.Nombre FROM EMPLEADO E INNER JOIN EMPLEADO_DEPTO ED ON E.ID=ED.ID_Empleado INNER JOIN DEPARTAMENTO D ON D.ID=ED.ID_Depto WHERE E.ID=" + ID;

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
                    txtNombre.Text = Lector.GetValue(0).ToString();
                    txtNumCel.Text = Lector.GetValue(1).ToString();
                    txtEmail.Text = Lector.GetValue(2).ToString();
                    txtDir.Text = Lector.GetValue(3).ToString();
                    lblRol.Text = AdmEmp.GetRol(ID);
                    lblDep.Text = Lector.GetValue(4).ToString();

                }
            }
            Connection.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA GUARDAR LOS CAMBIOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            int ID = AdmEmp.GetIDName(cmbEncargado.SelectedItem.ToString());
            string Nombre = txtNombre.Text;
            string NumCel = txtNumCel.Text;
            string Email = txtEmail.Text;
            string Dir = txtDir.Text;
            

            if (!(Utileria.IsEmpty(Nombre)))
            {
                AdmEmp.UpdateNom(ID, Nombre);
            }
            if (!(Utileria.IsEmpty(NumCel)))
            {
                AdmEmp.UpdateCel(ID, NumCel);
            }
            if (!(Utileria.IsEmpty(Email)))
            {
                AdmEmp.UpdateEmail(ID, Email);
            }
            if (!(Utileria.IsEmpty(Dir)))
            {
                AdmEmp.UpdateDir(ID, Dir);
            }
            if (cmbRol.SelectedIndex >= 0)
            {
                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
                int Rol = 0;

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                SqlDataReader Lector = null;

                string strComandoC = "SELECT ID FROM ROL WHERE NOMBRE LIKE '" + cmbRol.SelectedItem.ToString() + "'";

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
                        Rol = Convert.ToInt32(Lector.GetValue(0).ToString());
                    }
                }
                Connection.Close();

                AdmEmp.UpdateRolID(ID, Rol);
            }
            if (cmbDep.SelectedIndex >= 0)
            {
                int DepID = AdmDept.GetID(cmbDep.SelectedItem.ToString());
                AdmDept.UpdateDep(ID, DepID);
            }
                MessageBox.Show("EMPLEADO ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
