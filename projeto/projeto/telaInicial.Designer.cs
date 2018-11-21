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
            this.SuspendLayout();
            // 
            // praiamar
            // 
            this.praiamar.Location = new System.Drawing.Point(90, 118);
            this.praiamar.Name = "praiamar";
            this.praiamar.Size = new System.Drawing.Size(174, 65);
            this.praiamar.TabIndex = 0;
            this.praiamar.Text = "praiamar";
            this.praiamar.UseVisualStyleBackColor = true;
            this.praiamar.Click += new System.EventHandler(this.praiamar_Click);
            // 
            // litoranea
            // 
            this.litoranea.Location = new System.Drawing.Point(434, 118);
            this.litoranea.Name = "litoranea";
            this.litoranea.Size = new System.Drawing.Size(199, 62);
            this.litoranea.TabIndex = 1;
            this.litoranea.Text = "litoranea";
            this.litoranea.UseVisualStyleBackColor = true;
            this.litoranea.Click += new System.EventHandler(this.litoranea_Click);
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litoranea);
            this.Controls.Add(this.praiamar);
            this.Name = "telaInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button praiamar;
        private System.Windows.Forms.Button litoranea;
    }
}