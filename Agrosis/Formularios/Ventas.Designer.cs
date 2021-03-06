namespace Agrosis.Formularios
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanSup = new System.Windows.Forms.Panel();
            this.CboPrecio = new System.Windows.Forms.ComboBox();
            this.ChkCprecio = new System.Windows.Forms.CheckBox();
            this.CboNom = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NudCant = new System.Windows.Forms.NumericUpDown();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanLat = new System.Windows.Forms.Panel();
            this.LblDesc = new System.Windows.Forms.Label();
            this.BtnImp = new System.Windows.Forms.Button();
            this.LblCant = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCamb = new System.Windows.Forms.TextBox();
            this.TxtEfect = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCobrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvProd = new System.Windows.Forms.DataGridView();
            this.Ttinfo = new System.Windows.Forms.ToolTip(this.components);
            this.CboCli = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.AddClie = new System.Windows.Forms.Button();
            this.PanSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCant)).BeginInit();
            this.PanLat.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.BackColor = System.Drawing.Color.Transparent;
            this.PanSup.Controls.Add(this.CboPrecio);
            this.PanSup.Controls.Add(this.ChkCprecio);
            this.PanSup.Controls.Add(this.CboNom);
            this.PanSup.Controls.Add(this.TxtTotal);
            this.PanSup.Controls.Add(this.label7);
            this.PanSup.Controls.Add(this.LblTotal);
            this.PanSup.Controls.Add(this.BtnBorrar);
            this.PanSup.Controls.Add(this.label6);
            this.PanSup.Controls.Add(this.NudCant);
            this.PanSup.Controls.Add(this.TxtPrecio);
            this.PanSup.Controls.Add(this.label5);
            this.PanSup.Controls.Add(this.TxtMarca);
            this.PanSup.Controls.Add(this.label4);
            this.PanSup.Controls.Add(this.Txtdesc);
            this.PanSup.Controls.Add(this.label3);
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.TxtCod);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(1098, 133);
            this.PanSup.TabIndex = 0;
            // 
            // CboPrecio
            // 
            this.CboPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPrecio.FormattingEnabled = true;
            this.CboPrecio.Location = new System.Drawing.Point(603, 27);
            this.CboPrecio.Name = "CboPrecio";
            this.CboPrecio.Size = new System.Drawing.Size(174, 28);
            this.CboPrecio.TabIndex = 19;
            this.CboPrecio.SelectedIndexChanged += new System.EventHandler(this.CboPrecio_SelectedIndexChanged);
            // 
            // ChkCprecio
            // 
            this.ChkCprecio.AutoSize = true;
            this.ChkCprecio.Location = new System.Drawing.Point(667, 70);
            this.ChkCprecio.Name = "ChkCprecio";
            this.ChkCprecio.Size = new System.Drawing.Size(110, 24);
            this.ChkCprecio.TabIndex = 18;
            this.ChkCprecio.Text = "Precio Libre";
            this.ChkCprecio.UseVisualStyleBackColor = true;
            this.ChkCprecio.Visible = false;
            // 
            // CboNom
            // 
            this.CboNom.DropDownWidth = 400;
            this.CboNom.FormattingEnabled = true;
            this.CboNom.Location = new System.Drawing.Point(13, 90);
            this.CboNom.MaxDropDownItems = 10;
            this.CboNom.Name = "CboNom";
            this.CboNom.Size = new System.Drawing.Size(275, 28);
            this.CboNom.TabIndex = 17;
            this.CboNom.TextChanged += new System.EventHandler(this.CboNom_TextChanged);
            this.CboNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboNom_KeyDown);
            this.CboNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboNom_KeyPress);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(910, 59);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(175, 49);
            this.TxtTotal.TabIndex = 16;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(911, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total a pagar Q. ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1031, 94);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(65, 25);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.Text = "Total";
            this.LblTotal.Visible = false;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(784, 49);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(112, 63);
            this.BtnBorrar.TabIndex = 13;
            this.BtnBorrar.Text = "Borrar Producto";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // NudCant
            // 
            this.NudCant.Location = new System.Drawing.Point(533, 91);
            this.NudCant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudCant.Name = "NudCant";
            this.NudCant.Size = new System.Drawing.Size(85, 27);
            this.NudCant.TabIndex = 10;
            this.NudCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudCant_KeyDown);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(468, 29);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(107, 27);
            this.TxtPrecio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Location = new System.Drawing.Point(311, 91);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(203, 27);
            this.TxtMarca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca";
            // 
            // Txtdesc
            // 
            this.Txtdesc.Enabled = false;
            this.Txtdesc.Location = new System.Drawing.Point(284, 29);
            this.Txtdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtdesc.Name = "Txtdesc";
            this.Txtdesc.Size = new System.Drawing.Size(148, 27);
            this.Txtdesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(13, 29);
            this.TxtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(248, 27);
            this.TxtCod.TabIndex = 1;
            this.TxtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // PanLat
            // 
            this.PanLat.BackColor = System.Drawing.Color.Transparent;
            this.PanLat.Controls.Add(this.LblDesc);
            this.PanLat.Controls.Add(this.BtnImp);
            this.PanLat.Controls.Add(this.LblCant);
            this.PanLat.Controls.Add(this.label9);
            this.PanLat.Controls.Add(this.label8);
            this.PanLat.Controls.Add(this.TxtCamb);
            this.PanLat.Controls.Add(this.TxtEfect);
            this.PanLat.Controls.Add(this.BtnCancelar);
            this.PanLat.Controls.Add(this.BtnCobrar);
            this.PanLat.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanLat.Location = new System.Drawing.Point(847, 133);
            this.PanLat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanLat.Name = "PanLat";
            this.PanLat.Size = new System.Drawing.Size(251, 569);
            this.PanLat.TabIndex = 1;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(47, 333);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(18, 20);
            this.LblDesc.TabIndex = 8;
            this.LblDesc.Text = "0";
            this.LblDesc.Visible = false;
            // 
            // BtnImp
            // 
            this.BtnImp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnImp.Image = ((System.Drawing.Image)(resources.GetObject("BtnImp.Image")));
            this.BtnImp.Location = new System.Drawing.Point(11, 80);
            this.BtnImp.Name = "BtnImp";
            this.BtnImp.Size = new System.Drawing.Size(43, 36);
            this.BtnImp.TabIndex = 7;
            this.BtnImp.UseVisualStyleBackColor = true;
            this.BtnImp.Visible = false;
            this.BtnImp.Click += new System.EventHandler(this.BtnImp_Click);
            // 
            // LblCant
            // 
            this.LblCant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCant.AutoSize = true;
            this.LblCant.Location = new System.Drawing.Point(47, 313);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(84, 20);
            this.LblCant.TabIndex = 6;
            this.LblCant.Text = "Productos:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cambio";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Efectivo";
            // 
            // TxtCamb
            // 
            this.TxtCamb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCamb.Enabled = false;
            this.TxtCamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCamb.Location = new System.Drawing.Point(16, 224);
            this.TxtCamb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCamb.Name = "TxtCamb";
            this.TxtCamb.Size = new System.Drawing.Size(205, 49);
            this.TxtCamb.TabIndex = 3;
            this.TxtCamb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtEfect
            // 
            this.TxtEfect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtEfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfect.Location = new System.Drawing.Point(16, 145);
            this.TxtEfect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEfect.Name = "TxtEfect";
            this.TxtEfect.Size = new System.Drawing.Size(205, 49);
            this.TxtEfect.TabIndex = 2;
            this.TxtEfect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEfect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEfect_KeyDown);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(89, 67);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(132, 49);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCobrar.Image")));
            this.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCobrar.Location = new System.Drawing.Point(4, 5);
            this.BtnCobrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(217, 62);
            this.BtnCobrar.TabIndex = 0;
            this.BtnCobrar.Text = "Cobrar";
            this.BtnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCobrar.UseVisualStyleBackColor = true;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvProd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 238);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 464);
            this.panel3.TabIndex = 2;
            // 
            // DgvProd
            // 
            this.DgvProd.AllowUserToAddRows = false;
            this.DgvProd.AllowUserToDeleteRows = false;
            this.DgvProd.AllowUserToResizeColumns = false;
            this.DgvProd.AllowUserToResizeRows = false;
            this.DgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProd.BackgroundColor = System.Drawing.Color.Silver;
            this.DgvProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProd.EnableHeadersVisualStyles = false;
            this.DgvProd.Location = new System.Drawing.Point(0, 0);
            this.DgvProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvProd.MultiSelect = false;
            this.DgvProd.Name = "DgvProd";
            this.DgvProd.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvProd.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProd.ShowCellToolTips = false;
            this.DgvProd.ShowEditingIcon = false;
            this.DgvProd.ShowRowErrors = false;
            this.DgvProd.Size = new System.Drawing.Size(847, 464);
            this.DgvProd.TabIndex = 0;
            this.DgvProd.Click += new System.EventHandler(this.DgvProd_Click);
            // 
            // CboCli
            // 
            this.CboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCli.DropDownWidth = 400;
            this.CboCli.FormattingEnabled = true;
            this.CboCli.Location = new System.Drawing.Point(13, 156);
            this.CboCli.MaxDropDownItems = 10;
            this.CboCli.Name = "CboCli";
            this.CboCli.Size = new System.Drawing.Size(275, 28);
            this.CboCli.TabIndex = 19;
            this.CboCli.SelectedIndexChanged += new System.EventHandler(this.CboCli_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nit";
            // 
            // TxtNit
            // 
            this.TxtNit.Enabled = false;
            this.TxtNit.Location = new System.Drawing.Point(311, 159);
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(121, 27);
            this.TxtNit.TabIndex = 21;
            this.TxtNit.Text = "C/F";
            // 
            // AddClie
            // 
            this.AddClie.Image = ((System.Drawing.Image)(resources.GetObject("AddClie.Image")));
            this.AddClie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClie.Location = new System.Drawing.Point(680, 144);
            this.AddClie.Name = "AddClie";
            this.AddClie.Size = new System.Drawing.Size(130, 51);
            this.AddClie.TabIndex = 22;
            this.AddClie.Text = "Agregar Cliente";
            this.AddClie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddClie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddClie.UseVisualStyleBackColor = true;
            this.AddClie.Click += new System.EventHandler(this.AddClie_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 702);
            this.Controls.Add(this.AddClie);
            this.Controls.Add(this.TxtNit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CboCli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanLat);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventas_KeyDown);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCant)).EndInit();
            this.PanLat.ResumeLayout(false);
            this.PanLat.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudCant;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanLat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvProd;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCobrar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCamb;
        private System.Windows.Forms.TextBox TxtEfect;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Button BtnImp;
        private System.Windows.Forms.ToolTip Ttinfo;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.ComboBox CboNom;
        private System.Windows.Forms.CheckBox ChkCprecio;
        private System.Windows.Forms.ComboBox CboPrecio;
        private System.Windows.Forms.ComboBox CboCli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNit;
        private System.Windows.Forms.Button AddClie;
    }
}