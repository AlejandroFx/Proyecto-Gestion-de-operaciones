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
    public class ManejaCI
    {
        public bool AddCI(string Nombre, string Descripcion, string NumSerie, string FechaAdqui, int LocID, int EncaID, int ProvID)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO CI(Nombre,Descripcion,NumSerie,FechaAdquisicion,ID_Localizacion,ID_Encargado,ID_Proveedor,Estatus)";
            strComando += " VALUES(@Nombre,@Descripcion,@NumSerie,@FechaAdqui,@LocID,@EncaID,@ProvID,@Estatus)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Nombre", Nombre.Trim());
            Insert.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
            Insert.Parameters.AddWithValue("@NumSerie", NumSerie.Trim());
            Insert.Parameters.AddWithValue("@FechaAdqui", FechaAdqui.Trim());
            Insert.Parameters.AddWithValue("@LocID", LocID);
            Insert.Parameters.AddWithValue("@EncaID", EncaID);
            Insert.Parameters.AddWithValue("@ProvID", ProvID);
            Insert.Parameters.AddWithValue("@Estatus", 1);
           

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
            MessageBox.Show("ELEMENTO AGREGADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
            AddUpCI(Nombre,Descripcion,NumSerie,FechaAdqui,LocID,EncaID,ProvID);
            return true;
        }
        public bool AddUpCI(string Nombre, string Descripcion, string NumSerie, string FechaAdqui, int LocID, int EncaID, int ProvID)
        {
            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());
            SqlDataReader Lector2 = null;
            int IDCI = 0;

            string strComandoC2 = "SELECT ID FROM CI WHERE NumSerie LIKE'" + NumSerie + "'";

            Lector2 = UsoBD.Consulta(strComandoC2, Connection2);
            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection2.Close();
                return false;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    IDCI = Convert.ToInt32(Lector2.GetValue(0).ToString());
                }
            }
            Connection2.Close();
            //////////////////////

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO CAMBIOS_CI(IDCI,Nombre,Descripcion,NumSerie,FechaAdquisicion,ID_Localizacion,ID_Encargado,ID_Proveedor,Estatus)";
            strComando += " VALUES(@IDCI,@Nombre,@Descripcion,@NumSerie,@FechaAdqui,@LocID,@EncaID,@ProvID,@Estatus)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@IDCI", IDCI);
            Insert.Parameters.AddWithValue("@Nombre", Nombre.Trim());
            Insert.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
            Insert.Parameters.AddWithValue("@NumSerie", NumSerie.Trim());
            Insert.Parameters.AddWithValue("@FechaAdqui", FechaAdqui.Trim());
            Insert.Parameters.AddWithValue("@LocID", LocID);
            Insert.Parameters.AddWithValue("@EncaID", EncaID);
            Insert.Parameters.AddWithValue("@ProvID", ProvID);
            Insert.Parameters.AddWithValue("@Estatus", 1);

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
           
            Connection.Close();
            return true;
        }
        public string GetNumSerie(string Nombre)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Des = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Des;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT NumSerie FROM CI WHERE Nombre LIKE '" + Nombre + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Des;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Des = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Des;
        }
        public string GetDesc(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Des = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Des;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Descripcion FROM CI WHERE NumSerie LIKE '" + NumSerie + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Des;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Des = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Des;
        }
        public string GetUbi(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Ubi = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Ubi;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT L.Nombre FROM CI INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID WHERE NumSerie LIKE '" + NumSerie.Trim() + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Ubi;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Ubi = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Ubi;
        }
        public string GetDescUbi(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Des = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Des;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT L.Ubicacion FROM CI INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID WHERE NumSerie LIKE '" + NumSerie.Trim() + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Des;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Des = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Des;
        }
        public string GetFecha(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Date = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Date;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT FechaAdquisicion FROM CI WHERE NumSerie LIKE '" + NumSerie + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Date;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Date = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Date;
        }
        public int GetPlanta(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int num = 0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return num;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT L.NumPlanta FROM CI INNER JOIN LOCALIZACION L ON CI.ID = L.ID WHERE NumSerie LIKE '" + NumSerie + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return num;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    num = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
            return num;
        }
        public bool UpdateDesc(int ID, string Desc)
        {
            bool Band = false;
            string str = "", F="";

            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection3 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }

            SqlDataReader Lector2 = null;
            string strComando2 = "SELECT Descripcion FROM CI WHERE ID=" + ID;
            Lector2 = UsoBD.Consulta(strComando2, Connection3);

            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection3.Close();
                return Band;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    str = Lector2.GetValue(0).ToString();
                    F = str;
                    F +=  ". UPDATE; " + Desc;
                }
            }
            Connection3.Close();

            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE CI SET Descripcion=@Descripcion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Descripcion", F);
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
           // MessageBox.Show("CAMPO 'DESCRIPCIÓN' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateUbID(int ID, int UbicID)
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
            string strComando = "UPDATE CI SET ID_Localizacion=@ID_Localizacion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Localizacion", UbicID);
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
           // MessageBox.Show("CAMPO 'UBICACIÓN' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateDate(int ID, string Date)
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
            string strComando = "UPDATE CI SET FechaAdquisicion=@FechaAdquisicion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@FechaAdquisicion", Date.Trim());
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
           // MessageBox.Show("CAMPO 'FECHA DE ADQUISICIÓN' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateEnca(int ID, int EncID)
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
            string strComando = "UPDATE CI SET ID_Encargado=@ID_Encargado WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Encargado", EncID);
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
            MessageBox.Show("CAMPO 'ENCARGADO' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdatePro(int ID, int ProID)
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
            string strComando = "UPDATE CI SET ID_Proveedor=@ID_Proveedor WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Proveedor", ProID);
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
            MessageBox.Show("CAMPO 'PROVEEDOR' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public int GetIDLoc(string Num)
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

            string strComandoC = "SELECT L.ID FROM CI INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID WHERE NumSerie LIKE '" + Num + "'";

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
        public int GetID(string Num)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int ID = 0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return ID;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT ID FROM CI WHERE NumSerie LIKE '" + Num.Trim() + "'";

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
        public int GetIDLocBYID(string IDCI)
        {
            int ID = 0;
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return ID;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT ID_Localizacion FROM CI WHERE CI.ID=" + IDCI;

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
        public bool UpdateEstatus(int ID)
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
            string strComando = "UPDATE CI SET Estatus=@Estatus WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Estatus", 0);
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
            //MessageBox.Show("CAMPO 'CONTRASEÑA' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }

    }
}
