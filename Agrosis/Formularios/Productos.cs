using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrosis.Formularios
{
    public partial class Productos : Form
    {
        Clases.Producto prod = new Clases.Producto();
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (prod.ExisteServ(TxtCod.Text) == 1)
            {
                MessageBox.Show("El codigo ya esta registrado como un servicio", "Ya asignado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (prod.ExisteServ(TxtCod.Text) == 2)
            {
                if (!prod.existeprod(TxtCod.Text))
                { addProd(); }
                else
                {
                    UpdProd();
                }
            }
            else
            {
                if (!prod.existeprod(TxtCod.Text))
                { addProd(); }
                else
                {
                    UpdProd();
                }
            }
            
            
        }
        private void addProd ()
        {
            string[] datos = {TxtCod .Text,TxtNom.Text ,TxtDesc.Text,TxtMarca.Text,TxtCosto.Text ,TxtPrecio_M1.Text,TxtPrecio_M2.Text,TxtPrecio_V1.Text, TxtPrecio_V2.Text,Nud.Value .ToString (),DtpCad.Value.ToString ("yyyy/MM/dd"),"0" };
            if (prod.agregprod(datos))
            { MessageBox.Show("Producto ingresado Correctamente"); }
            else
            { MessageBox.Show("Error al ingresar producto"); }
        }

        private void UpdProd()
        {
            string[] datos = { TxtCod.Text, TxtNom.Text, TxtDesc.Text, TxtMarca.Text, TxtCosto.Text, TxtPrecio_M1.Text, TxtPrecio_M2.Text, TxtPrecio_V1.Text, TxtPrecio_V2.Text, Nud.Value.ToString(), DtpCad.Value.ToString("yyyy/MM/dd"),"0"};
            if (prod.actualprod (datos))
            { MessageBox.Show("Producto Actualizado"); }
            else
            { MessageBox.Show("Error al ingresar producto"); }
        }

        private void TxtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (prod.existeprod(TxtCod.Text))
                { llenarcajas();
                    BtnAdd.Text = "Actualizar";
                }
                else
                { BtnAdd.Text = "Agregar"; }
                    
            }
        }

        private void llenarcajas()
        {
            DataTable datos = new DataTable();
            datos = prod.buscarprod(TxtCod .Text);
            TxtNom.Text = datos.Rows[0][0].ToString();
            TxtDesc.Text= datos.Rows[0][1].ToString();
            TxtMarca.Text= datos.Rows[0][2].ToString();
            TxtCosto.Text = datos.Rows[0][3].ToString();
            TxtPrecio_M1.Text = datos.Rows[0][10].ToString();
            TxtPrecio_M2.Text = datos.Rows[0][11].ToString();
            TxtPrecio_V1.Text = datos.Rows[0][4].ToString();
            TxtPrecio_V2.Text = datos.Rows[0][9].ToString();
            Nud.Value =decimal.Parse( datos.Rows[0][5].ToString());
            DtpCad.Value = DateTime.Parse(DateTime.Parse( datos.Rows[0][6].ToString()).ToString ("dd/MM/yyyyy"));
            /*NudPack.Value = decimal.Parse(datos.Rows[0][7].ToString());
            TxtPpack.Text = datos.Rows[0][8].ToString();*/


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscarnom();
            EstiloFecha();
            estiloFecha2();
            BtnAdd.Enabled = true;
            
        }

        private void buscarcod()
        {
            string cod = TxtCodp.Text;
            DataTable datos = new DataTable();
            datos = prod.buscarprod(cod);
            DgvDatos.DataSource = datos;
        }

        private void buscarnom()
        {
            string nombre = TxtNom.Text;
            string desc = TxtDesc.Text;
            string marca = TxtMarca.Text;
            DataTable datos = new DataTable();
            datos = prod.Buscarprodnom(nombre,marca,desc);
            if (datos.Rows.Count > 0) { DgvDatos.DataSource = datos; }
            else { MessageBox.Show("No existe el producto buscado","No existe",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
            
        }

        private void BuscarServ()
        {
            string nombre = TxtNom.Text;
            string desc = TxtDesc.Text;
            string marca = TxtMarca.Text;
            DataTable datos = new DataTable();
            datos = prod.BuscarServNom(nombre, marca, desc);
            if (datos.Rows.Count > 0) { DgvDatos.DataSource = datos; }
            else { MessageBox.Show("No existe el servicio buscado", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void TxtCodp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                buscarcod();
                TxtNomP.Clear();
                    TxtCodp.SelectionStart = 0;
                TxtCodp.SelectionLength = TxtCod.Text.Length;
                TxtCodp.Focus();
            }
        }

        private void TxtNomP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                buscarnom();
                TxtCodp.Clear();
                TxtNomP.SelectionStart = 0;
                TxtNomP.SelectionLength = TxtCod.Text.Length;
                TxtNomP.Focus();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SelectProd();
        }
        private void SelectProd()
        {
            int indice = 0;
            if (DgvDatos.Rows.Count>0 )
            {
                indice = DgvDatos.CurrentRow.Index;
            }
            else
            { MessageBox.Show("No se ha seleccionado ningún producto", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TxtCod.Text = DgvDatos.Rows[indice].Cells[0].Value.ToString();
            if (prod.existeprod(TxtCod.Text))
            {
                llenarcajas();
                BtnAdd.Text = "Actualizar";
            }
            else
            { BtnAdd.Text = "Agregar"; }
        }

        private void EstiloFecha()
        {
            int totalprod,cont;
            totalprod = DgvDatos.Rows.Count;
            DateTime fechaini = DateTime.Now;
            fechaini = fechaini.AddDays(31);
            string fecha = fechaini.ToString("yyyy/MM/dd");
            DgvDatos.EnableHeadersVisualStyles = false;
            for (cont=0;cont<totalprod;cont++)
            {
                string codig;
                codig = DgvDatos.Rows[cont].Cells[0].Value.ToString();
                if(prod.caducado(codig, fecha))
                {
                    //cambio de color para los que sean caducados
                    DgvDatos.Rows[cont].DefaultCellStyle.ForeColor = Color.White;
                    DgvDatos.Rows[cont].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
            }

        }

        private void estiloFecha2()
        {
            int totalprod, cont;
            totalprod = DgvDatos.Rows.Count;
            DgvDatos.EnableHeadersVisualStyles = false;
            for (cont = 0; cont < totalprod; cont++)
            {
                string codig;
                codig = DgvDatos.Rows[cont].Cells[0].Value.ToString();
                if (prod.Cantibaja(codig))
                {
                    //cambio de color para los que sean caducados
                    DgvDatos.Rows[cont].DefaultCellStyle.ForeColor = Color.White;
                    DgvDatos.Rows[cont].DefaultCellStyle.BackColor = Color.DarkCyan;
                }
            }
        }



        private void DgvDatos_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            EstiloFecha();
        }

        private void DgvDatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EstiloFecha();
        }

        private void Chk1_CheckStateChanged(object sender, EventArgs e)
        {
            if (Chk1.Checked)
            {
                DtpCad.Visible = false;
                DateTime fecha = DateTime.Now;
                fecha = fecha.AddYears(15);
                DtpCad.Value = fecha;
            }
            else
            {
                DtpCad.Visible = true;
                DtpCad.Value = DateTime.Now;
            }
        }

        private void BtnServ_Click(object sender, EventArgs e)
        {
            Servicio serv = new Servicio();
            serv.ShowDialog();
        }

        private void BtnBuscServ_Click(object sender, EventArgs e)
        {
            BuscarServ();
            EstiloFecha();
            estiloFecha2();
            BtnAdd.Enabled = false;
            
        }

        private void limpiar()
        {
            TxtCod.Clear();
            TxtNom.Clear();
            TxtDesc.Clear();
            TxtMarca.Clear();
            TxtPrecio_M1.Text = "0";
            TxtPrecio_M2.Text = "0";
            TxtPrecio_V1.Text = "0";
            TxtPrecio_V2.Text = "0";
            Nud.Value = 0;
        }

        private void TxtPercM1_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto.Text != "")
            {
                decimal costo, porcent=0, precio=0;
                bool numerico;
                costo = decimal.Parse(TxtCosto.Text);
                numerico = decimal.TryParse(TxtPercM1.Text,out  porcent);
                if (numerico)
                {
                    precio = costo + (costo * porcent / 100);
                    
                }

                TxtPrecio_M1.Text = precio.ToString("###,###.##");
                 }
        }

        private void TxtPercM2_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto.Text != "")
            {
                decimal costo, porcent = 0, precio = 0;
                bool numerico;
                costo = decimal.Parse(TxtCosto.Text);
                numerico = decimal.TryParse(TxtPercM2.Text, out porcent);
                if (numerico)
                {
                    precio = costo + (costo * porcent / 100);

                }

                TxtPrecio_M2.Text = precio.ToString("###,###.##");
            }
        }

        private void TxtPercV1_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto.Text != "")
            {
                decimal costo, porcent = 0, precio = 0;
                bool numerico;
                costo = decimal.Parse(TxtCosto.Text);
                numerico = decimal.TryParse(TxtPercV1.Text, out porcent);
                if (numerico)
                {
                    precio = costo + (costo * porcent / 100);
                }
                TxtPrecio_V1.Text = precio.ToString("###,###.##");
            }
        }

        private void TxtPercV2_TextChanged(object sender, EventArgs e)
        {
            if (TxtCosto.Text != "")
            {
                decimal costo, porcent = 0, precio = 0;
                bool numerico;
                costo = decimal.Parse(TxtCosto.Text);
                numerico = decimal.TryParse(TxtPercV2.Text, out porcent);
                if (numerico)
                {
                    precio = costo + (costo * porcent / 100);
                }
                TxtPrecio_V2.Text = precio.ToString("###,###.##");
            }

        }
    }
}
