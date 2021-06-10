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
    public class ManejaDepartamento
    {
        public bool AddDepto(string Nombre, int Encargado)
        {
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }


            string strComando = "INSERT INTO DEPARTAMENTO(Nombre,ID_EmpEncar,Estatus)";
            strComando += " VALUES(@Nombre, @Encargado,@Estatus)";

            SqlCommand Insert = new SqlCommand(strComando, Connection);

            Insert.Parameters.AddWithValue("@Nombre", Nombre.Trim());
            Insert.Parameters.AddWithValue("@Encargado", Encargado);
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
        public string EncDep(int ID)
        {
            string Enc = "";
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Enc;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT E.NOMBRE FROM DEPARTAMENTO D INNER JOIN  EMPLEADO E ON D.ID_EmpEncar=E.ID WHERE D.ID=" + ID ;

            Lector = UsoBD.Consulta(strComandoC, Connection);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection.Close();
                return Enc;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                   Enc = Lector.GetValue(0).ToString();
                }
            }
            Connection.Close();
            return Enc;
        }
        public int GetID(string Name)
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

            string strComandoC = "SELECT ID FROM DEPARTAMENTO WHERE Nombre LIKE '" + Name + "'";

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
        public bool UpdateEnc(int EncID, int ID)
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
            string strComando = "UPDATE DEPARTAMENTO SET ID_EmpEncar=@ID_EmpEncar WHERE ID=@ID";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_EmpEncar", EncID);
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
            string strComando = "UPDATE DEPARTAMENTO SET Estatus=@Estatus WHERE ID=@ID";

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
        public bool UpdateDep(int ID, int Dep)
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
            string strComando = "UPDATE EMPLEADO_DEPTO SET ID_Depto=@ID_Depto WHERE ID_Empleado=@ID_Empleado";

            SqlCommand Update = new SqlCommand(strComando, Connection);

            Update.Parameters.AddWithValue("@ID_Depto", Dep);
            Update.Parameters.AddWithValue("@ID_Empleado", ID);

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
            return !Band;
        }
    }
}
