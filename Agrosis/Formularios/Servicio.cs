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
    public partial class Servicio : Form
    {
        Clases.Producto prod = new Clases.Producto();
        public Servicio()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            listardatos();
            limpiar();
        }

        private void listardatos()
        {
            string []  datos = {TxtCod.Text,TxtNom.Text,TxtDesc.Text,"","0",TxtM1.Text,TxtM2.Text,TxtV1.Text,TxtV2.Text,"0","2100/12/31","1" };
            if (prod.ExisteServ(TxtCod.Text) == 0)
            {
                if (prod.agregprod(datos))
                { MessageBox.Show("Servicio ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    MessageBox.Show("No se pudo ingresar el servicio", "Inconveniente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (prod.ExisteServ(TxtCod.Text) == 1)
            {
                DialogResult = MessageBox.Show("El servicio ya existe, ¿Desea actualizar los datos?", "Existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    if (prod.actualprod(datos))
                    {
                        MessageBox.Show("Servicio actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actuaizar el servicio", "Inconveniente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (prod.ExisteServ(TxtCod.Text) == 2)
            {
                MessageBox.Show("Ya existe el mismo código asignado a un producto, verifique el código ingresado", "Código ya existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limpiar()
        {
            TxtCod.Clear();
            TxtNom.Clear();
            TxtDesc.Clear();
            TxtM1.Clear();
            TxtM2.Clear();
            TxtV1.Clear();
            TxtV2.Clear();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
