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
    public partial class frmMisReportes : Form
    {
        private int UsID;
        public frmMisReportes(int UsID)
        {
            InitializeComponent();
            this.UsID = UsID;
        }

        private void frmMisReportes_Load(object sender, EventArgs e)
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

            string strComando = "SELECT  I.ID, I.Descripcion, T.Descripcion, E.Descripcion, I.FechaInicio,I.FechaTerminacion FROM INCIDENCIA I  INNER JOIN ESTATUS_INCIDENCIA E ON I.ID_Stat=E.ID INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID WHERE ID_Usuario=" + UsID;

            Lector = UsoBD.Consulta(strComando, Connection);

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
                    this.dgvIncidencias.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString(), Lector.GetValue(5).ToString());
            }
            Connection.Close();
        }
    }
}
