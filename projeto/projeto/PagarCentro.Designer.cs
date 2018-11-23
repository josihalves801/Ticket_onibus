namespace projeto
{
    partial class PagarCentro
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
            this.dimCentro = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ok3 = new System.Windows.Forms.Button();
            this.voltar3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dimCentro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dimCentro
            // 
            this.dimCentro.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimCentro.Location = new System.Drawing.Point(338, 238);
            this.dimCentro.Name = "dimCentro";
            this.dimCentro.Size = new System.Drawing.Size(84, 37);
            this.dimCentro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira R$8,90";
            // 
            // ok3
            // 
            this.ok3.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.ok3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok3.ForeColor = System.Drawing.Color.White;
            this.ok3.Location = new System.Drawing.Point(645, 367);
            this.ok3.Name = "ok3";
            this.ok3.Size = new System.Drawing.Size(116, 59);
            this.ok3.TabIndex = 9;
            this.ok3.Text = "Avançar";
            this.ok3.UseVisualStyleBackColor = true;
            this.ok3.Click += new System.EventHandler(this.ok3_Click);
            // 
            // voltar3
            // 
            this.voltar3.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.voltar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar3.ForeColor = System.Drawing.SystemColors.Control;
            this.voltar3.Location = new System.Drawing.Point(56, 367);
            this.voltar3.Name = "voltar3";
            this.voltar3.Size = new System.Drawing.Size(102, 59);
            this.voltar3.TabIndex = 10;
            this.voltar3.Text = "Voltar";
            this.voltar3.UseVisualStyleBackColor = true;
            this.voltar3.Click += new System.EventHandler(this.voltar3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 52);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Centro\r\nUbatuba\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PagarCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.fundoaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voltar3);
            this.Controls.Add(this.ok3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarCentro";
            this.Text = "PagarCentro";
            this.Load += new System.EventHandler(this.PagarCentro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimCentro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok3;
        private System.Windows.Forms.Button voltar3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}