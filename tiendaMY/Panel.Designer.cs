namespace tiendaMY
{
    partial class Panel
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
            this.pictureBoxFacturacion = new System.Windows.Forms.PictureBox();
            this.panelLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.filtroFecha = new System.Windows.Forms.ComboBox();
            this.filtroMoneda = new System.Windows.Forms.ComboBox();
            this.ventasDGV = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoDePagoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVentaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verFacturaLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.facturacionTitle = new System.Windows.Forms.Label();
            this.cantidadFacturadoLbl = new System.Windows.Forms.Label();
            this.gananciaLbl = new System.Windows.Forms.Label();
            this.gananciasTitulo = new System.Windows.Forms.Label();
            this.pictureGanancia = new System.Windows.Forms.PictureBox();
            this.ventasLbl = new System.Windows.Forms.Label();
            this.ventasTitulo = new System.Windows.Forms.Label();
            this.picturVentas = new System.Windows.Forms.PictureBox();
            this.labelFiltroFecha = new System.Windows.Forms.Label();
            this.labelFiltroMoneda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGanancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFacturacion
            // 
            this.pictureBoxFacturacion.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBoxFacturacion.Location = new System.Drawing.Point(109, 148);
            this.pictureBoxFacturacion.Name = "pictureBoxFacturacion";
            this.pictureBoxFacturacion.Size = new System.Drawing.Size(190, 191);
            this.pictureBoxFacturacion.TabIndex = 0;
            this.pictureBoxFacturacion.TabStop = false;
            // 
            // panelLbl
            // 
            this.panelLbl.AutoSize = true;
            this.panelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLbl.Location = new System.Drawing.Point(398, 9);
            this.panelLbl.Name = "panelLbl";
            this.panelLbl.Size = new System.Drawing.Size(247, 42);
            this.panelLbl.TabIndex = 1;
            this.panelLbl.Text = "Panel ventas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(402, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 191);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(708, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 191);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // filtroFecha
            // 
            this.filtroFecha.FormattingEnabled = true;
            this.filtroFecha.Items.AddRange(new object[] {
            "Hoy",
            "Ayer",
            "Esta semana",
            "Ultimos 15 dias",
            "Este mes",
            "Este año",
            "Historicas"});
            this.filtroFecha.Location = new System.Drawing.Point(107, 94);
            this.filtroFecha.Name = "filtroFecha";
            this.filtroFecha.Size = new System.Drawing.Size(156, 24);
            this.filtroFecha.TabIndex = 4;
            this.filtroFecha.SelectedIndexChanged += new System.EventHandler(this.filtroFecha_SelectedIndexChanged);
            // 
            // filtroMoneda
            // 
            this.filtroMoneda.FormattingEnabled = true;
            this.filtroMoneda.Items.AddRange(new object[] {
            "USD",
            "Bs.D"});
            this.filtroMoneda.Location = new System.Drawing.Point(289, 94);
            this.filtroMoneda.Name = "filtroMoneda";
            this.filtroMoneda.Size = new System.Drawing.Size(75, 24);
            this.filtroMoneda.TabIndex = 5;
            this.filtroMoneda.SelectedIndexChanged += new System.EventHandler(this.filtroMoneda_SelectedIndexChanged);
            // 
            // ventasDGV
            // 
            this.ventasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.metodoDePagoColumn,
            this.idVentaColumn,
            this.totalColumn,
            this.gananciaColumn,
            this.fechaColumn,
            this.verFacturaLink});
            this.ventasDGV.Location = new System.Drawing.Point(65, 404);
            this.ventasDGV.Name = "ventasDGV";
            this.ventasDGV.RowHeadersWidth = 51;
            this.ventasDGV.RowTemplate.Height = 24;
            this.ventasDGV.Size = new System.Drawing.Size(918, 229);
            this.ventasDGV.TabIndex = 7;
            this.ventasDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre del cliente";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // metodoDePagoColumn
            // 
            this.metodoDePagoColumn.HeaderText = "Metodo de pago";
            this.metodoDePagoColumn.MinimumWidth = 6;
            this.metodoDePagoColumn.Name = "metodoDePagoColumn";
            this.metodoDePagoColumn.Width = 125;
            // 
            // idVentaColumn
            // 
            this.idVentaColumn.HeaderText = "Codigo de la venta";
            this.idVentaColumn.MinimumWidth = 6;
            this.idVentaColumn.Name = "idVentaColumn";
            this.idVentaColumn.Width = 85;
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.MinimumWidth = 6;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.Width = 85;
            // 
            // gananciaColumn
            // 
            this.gananciaColumn.HeaderText = "Ganancia";
            this.gananciaColumn.MinimumWidth = 6;
            this.gananciaColumn.Name = "gananciaColumn";
            this.gananciaColumn.Width = 85;
            // 
            // fechaColumn
            // 
            this.fechaColumn.HeaderText = "Fecha y hora";
            this.fechaColumn.MinimumWidth = 6;
            this.fechaColumn.Name = "fechaColumn";
            this.fechaColumn.Width = 125;
            // 
            // verFacturaLink
            // 
            this.verFacturaLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.verFacturaLink.HeaderText = "Ver factura";
            this.verFacturaLink.MinimumWidth = 6;
            this.verFacturaLink.Name = "verFacturaLink";
            this.verFacturaLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.verFacturaLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.verFacturaLink.Width = 55;
            // 
            // facturacionTitle
            // 
            this.facturacionTitle.AutoSize = true;
            this.facturacionTitle.BackColor = System.Drawing.Color.DarkRed;
            this.facturacionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.facturacionTitle.Location = new System.Drawing.Point(109, 168);
            this.facturacionTitle.Name = "facturacionTitle";
            this.facturacionTitle.Size = new System.Drawing.Size(155, 25);
            this.facturacionTitle.TabIndex = 8;
            this.facturacionTitle.Text = "Dinero facturado";
            // 
            // cantidadFacturadoLbl
            // 
            this.cantidadFacturadoLbl.AutoSize = true;
            this.cantidadFacturadoLbl.BackColor = System.Drawing.Color.DarkRed;
            this.cantidadFacturadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadFacturadoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cantidadFacturadoLbl.Location = new System.Drawing.Point(109, 226);
            this.cantidadFacturadoLbl.Name = "cantidadFacturadoLbl";
            this.cantidadFacturadoLbl.Size = new System.Drawing.Size(39, 29);
            this.cantidadFacturadoLbl.TabIndex = 9;
            this.cantidadFacturadoLbl.Text = "$0";
            // 
            // gananciaLbl
            // 
            this.gananciaLbl.AutoSize = true;
            this.gananciaLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gananciaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gananciaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gananciaLbl.Location = new System.Drawing.Point(402, 226);
            this.gananciaLbl.Name = "gananciaLbl";
            this.gananciaLbl.Size = new System.Drawing.Size(39, 29);
            this.gananciaLbl.TabIndex = 12;
            this.gananciaLbl.Text = "$0";
            // 
            // gananciasTitulo
            // 
            this.gananciasTitulo.AutoSize = true;
            this.gananciasTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gananciasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gananciasTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gananciasTitulo.Location = new System.Drawing.Point(402, 164);
            this.gananciasTitulo.Name = "gananciasTitulo";
            this.gananciasTitulo.Size = new System.Drawing.Size(114, 29);
            this.gananciasTitulo.TabIndex = 11;
            this.gananciasTitulo.Text = "Ganancia";
            // 
            // pictureGanancia
            // 
            this.pictureGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureGanancia.Location = new System.Drawing.Point(402, 148);
            this.pictureGanancia.Name = "pictureGanancia";
            this.pictureGanancia.Size = new System.Drawing.Size(190, 191);
            this.pictureGanancia.TabIndex = 10;
            this.pictureGanancia.TabStop = false;
            // 
            // ventasLbl
            // 
            this.ventasLbl.AutoSize = true;
            this.ventasLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ventasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ventasLbl.Location = new System.Drawing.Point(708, 226);
            this.ventasLbl.Name = "ventasLbl";
            this.ventasLbl.Size = new System.Drawing.Size(26, 29);
            this.ventasLbl.TabIndex = 15;
            this.ventasLbl.Text = "0";
            // 
            // ventasTitulo
            // 
            this.ventasTitulo.AutoSize = true;
            this.ventasTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ventasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ventasTitulo.Location = new System.Drawing.Point(708, 164);
            this.ventasTitulo.Name = "ventasTitulo";
            this.ventasTitulo.Size = new System.Drawing.Size(86, 29);
            this.ventasTitulo.TabIndex = 14;
            this.ventasTitulo.Text = "Ventas";
            // 
            // picturVentas
            // 
            this.picturVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.picturVentas.Location = new System.Drawing.Point(708, 148);
            this.picturVentas.Name = "picturVentas";
            this.picturVentas.Size = new System.Drawing.Size(190, 191);
            this.picturVentas.TabIndex = 13;
            this.picturVentas.TabStop = false;
            // 
            // labelFiltroFecha
            // 
            this.labelFiltroFecha.AutoSize = true;
            this.labelFiltroFecha.Location = new System.Drawing.Point(106, 75);
            this.labelFiltroFecha.Name = "labelFiltroFecha";
            this.labelFiltroFecha.Size = new System.Drawing.Size(52, 16);
            this.labelFiltroFecha.TabIndex = 16;
            this.labelFiltroFecha.Text = "Ventas:";
            // 
            // labelFiltroMoneda
            // 
            this.labelFiltroMoneda.AutoSize = true;
            this.labelFiltroMoneda.Location = new System.Drawing.Point(286, 75);
            this.labelFiltroMoneda.Name = "labelFiltroMoneda";
            this.labelFiltroMoneda.Size = new System.Drawing.Size(57, 16);
            this.labelFiltroMoneda.TabIndex = 17;
            this.labelFiltroMoneda.Text = "Moneda";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 704);
            this.Controls.Add(this.labelFiltroMoneda);
            this.Controls.Add(this.labelFiltroFecha);
            this.Controls.Add(this.ventasLbl);
            this.Controls.Add(this.ventasTitulo);
            this.Controls.Add(this.picturVentas);
            this.Controls.Add(this.gananciaLbl);
            this.Controls.Add(this.gananciasTitulo);
            this.Controls.Add(this.pictureGanancia);
            this.Controls.Add(this.cantidadFacturadoLbl);
            this.Controls.Add(this.facturacionTitle);
            this.Controls.Add(this.ventasDGV);
            this.Controls.Add(this.filtroMoneda);
            this.Controls.Add(this.filtroFecha);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelLbl);
            this.Controls.Add(this.pictureBoxFacturacion);
            this.Name = "Panel";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGanancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFacturacion;
        private System.Windows.Forms.Label panelLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox filtroFecha;
        private System.Windows.Forms.ComboBox filtroMoneda;
        private System.Windows.Forms.DataGridView ventasDGV;
        private System.Windows.Forms.Label facturacionTitle;
        private System.Windows.Forms.Label cantidadFacturadoLbl;
        private System.Windows.Forms.Label gananciaLbl;
        private System.Windows.Forms.Label gananciasTitulo;
        private System.Windows.Forms.PictureBox pictureGanancia;
        private System.Windows.Forms.Label ventasLbl;
        private System.Windows.Forms.Label ventasTitulo;
        private System.Windows.Forms.PictureBox picturVentas;
        private System.Windows.Forms.Label labelFiltroFecha;
        private System.Windows.Forms.Label labelFiltroMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoDePagoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaColumn;
        private System.Windows.Forms.DataGridViewLinkColumn verFacturaLink;
    }
}