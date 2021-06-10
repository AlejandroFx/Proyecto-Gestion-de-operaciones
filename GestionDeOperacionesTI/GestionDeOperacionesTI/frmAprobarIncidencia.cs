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
    public partial class frmAprobarIncidencia : Form
    {
        private ManejaIncidencia AdmIn;
        int InID = 0;
        public frmAprobarIncidencia(ManejaIncidencia AdmIn)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
        }

        private void frmAprobarIncidencia_Load(object sender, EventArgs e)
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

            string strComandoC = "SELECT Descripcion FROM PRIORIDAD";

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
                    cmbPrioridad.Items.Add(Lector.GetValue(0).ToString());
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
            string FE = "", PR = "", TI="", ID="";
            string strComandoC2 = "SELECT I.ID, I.FechaInicio, I.Descripcion,T.Descripcion FROM INCIDENCIA I INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID WHERE ID_Stat=2 ORDER BY I.FechaInicio";
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
                    ID= Lector2.GetValue(0).ToString();
                    FE = Lector2.GetValue(1).ToString();
                    PR = Lector2.GetValue(2).ToString();
                    TI = Lector2.GetValue(3).ToString();

                    ListViewItem Registro = new ListViewItem(ID);
                    Registro.SubItems.Add(FE);
                    Registro.SubItems.Add(PR);
                    Registro.SubItems.Add(TI);

                    lvIndicencias.Items.Add(Registro);
                }
            }
            Connection2.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (lvIndicencias.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUNA INCIDENCIA", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int PrioID = 0, Stat = 3;

                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);

                    return;
                }
                SqlDataReader Lector = null;
                string strComandoC = "SELECT ID FROM PRIORIDAD WHERE Descripcion LIKE '"+cmbPrioridad.SelectedItem.ToString()+"'";

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
                        PrioID=Convert.ToInt32(Lector.GetValue(0).ToString());
                    }
                }
                Connection.Close();

                AdmIn.UpdatePrioridad(InID, PrioID);
                AdmIn.UpdateStatus(InID, Stat);
                MessageBox.Show("INCIDENCIA APROBADA EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvIndicencias.Items.Count; i++)
            {
                if (lvIndicencias.SelectedItems.Contains(lvIndicencias.Items[i]))
                {
                    txtIncidencia.Text= lvIndicencias.Items[i].SubItems[0].Text;
                    InID=Convert.ToInt32(txtIncidencia.Text);
                }
            }
        }
    }
}
