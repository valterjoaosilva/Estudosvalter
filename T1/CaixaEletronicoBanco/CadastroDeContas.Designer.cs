namespace CaixaEletronicoBanco
{
    partial class CadastroDeContas
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
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(277, 52);
            this.titularConta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(76, 20);
            this.titularConta.TabIndex = 0;
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(277, 76);
            this.numeroConta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(76, 20);
            this.numeroConta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.comboTipoConta.Location = new System.Drawing.Point(277, 26);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoConta.TabIndex = 3;
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboTipoConta_SelectedIndexChanged);
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.titularConta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}