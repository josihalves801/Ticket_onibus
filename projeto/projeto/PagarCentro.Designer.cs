﻿namespace projeto
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
            this.cuntinue = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.dimcentro = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dimcentro)).BeginInit();
            this.SuspendLayout();
            // 
            // cuntinue
            // 
            this.cuntinue.Location = new System.Drawing.Point(564, 302);
            this.cuntinue.Name = "cuntinue";
            this.cuntinue.Size = new System.Drawing.Size(75, 23);
            this.cuntinue.TabIndex = 0;
            this.cuntinue.Text = "ok";
            this.cuntinue.UseVisualStyleBackColor = true;
            this.cuntinue.Click += new System.EventHandler(this.cuntinue_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(86, 302);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // dimcentro
            // 
            this.dimcentro.Location = new System.Drawing.Point(297, 124);
            this.dimcentro.Name = "dimcentro";
            this.dimcentro.Size = new System.Drawing.Size(120, 20);
            this.dimcentro.TabIndex = 2;
            // 
            // PagarCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dimcentro);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cuntinue);
            this.Name = "PagarCentro";
            this.Text = "PagarCentro";
            this.Load += new System.EventHandler(this.PagarCentro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimcentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cuntinue;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.NumericUpDown dimcentro;
    }
}