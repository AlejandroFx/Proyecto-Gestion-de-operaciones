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
using System.Collections;

namespace GestionDeOperacionesTI
{
    public partial class frmTiempoRespuestaIncidencia : Form
    {
        private ManejaIncidencia AdmIn;
        int TecID, InID = 0;
        public frmTiempoRespuestaIncidencia(ManejaIncidencia AdmIn,int TecID)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
            this.TecID = TecID;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvIndicencias.Items.Count; i++)
            {
                if (lvIndicencias.SelectedItems.Contains(lvIndicencias.Items[i]))
                {
                    InID = Convert.ToInt32(lvIndicencias.Items[i].SubItems[0].Text);
                    int Tipo = 0, CI=0;

                    SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                    if (Connection == null)
                    {
                        MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                        foreach (SqlError E in UsoBD.ESalida.Errors)
                            MessageBox.Show(E.Message);

                        return;
                    }
                    SqlDataReader Lector = null;

                    string strComandoC = "SELECT ID_Tipo FROM INCIDENCIA WHERE ID ="+InID;

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
                            Tipo = Convert.ToInt32(Lector.GetValue(0).ToString());
                        }
                    }
                    Connection.Close();

                    if (Tipo == 1)
                    {
                        string UB="", NP=""; 

                        SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                        if (Connection2 == null)
                        {
                            MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            return;
                        }

                        SqlDataReader Lector2 = null;
                        string strComandoC2 = "SELECT CI.ID,I.ID_Tipo,CI.Nombre+', CON NUMERO DE SERIE: '+CI.NumSerie+', '+CI.Descripcion FROM INCIDENCIA I INNER JOIN CI ON I.ID_CI=CI.ID WHERE I.ID=" + InID;
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
                                CI = Convert.ToInt32(Lector2.GetValue(0).ToString());

                                if (Lector2.GetValue(1).ToString() == "1") 
                                {
                                    txtCI.Text = Lector2.GetValue(2).ToString();
                                }
                                
                            }
                        }
                        Connection2.Close();

                        SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                        if (Connection3 == null)
                        {
                            MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            return;
                        }
                        SqlDataReader Lector3 = null;

                        string strComandoC3 = "SELECT 'EDIFICIO: '+E.Nombre+', '+E.Ubicacion+'.  '+L.Nombre+', '+L.Ubicacion+', PLANTA: ' FROM INCIDENCIA I INNER JOIN CI ON I.ID_CI=CI.ID INNER JOIN LOCALIZACION L ON CI.ID_Localizacion=L.ID INNER JOIN EDIFICIO E ON L.ID_Edificio=E.ID  WHERE CI.ID=" + CI;

                        Lector3 = UsoBD.Consulta(strComandoC3, Connection3);
                        if (Lector3 == null)
                        {
                            MessageBox.Show("ERROR AL HACER LA CONSULTA");
                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            Connection3.Close();
                            return;
                        }
                        if (Lector3.HasRows)
                        {
                            while (Lector3.Read())
                            {
                                UB = Lector3.GetValue(0).ToString();
                            }
                        }
                        Connection3.Close();

                        SqlConnection Connection4 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                        if (Connection4 == null)
                        {
                            MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            return;
                        }

                        SqlDataReader Lector4 = null;
                        string strComandoC4 = "SELECT L.NumPlanta FROM INCIDENCIA I INNER JOIN CI ON I.ID_CI=CI.ID INNER JOIN LOCALIZACION L ON CI.ID_Localizacion=L.ID WHERE CI.ID=" + CI;
                        Lector4 = UsoBD.Consulta(strComandoC4, Connection4);

                        if (Lector4 == null)
                        {
                            MessageBox.Show("ERROR AL HACER LA CONSULTA");
                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            Connection4.Close();
                            return;
                        }
                        if (Lector4.HasRows)
                        {
                            while (Lector4.Read())
                            {
                                NP = Lector4.GetValue(0).ToString();
                                richTextBox1.Text = UB + NP;
                            }
                        }
                        Connection4.Close();

                    }
                    else
                    {
                        txtCI.Text = "";

                        SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                        if (Connection3 == null)
                        {
                            MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            return;
                        }
                        SqlDataReader Lector3 = null;

                        string strComandoC3 = "SELECT I.Ubicacion,I.ID_Tipo FROM INCIDENCIA I WHERE I.ID=" + InID;

                        Lector3 = UsoBD.Consulta(strComandoC3, Connection3);
                        if (Lector3 == null)
                        {
                            MessageBox.Show("ERROR AL HACER LA CONSULTA");
                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            Connection3.Close();
                            return;
                        }
                        if (Lector3.HasRows)
                        {
                            while (Lector3.Read())
                            {
                                richTextBox1.Text = Lector3.GetValue(0).ToString();

                                if (Lector3.GetValue(1).ToString() == "3")
                                {
                                    richTextBox1.Text = "";
                                }

                            }
                        }
                        Connection3.Close();
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(Utileria.IsEmpty(txtTiempo.Text)))
            {
                string Time = txtTiempo.Text;
                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                MessageBox.Show(ID.ToString());
                string strComando = "UPDATE INCIDENCIA SET Tiempo_Respuesta=@Tiempo_Respuesta WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando, Connection);

                Update.Parameters.AddWithValue("@Tiempo_Respuesta", Time);
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
                MessageBox.Show("TIEMPO DE RESPUESTA ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTiempoRespuestaIncidencia_Load(object sender, EventArgs e)
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
                string ID = "", DE="", TI = "", PR = "",FE = "";
                string strComandoC2 = "SELECT I.ID,I.Descripcion,T.Descripcion,P.Descripcion, I.FechaInicio, I.Tiempo_Respuesta, I.ID_Stat FROM INCIDENCIA I INNER JOIN PRIORIDAD P ON I.ID_Prioridad=P.ID INNER JOIN TIPO_INCIDENCIA T ON I.ID_Tipo=T.ID WHERE I.ID_Tecnico=" + TecID;
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
                        if (Utileria.IsEmpty(Lector2.GetValue(5).ToString()))
                        {
                            if (Lector2.GetValue(6).ToString() != "1" && Lector2.GetValue(5).ToString() != "5") 
                            {
                                ID = Lector2.GetValue(0).ToString();
                                DE = Lector2.GetValue(1).ToString();
                                TI = Lector2.GetValue(2).ToString();
                                PR = Lector2.GetValue(3).ToString();
                                FE = Lector2.GetValue(4).ToString();

                                ListViewItem Registro = new ListViewItem(ID);
                                Registro.SubItems.Add(DE);
                                Registro.SubItems.Add(TI);
                                Registro.SubItems.Add(PR);
                                Registro.SubItems.Add(FE);

                                lvIndicencias.Items.Add(Registro);
                            }
                        }
                    }
                }
                Connection2.Close();
        }
    }
}
