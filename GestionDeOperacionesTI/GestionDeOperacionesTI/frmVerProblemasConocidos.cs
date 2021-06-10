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
    public partial class frmVerProblemasConocidos : Form
    {
        public frmVerProblemasConocidos()
        {
            InitializeComponent();
        }

        private void frmVerProblemasConocidos_Load(object sender, EventArgs e)
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
            string ID = "", DE = "", SO = "", TM = "";
            string strComandoC2 = "SELECT * FROM PROBLEMAS_CONOCIDOS";
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
                    ID = Lector2.GetValue(0).ToString();
                    DE = Lector2.GetValue(1).ToString();
                    SO = Lector2.GetValue(2).ToString();
                    TM = Lector2.GetValue(3).ToString();

                    ListViewItem Registro = new ListViewItem(ID);
                    Registro.SubItems.Add(DE);
                    Registro.SubItems.Add(SO);
                    Registro.SubItems.Add(TM);

                    lvInci.Items.Add(Registro);
                }
            }
            Connection2.Close();
        }

        private void btnSelectTec_Click(object sender, EventArgs e)
        {
            int ID = 0;

            for (int i = 0; i < lvInci.Items.Count; i++)
            {
                if (lvInci.SelectedItems.Contains(lvInci.Items[i]))
                {
                    ID = Convert.ToInt32(lvInci.Items[i].SubItems[0].Text);

                    SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                    if (Connection == null)
                    {
                        MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                        foreach (SqlError E in UsoBD.ESalida.Errors)
                            MessageBox.Show(E.Message);

                        return;
                    }
                    SqlDataReader Lector = null;
                    string strComandoC = "SELECT Descripcion,Solucion,Tiempo FROM PROBLEMAS_CONOCIDOS WHERE ID=" + ID;

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
                            txtDesc.Text = Lector.GetValue(0).ToString();
                            txtSol.Text = Lector.GetValue(1).ToString();
                            txtTime.Text = Lector.GetValue(2).ToString();
                        }
                    }
                    Connection.Close();
                }
            }
        }


    }
}
