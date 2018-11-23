namespace projeto
{
    partial class PagarSebastiao
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
            this.dimSeba = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ok4 = new System.Windows.Forms.Button();
            this.voltar4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dimSeba)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dimSeba
            // 
            this.dimSeba.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimSeba.Location = new System.Drawing.Point(441, 231);
            this.dimSeba.Name = "dimSeba";
            this.dimSeba.Size = new System.Drawing.Size(84, 37);
            this.dimSeba.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tarifa - R$5,15";
            // 
            // ok4
            // 
            this.ok4.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.ok4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok4.ForeColor = System.Drawing.Color.White;
            this.ok4.Location = new System.Drawing.Point(638, 371);
            this.ok4.Name = "ok4";
            this.ok4.Size = new System.Drawing.Size(116, 59);
            this.ok4.TabIndex = 9;
            this.ok4.Text = "Avançar";
            this.ok4.UseVisualStyleBackColor = true;
            this.ok4.Click += new System.EventHandler(this.ok4_Click);
            // 
            // voltar4
            // 
            this.voltar4.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.voltar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar4.ForeColor = System.Drawing.Color.White;
            this.voltar4.Location = new System.Drawing.Point(45, 362);
            this.voltar4.Name = "voltar4";
            this.voltar4.Size = new System.Drawing.Size(102, 59);
            this.voltar4.TabIndex = 10;
            this.voltar4.Text = "Voltar";
            this.voltar4.UseVisualStyleBackColor = true;
            this.voltar4.Click += new System.EventHandler(this.voltar4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-10, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 60);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "São\r\nSebastião";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Insira o dinheiro:";
            // 
            // PagarSebastiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.fundoaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voltar4);
            this.Controls.Add(this.ok4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimSeba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarSebastiao";
            this.Text = "PagarSebastiao";
            ((System.ComponentModel.ISupportInitialize)(this.dimSeba)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimSeba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok4;
        private System.Windows.Forms.Button voltar4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}