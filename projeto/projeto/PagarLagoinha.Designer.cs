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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dimLago
            // 
            this.dimLago.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimLago.Location = new System.Drawing.Point(345, 240);
            this.dimLago.Name = "dimLago";
            this.dimLago.Size = new System.Drawing.Size(84, 37);
            this.dimLago.TabIndex = 7;
            this.dimLago.ValueChanged += new System.EventHandler(this.dimLago_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira R$4,95";
            // 
            // ok2
            // 
            this.ok2.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.ok2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok2.ForeColor = System.Drawing.Color.White;
            this.ok2.Location = new System.Drawing.Point(647, 367);
            this.ok2.Name = "ok2";
            this.ok2.Size = new System.Drawing.Size(116, 59);
            this.ok2.TabIndex = 9;
            this.ok2.Text = "Avançar";
            this.ok2.UseVisualStyleBackColor = true;
            this.ok2.Click += new System.EventHandler(this.ok2_Click);
            // 
            // voltar2
            // 
            this.voltar2.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.voltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar2.ForeColor = System.Drawing.Color.White;
            this.voltar2.Location = new System.Drawing.Point(54, 367);
            this.voltar2.Name = "voltar2";
            this.voltar2.Size = new System.Drawing.Size(102, 59);
            this.voltar2.TabIndex = 10;
            this.voltar2.Text = "Voltar";
            this.voltar2.UseVisualStyleBackColor = true;
            this.voltar2.Click += new System.EventHandler(this.voltar2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 52);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lagoinha";
            // 
            // PagarLagoinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.fundoaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voltar2);
            this.Controls.Add(this.ok2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimLago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarLagoinha";
            this.Text = "PagarLagoinha";
            this.Load += new System.EventHandler(this.PagarLagoinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimLago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimLago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok2;
        private System.Windows.Forms.Button voltar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}