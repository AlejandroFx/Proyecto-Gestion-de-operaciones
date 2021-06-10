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
    public partial class frmConsultaEmpleado : Form
    {
        public frmConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void frmConsultaEmpleado_Load(object sender, EventArgs e)
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

            string strComando = "SELECT E.Nombre,Email,Celular,Direccion,R.Nombre,D.Nombre FROM EMPLEADO E INNER JOIN ROL R ON E.ID_Rol=R.ID INNER JOIN EMPLEADO_DEPTO ED ON E.ID=ED.ID_Empleado INNER JOIN DEPARTAMENTO D ON D.ID=ED.ID_Depto AND E.Estatus=1 ORDER BY E.Nombre";

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
                    this.dgwEmpleado.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString(), Lector.GetValue(5).ToString());
            }
            Connection.Close();
        }
    }
}
