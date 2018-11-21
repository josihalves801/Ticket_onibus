namespace projeto
{
    partial class telaInicial
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
            this.praiamar = new System.Windows.Forms.Button();
            this.litoranea = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // praiamar
            // 
            this.praiamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.praiamar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.praiamar.ForeColor = System.Drawing.Color.White;
            this.praiamar.Image = global::projeto.Properties.Resources.ERF;
            this.praiamar.Location = new System.Drawing.Point(136, 260);
            this.praiamar.Name = "praiamar";
            this.praiamar.Size = new System.Drawing.Size(193, 72);
            this.praiamar.TabIndex = 0;
            this.praiamar.Text = "Praiamar";
            this.praiamar.UseVisualStyleBackColor = true;
            this.praiamar.Click += new System.EventHandler(this.praiamar_Click);
            // 
            // litoranea
            // 
            this.litoranea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.litoranea.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litoranea.ForeColor = System.Drawing.Color.White;
            this.litoranea.Image = global::projeto.Properties.Resources.ERF1;
            this.litoranea.Location = new System.Drawing.Point(435, 260);
            this.litoranea.Name = "litoranea";
            this.litoranea.Size = new System.Drawing.Size(190, 72);
            this.litoranea.TabIndex = 1;
            this.litoranea.Text = "Litorânea";
            this.litoranea.UseVisualStyleBackColor = true;
            this.litoranea.Click += new System.EventHandler(this.litoranea_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE A LINHA";
            // 
            // telaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::projeto.Properties.Resources.fundoaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.litoranea);
            this.Controls.Add(this.praiamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaInicial";
            this.Text = "Form1";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.telaInicial_Load);
=======
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
>>>>>>> 6dfa5f6fe71df68564f50e38f3ca71416ebbd650
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button praiamar;
        private System.Windows.Forms.Button litoranea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}