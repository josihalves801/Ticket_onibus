namespace projeto
{
    partial class escolherLinha
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
            this.label1 = new System.Windows.Forms.Label();
            this.lagoinha = new System.Windows.Forms.Button();
            this.centro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE O DESTINO\r\n";
            // 
            // lagoinha
            // 
            this.lagoinha.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.lagoinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lagoinha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagoinha.ForeColor = System.Drawing.Color.White;
            this.lagoinha.Location = new System.Drawing.Point(109, 232);
            this.lagoinha.Name = "lagoinha";
            this.lagoinha.Size = new System.Drawing.Size(157, 79);
            this.lagoinha.TabIndex = 1;
            this.lagoinha.Text = "Lagoinha";
            this.lagoinha.UseVisualStyleBackColor = true;
            this.lagoinha.Click += new System.EventHandler(this.button1_Click);
            // 
            // centro
            // 
            this.centro.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.centro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centro.ForeColor = System.Drawing.Color.White;
            this.centro.Location = new System.Drawing.Point(318, 232);
            this.centro.Name = "centro";
            this.centro.Size = new System.Drawing.Size(140, 79);
            this.centro.TabIndex = 2;
            this.centro.Text = "Centro de Ubatuba";
            this.centro.UseVisualStyleBackColor = true;
            this.centro.Click += new System.EventHandler(this.centro_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::projeto.Properties.Resources.ERF;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(527, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "São Sebastião ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 88);
            this.panel1.TabIndex = 4;
            // 
            // escolherLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.fundoaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.centro);
            this.Controls.Add(this.lagoinha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "escolherLinha";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lagoinha;
        private System.Windows.Forms.Button centro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}