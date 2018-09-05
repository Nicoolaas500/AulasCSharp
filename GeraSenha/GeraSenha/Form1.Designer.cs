namespace GeraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaSenhas = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.count_chars = new System.Windows.Forms.NumericUpDown();
            this.cbMaiusculas = new System.Windows.Forms.CheckBox();
            this.cbSimbolos = new System.Windows.Forms.CheckBox();
            this.cbNumeros = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // listaSenhas
            // 
            this.listaSenhas.FormattingEnabled = true;
            this.listaSenhas.ItemHeight = 19;
            this.listaSenhas.Location = new System.Drawing.Point(52, 31);
            this.listaSenhas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listaSenhas.Name = "listaSenhas";
            this.listaSenhas.Size = new System.Drawing.Size(461, 479);
            this.listaSenhas.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(525, 417);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(228, 95);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar senhas";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº de Caracteres";
            // 
            // count_chars
            // 
            this.count_chars.Location = new System.Drawing.Point(530, 54);
            this.count_chars.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.count_chars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_chars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_chars.Name = "count_chars";
            this.count_chars.Size = new System.Drawing.Size(200, 26);
            this.count_chars.TabIndex = 3;
            this.count_chars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cbMaiusculas
            // 
            this.cbMaiusculas.AutoSize = true;
            this.cbMaiusculas.Location = new System.Drawing.Point(529, 87);
            this.cbMaiusculas.Name = "cbMaiusculas";
            this.cbMaiusculas.Size = new System.Drawing.Size(175, 23);
            this.cbMaiusculas.TabIndex = 4;
            this.cbMaiusculas.Text = "Usar MAIÚSCULAS";
            this.cbMaiusculas.UseVisualStyleBackColor = true;
            // 
            // cbSimbolos
            // 
            this.cbSimbolos.AutoSize = true;
            this.cbSimbolos.Location = new System.Drawing.Point(530, 145);
            this.cbSimbolos.Name = "cbSimbolos";
            this.cbSimbolos.Size = new System.Drawing.Size(153, 23);
            this.cbSimbolos.TabIndex = 8;
            this.cbSimbolos.Text = "Usar SÍMBOLOS";
            this.cbSimbolos.UseVisualStyleBackColor = true;
            // 
            // cbNumeros
            // 
            this.cbNumeros.AutoSize = true;
            this.cbNumeros.Location = new System.Drawing.Point(530, 116);
            this.cbNumeros.Name = "cbNumeros";
            this.cbNumeros.Size = new System.Drawing.Size(151, 23);
            this.cbNumeros.TabIndex = 9;
            this.cbNumeros.Text = "Usar NÚMEROS";
            this.cbNumeros.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(773, 579);
            this.Controls.Add(this.cbNumeros);
            this.Controls.Add(this.cbSimbolos);
            this.Controls.Add(this.cbMaiusculas);
            this.Controls.Add(this.count_chars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.listaSenhas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSenhas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count_chars;
        private System.Windows.Forms.CheckBox cbMaiusculas;
        private System.Windows.Forms.CheckBox cbSimbolos;
        private System.Windows.Forms.CheckBox cbNumeros;
    }
}

