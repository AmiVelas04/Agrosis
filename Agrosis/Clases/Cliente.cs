using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Agrosis.Clases
{
    class Cliente
    {
        Conexion conect = new Conexion();
        #region "General"
        private DataTable buscar(string consulta)
        {
            conect.iniciar();
            DataTable datos = new DataTable();
            try
            {

                MySqlDataAdapter adap = new MySqlDataAdapter(consulta, conect.conn);
                adap.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + consulta);
                //MessageBox.Show(consulta);
            }
            return datos;
        }
        private bool consulta_gen(string consulta)
        {
            conect.iniciar();
            MySqlCommand com1 = new MySqlCommand();
            com1.Connection = conect.conn;
            com1.CommandText = consulta;
            com1.CommandType = CommandType.Text;
            try
            {
                conect.conn.Open();
                com1.ExecuteNonQuery();
                conect.conn.Close();
            }

            catch (Exception ex)
            {
                conect.conn.Close();
                MessageBox.Show(consulta + "\n" + ex.ToString());
                return false;
            }
            return true;
        }
        #endregion

        private int idcli()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_cli) from clientes";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        public DataTable Listcliente()
        {
            string consulta;
            consulta = "Select id_cli as cod,nombre,Nit from clientes";
            return buscar(consulta);
        }

        public string nit(string cod)
        {
            string consulta;
            DataTable datos = new DataTable();
            consulta = "Select Nit from clientes where id_cli="+cod;
            datos= buscar(consulta);
            if (datos.Rows.Count >= 1)
            {
                return datos.Rows[0][0].ToString();
            }
            else
                return "";
        }

        public bool ingreso_cli(string[] datos)
        {
            string consulta,id;
            id = (idcli() + 1).ToString ();
            consulta = "insert into clientes(id_cli,nombre,direccion,nit,dpi,telefono) values("+
                id+",'" + datos[0]+"','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
            return consulta_gen(consulta);
        }

        public DataTable datoscli(string cod)
        {
            string consulta;
            consulta = "Select nombre,nit from clientes where id_cli= " + cod;
            return buscar(consulta);
        }
            

    }
}
