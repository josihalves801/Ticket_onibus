﻿namespace projeto
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "escolha o destino";
            // 
            // lagoinha
            // 
            this.lagoinha.Location = new System.Drawing.Point(130, 134);
            this.lagoinha.Name = "lagoinha";
            this.lagoinha.Size = new System.Drawing.Size(107, 61);
            this.lagoinha.TabIndex = 1;
            this.lagoinha.Text = "Ubatuba Lagoinha";
            this.lagoinha.UseVisualStyleBackColor = true;
            this.lagoinha.Click += new System.EventHandler(this.button1_Click);
            // 
            // centro
            // 
            this.centro.Location = new System.Drawing.Point(293, 134);
            this.centro.Name = "centro";
            this.centro.Size = new System.Drawing.Size(107, 61);
            this.centro.TabIndex = 2;
            this.centro.Text = "Centro de Ubatuba";
            this.centro.UseVisualStyleBackColor = true;
            this.centro.Click += new System.EventHandler(this.centro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "São Sebastião ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // escolherLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.centro);
            this.Controls.Add(this.lagoinha);
            this.Controls.Add(this.label1);
            this.Name = "escolherLinha";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lagoinha;
        private System.Windows.Forms.Button centro;
        private System.Windows.Forms.Button button1;
    }
}