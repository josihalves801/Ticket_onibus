﻿namespace projeto
{
    partial class IniciarSessao
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
            this.iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(262, 160);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(273, 116);
            this.iniciar.TabIndex = 0;
            this.iniciar.Text = "iniciar uma nova sessão";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // IniciarSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciar);
            this.Name = "IniciarSessao";
            this.Text = "IniciarSessao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar;
    }
}