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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoTitular);
            this.Controls.Add(this.TextoSaldo);
            this.Controls.Add(this.TextoNumero);
            this.Controls.Add(this.ComboDeContas);
            this.Name = "Form1";
            this.Text = "Form1";
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

