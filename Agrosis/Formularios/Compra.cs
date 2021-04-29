﻿using System;
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
    public partial class Compra : Form
    {
        private Clases.Producto prod = new Clases.Producto();
        private Clases.Compra comp = new Clases.Compra();
        private Clases.Proveedor prov = new Clases.Proveedor();
        public Compra()
        {
            InitializeComponent();
        }

        private void Dgv1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
               // mostrarDatos();
            }

           
        }

        private void Dgv1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           // mostrarDatos();
        }

        private void mostrarDatos()
        {
            int fila = -1;
            if (Dgv1.Rows.Count >= 1)
            {
                string cod;
                fila = Int32.Parse(Dgv1.CurrentRow.Index.ToString());
                cod = Dgv1.Rows[fila].Cells[0].Value.ToString();
                if (cod != "")
                {
                    if (prod.existeprod(cod) && !ChkPrecio.Checked)
                    {
                        DataTable prods = new DataTable();
                        prods = prod.buscarprod(cod);
                        Dgv1.Rows[fila].Cells[1].Value = prods.Rows[0][0].ToString();
                        Dgv1.Rows[fila].Cells[2].Value = prods.Rows[0][1].ToString();
                        Dgv1.Rows[fila].Cells[3].Value = prods.Rows[0][2].ToString();
                        Dgv1.Rows[fila].Cells[4].Value = prods.Rows[0][3].ToString();
                        Dgv1.Rows[fila].Cells[5].Value = prods.Rows[0][10].ToString();
                        Dgv1.Rows[fila].Cells[6].Value = prods.Rows[0][11].ToString();
                        Dgv1.Rows[fila].Cells[7].Value = prods.Rows[0][4].ToString();
                        Dgv1.Rows[fila].Cells[8].Value = prods.Rows[0][9].ToString();
                        if (Dgv1.Rows[fila].Cells[9].Value == null) Dgv1.Rows[fila].Cells[9].Value = 0;
                        Dgv1.Rows[fila].Cells[10].Value = prods.Rows[0][6].ToString();
                    }
                }
            }
           
            
        }

        private void sumtotal()
        {
            int numf,cont;
            decimal TotalC = 0;
            numf = Dgv1.Rows.Count;
            for (cont=0;cont<numf;cont++)
            {
                decimal cant, precio;
                cant = Dgv1.Rows[cont].Cells[4].Value != null ? decimal.Parse(Dgv1.Rows[cont].Cells[4].Value.ToString()) : 0;
                precio = Dgv1.Rows[cont].Cells[9].Value != null ? decimal.Parse(Dgv1.Rows[cont].Cells[9].Value.ToString()) : 0;
                TotalC += (cant*precio);
            }
            TxtTotalC.Text = "Q." + TotalC.ToString("###,###,###.##");
        }

        private void Dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
            sumtotal();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtNumDoc.Text == "")
            {
                MessageBox.Show("No se ha ingresado en número del documento", "Sin número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listarprods();
                limpiar();
            }
            
        }

        private void listarprods()
        {
            int cantP;
            cantP = Dgv1.Rows.Count;
            if (cantP >= 0)
            {
                int cont;
                string[,] datos = new string[cantP, 11];
                for (cont= 0; cont<cantP;cont++)
                {
                    datos[cont, 0] = Dgv1.Rows[cont].Cells["Cod"].Value!=null ? Dgv1.Rows[cont].Cells["Cod"].Value.ToString() : "";
                    datos[cont, 1] = Dgv1.Rows[cont].Cells["Nom"].Value!=null ? Dgv1.Rows[cont].Cells["Nom"].Value.ToString():"";
                    datos[cont, 2] = Dgv1.Rows[cont].Cells["Desc"].Value !=null ? Dgv1.Rows[cont].Cells["Desc"].Value.ToString():"";
                    datos[cont, 3] = Dgv1.Rows[cont].Cells["Marc"].Value !=null? Dgv1.Rows[cont].Cells["Desc"].Value.ToString():"";
                    datos[cont, 4] = Dgv1.Rows[cont].Cells["Precio1"].Value !=null ? Dgv1.Rows[cont].Cells["Precio1"].Value.ToString():"0";
                    datos[cont, 5] = Dgv1.Rows[cont].Cells["Precio2"].Value !=null ? Dgv1.Rows[cont].Cells["Precio2"].Value.ToString():"0";
                    datos[cont, 6] = Dgv1.Rows[cont].Cells["Precio3"].Value !=null ? Dgv1.Rows[cont].Cells["Precio3"].Value.ToString():"0";
                    datos[cont, 7] = Dgv1.Rows[cont].Cells["Precio4"].Value !=null ? Dgv1.Rows[cont].Cells["Precio4"].Value.ToString():"0";
                    datos[cont, 8] = Dgv1.Rows[cont].Cells["Precio5"].Value!=null? Dgv1.Rows[cont].Cells["Precio5"].Value.ToString():"0";
                    datos[cont,9]= Dgv1.Rows[cont].Cells["Cant"].Value != null ? Dgv1.Rows[cont].Cells["Cant"].Value.ToString() : "0";
                    datos[cont, 10] = Dgv1.Rows[cont].Cells["Cad"].Value !=null ? Dgv1.Rows[cont].Cells["Cad"].Value.ToString(): DateTime.Today.ToString("dd/MM/yyyy");
                    DateTime fechacad;
                    fechacad = DateTime.Parse(datos[cont,10]);
                    datos[cont,10]=fechacad.ToString("yyyy/MM/dd");

                }

                string prove, cajero, fecha, docu=CboDoc.Text,numdoc;
                fecha = DtpComp.Value.ToString("yyyy/MM/dd");
                prove = CboProv.SelectedValue.ToString();
                cajero = Main.id.ToString();
                numdoc = TxtNumDoc.Text;
                if (comp.ingreso_prod_compra(datos,cajero,prove,fecha,docu,numdoc))
                {
                    MessageBox.Show("Productos ingresdo con exito");
                }
                else
                {
                    MessageBox.Show("Error al ingresar producto");
                }
               
            }
            

        }


        private void limpiar()
        {
            while (Dgv1.Rows.Count>=1)
            {
                string lol;
                lol = Dgv1.Rows.GetRowState(0).ToString();
                Dgv1.Rows.RemoveAt(0);
                TxtTotalC.Text = "Q 0.00";
            }
        }

        private void listaprov()
        {
            DataTable datosprov = new DataTable();
            datosprov = prov.listaprov();
            CboProv.DataSource = datosprov;
            CboProv.ValueMember = "id_prov";
            CboProv.DisplayMember = "nombre";
           
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            CboDoc.SelectedIndex = 0;
            listaprov();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Dgv1.Rows.Add(0,"","","",0,0,0,0,0,0,"");
        }

        private void btnAddProv_Click(object sender, EventArgs e)
        {
            AgregaProv aniadir = new AgregaProv();
            aniadir.ShowDialog();
        }
    }
}