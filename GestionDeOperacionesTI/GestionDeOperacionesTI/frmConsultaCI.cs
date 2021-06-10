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
    public partial class frmConsultaCI : Form
    {
        public frmConsultaCI()
        {
            InitializeComponent();
        }

        private void frmConsultaCI_Load(object sender, EventArgs e)
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

            string strComando = "SELECT CI.Nombre,CI.Descripcion,CI.NumSerie,CI.FechaAdquisicion,E.Nombre,EM.Nombre,P.Nombre FROM CI " +
                                "INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID " +
                                "INNER JOIN EDIFICIO E ON L.ID_Edificio = E.ID " +
                                "INNER JOIN EMPLEADO EM ON CI.ID_Encargado = EM.ID " +
                                "INNER JOIN PROVEEDOR P ON CI.ID_Proveedor = P.ID AND CI.Estatus=1 ORDER BY CI.Nombre";

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
                    this.dgwCI.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString(), Lector.GetValue(5).ToString(), Lector.GetValue(6).ToString());
            }
            Connection.Close();
        }
    }
}
