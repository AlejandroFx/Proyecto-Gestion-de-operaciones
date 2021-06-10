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
   public class ManejaEmpleado
    {
        public int GetID(string Email)
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

            string strComandoC = "SELECT ID FROM EMPLEADO WHERE Email LIKE '" + Email + "'";

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
        public string GetRol(int ID)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Rol = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Rol;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT R.Nombre FROM EMPLEADO E INNER JOIN ROL R ON E.ID_Rol = R.ID WHERE E.ID ="+ID;

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Rol;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Rol = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Rol;
        }
        public bool UpdateCel(int ID, string Celular)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            bool Band=false;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Band;
            }
            string strComando = "UPDATE EMPLEADO SET Celular=@Celular WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Celular", Celular);
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
          //  MessageBox.Show("CAMPO 'NUMERO CELULAR' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateDir(int ID, string Dir)
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
            string strComando = "UPDATE EMPLEADO SET Direccion=@Direccion WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Direccion", Dir);
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
           // MessageBox.Show("CAMPO 'DIRECCION' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public int GetIDRol(int ID)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int Rol = 0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Rol;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT ID_Rol FROM EMPLEADO WHERE ID=" + ID;

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Rol;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Rol = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
            return Rol;
        }
        public bool AddEmp(string Nombre, string Email, string Celular, string Direc, int Rol)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Pass = "12345";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO EMPLEADO(Nombre,Email,Celular,Direccion,ID_Rol,Contraseña,Estatus)";
            strComando += " VALUES(@Nombre, @Email, @Celular, @Direc, @Rol, @Contraseña, @Estatus)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Nombre", Nombre.Trim());
            Insert.Parameters.AddWithValue("@Email", Email.Trim());
            Insert.Parameters.AddWithValue("@Celular", Celular.Trim());
            Insert.Parameters.AddWithValue("@Direc", Direc.Trim());
            Insert.Parameters.AddWithValue("@Rol", Rol);
            Insert.Parameters.AddWithValue("@Contraseña", Pass);
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
        public int GetIDByName(string Name)
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

            string strComandoC = "SELECT ID FROM EMPLEADO WHERE Nombre LIKE '" + Name.Trim() + "'";

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
        public int GetIDByNameRol(string Name)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int Rol=0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Rol;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT ID FROM ROL WHERE Nombre LIKE '"+ Name +"'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Rol;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Rol = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
            return Rol;
        }
        public int GetIDNameByRol(string Name)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            int Rol = 0;

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Rol;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT ID FROM EMPLEADO WHERE Nombre LIKE '" + Name + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Rol;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Rol = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
            return Rol;
        }
        public string GetIDNameByCI(string NumSerie)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            string Name = "";

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Name;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT E.Nombre FROM EMPLEADO E INNER JOIN CI ON E.ID = CI.ID_Encargado WHERE CI.NumSerie LIKE'" + NumSerie + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Name;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Name = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Name;
        }

        public bool CheckPass(string Email, string Pass)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Contraseña FROM EMPLEADO WHERE Email LIKE '" + Email + "' AND Contraseña LIKE '" + Pass + "'";

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return false;
            }
            if (Lector.HasRows)
            {
                Connection.Close();
                return true;
            }
            Connection.Close();
            return false;
        }
        public bool UpdatePass(int ID, string Pass)
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
            string strComando = "UPDATE EMPLEADO SET Contraseña=@Contraseña WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Contraseña", Pass);
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
        public int GetIDName(string Name)
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

            string strComandoC = "SELECT ID FROM EMPLEADO WHERE Nombre LIKE'" + Name.Trim()+"'";

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
        public bool UpdateNom(int ID, string Nom)
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
            string strComando = "UPDATE EMPLEADO SET Nombre=@Nombre WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Nombre", Nom);
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
            // MessageBox.Show("CAMPO 'DIRECCION' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateEmail(int ID, string Email)
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
            string strComando = "UPDATE EMPLEADO SET Email=@Email WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@Email", Email);
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
            // MessageBox.Show("CAMPO 'DIRECCION' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
        }
        public bool UpdateRolID(int ID, int Rol)
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
            string strComando = "UPDATE EMPLEADO SET ID_Rol=@ID_Rol WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Rol", Rol);
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
            // MessageBox.Show("CAMPO 'DIRECCION' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return !Band;
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
            string strComando = "UPDATE EMPLEADO SET Estatus=@Estatus WHERE ID=@ID";

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
