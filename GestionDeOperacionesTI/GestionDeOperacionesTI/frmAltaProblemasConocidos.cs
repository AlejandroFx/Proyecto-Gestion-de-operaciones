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
    public partial class frmAltaProblemasConocidos : Form
    {
        public frmAltaProblemasConocidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(txtDesc.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA DESCRIPCIÓN DEL PROBLEMA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtSol.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA SOLUCIÓN DEL PROBLEMA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtTime.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL TIEMPO DE SOLUCIÓN DEL PROBLEMA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            string strComando = "INSERT INTO PROBLEMAS_CONOCIDOS(Descripcion,Solucion,Tiempo)";
            strComando += " VALUES(@Descripcion,@Solucion,@Tiempo)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Descripcion", txtDesc.Text);
            Insert.Parameters.AddWithValue("@Solucion", txtSol.Text);
            Insert.Parameters.AddWithValue("@Tiempo", txtTime.Text);

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
            MessageBox.Show("SOLUCION A PROBLEMA CONOCIDO AGREGADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();

        }
    }
}
