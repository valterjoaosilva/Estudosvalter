namespace Banco
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(308, 68);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(185, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(308, 107);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(185, 20);
            this.textoSaldo.TabIndex = 1;
            this.textoSaldo.Text = "textoSaldo";
            this.textoSaldo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(308, 162);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(185, 20);
            this.textoNumero.TabIndex = 2;
            this.textoNumero.Text = "textoNumero";
            this.textoNumero.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(308, 230);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(185, 20);
            this.textoValor.TabIndex = 3;
            this.textoValor.Text = "textoValor";
            this.textoValor.TextChanged += new System.EventHandler(this.textoValor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "textoValor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoValor;
    }
}

