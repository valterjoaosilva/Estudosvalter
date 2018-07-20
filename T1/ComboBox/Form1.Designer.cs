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
            this.SuspendLayout();
            // 
            // ComboDeContas
            // 
            this.ComboDeContas.FormattingEnabled = true;
            this.ComboDeContas.Location = new System.Drawing.Point(303, 80);
            this.ComboDeContas.Name = "ComboDeContas";
            this.ComboDeContas.Size = new System.Drawing.Size(121, 21);
            this.ComboDeContas.TabIndex = 0;
            this.ComboDeContas.SelectedIndexChanged += new System.EventHandler(this.ComboDeContas_SelectedIndexChanged);
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(303, 206);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.Size = new System.Drawing.Size(121, 20);
            this.TextoNumero.TabIndex = 1;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(303, 168);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.Size = new System.Drawing.Size(121, 20);
            this.TextoSaldo.TabIndex = 2;
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(303, 124);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(121, 20);
            this.TextoTitular.TabIndex = 3;
            this.TextoTitular.TextChanged += new System.EventHandler(this.TextoTitular_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deposito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Saca";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(303, 232);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(121, 20);
            this.textoValor.TabIndex = 6;
            this.textoValor.Text = "textoValor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Transfere";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(303, 276);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(121, 21);
            this.destinoDaTransferencia.TabIndex = 8;
            this.destinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.destinoDaTransferencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Depósito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Titular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

