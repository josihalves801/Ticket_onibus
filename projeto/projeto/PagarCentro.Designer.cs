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
            ((System.ComponentModel.ISupportInitialize)(this.dimCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // dimCentro
            // 
            this.dimCentro.Location = new System.Drawing.Point(298, 144);
            this.dimCentro.Name = "dimCentro";
            this.dimCentro.Size = new System.Drawing.Size(120, 20);
            this.dimCentro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "insira 8,90";
            // 
            // ok3
            // 
            this.ok3.Location = new System.Drawing.Point(604, 339);
            this.ok3.Name = "ok3";
            this.ok3.Size = new System.Drawing.Size(75, 23);
            this.ok3.TabIndex = 9;
            this.ok3.Text = "ok";
            this.ok3.UseVisualStyleBackColor = true;
            this.ok3.Click += new System.EventHandler(this.ok3_Click);
            // 
            // voltar3
            // 
            this.voltar3.Location = new System.Drawing.Point(103, 322);
            this.voltar3.Name = "voltar3";
            this.voltar3.Size = new System.Drawing.Size(75, 23);
            this.voltar3.TabIndex = 10;
            this.voltar3.Text = "voltar";
            this.voltar3.UseVisualStyleBackColor = true;
            this.voltar3.Click += new System.EventHandler(this.voltar3_Click);
            // 
            // PagarCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar3);
            this.Controls.Add(this.ok3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimCentro);
            this.Name = "PagarCentro";
            this.Text = "PagarCentro";
            ((System.ComponentModel.ISupportInitialize)(this.dimCentro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok3;
        private System.Windows.Forms.Button voltar3;
    }
}