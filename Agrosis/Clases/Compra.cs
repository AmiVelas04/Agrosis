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
    class Compra
    {

        private Producto prod = new Producto();
        private Conexion conect = new Conexion();
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
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
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
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
                return false;
            }
            return true;
        }
        #endregion
        #region "Datos"

        public int idcompra()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_compra) from compra";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        private int idetallecomp()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_det_comp) from compra_det";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }
        #endregion

        public bool ingreso_prod_compra(string[,] datos, string cajero, string prov, string fecha,string doc,string docnum)
        {
            int totalp, cont;
            bool res=false;
            totalp = datos.Length / 11;
            for (cont = 0; cont < totalp; cont++)
            {
                string[] prods = new String[11];
                int cont2;
                for (cont2 = 0; cont2 < 11; cont2++)
                {
                    prods[cont2] = datos[cont, cont2];
                }
                if (!prod.existeprod(datos[cont, 0]))
                {
                  res = prod.agregprod(prods);
                }
                else
                {
                    res = prod.actualprod(prods);
                }
            }
            if (res)
            {
                ingreso_compra(datos, cajero, prov, fecha,doc,docnum);
            }

            return res;
        }

        private void ingreso_compra(string[,] prods, string cajero, string prov, string fecha,string doc, string numdoc)
        {
            int cont, totalp;
            string idc,iddet, ConsCompDet, ConsComp;
            idc = (idcompra()+1).ToString();
            totalp = prods.Length / 11;
            ConsComp = "insert into compra(id_compra,id_prov,fecha,id_caj,doc,num_doc) values(" +
                    idc + "," + prov + ",'" + fecha + "'," + cajero +",'"+doc+"',"+numdoc+ ")";
            if (consulta_gen(ConsComp))
            {
                for (cont = 0; cont < totalp; cont++)
                {
                    iddet = (idetallecomp()+1).ToString();
                    decimal tot=0;
                    tot += decimal.Parse(prods[cont, 9]) * decimal.Parse(prods[cont,4]);
                    ConsCompDet = "insert into compra_det(id_det_comp,id_comp,id_prod,costo,cantidad,total) values(" +
                        iddet + "," + idc + ","+ prods[cont, 0] + "," + prods[cont, 4] + ",'" + prods[cont, 9] + "'," + tot + ")";
                    if (!consulta_gen(ConsCompDet))
                    {
                        MessageBox.Show("Error al ingresar el regsitro de detalle de compra");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar el regsitro de compra");
            }

        }

    }
}
