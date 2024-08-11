namespace tiendaMY
{
    partial class Facturar
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
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.cedulaTB = new System.Windows.Forms.TextBox();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.codigoTB = new System.Windows.Forms.TextBox();
            this.cantidadTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.facturaDGV = new System.Windows.Forms.DataGridView();
            this.codigoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarPB = new System.Windows.Forms.DataGridViewImageColumn();
            this.totalBsTB = new System.Windows.Forms.Label();
            this.totalUSDTB = new System.Windows.Forms.Label();
            this.facturarButton = new System.Windows.Forms.Button();
            this.metodosDePagolbl = new System.Windows.Forms.Label();
            this.puntoDeVentaRB = new System.Windows.Forms.RadioButton();
            this.dolaresRB = new System.Windows.Forms.RadioButton();
            this.bsRB = new System.Windows.Forms.RadioButton();
            this.zelleRB = new System.Windows.Forms.RadioButton();
            this.datosClienteLbl = new System.Windows.Forms.Label();
            this.cedulaLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.cantidadLbl = new System.Windows.Forms.Label();
            this.codigoLbl = new System.Windows.Forms.Label();
            this.datosProductolbl = new System.Windows.Forms.Label();
            this.pagoMovilRB = new System.Windows.Forms.RadioButton();
            this.busquedaLINQbutton = new System.Windows.Forms.Button();
            this.validacionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(88, 166);
            this.nombreTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(76, 20);
            this.nombreTB.TabIndex = 1;
            // 
            // cedulaTB
            // 
            this.cedulaTB.Location = new System.Drawing.Point(88, 138);
            this.cedulaTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cedulaTB.Name = "cedulaTB";
            this.cedulaTB.Size = new System.Drawing.Size(76, 20);
            this.cedulaTB.TabIndex = 2;
            this.cedulaTB.TextChanged += new System.EventHandler(this.cedulaTB_TextChanged);
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(713, 27);
            this.tituloLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(191, 44);
            this.tituloLbl.TabIndex = 3;
            this.tituloLbl.Text = "COMPRA";
            // 
            // codigoTB
            // 
            this.codigoTB.Location = new System.Drawing.Point(77, 245);
            this.codigoTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoTB.Name = "codigoTB";
            this.codigoTB.Size = new System.Drawing.Size(76, 20);
            this.codigoTB.TabIndex = 4;
            this.codigoTB.Tag = "Hola";
            // 
            // cantidadTB
            // 
            this.cantidadTB.Location = new System.Drawing.Point(77, 267);
            this.cantidadTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidadTB.Name = "cantidadTB";
            this.cantidadTB.Size = new System.Drawing.Size(31, 20);
            this.cantidadTB.TabIndex = 5;
            this.cantidadTB.TextChanged += new System.EventHandler(this.cantidadTB_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(161, 239);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 29);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Añadir";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(171, 134);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(78, 24);
            this.buscarButton.TabIndex = 7;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // facturaDGV
            // 
            this.facturaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoC,
            this.nombreColumn,
            this.precioUnitarioColumn,
            this.cantidadColumn,
            this.precioTotalColumn,
            this.eliminarPB});
            this.facturaDGV.Location = new System.Drawing.Point(478, 84);
            this.facturaDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facturaDGV.Name = "facturaDGV";
            this.facturaDGV.RowHeadersWidth = 51;
            this.facturaDGV.RowTemplate.Height = 24;
            this.facturaDGV.Size = new System.Drawing.Size(702, 549);
            this.facturaDGV.TabIndex = 8;
            this.facturaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturaDGV_CellContentClick);
            // 
            // codigoC
            // 
            this.codigoC.HeaderText = "Codigo";
            this.codigoC.MinimumWidth = 6;
            this.codigoC.Name = "codigoC";
            this.codigoC.Width = 65;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // precioUnitarioColumn
            // 
            this.precioUnitarioColumn.HeaderText = "Precio unitario";
            this.precioUnitarioColumn.MinimumWidth = 6;
            this.precioUnitarioColumn.Name = "precioUnitarioColumn";
            this.precioUnitarioColumn.Width = 65;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.MinimumWidth = 6;
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.Width = 65;
            // 
            // precioTotalColumn
            // 
            this.precioTotalColumn.HeaderText = "Precio total";
            this.precioTotalColumn.MinimumWidth = 6;
            this.precioTotalColumn.Name = "precioTotalColumn";
            this.precioTotalColumn.Width = 65;
            // 
            // eliminarPB
            // 
            this.eliminarPB.HeaderText = "Eliminar";
            this.eliminarPB.MinimumWidth = 6;
            this.eliminarPB.Name = "eliminarPB";
            this.eliminarPB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarPB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminarPB.Width = 55;
            // 
            // totalBsTB
            // 
            this.totalBsTB.AutoSize = true;
            this.totalBsTB.Location = new System.Drawing.Point(33, 426);
            this.totalBsTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalBsTB.Name = "totalBsTB";
            this.totalBsTB.Size = new System.Drawing.Size(49, 13);
            this.totalBsTB.TabIndex = 9;
            this.totalBsTB.Text = "Total Bs.";
            // 
            // totalUSDTB
            // 
            this.totalUSDTB.AutoSize = true;
            this.totalUSDTB.Location = new System.Drawing.Point(33, 449);
            this.totalUSDTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalUSDTB.Name = "totalUSDTB";
            this.totalUSDTB.Size = new System.Drawing.Size(70, 13);
            this.totalUSDTB.TabIndex = 10;
            this.totalUSDTB.Text = "Total Dolares";
            // 
            // facturarButton
            // 
            this.facturarButton.Location = new System.Drawing.Point(115, 485);
            this.facturarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facturarButton.Name = "facturarButton";
            this.facturarButton.Size = new System.Drawing.Size(66, 29);
            this.facturarButton.TabIndex = 11;
            this.facturarButton.Text = "Facturar";
            this.facturarButton.UseVisualStyleBackColor = true;
            this.facturarButton.Click += new System.EventHandler(this.facturarButton_Click);
            // 
            // metodosDePagolbl
            // 
            this.metodosDePagolbl.AutoSize = true;
            this.metodosDePagolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodosDePagolbl.Location = new System.Drawing.Point(30, 332);
            this.metodosDePagolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metodosDePagolbl.Name = "metodosDePagolbl";
            this.metodosDePagolbl.Size = new System.Drawing.Size(125, 17);
            this.metodosDePagolbl.TabIndex = 12;
            this.metodosDePagolbl.Text = "Metodo de pago";
            this.metodosDePagolbl.Click += new System.EventHandler(this.metodosDePagolbl_Click);
            // 
            // puntoDeVentaRB
            // 
            this.puntoDeVentaRB.AutoSize = true;
            this.puntoDeVentaRB.Location = new System.Drawing.Point(33, 361);
            this.puntoDeVentaRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.puntoDeVentaRB.Name = "puntoDeVentaRB";
            this.puntoDeVentaRB.Size = new System.Drawing.Size(98, 17);
            this.puntoDeVentaRB.TabIndex = 16;
            this.puntoDeVentaRB.TabStop = true;
            this.puntoDeVentaRB.Text = "Punto de venta";
            this.puntoDeVentaRB.UseVisualStyleBackColor = true;
            this.puntoDeVentaRB.CheckedChanged += new System.EventHandler(this.puntoDeVentaRB_CheckedChanged);
            // 
            // dolaresRB
            // 
            this.dolaresRB.AutoSize = true;
            this.dolaresRB.Location = new System.Drawing.Point(132, 361);
            this.dolaresRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dolaresRB.Name = "dolaresRB";
            this.dolaresRB.Size = new System.Drawing.Size(117, 17);
            this.dolaresRB.TabIndex = 17;
            this.dolaresRB.TabStop = true;
            this.dolaresRB.Text = "Dolares en efectivo";
            this.dolaresRB.UseVisualStyleBackColor = true;
            this.dolaresRB.CheckedChanged += new System.EventHandler(this.dolaresRB_CheckedChanged);
            // 
            // bsRB
            // 
            this.bsRB.AutoSize = true;
            this.bsRB.Location = new System.Drawing.Point(33, 382);
            this.bsRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bsRB.Name = "bsRB";
            this.bsRB.Size = new System.Drawing.Size(124, 17);
            this.bsRB.TabIndex = 18;
            this.bsRB.TabStop = true;
            this.bsRB.Text = "Bolivares en efectivo";
            this.bsRB.UseVisualStyleBackColor = true;
            this.bsRB.CheckedChanged += new System.EventHandler(this.bsRB_CheckedChanged);
            // 
            // zelleRB
            // 
            this.zelleRB.AutoSize = true;
            this.zelleRB.Location = new System.Drawing.Point(158, 382);
            this.zelleRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zelleRB.Name = "zelleRB";
            this.zelleRB.Size = new System.Drawing.Size(48, 17);
            this.zelleRB.TabIndex = 19;
            this.zelleRB.TabStop = true;
            this.zelleRB.Text = "Zelle";
            this.zelleRB.UseVisualStyleBackColor = true;
            this.zelleRB.CheckedChanged += new System.EventHandler(this.zelleRB_CheckedChanged);
            // 
            // datosClienteLbl
            // 
            this.datosClienteLbl.AutoSize = true;
            this.datosClienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosClienteLbl.Location = new System.Drawing.Point(11, 27);
            this.datosClienteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosClienteLbl.Name = "datosClienteLbl";
            this.datosClienteLbl.Size = new System.Drawing.Size(395, 55);
            this.datosClienteLbl.TabIndex = 22;
            this.datosClienteLbl.Text = "Datos del cliente";
            // 
            // cedulaLbl
            // 
            this.cedulaLbl.AutoSize = true;
            this.cedulaLbl.Location = new System.Drawing.Point(44, 141);
            this.cedulaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cedulaLbl.Name = "cedulaLbl";
            this.cedulaLbl.Size = new System.Drawing.Size(40, 13);
            this.cedulaLbl.TabIndex = 23;
            this.cedulaLbl.Text = "Cedula";
            this.cedulaLbl.Click += new System.EventHandler(this.cedulaLbl_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(40, 169);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreLbl.TabIndex = 24;
            this.nombreLbl.Text = "Nombre";
            // 
            // cantidadLbl
            // 
            this.cantidadLbl.AutoSize = true;
            this.cantidadLbl.Location = new System.Drawing.Point(20, 270);
            this.cantidadLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantidadLbl.Name = "cantidadLbl";
            this.cantidadLbl.Size = new System.Drawing.Size(49, 13);
            this.cantidadLbl.TabIndex = 25;
            this.cantidadLbl.Text = "Cantidad";
            this.cantidadLbl.Click += new System.EventHandler(this.nombreProductoLbl_Click);
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Location = new System.Drawing.Point(31, 247);
            this.codigoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(40, 13);
            this.codigoLbl.TabIndex = 26;
            this.codigoLbl.Text = "Codigo";
            // 
            // datosProductolbl
            // 
            this.datosProductolbl.AutoSize = true;
            this.datosProductolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosProductolbl.Location = new System.Drawing.Point(43, 220);
            this.datosProductolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosProductolbl.Name = "datosProductolbl";
            this.datosProductolbl.Size = new System.Drawing.Size(146, 17);
            this.datosProductolbl.TabIndex = 28;
            this.datosProductolbl.Text = "Datos del producto";
            // 
            // pagoMovilRB
            // 
            this.pagoMovilRB.AutoSize = true;
            this.pagoMovilRB.Location = new System.Drawing.Point(206, 382);
            this.pagoMovilRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagoMovilRB.Name = "pagoMovilRB";
            this.pagoMovilRB.Size = new System.Drawing.Size(77, 17);
            this.pagoMovilRB.TabIndex = 31;
            this.pagoMovilRB.TabStop = true;
            this.pagoMovilRB.Text = "Pago movil";
            this.pagoMovilRB.UseVisualStyleBackColor = true;
            this.pagoMovilRB.CheckedChanged += new System.EventHandler(this.pagoMovilRB_CheckedChanged);
            // 
            // busquedaLINQbutton
            // 
            this.busquedaLINQbutton.Location = new System.Drawing.Point(231, 239);
            this.busquedaLINQbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.busquedaLINQbutton.Name = "busquedaLINQbutton";
            this.busquedaLINQbutton.Size = new System.Drawing.Size(66, 29);
            this.busquedaLINQbutton.TabIndex = 32;
            this.busquedaLINQbutton.Text = "Buscar";
            this.busquedaLINQbutton.UseVisualStyleBackColor = true;
            this.busquedaLINQbutton.Click += new System.EventHandler(this.busquedaLINQbutton_Click);
            // 
            // validacionLbl
            // 
            this.validacionLbl.AutoSize = true;
            this.validacionLbl.BackColor = System.Drawing.Color.Transparent;
            this.validacionLbl.ForeColor = System.Drawing.Color.Red;
            this.validacionLbl.Location = new System.Drawing.Point(74, 297);
            this.validacionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validacionLbl.Name = "validacionLbl";
            this.validacionLbl.Size = new System.Drawing.Size(163, 13);
            this.validacionLbl.TabIndex = 33;
            this.validacionLbl.Text = "Solo intruducir caracteres validos";
            this.validacionLbl.Visible = false;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 675);
            this.Controls.Add(this.validacionLbl);
            this.Controls.Add(this.busquedaLINQbutton);
            this.Controls.Add(this.pagoMovilRB);
            this.Controls.Add(this.datosProductolbl);
            this.Controls.Add(this.codigoLbl);
            this.Controls.Add(this.cantidadLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.cedulaLbl);
            this.Controls.Add(this.datosClienteLbl);
            this.Controls.Add(this.zelleRB);
            this.Controls.Add(this.bsRB);
            this.Controls.Add(this.dolaresRB);
            this.Controls.Add(this.puntoDeVentaRB);
            this.Controls.Add(this.metodosDePagolbl);
            this.Controls.Add(this.facturarButton);
            this.Controls.Add(this.totalUSDTB);
            this.Controls.Add(this.totalBsTB);
            this.Controls.Add(this.facturaDGV);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cantidadTB);
            this.Controls.Add(this.codigoTB);
            this.Controls.Add(this.tituloLbl);
            this.Controls.Add(this.cedulaTB);
            this.Controls.Add(this.nombreTB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Facturar";
            this.Text = "Facturacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturar_FormClosed);
            this.Load += new System.EventHandler(this.Facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox cedulaTB;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.TextBox codigoTB;
        private System.Windows.Forms.TextBox cantidadTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView facturaDGV;
        private System.Windows.Forms.Label totalBsTB;
        private System.Windows.Forms.Label totalUSDTB;
        private System.Windows.Forms.Button facturarButton;
        private System.Windows.Forms.Label metodosDePagolbl;
        private System.Windows.Forms.RadioButton puntoDeVentaRB;
        private System.Windows.Forms.RadioButton dolaresRB;
        private System.Windows.Forms.RadioButton bsRB;
        private System.Windows.Forms.RadioButton zelleRB;
        private System.Windows.Forms.Label datosClienteLbl;
        private System.Windows.Forms.Label cedulaLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label cantidadLbl;
        private System.Windows.Forms.Label codigoLbl;
        private System.Windows.Forms.Label datosProductolbl;
        private System.Windows.Forms.RadioButton pagoMovilRB;
        private System.Windows.Forms.Button busquedaLINQbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalColumn;
        private System.Windows.Forms.DataGridViewImageColumn eliminarPB;
        private System.Windows.Forms.Label validacionLbl;
    }
}