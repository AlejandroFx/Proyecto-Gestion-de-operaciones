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
    public partial class frmAutorizaCambios : Form
    {
        private ManejaIncidencia AdmIn;
        int IDCam;
        public frmAutorizaCambios(ManejaIncidencia AdmIn)
        {
            InitializeComponent();
            this.AdmIn = AdmIn;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvCam.Items.Count; i++)
            {
                if (lvCam.SelectedItems.Contains(lvCam.Items[i]))
                {
                    txtID.Text = lvCam.Items[i].SubItems[0].Text;
                    IDCam = Convert.ToInt32(txtID.Text);
                }
            }
        }

        private void frmAutorizaCambios_Load(object sender, EventArgs e)
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
            string FE = "", IN = "", DE = "", ID = "";
            string strComandoC2 = "SELECT C.ID,I.Descripcion,C.Descripcion,C.FechaSol FROM CAMBIOS C INNER JOIN INCIDENCIA I ON C.IDInc=I.ID WHERE C.Estatus=1 ORDER BY C.FechaSol ";
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
                    IN = Lector2.GetValue(1).ToString();
                    DE = Lector2.GetValue(2).ToString();
                    FE = Lector2.GetValue(3).ToString();

                    ListViewItem Registro = new ListViewItem(ID);
                    Registro.SubItems.Add(IN);
                    Registro.SubItems.Add(DE);
                    Registro.SubItems.Add(FE);

                    lvCam.Items.Add(Registro);
                }
            }
            Connection2.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(txtCom.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL COMENTARIO A LA RESPUESTA DE LA SOLICITUD DEL CAMBIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string strComando = "UPDATE CAMBIOS SET Comentario=@Comentario WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Comentario", txtCom.Text);
            Update.Parameters.AddWithValue("@ID", IDCam);

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
           //
            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection2 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando2 = "UPDATE CAMBIOS SET FechaTer=@FechaTer WHERE ID=@ID";

            SqlCommand Update2 = new SqlCommand(strComando2, Connection2);

            Update2.Parameters.AddWithValue("@FechaTer", maskDate.Text);
            Update2.Parameters.AddWithValue("@ID", IDCam);

            try
            {
                Update2.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection2.Close();
                return;
            }
            Connection2.Close();
            //
            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection3 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando3 = "UPDATE CAMBIOS SET Estatus=@Estatus WHERE ID=@ID";

            SqlCommand Update3 = new SqlCommand(strComando3, Connection3);

            Update3.Parameters.AddWithValue("@Estatus", 2);
            Update3.Parameters.AddWithValue("@ID", IDCam);

            try
            {
                Update3.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection3.Close();
                return;
            }
            Connection3.Close();
            MessageBox.Show("CAMBIO APROBADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (Utileria.IsEmpty(txtCom.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL COMENTARIO A LA RESPUESTA DE LA SOLICITUD DEL CAMBIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string strComando = "UPDATE CAMBIOS SET Comentario=@Comentario WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Comentario", txtCom.Text);
            Update.Parameters.AddWithValue("@ID", IDCam);

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
            //
            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection2 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando2 = "UPDATE CAMBIOS SET FechaTer=@FechaTer WHERE ID=@ID";

            SqlCommand Update2 = new SqlCommand(strComando2, Connection2);

            Update2.Parameters.AddWithValue("@FechaTer", maskDate.Text);
            Update2.Parameters.AddWithValue("@ID", IDCam);

            try
            {
                Update2.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection2.Close();
                return;
            }
            Connection2.Close();
            //
            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection3 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando3 = "UPDATE CAMBIOS SET Estatus=@Estatus WHERE ID=@ID";

            SqlCommand Update3 = new SqlCommand(strComando3, Connection3);

            Update3.Parameters.AddWithValue("@Estatus", 3);
            Update3.Parameters.AddWithValue("@ID", IDCam);

            try
            {
                Update3.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection3.Close();
                return;
            }
            Connection3.Close();
            //
            int IDInc = AdmIn.GetIncID(IDCam);
            SqlConnection Connection4 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection4 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando4 = "UPDATE INCIDENCIA SET FechaTerminacion=@FechaTerminacion WHERE ID=@ID";

            SqlCommand Update4 = new SqlCommand(strComando4, Connection4);

            Update4.Parameters.AddWithValue("@FechaTerminacion", maskDate.Text);
            Update4.Parameters.AddWithValue("@ID", IDInc);

            try
            {
                Update4.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection4.Close();
                return;
            }
            Connection4.Close();
            //
            SqlConnection Connection5 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection5 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            string strComando5 = "UPDATE INCIDENCIA SET ID_Stat=@ID_Stat WHERE ID=@ID";

            SqlCommand Update5 = new SqlCommand(strComando5, Connection5);

            Update5.Parameters.AddWithValue("@ID_Stat", 5);
            Update5.Parameters.AddWithValue("@ID", IDInc);

            try
            {
                Update5.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection5.Close();
                return;
            }
            Connection5.Close();
            MessageBox.Show("CAMBIO RECHAZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
