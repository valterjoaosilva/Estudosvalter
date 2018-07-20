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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}

