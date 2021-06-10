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
    public partial class frmBajaCI : Form
    {
        private ManejaCI AdmCI;
        public frmBajaCI(ManejaCI AdmCI)
        {
            InitializeComponent();
            this.AdmCI = AdmCI;
        }

        private void frmBajaCI_Load(object sender, EventArgs e)
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
            string NA = "",DE = "",NUM = "",FE = "",LO = "",EN = "",P = "";
            string strComandoC = "SELECT CI.Nombre,CI.Descripcion,CI.NumSerie,CI.FechaAdquisicion,E.Nombre,EM.Nombre,P.Nombre FROM CI " +
                "INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID " +
                "INNER JOIN EDIFICIO E ON L.ID_Edificio = E.ID " +
                "INNER JOIN EMPLEADO EM ON CI.ID_Encargado = EM.ID " +
                "INNER JOIN PROVEEDOR P ON CI.ID_Proveedor = P.ID AND CI.Estatus=1";
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
                    DE = Lector.GetValue(1).ToString();
                    NUM = Lector.GetValue(2).ToString();
                    FE = Lector.GetValue(3).ToString();
                    LO = Lector.GetValue(4).ToString();
                    EN = Lector.GetValue(5).ToString();
                    P = Lector.GetValue(6).ToString();

                    ListViewItem Registro = new ListViewItem(NA);
                    Registro.SubItems.Add(DE);
                    Registro.SubItems.Add(NUM);
                    Registro.SubItems.Add(FE);
                    Registro.SubItems.Add(LO);
                    Registro.SubItems.Add(EN);
                    Registro.SubItems.Add(P);

                    lvCI.Items.Add(Registro);
                }
            }
            Connection.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvCI.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN ELEMENTO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL CI SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                string NU="";
                for (int i = 0; i < lvCI.Items.Count; i++)
                {
                    if (lvCI.SelectedItems.Contains(lvCI.Items[i]))
                    {
                        
                        NU = lvCI.Items[i].SubItems[2].Text;
                        int IDCI= AdmCI.GetID(NU); 
                        AdmCI.UpdateEstatus(IDCI);

                        if (true)
                        {
                            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());
                            SqlDataReader Lector3 = null;
                            string strComandoC3 = "SELECT ID FROM INCIDENCIA I WHERE I.ID_CI=" + IDCI;

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
                                    MessageBox.Show("LA BAJA DEL CI SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lvCI.Items[i].Remove();
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

                        string strComandoC = "DELETE FROM CI WHERE NumSerie LIKE'"+NU+"'";

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
                        lvCI.Items[i].Remove();
                        MessageBox.Show("LA ELIMINACION DEL CI SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }
    }
}