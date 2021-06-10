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
    public partial class frmAltaCI : Form
    {
        private ManejaEmpleado AdmEmp;
        private ManejaCI AdmCI;
        private ManejaProveedor AdmPro;
        public frmAltaCI(ManejaEmpleado AdmEmp, ManejaCI AdmCI, ManejaProveedor AdmPro)
        {
            InitializeComponent();
            this.AdmEmp = AdmEmp;
            this.AdmCI = AdmCI;
            this.AdmPro = AdmPro;
        }

        private void frmAltaCI_Load(object sender, EventArgs e)
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

            Lector3= UsoBD.Consulta(strComandoC3, Connection3);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA AGREGAR ESTE ELEMENTO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if (Utileria.IsEmpty(txtNombre.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL NOMBRE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN LA DESCRIPCIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Utileria.IsEmpty(txtNumSerie.Text))
            {
                MessageBox.Show("NO SE ACEPTAN CAMPOS VACIOS EN EL NÚMERO DE SERIE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Edificio = 0;
            SqlConnection Connection = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector = null;
            string strComandoC = "SELECT ID FROM EDIFICIO WHERE Nombre LIKE '"+cmbEdificio.SelectedItem.ToString()+"'";
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
                    Edificio = Convert.ToInt32(Lector.GetValue(0).ToString());
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

            string strComando = "INSERT INTO LOCALIZACION(Nombre,NumPlanta,ID_Edificio,Ubicacion)";
            strComando += " VALUES(@Nombre,@NumPlanta,@ID_Edificio,@Ubicacion)";
            SqlCommand Insert = new SqlCommand(strComando, Connection2);

            Insert.Parameters.AddWithValue("@Nombre", txtUbicacion.Text.Trim());
            Insert.Parameters.AddWithValue("@NumPlanta", nudPlanta.Text);
            Insert.Parameters.AddWithValue("@ID_Edificio", Edificio);
            Insert.Parameters.AddWithValue("@Ubicacion", txtDescUbicacion.Text.Trim());

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Connection2.Close();
                return;
            }
            Connection2.Close();

            int Loc = 0;
            SqlConnection Connection3 = UsoBD.ConectaBD(Utileria.GetConnectionString());

            if (Connection3 == null)
            {
                MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector2 = null;
            string strComando2 = "SELECT ID FROM LOCALIZACION WHERE Ubicacion LIKE '" + txtDescUbicacion.Text.Trim()+ "'";
            Lector2 = UsoBD.Consulta(strComando2, Connection3);

            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Connection3.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    Loc = Convert.ToInt32(Lector2.GetValue(0).ToString());
                }
            }
            Connection3.Close();

            int Enc = AdmEmp.GetIDByName(cmbEncargado.SelectedItem.ToString());
            int Pov = AdmPro.GetID(cmbProveedor.SelectedItem.ToString());
            AdmCI.AddCI(txtNombre.Text, txtDescripcion.Text, txtNumSerie.Text, maskDate.Text, Loc, Enc, Pov);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Computadora")
            {
                Formulario.Text = "MODELO, COLOR, RAM, GRÁFICOS, PROCESADOR, VELOCIDAD DEL PROCESADOR, ALMACENAMIENTO, SISTEMA OPERATIVO, EDICIÓN DEL SISTEMA OPERATIVO, CON BLUETOOTH, LISTADO DE SOFTWARE INSTALADOS, A QUE RED Y A QUE PUERTO ESTÁ CONECTADO, MODELO DEL MONITOR, MODELO DEL TECLADO, MODELO DEL MOUSE Y GARANTIA";
            }
            if (comboBox1.SelectedItem.ToString() == "Impresora")
            {
                Formulario.Text = "MODELO, COLOR, VELOCIDAD DE IMPRESIÓN POR HOJA, TÓNER QUE UTILIZA, CAPACIDAD DE HOJAS SOPORTADAS, CONECTIVIDAD Y GARANTIA";
            }
            if (comboBox1.SelectedItem.ToString() == "Proyector")
            {
                Formulario.Text = "MODELO, COLOR, RESOLUCIÓN, CONEXIONES Y GARANTIA";
            }
            if (comboBox1.SelectedItem.ToString() == "Teléfono")
            {
                Formulario.Text = "MODELO, COLOR, TIPO (ALAMBICO O INALÁMBRICOS), MEMORIA Y GARANTIA";
            }
            if (comboBox1.SelectedItem.ToString() == "Switch")
            {
                Formulario.Text = "MODELO, COLOR, CAPACIDAD EN PUERTO, CONECTIVIDAD Y GARANTIA";
            }
            if (comboBox1.SelectedItem.ToString() == "Router")
            {
                Formulario.Text = "MODELO, COLOR, NÚMERO DE PUERTOS, CONECTIVIDAD, VELOCIDAD Y GARANTIA";
            }
        }
    }
}
