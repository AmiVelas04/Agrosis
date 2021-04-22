namespace Agrosis.Formularios
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.PanSup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotalC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumDoc = new System.Windows.Forms.TextBox();
            this.CboDoc = new System.Windows.Forms.ComboBox();
            this.DtpComp = new System.Windows.Forms.DateTimePicker();
            this.CboProv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblProv = new System.Windows.Forms.Label();
            this.PanInf = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PanCent = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkPrecio = new System.Windows.Forms.CheckBox();
            this.PanSup.SuspendLayout();
            this.PanInf.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.TxtTotalC);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Controls.Add(this.TxtNumDoc);
            this.PanSup.Controls.Add(this.CboDoc);
            this.PanSup.Controls.Add(this.DtpComp);
            this.PanSup.Controls.Add(this.CboProv);
            this.PanSup.Controls.Add(this.label3);
            this.PanSup.Controls.Add(this.LblDate);
            this.PanSup.Controls.Add(this.LblProv);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(1184, 103);
            this.PanSup.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1028, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total";
            // 
            // TxtTotalC
            // 
            this.TxtTotalC.Enabled = false;
            this.TxtTotalC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalC.Location = new System.Drawing.Point(961, 36);
            this.TxtTotalC.Multiline = true;
            this.TxtTotalC.Name = "TxtTotalC";
            this.TxtTotalC.Size = new System.Drawing.Size(211, 51);
            this.TxtTotalC.TabIndex = 10;
            this.TxtTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. Documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtNumDoc
            // 
            this.TxtNumDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumDoc.Location = new System.Drawing.Point(425, 39);
            this.TxtNumDoc.Name = "TxtNumDoc";
            this.TxtNumDoc.Size = new System.Drawing.Size(121, 29);
            this.TxtNumDoc.TabIndex = 8;
            // 
            // CboDoc
            // 
            this.CboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDoc.FormattingEnabled = true;
            this.CboDoc.Items.AddRange(new object[] {
            "Factura",
            "Envio"});
            this.CboDoc.Location = new System.Drawing.Point(227, 36);
            this.CboDoc.Name = "CboDoc";
            this.CboDoc.Size = new System.Drawing.Size(152, 29);
            this.CboDoc.TabIndex = 7;
            // 
            // DtpComp
            // 
            this.DtpComp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpComp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpComp.Location = new System.Drawing.Point(625, 39);
            this.DtpComp.Name = "DtpComp";
            this.DtpComp.Size = new System.Drawing.Size(175, 29);
            this.DtpComp.TabIndex = 6;
            // 
            // CboProv
            // 
            this.CboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboProv.FormattingEnabled = true;
            this.CboProv.Location = new System.Drawing.Point(12, 39);
            this.CboProv.Name = "CboProv";
            this.CboProv.Size = new System.Drawing.Size(175, 29);
            this.CboProv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(635, 12);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(54, 21);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Fecha";
            // 
            // LblProv
            // 
            this.LblProv.AutoSize = true;
            this.LblProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProv.Location = new System.Drawing.Point(20, 12);
            this.LblProv.Name = "LblProv";
            this.LblProv.Size = new System.Drawing.Size(89, 21);
            this.LblProv.TabIndex = 0;
            this.LblProv.Text = "Proveedor";
            // 
            // PanInf
            // 
            this.PanInf.Controls.Add(this.BtnSave);
            this.PanInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanInf.Location = new System.Drawing.Point(0, 623);
            this.PanInf.Name = "PanInf";
            this.PanInf.Size = new System.Drawing.Size(1184, 79);
            this.PanInf.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(984, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(197, 61);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Guardar Compra";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.ChkPrecio);
            this.PanCent.Controls.Add(this.BtnAdd);
            this.PanCent.Controls.Add(this.Dgv1);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 103);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(1184, 520);
            this.PanCent.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(1014, 17);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(158, 54);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Dgv1
            // 
            this.Dgv1.AllowUserToAddRows = false;
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nom,
            this.Desc,
            this.Marc,
            this.Precio1,
            this.Precio2,
            this.Precio3,
            this.Precio4,
            this.Precio5,
            this.Cant,
            this.Cad});
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dgv1.Location = new System.Drawing.Point(0, 0);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.Size = new System.Drawing.Size(996, 520);
            this.Dgv1.TabIndex = 0;
            this.Dgv1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv1_CellEndEdit);
            this.Dgv1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv1_RowLeave);
            this.Dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv1_KeyDown);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombre";
            this.Nom.Name = "Nom";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripción";
            this.Desc.Name = "Desc";
            // 
            // Marc
            // 
            this.Marc.HeaderText = "Marca";
            this.Marc.Name = "Marc";
            // 
            // Precio1
            // 
            this.Precio1.HeaderText = "Costo";
            this.Precio1.Name = "Precio1";
            // 
            // Precio2
            // 
            this.Precio2.HeaderText = "Mayorista 1";
            this.Precio2.Name = "Precio2";
            // 
            // Precio3
            // 
            this.Precio3.HeaderText = "Mayorista 2";
            this.Precio3.Name = "Precio3";
            // 
            // Precio4
            // 
            this.Precio4.HeaderText = "Venta 1";
            this.Precio4.Name = "Precio4";
            // 
            // Precio5
            // 
            this.Precio5.HeaderText = "Venta 2";
            this.Precio5.Name = "Precio5";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // Cad
            // 
            this.Cad.HeaderText = "Fecha de caducidad";
            this.Cad.Name = "Cad";
            // 
            // ChkPrecio
            // 
            this.ChkPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPrecio.Location = new System.Drawing.Point(1014, 89);
            this.ChkPrecio.Name = "ChkPrecio";
            this.ChkPrecio.Size = new System.Drawing.Size(158, 68);
            this.ChkPrecio.TabIndex = 2;
            this.ChkPrecio.Text = "Modificar producto";
            this.ChkPrecio.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 702);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanInf);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanInf.ResumeLayout(false);
            this.PanCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Label LblProv;
        private System.Windows.Forms.Panel PanInf;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.DateTimePicker DtpComp;
        private System.Windows.Forms.ComboBox CboProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ComboBox CboDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumDoc;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotalC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cad;
        private System.Windows.Forms.CheckBox ChkPrecio;
    }
}