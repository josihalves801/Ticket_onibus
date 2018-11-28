namespace projeto
{
    partial class Pagar_Lagoinha
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
            this.continuar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.dimLago = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).BeginInit();
            this.SuspendLayout();
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(595, 299);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(130, 50);
            this.continuar.TabIndex = 0;
            this.continuar.Text = "ok";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(58, 289);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(108, 50);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // dimLago
            // 
            this.dimLago.Location = new System.Drawing.Point(325, 179);
            this.dimLago.Name = "dimLago";
            this.dimLago.Size = new System.Drawing.Size(120, 20);
            this.dimLago.TabIndex = 2;
            // 
            // Pagar_Lagoinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dimLago);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.continuar);
            this.Name = "Pagar_Lagoinha";
            this.Text = "Pagar_Lagoinha";
            this.Load += new System.EventHandler(this.Pagar_Lagoinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.NumericUpDown dimLago;
    }
}