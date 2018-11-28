namespace projeto
{
    partial class TelaInicial
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
            this.Praiamar = new System.Windows.Forms.Button();
            this.Litoranea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Praiamar
            // 
            this.Praiamar.Location = new System.Drawing.Point(69, 144);
            this.Praiamar.Name = "Praiamar";
            this.Praiamar.Size = new System.Drawing.Size(231, 101);
            this.Praiamar.TabIndex = 0;
            this.Praiamar.Text = "Praiamar";
            this.Praiamar.UseVisualStyleBackColor = true;
            this.Praiamar.Click += new System.EventHandler(this.Praiamar_Click);
            // 
            // Litoranea
            // 
            this.Litoranea.Location = new System.Drawing.Point(429, 140);
            this.Litoranea.Name = "Litoranea";
            this.Litoranea.Size = new System.Drawing.Size(259, 108);
            this.Litoranea.TabIndex = 1;
            this.Litoranea.Text = "Litorânea";
            this.Litoranea.UseVisualStyleBackColor = true;
            this.Litoranea.Click += new System.EventHandler(this.Litoranea_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Litoranea);
            this.Controls.Add(this.Praiamar);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Praiamar;
        private System.Windows.Forms.Button Litoranea;
    }
}