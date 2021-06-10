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
    public partial class frmEvaluarIncidencia : Form
    {
        private ManejaIncidencia AdmIn;
        int UsID, InID;
        public frmEvaluarIncidencia(ManejaIncidencia AdmIn, int UsID)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
            this.UsID = UsID;

        }

        private void frmEvaluarIncidencia_Load(object sender, EventArgs e)
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
            string D1 = "", D2 = "", D3 = "", D4 = "", D5 = "", D6 = "", D7 = "";
            string strComandoC2 = "SELECT I.ID,I.Descripcion,T.Descripcion,P.Descripcion, I.FechaInicio, I.FechaTerminacion, I.Tiempo_Respuesta, I.Califiacion FROM INCIDENCIA I INNER JOIN PRIORIDAD P ON I.ID_Prioridad=P.ID INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID WHERE I.ID_Stat=1 AND ID_Usuario=" + UsID;
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
                    if (Utileria.IsEmpty(Lector2.GetValue(7).ToString()))
                    {
                        D1 = Lector2.GetValue(0).ToString();
                        D2 = Lector2.GetValue(1).ToString();
                        D3 = Lector2.GetValue(2).ToString();
                        D4 = Lector2.GetValue(3).ToString();
                        D5 = Lector2.GetValue(4).ToString();
                        D6 = Lector2.GetValue(5).ToString();
                        D7 = Lector2.GetValue(6).ToString();


                        ListViewItem Registro = new ListViewItem(D1);
                        Registro.SubItems.Add(D2);
                        Registro.SubItems.Add(D3);
                        Registro.SubItems.Add(D4);
                        Registro.SubItems.Add(D5);
                        Registro.SubItems.Add(D6);
                        Registro.SubItems.Add(D7);

                        lvIndicencias.Items.Add(Registro);
                    }

                }
            }
            Connection2.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(cmbCalif.SelectedItem.ToString()))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CALIFICACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtIn.Text))
            {
                MessageBox.Show("DEBE SELECCIONAR UN REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Calif = cmbCalif.SelectedItem.ToString(), Com=txtCom.Text;
            AdmIn.UpdateCal(InID, Calif);
            AdmIn.UpdateRetro(InID, Com);
            MessageBox.Show("RETROALIMENTACION ACTUALIZADA EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
