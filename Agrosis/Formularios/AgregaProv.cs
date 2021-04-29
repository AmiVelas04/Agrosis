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
    public partial class AgregaProv : Form
    {
        Clases.Proveedor prov = new Clases.Proveedor();
        public AgregaProv()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            agregaProv();
            limpiar();
        }

        private void agregaProv()
        {
            string nombre, dir, nit;

            if (TxtNom.Text == "")
            {
                MessageBox.Show("Se debe ingresar el nombre del proveedor");
            }
            else
            {
                nombre = TxtNom.Text;
                dir = TxtDir.Text == "" ? "N/E" : TxtDir.Text;
                nit = TxtNit.Text == "" ? "N/E" : TxtNit.Text;
                string[] datos = {nombre,dir,nit };

                prov.ingresoprov(datos);
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            TxtNom.Clear();
            TxtDir.Clear();
            TxtNit.Clear();
        }
    }
}
