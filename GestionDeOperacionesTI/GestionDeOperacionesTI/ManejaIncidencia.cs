using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace GestionDeOperacionesTI
{
    public class ManejaIncidencia
    {
        public bool AddInCI(string Descripcion, string FechaInicio, int IDCI, int ID_Tipo, int IDEmp)
        {
            int ID_Stat = 2;

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO INCIDENCIA(Descripcion,FechaInicio,ID_CI,ID_Stat,ID_Tipo,ID_Usuario)";
            strComando += " VALUES(@Descripcion,@FechaInicio,@ID_CI,@ID_Stat,@ID_Tipo,@ID_Usuario)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
            Insert.Parameters.AddWithValue("@FechaInicio", FechaInicio.Trim());
            Insert.Parameters.AddWithValue("@ID_CI", IDCI);
            Insert.Parameters.AddWithValue("@ID_Stat", ID_Stat);
            Insert.Parameters.AddWithValue("@ID_Tipo", ID_Tipo);
            Insert.Parameters.AddWithValue("@ID_Usuario", IDEmp);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return false;
            }
            MessageBox.Show("INCIDENCIA REPORTADA EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
            return true;
        }
        public bool AddInRed(string Descripcion, string FechaInicio, string Ubicacion, int ID_Tipo, int IDEmp)
        {
            int ID_Stat = 2;

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO INCIDENCIA(Descripcion,FechaInicio,ID_Stat,ID_Tipo,Ubicacion,ID_Usuario)";
            strComando += " VALUES(@Descripcion,@FechaInicio,@ID_Stat,@ID_Tipo,@Ubicacion,@ID_Usuario)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
            Insert.Parameters.AddWithValue("@FechaInicio", FechaInicio.Trim());
            Insert.Parameters.AddWithValue("@ID_Stat", ID_Stat);
            Insert.Parameters.AddWithValue("@ID_Tipo", ID_Tipo);
            Insert.Parameters.AddWithValue("@Ubicacion", Ubicacion.Trim());
            Insert.Parameters.AddWithValue("@ID_Usuario", IDEmp);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return false;
            }
            MessageBox.Show("INCIDENCIA DE RED REPORTADA EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
            return true;
        }
        public bool AddInSO(string Descripcion, string FechaInicio, int ID_Tipo, int IDEmp)
        {
            int ID_Stat = 2;

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO INCIDENCIA(Descripcion,FechaInicio,ID_Stat,ID_Tipo,ID_Usuario)";
            strComando += " VALUES(@Descripcion,@FechaInicio,@ID_Stat,@ID_Tipo,@ID_Usuario)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
            Insert.Parameters.AddWithValue("@FechaInicio", FechaInicio.Trim());
            Insert.Parameters.AddWithValue("@ID_Stat", ID_Stat);
            Insert.Parameters.AddWithValue("@ID_Tipo", ID_Tipo);
            Insert.Parameters.AddWithValue("@ID_Usuario", IDEmp);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return false;
            }
            MessageBox.Show("INCIDENCIA DE SOFTWARE  REPORTADA EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
            return true;
        }
        public bool UpdatePrioridad(int ID, int Pri)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band = false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE INCIDENCIA SET ID_Prioridad=@ID_Prioridad WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Prioridad", Pri);
            Update.Parameters.AddWithValue("@ID", ID);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return Band;
            }
            Connection.Close();
            // MessageBox.Show("CAMPO PRIORIDAD ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateStatus(int ID, int Status)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band = false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE INCIDENCIA SET ID_Stat=@ID_Stat WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Stat", Status);
            Update.Parameters.AddWithValue("@ID", ID);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return Band;
            }
            Connection.Close();
            // MessageBox.Show("CAMPO ESTATUS ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateTec(int ID, int Tec)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band = false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE INCIDENCIA SET ID_Tecnico=@ID_Tecnico WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Tecnico", Tec);
            Update.Parameters.AddWithValue("@ID", ID);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return Band;
            }
            Connection.Close();
            // MessageBox.Show("CAMPO ESTATUS ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateCal(int ID, string Cal)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band = false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE INCIDENCIA SET Califiacion=@Califiacion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Califiacion", Cal);
            Update.Parameters.AddWithValue("@ID", ID);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return Band;
            }
            Connection.Close();
            // MessageBox.Show("CAMPO ESTATUS ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateRetro(int ID, string Com)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band = false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE INCIDENCIA SET Comentario=@Comentario WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Comentario", Com);
            Update.Parameters.AddWithValue("@ID", ID);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection.Close();
                return Band;
            }
            Connection.Close();
            // MessageBox.Show("CAMPO ESTATUS ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public int GetIncID(int Cam)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int ID=0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return ID;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT I.ID FROM INCIDENCIA I INNER JOIN CAMBIOS C ON C.IDInc=I.ID WHERE C.ID="+Cam;

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return ID;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    ID = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
            return ID;
        }

    }
}
