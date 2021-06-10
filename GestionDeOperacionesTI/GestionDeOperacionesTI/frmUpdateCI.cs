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
    public partial class frmUpdateCI : Form
    {
        private ManejaCI AdmCI;
        private ManejaProveedor AdmProv;
        private ManejaEmpleado AdmEmp;
        public frmUpdateCI(ManejaCI AdmCI, ManejaProveedor AdmProv, ManejaEmpleado AdmEmp)
        {
            InitializeComponent();
            this.AdmCI = AdmCI;
            this.AdmProv = AdmProv;
            this.AdmEmp = AdmEmp;

        }
        private void cmbEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProveedor.Items.Clear();
            cmbEncargado.Items.Clear();
            cmbEdificio.Items.Clear();

            string Nombre = cmbNombre.SelectedItem.ToString();
            string NumSerie = AdmCI.GetNumSerie(Nombre);
            txtxNumSerie.Text = NumSerie;
            string Desc = AdmCI.GetDesc(NumSerie);
            txtDescripcion.Text = Desc;
            string Ubi = AdmCI.GetUbi(NumSerie);
            txtUbicacion.Text = Ubi;
            string DescUb = AdmCI.GetDescUbi(NumSerie);
            txtDescUbicacion.Text = DescUb;
            string Fecha = AdmCI.GetFecha(NumSerie);
            lblDate.Text = Fecha;
            int Num = AdmCI.GetPlanta(NumSerie);
            nudPlanta.Value = Num;
            string Pro = AdmProv.GetNombreByCI(NumSerie);
            lblProveedor.Text = Pro;
            string Enc = AdmEmp.GetIDNameByCI(NumSerie);
            lblEncargado.Text = Enc;
            int IDCI = AdmCI.GetID(NumSerie);



            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Nombre FROM EMPLEADO WHERE Estatus=1";

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
                    cmbEncargado.Items.Add(Lector.GetValue(0).ToString());
                }
            }

            Connection.Close();
            SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());
            SqlDataReader Lector2 = null;
            string strComandoC2 = "SELECT Nombre FROM PROVEEDOR";

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
                    cmbProveedor.Items.Add(Lector2.GetValue(0).ToString());
                }
            }
            Connection2.Close();

            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());
            SqlDataReader Lector3 = null;
            string strComandoC3 = "SELECT Nombre FROM EDIFICIO";

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
                    cmbEdificio.Items.Add(Lector3.GetValue(0).ToString());
                }
            }
            Connection3.Close();

            SqlConnection Connection4 = UsoBD.ConectaBD(Utileria.GetConnectionString());
            SqlDataReader Lector4 = null;

            string strComandoC4 = "SELECT E.Nombre FROM CI INNER JOIN LOCALIZACION L ON CI.ID_Localizacion = L.ID INNER JOIN EDIFICIO E ON L.ID_Edificio = E.ID WHERE L.ID_Edificio = E.ID AND CI.ID ="+IDCI+"";

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
                    lblEdificio.Text = Lector4.GetValue(0).ToString();
                }
            }
            Connection4.Close();


        }
        private void frmUpdateCI_Load(object sender, EventArgs e)
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

            string strComandoC = "SELECT Nombre FROM CI WHERE Estatus=1";

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
                    cmbNombre.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Connection.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA GUARDAR LOS CAMBIOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            string Nombre = cmbNombre.SelectedItem.ToString();
            string NumSerie = AdmCI.GetNumSerie(Nombre);
            int ID = AdmCI.GetID(NumSerie);

            if (!(Utileria.IsEmpty(txtDescripcion.Text)))
            {
                AdmCI.UpdateDesc(ID, txtDescripcion.Text);
            }
            if (!(Utileria.IsEmpty(maskDate.Text)))
            {
                AdmCI.UpdateDate(ID,maskDate.Text);
            }
            if (!(Utileria.IsEmpty(txtUbicacion.Text)))
            {
                int LocID = AdmCI.GetIDLoc(NumSerie.Trim());

                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando = "UPDATE LOCALIZACION SET Nombre=@Nombre WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando, Connection);

                Update.Parameters.AddWithValue("@Nombre", txtUbicacion.Text);
                Update.Parameters.AddWithValue("@ID", LocID);

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
                //MessageBox.Show("CAMPO 'NOMBRE DE LA UBICACIÓN' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!(Utileria.IsEmpty(txtDescUbicacion.Text)))
            {

                int LocID = AdmCI.GetIDLoc(NumSerie.Trim());

                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando = "UPDATE LOCALIZACION SET Ubicacion=@Ubicacion WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando, Connection);

                Update.Parameters.AddWithValue("@Ubicacion", txtDescUbicacion.Text);
                Update.Parameters.AddWithValue("@ID", LocID);

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
                //MessageBox.Show("CAMPO 'DESCRIPCION DE LA UBICACIÓN' ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cmbProveedor.SelectedIndex >= 0 )
            {
                string Prov = cmbProveedor.SelectedItem.ToString();
                int IDPro = AdmProv.GetID(Prov);
                int IDCI = AdmCI.GetID(NumSerie);


                SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection2 == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando2 = "UPDATE CI SET ID_Proveedor=@ID_Proveedor WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando2, Connection2);

                Update.Parameters.AddWithValue("@ID_Proveedor", IDPro);
                Update.Parameters.AddWithValue("@ID", IDCI);

                try
                {
                    Update.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Connection2.Close();
                    return;
                }
                Connection2.Close();

            }
            if (cmbEncargado.SelectedIndex >= 0)
            {
                string Enc = cmbEncargado.SelectedItem.ToString();
                int IDEm = AdmEmp.GetIDByName(Enc);
                int IDCI = AdmCI.GetID(NumSerie);


                SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection2 == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando2 = "UPDATE CI SET ID_Encargado=@ID_Encargado WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando2, Connection2);

                Update.Parameters.AddWithValue("@ID_Encargado", IDEm);
                Update.Parameters.AddWithValue("@ID", IDCI);

                try
                {
                    Update.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Connection2.Close();
                    return;
                }
                Connection2.Close();
            }
            if (cmbEdificio.SelectedIndex >= 0)
            {
                string Ed = cmbEdificio.SelectedItem.ToString();
                int IDLoc = AdmCI.GetIDLoc(NumSerie);
                int IDEd=0;

                SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                SqlDataReader Lector = null;

                string strComandoC = "SELECT ID FROM EDIFICIO WHERE Nombre LIKE '" + Ed+"'";

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
                        IDEd = Convert.ToInt32(Lector.GetValue(0).ToString());
                    }
                }
                Connection.Close();

                SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection2 == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando2 = "UPDATE LOCALIZACION SET ID_Edificio=@ID_Edificio WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando2, Connection2);

                Update.Parameters.AddWithValue("@ID_Edificio", IDEd);
                Update.Parameters.AddWithValue("@ID", IDLoc);

                try
                {
                    Update.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Connection2.Close();
                    return;
                }
                Connection2.Close();
            }
            if (nudPlanta.Value >= 1 )
            {
                int num = Convert.ToInt32(nudPlanta.Value);
                int IDLoc=AdmCI.GetIDLoc(NumSerie);

                SqlConnection Connection2 = UsoBD.ConectaBD(Utileria.GetConnectionString());

                if (Connection2 == null)
                {
                    MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }
                string strComando2 =  "UPDATE LOCALIZACION SET NumPlanta=@NumPlanta WHERE ID=@ID";

                SqlCommand Update = new SqlCommand(strComando2, Connection2);

                Update.Parameters.AddWithValue("@NumPlanta", num);
                Update.Parameters.AddWithValue("@ID", IDLoc);

                try
                {
                    Update.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Connection2.Close();
                    return;
                }
                Connection2.Close();
            }
            MessageBox.Show("ELEMENTO DE CONFIGURACION ACTUALIZADO EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
