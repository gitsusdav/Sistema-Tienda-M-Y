namespace tiendaMY
{
    partial class Ajustes
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
            this.ajustesLbl = new System.Windows.Forms.Label();
            this.tasaLbl = new System.Windows.Forms.Label();
            this.tasaTB = new System.Windows.Forms.TextBox();
            this.alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajustesLbl
            // 
            this.ajustesLbl.AutoSize = true;
            this.ajustesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustesLbl.Location = new System.Drawing.Point(12, 21);
            this.ajustesLbl.Name = "ajustesLbl";
            this.ajustesLbl.Size = new System.Drawing.Size(115, 32);
            this.ajustesLbl.TabIndex = 0;
            this.ajustesLbl.Text = "Ajustes";
            // 
            // tasaLbl
            // 
            this.tasaLbl.AutoSize = true;
            this.tasaLbl.Location = new System.Drawing.Point(22, 101);
            this.tasaLbl.Name = "tasaLbl";
            this.tasaLbl.Size = new System.Drawing.Size(95, 16);
            this.tasaLbl.TabIndex = 1;
            this.tasaLbl.Text = "Tasa del dolar";
            // 
            // tasaTB
            // 
            this.tasaTB.Location = new System.Drawing.Point(123, 98);
            this.tasaTB.Name = "tasaTB";
            this.tasaTB.Size = new System.Drawing.Size(100, 22);
            this.tasaTB.TabIndex = 2;
            this.tasaTB.TextChanged += new System.EventHandler(this.tasaTB_TextChanged);
            // 
            // alerta
            // 
            this.alerta.AutoSize = true;
            this.alerta.ForeColor = System.Drawing.Color.Red;
            this.alerta.Location = new System.Drawing.Point(22, 132);
            this.alerta.Name = "alerta";
            this.alerta.Size = new System.Drawing.Size(343, 16);
            this.alerta.TabIndex = 3;
            this.alerta.Text = "Solo incluir numeros y caracteres validos (punto o coma)";
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 697);
            this.Controls.Add(this.alerta);
            this.Controls.Add(this.tasaTB);
            this.Controls.Add(this.tasaLbl);
            this.Controls.Add(this.ajustesLbl);
            this.Name = "Ajustes";
            this.Text = "Ajustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ajustesLbl;
        private System.Windows.Forms.Label tasaLbl;
        private System.Windows.Forms.TextBox tasaTB;
        private System.Windows.Forms.Label alerta;
    }
}