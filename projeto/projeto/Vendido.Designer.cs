namespace projeto
{
    partial class Vendido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destino = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::projeto.Properties.Resources.foto__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.data);
            this.panel1.Controls.Add(this.dep);
            this.panel1.Controls.Add(this.destino);
            this.panel1.Location = new System.Drawing.Point(152, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 288);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sua Venda Foi Efetuada com Sucesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retire Seu Ticket";
            // 
            // destino
            // 
            this.destino.AutoSize = true;
            this.destino.Location = new System.Drawing.Point(95, 110);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(35, 13);
            this.destino.TabIndex = 3;
            this.destino.Text = "label3";
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Location = new System.Drawing.Point(95, 165);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(35, 13);
            this.dep.TabIndex = 4;
            this.dep.Text = "label3";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(310, 110);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(35, 13);
            this.data.TabIndex = 5;
            this.data.Text = "label3";
            // 
            // Vendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Vendido";
            this.Text = "Vendido";
            this.Load += new System.EventHandler(this.Vendido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.Label destino;
    }
}