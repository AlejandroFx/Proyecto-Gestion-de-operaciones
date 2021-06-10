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
    public partial class frmSolicitaCambio : Form
    {
        int IDEmp, IDInc;
        public frmSolicitaCambio(int IDEmp)
        {
            InitializeComponent();
            this.IDEmp = IDEmp;
        }

        private void frmSolicitaCambio_Load(object sender, EventArgs e)
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

            string strComandoC = "SELECT Descripcion, ID_Stat, Tiempo_Respuesta FROM INCIDENCIA WHERE ID_Tecnico=" + IDEmp;

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
                    if (!(Utileria.IsEmpty(Lector.GetValue(2).ToString())))
                    {
                        if (Lector.GetValue(1).ToString() != "1" && Lector.GetValue(1).ToString() != "5")
                        {
                            cmbInc.Items.Add(Lector.GetValue(0).ToString());
                        }
                    }    
                }
            }
            Connection.Close();
        }

        private void cmbInc_SelectedIndexChanged(object sender, EventArgs e)
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

            string strComandoC = "SELECT ID FROM INCIDENCIA WHERE Descripcion LIKE '" + cmbInc.SelectedItem.ToString().Trim() + "'";

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
                    IDInc = Convert.ToInt32(Lector.GetValue(0));
                    txtID.Text = IDInc.ToString();
                }
            }
            Connection.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(txtCambio.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA DESCRIPCION DE LA SOLICITUD DEL CAMBIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            string strComando = "INSERT INTO CAMBIOS(IDInc,Descripcion,FechaSol,Estatus)";
            strComando += " VALUES(@Inc,@Desc,@Fec,@Est)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Inc", IDInc);
            Insert.Parameters.AddWithValue("@Desc", txtCambio.Text);
            Insert.Parameters.AddWithValue("@Fec", maskDate.Text);
            Insert.Parameters.AddWithValue("@Est", 1);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return;
            }
            MessageBox.Show("CAMBIO SOLICITADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
        }
    }
}
