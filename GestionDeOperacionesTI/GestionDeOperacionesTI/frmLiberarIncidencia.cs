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
    public partial class frmLiberarIncidencia : Form
    {
        private ManejaIncidencia AdmIn;
        private int TecID, InID;
        public frmLiberarIncidencia(ManejaIncidencia AdmIn, int TecID)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
            this.TecID = TecID;
        }

        private void frmLiberarIncidencia_Load(object sender, EventArgs e)
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
            string ID = "", DE = "", TI = "", PR = "", FE = "",FF="";
            string strComandoC2 = "SELECT I.ID,I.Descripcion,T.Descripcion,P.Descripcion, I.FechaInicio, I.Tiempo_Respuesta,I.FechaTerminacion FROM INCIDENCIA I INNER JOIN PRIORIDAD P ON I.ID_Prioridad=P.ID INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID WHERE I.ID_Stat=4 AND I.ID_Tecnico=" + TecID;
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
                    if (Utileria.IsEmpty(Lector2.GetValue(6).ToString()) && !(Utileria.IsEmpty(Lector2.GetValue(5).ToString())))
                    { 
                        ID = Lector2.GetValue(0).ToString();
                        DE = Lector2.GetValue(1).ToString();
                        TI = Lector2.GetValue(2).ToString();
                        PR = Lector2.GetValue(3).ToString();
                        FE = Lector2.GetValue(4).ToString();
                        FF = Lector2.GetValue(5).ToString();

                        ListViewItem Registro = new ListViewItem(ID);
                        Registro.SubItems.Add(DE);
                        Registro.SubItems.Add(TI);
                        Registro.SubItems.Add(PR);
                        Registro.SubItems.Add(FE);
                        Registro.SubItems.Add(FF);

                        lvIndicencias.Items.Add(Registro);
                    }

                }
            }
            Connection2.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvIndicencias.Items.Count; i++)
            {
                if (lvIndicencias.SelectedItems.Contains(lvIndicencias.Items[i]))
                {
                    txtIn.Text = lvIndicencias.Items[i].SubItems[0].Text;
                    InID = Convert.ToInt32(lvIndicencias.Items[i].SubItems[0].Text);
                }
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando = "UPDATE INCIDENCIA SET FechaTerminacion=@FechaTerminacion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@FechaTerminacion", maskDate.Text.Trim());
            Update.Parameters.AddWithValue("@ID", InID);

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
            AdmIn.UpdateStatus(InID, 1);
            MessageBox.Show("FINALIZACION DE LA INCIDENCIA "+InID+" EXITOSA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
