namespace ComboBox
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
            this.ComboDeContas = new System.Windows.Forms.ComboBox();
            this.TextoNumero = new System.Windows.Forms.TextBox();
            this.TextoSaldo = new System.Windows.Forms.TextBox();
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboDeContas
            // 
            this.ComboDeContas.FormattingEnabled = true;
            this.ComboDeContas.Location = new System.Drawing.Point(404, 98);
            this.ComboDeContas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboDeContas.Name = "ComboDeContas";
            this.ComboDeContas.Size = new System.Drawing.Size(160, 24);
            this.ComboDeContas.TabIndex = 0;
            this.ComboDeContas.SelectedIndexChanged += new System.EventHandler(this.ComboDeContas_SelectedIndexChanged);
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(404, 254);
            this.TextoNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.Size = new System.Drawing.Size(160, 22);
            this.TextoNumero.TabIndex = 1;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(404, 207);
            this.TextoSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.Size = new System.Drawing.Size(160, 22);
            this.TextoSaldo.TabIndex = 2;
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(404, 153);
            this.TextoTitular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(160, 22);
            this.TextoTitular.TabIndex = 3;
            this.TextoTitular.TextChanged += new System.EventHandler(this.TextoTitular_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deposito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Saca";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(404, 286);
            this.textoValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(160, 22);
            this.textoValor.TabIndex = 6;
            this.textoValor.Text = "textoValor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 484);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Transfere";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(404, 340);
            this.destinoDaTransferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(160, 24);
            this.destinoDaTransferencia.TabIndex = 8;
            this.destinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.destinoDaTransferencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Depósito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Titular";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(722, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextoTitular);
            this.Controls.Add(this.TextoSaldo);
            this.Controls.Add(this.TextoNumero);
            this.Controls.Add(this.ComboDeContas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboDeContas;
        private System.Windows.Forms.TextBox TextoNumero;
        private System.Windows.Forms.TextBox TextoSaldo;
        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}

