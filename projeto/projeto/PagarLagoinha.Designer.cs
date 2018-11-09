namespace projeto
{
    partial class PagarLagoinha
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
            this.dimLago = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ok2 = new System.Windows.Forms.Button();
            this.voltar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).BeginInit();
            this.SuspendLayout();
            // 
            // dimLago
            // 
            this.dimLago.Location = new System.Drawing.Point(320, 138);
            this.dimLago.Name = "dimLago";
            this.dimLago.Size = new System.Drawing.Size(120, 20);
            this.dimLago.TabIndex = 7;
            this.dimLago.ValueChanged += new System.EventHandler(this.dimLago_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira 4,95";
            // 
            // ok2
            // 
            this.ok2.Location = new System.Drawing.Point(583, 314);
            this.ok2.Name = "ok2";
            this.ok2.Size = new System.Drawing.Size(102, 28);
            this.ok2.TabIndex = 9;
            this.ok2.Text = "ok";
            this.ok2.UseVisualStyleBackColor = true;
            this.ok2.Click += new System.EventHandler(this.ok2_Click);
            // 
            // voltar2
            // 
            this.voltar2.Location = new System.Drawing.Point(58, 319);
            this.voltar2.Name = "voltar2";
            this.voltar2.Size = new System.Drawing.Size(75, 23);
            this.voltar2.TabIndex = 10;
            this.voltar2.Text = "voltar";
            this.voltar2.UseVisualStyleBackColor = true;
            this.voltar2.Click += new System.EventHandler(this.voltar2_Click);
            // 
            // PagarLagoinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar2);
            this.Controls.Add(this.ok2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimLago);
            this.Name = "PagarLagoinha";
            this.Text = "PagarLagoinha";
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimLago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok2;
        private System.Windows.Forms.Button voltar2;
    }
}