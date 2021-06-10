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
    public partial class frmAsignarIncidencia : Form
    {
        private ManejaIncidencia AdmIn;
        int TecID = 0, InID = 0;
        public frmAsignarIncidencia(ManejaIncidencia AdmIn)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(txtTecnico.Text))
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN TECNICO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Utileria.IsEmpty(txtIncidencia.Text))
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUNA INCIDENCIA", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                AdmIn.UpdateTec(InID, TecID);
                AdmIn.UpdateStatus(InID, 4);
                MessageBox.Show("TECNICO ASIGNADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAsignarIncidencia_Load(object sender, EventArgs e)
        {
            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection2 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                return;
            }

            SqlDataReader Lector2 = null;
            string NO = "", EM = "", NC = "";
            string strComandoC2 = "SELECT Nombre,Email,Celular FROM EMPLEADO WHERE ID_Rol=3 AND Estatus=1";
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
                    NO = Lector2.GetValue(0).ToString();
                    EM = Lector2.GetValue(1).ToString();
                    NC = Lector2.GetValue(2).ToString();

                    ListViewItem Registro = new ListViewItem(NO);
                    Registro.SubItems.Add(EM);
                    Registro.SubItems.Add(NC);

                    lvTecnicos.Items.Add(Registro);
                }
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
            string INID = "", PR = "", FE = "", DP = "", TI = "";
            string strComandoC = "SELECT  I.ID, P.Descripcion, I.FechaInicio, I.Descripcion,T.Descripcion FROM INCIDENCIA I INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID INNER JOIN PRIORIDAD P ON I.ID_Prioridad=P.ID WHERE ID_Stat=3 ORDER BY I.FechaInicio";
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
                    INID = Lector.GetValue(0).ToString();
                    PR = Lector.GetValue(1).ToString();
                    FE = Lector.GetValue(2).ToString();
                    DP = Lector.GetValue(3).ToString();
                    TI = Lector.GetValue(4).ToString();

                    ListViewItem Registro2 = new ListViewItem(INID);
                    Registro2.SubItems.Add(PR);
                    Registro2.SubItems.Add(FE);
                    Registro2.SubItems.Add(DP);
                    Registro2.SubItems.Add(TI);

                    lvIncidencias.Items.Add(Registro2);
                }
            }
            Connection2.Close();
        }

        private void btnSelectTec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvTecnicos.Items.Count; i++)
            {
                if (lvTecnicos.SelectedItems.Contains(lvTecnicos.Items[i]))
                {
                    txtTecnico.Text = lvTecnicos.Items[i].SubItems[0].Text;

                    SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                    if (Connection == null)
                    {
                        MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                        foreach (SqlError E in UsoBD.ESalida.Errors)
                            MessageBox.Show(E.Message);

                        return;
                    }
                    SqlDataReader Lector = null;
                    string strComandoC = "SELECT ID FROM EMPLEADO WHERE Nombre LIKE '" + txtTecnico.Text.Trim() + "'";

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
                            TecID = Convert.ToInt32(Lector.GetValue(0).ToString());
                        }
                    }
                    Connection.Close();
                }
            }
        }

        private void btnSelectIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvIncidencias.Items.Count; i++)
            {
                if (lvIncidencias.SelectedItems.Contains(lvIncidencias.Items[i]))
                {
                    txtIncidencia.Text = lvIncidencias.Items[i].SubItems[0].Text;
                    InID = Convert.ToInt32(txtIncidencia.Text);
                }
            }
        }
    }
}
