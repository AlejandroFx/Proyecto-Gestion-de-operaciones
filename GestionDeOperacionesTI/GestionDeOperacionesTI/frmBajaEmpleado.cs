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
    public partial class frmBajaEmpleado : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaDepartamento AdmDept;
        public frmBajaEmpleado(ManejaEmpleado AdmEmp,ManejaDepartamento AdmDept)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmDept = AdmDept;
        }

        private void frmBajaEmpleado_Load(object sender, EventArgs e)
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
            string NA = "", EM = "", CE = "", DI = "", RO = "";
            string strComandoC = "SELECT E.Nombre,Email,Celular,Direccion,R.Nombre FROM EMPLEADO E INNER JOIN ROL R ON E.ID_Rol=R.ID WHERE Estatus=1";
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
                    EM = Lector.GetValue(1).ToString();
                    CE = Lector.GetValue(2).ToString();
                    DI = Lector.GetValue(3).ToString();
                    RO = Lector.GetValue(3).ToString();

                    ListViewItem Registro = new ListViewItem(NA);
                    Registro.SubItems.Add(EM);
                    Registro.SubItems.Add(CE);
                    Registro.SubItems.Add(DI);
                    Registro.SubItems.Add(RO);

                    lvEmpleados.Items.Add(Registro);
                }
            }
            Connection.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvEmpleados.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN EMPLEADO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL EMPLEADO SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                string NA, EM;
                for (int i = 0; i < lvEmpleados.Items.Count; i++)
                {
                    if (lvEmpleados.SelectedItems.Contains(lvEmpleados.Items[i]))
                    {
                        NA = lvEmpleados.Items[i].SubItems[0].Text;
                        EM = lvEmpleados.Items[i].SubItems[1].Text;
                        int EmpID = AdmEmp.GetIDByName(NA);
                        if (true)
                        {
                            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector3 = null;
                            string strComandoC3 = "SELECT ID FROM DEPARTAMENTO WHERE ID_EmpEncar=" + EmpID;

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
                                    AdmEmp.UpdateEstatus(EmpID);
                                    MessageBox.Show("LA BAJA DEL EMPLEADO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lvEmpleados.Items[i].Remove();
                                    Connection3.Close();
                                    return;
                                }
                            }
                            Connection3.Close();

                            SqlConnection Connection4 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector4 = null;
                            string strComandoC4 = "SELECT  I.ID FROM INCIDENCIA I WHERE I.ID_Tecnico=" + EmpID;

                            Lector4 = UsoBD.Consulta(strComandoC4, Connection4);
                            if (Lector4 == null)
                            {
                                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                                foreach (SqlError E in UsoBD.ESalida.Errors)
                                    MessageBox.Show(E.Message);

                                Connection4.Close();
                                return;
                            }
                            if (Lector4.HasRows)
                            {
                                while (Lector4.Read())
                                {
                                    AdmEmp.UpdateEstatus(EmpID);
                                    MessageBox.Show("LA BAJA DEL EMPLEADO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lvEmpleados.Items[i].Remove();
                                    Connection4.Close();
                                    return;
                                }
                            }
                            Connection4.Close();


                            SqlConnection Connection5 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector5 = null;
                            string strComandoC5 = "SELECT ID FROM INCIDENCIA WHERE ID_Usuario=" + EmpID;

                            Lector5 = UsoBD.Consulta(strComandoC5, Connection5);
                            if (Lector5 == null)
                            {
                                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                                foreach (SqlError E in UsoBD.ESalida.Errors)
                                    MessageBox.Show(E.Message);

                                Connection5.Close();
                                return;
                            }
                            if (Lector5.HasRows)
                            {
                                while (Lector5.Read())
                                {
                                    AdmEmp.UpdateEstatus(EmpID);
                                    MessageBox.Show("LA BAJA DEL EMPLEADO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lvEmpleados.Items[i].Remove();
                                    Connection4.Close();
                                    return;
                                }
                            }
                            Connection4.Close();
                        }
                            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector2 = null;
                            string strComandoC2 = "DELETE FROM EMPLEADO_DEPTO WHERE ID_Empleado=" + EmpID;

                            Lector2 = UsoBD.Consulta(strComandoC2, Connection2);
                            if (Lector2 == null)
                            {
                                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                                foreach (SqlError E in UsoBD.ESalida.Errors)
                                    MessageBox.Show(E.Message);

                                Connection2.Close();
                                return;
                            }
                            Connection2.Close();

                            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                            if (Connection == null)
                            {
                                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                                foreach (SqlError E in UsoBD.ESalida.Errors)
                                    MessageBox.Show(E.Message);

                                return;
                            }

                            SqlDataReader Lector = null;
                            string strComandoC = "DELETE FROM EMPLEADO WHERE Nombre LIKE '" + NA + "' AND Email LIKE '" + EM + "'";

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

                            lvEmpleados.Items[i].Remove();
                            MessageBox.Show("LA ELIMINACION DEL EMPLEADO SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                }
            }
        }
    }
}
