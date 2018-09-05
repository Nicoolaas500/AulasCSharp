namespace CalculadoraCSharp
{
    partial class Form1
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
            this.txtUm = new System.Windows.Forms.TextBox();
            this.txtDois = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDoispontos = new System.Windows.Forms.Button();
            this.lbCalculadora = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUm
            // 
            this.txtUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUm.Location = new System.Drawing.Point(22, 101);
            this.txtUm.Name = "txtUm";
            this.txtUm.Size = new System.Drawing.Size(143, 45);
            this.txtUm.TabIndex = 0;
            this.txtUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDois
            // 
            this.txtDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDois.Location = new System.Drawing.Point(22, 152);
            this.txtDois.Name = "txtDois";
            this.txtDois.Size = new System.Drawing.Size(143, 45);
            this.txtDois.TabIndex = 1;
            this.txtDois.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(22, 203);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(72, 51);
            this.btnMais.TabIndex = 2;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.operacaoClick);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(100, 203);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(65, 51);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.operacaoClick);
            // 
            // btnVezes
            // 
            this.btnVezes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.Location = new System.Drawing.Point(100, 260);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(65, 51);
            this.btnVezes.TabIndex = 9;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.operacaoClick);
            // 
            // btnDoispontos
            // 
            this.btnDoispontos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoispontos.Location = new System.Drawing.Point(22, 260);
            this.btnDoispontos.Name = "btnDoispontos";
            this.btnDoispontos.Size = new System.Drawing.Size(72, 51);
            this.btnDoispontos.TabIndex = 10;
            this.btnDoispontos.Text = ":";
            this.btnDoispontos.UseVisualStyleBackColor = true;
            this.btnDoispontos.Click += new System.EventHandler(this.operacaoClick);
            // 
            // lbCalculadora
            // 
            this.lbCalculadora.AutoSize = true;
            this.lbCalculadora.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculadora.Location = new System.Drawing.Point(12, 9);
            this.lbCalculadora.Name = "lbCalculadora";
            this.lbCalculadora.Size = new System.Drawing.Size(374, 56);
            this.lbCalculadora.TabIndex = 11;
            this.lbCalculadora.Text = "Calculadora C#";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(210, 175);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(156, 34);
            this.lbResultado.TabIndex = 12;
            this.lbResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 342);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbCalculadora);
            this.Controls.Add(this.btnDoispontos);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.txtDois);
            this.Controls.Add(this.txtUm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUm;
        private System.Windows.Forms.TextBox txtDois;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDoispontos;
        private System.Windows.Forms.Label lbCalculadora;
        private System.Windows.Forms.Label lbResultado;
    }
}

