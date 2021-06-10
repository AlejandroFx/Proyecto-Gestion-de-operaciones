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
    public partial class frmVerCambios : Form
    {
        public frmVerCambios()
        {
            InitializeComponent();
        }

        private void frmVerCambios_Load(object sender, EventArgs e)
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

            string strComando = "SELECT I.Descripcion,C.Descripcion,E.Descripcion,C.FechaSol,FechaTer FROM CAMBIOS C INNER JOIN INCIDENCIA I ON C.IDInc=I.ID INNER JOIN ESTATUS_CAMBIO E ON C.Estatus=E.ID";

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
                    this.dgwCI.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString());
            }
            Connection.Close();
        }
    }
}
