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
    public partial class frmBajaDepartamento : Form
    {
        private ManejaDepartamento AdmDept;
        public frmBajaDepartamento(ManejaDepartamento AdmDept)
        {
            InitializeComponent();
            this.AdmDept = AdmDept;
        }

        private void frmBajaDepartamento_Load(object sender, EventArgs e)
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
            string NA = "", EN= "";
            string strComandoC = "SELECT D.Nombre,E.Nombre FROM DEPARTAMENTO D INNER JOIN EMPLEADO E ON D.ID_EmpEncar=E.ID AND D.Estatus=1";
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
                    NA = Lector.GetValue(0).ToString();
                    EN = Lector.GetValue(1).ToString();

                    ListViewItem Registro = new ListViewItem(NA);
                    Registro.SubItems.Add(EN);

                    lvDepartamentos.Items.Add(Registro);
                }
            }
            Connection.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvDepartamentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN DEPARTAMENTO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL DEPARTAMENTO SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                string NA;
                for (int i = 0; i < lvDepartamentos.Items.Count; i++)
                {
                    if (lvDepartamentos.SelectedItems.Contains(lvDepartamentos.Items[i]))
                    {
                        NA = lvDepartamentos.Items[i].SubItems[0].Text;
                        int DepID=AdmDept.GetID(NA);
                        if (true)
                        {
                            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector3 = null;
                            string strComandoC3 = "SELECT ID_Empleado FROM EMPLEADO_DEPTO WHERE ID_Depto=" + DepID;

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
                                    AdmDept.UpdateEstatus(DepID);
                                    MessageBox.Show("LA BAJA DEL DEPARTAMENTO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lvDepartamentos.Items[i].Remove();
                                    Connection3.Close();
                                    return;
                                }
                            }
                            Connection3.Close();
                        }

                        SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                        if (Connection == null)
                        {
                            MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            return;
                        }

                        SqlDataReader Lector = null;

                        string strComandoC = "DELETE FROM DEPARTAMENTO WHERE Nombre LIKE '" + NA + "'";

                        Lector = UsoBD.Consulta(strComandoC, Connection);
                        if (Lector == null)
                        {
                            MessageBox.Show("ERROR AL HACER LA CONSULTA");
                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            Connection.Close();
                            return;
                        }
                        Connection.Close();
                        lvDepartamentos.Items[i].Remove();
                        MessageBox.Show("LA ELIMINACION DEL DEPARTAMENTO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }
    }
}
