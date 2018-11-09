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
            ((System.ComponentModel.ISupportInitialize)(this.dimSeba)).BeginInit();
            this.SuspendLayout();
            // 
            // dimSeba
            // 
            this.dimSeba.Location = new System.Drawing.Point(308, 149);
            this.dimSeba.Name = "dimSeba";
            this.dimSeba.Size = new System.Drawing.Size(120, 20);
            this.dimSeba.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "insira 5,15";
            // 
            // ok4
            // 
            this.ok4.Location = new System.Drawing.Point(610, 316);
            this.ok4.Name = "ok4";
            this.ok4.Size = new System.Drawing.Size(75, 23);
            this.ok4.TabIndex = 9;
            this.ok4.Text = "ok";
            this.ok4.UseVisualStyleBackColor = true;
            this.ok4.Click += new System.EventHandler(this.ok4_Click);
            // 
            // voltar4
            // 
            this.voltar4.Location = new System.Drawing.Point(103, 306);
            this.voltar4.Name = "voltar4";
            this.voltar4.Size = new System.Drawing.Size(75, 23);
            this.voltar4.TabIndex = 10;
            this.voltar4.Text = "voltar";
            this.voltar4.UseVisualStyleBackColor = true;
            this.voltar4.Click += new System.EventHandler(this.voltar4_Click);
            // 
            // PagarSebastiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar4);
            this.Controls.Add(this.ok4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimSeba);
            this.Name = "PagarSebastiao";
            this.Text = "PagarSebastiao";
            ((System.ComponentModel.ISupportInitialize)(this.dimSeba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dimSeba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok4;
        private System.Windows.Forms.Button voltar4;
    }
}