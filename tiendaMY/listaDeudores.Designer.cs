namespace tiendaMY
{
    partial class listaDeudores
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
            this.tituloListaDeudores = new System.Windows.Forms.Label();
            this.deudoresDGV = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarIB = new System.Windows.Forms.DataGridViewImageColumn();
            this.actualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deudoresDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloListaDeudores
            // 
            this.tituloListaDeudores.AutoSize = true;
            this.tituloListaDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloListaDeudores.Location = new System.Drawing.Point(358, 34);
            this.tituloListaDeudores.Name = "tituloListaDeudores";
            this.tituloListaDeudores.Size = new System.Drawing.Size(353, 46);
            this.tituloListaDeudores.TabIndex = 0;
            this.tituloListaDeudores.Text = "Lista de deudores";
            // 
            // deudoresDGV
            // 
            this.deudoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deudoresDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.cantidadColumn,
            this.notasColumn,
            this.eliminarIB});
            this.deudoresDGV.Location = new System.Drawing.Point(211, 115);
            this.deudoresDGV.Name = "deudoresDGV";
            this.deudoresDGV.RowHeadersWidth = 51;
            this.deudoresDGV.RowTemplate.Height = 24;
            this.deudoresDGV.Size = new System.Drawing.Size(712, 454);
            this.deudoresDGV.TabIndex = 1;
            this.deudoresDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deudoresDGV_CellContentClick);
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.MinimumWidth = 6;
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.Width = 125;
            // 
            // notasColumn
            // 
            this.notasColumn.HeaderText = "Notas";
            this.notasColumn.MinimumWidth = 6;
            this.notasColumn.Name = "notasColumn";
            this.notasColumn.Width = 160;
            // 
            // eliminarIB
            // 
            this.eliminarIB.HeaderText = "Eliminar";
            this.eliminarIB.MinimumWidth = 6;
            this.eliminarIB.Name = "eliminarIB";
            this.eliminarIB.Width = 65;
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(490, 646);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(116, 44);
            this.actualizarButton.TabIndex = 2;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // listaDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 693);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.deudoresDGV);
            this.Controls.Add(this.tituloListaDeudores);
            this.Name = "listaDeudores";
            this.Text = "Lista deudores";
            ((System.ComponentModel.ISupportInitialize)(this.deudoresDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloListaDeudores;
        private System.Windows.Forms.DataGridView deudoresDGV;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasColumn;
        private System.Windows.Forms.DataGridViewImageColumn eliminarIB;
    }
}