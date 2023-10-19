namespace Calculadora_de_Juros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorPrincipal = new System.Windows.Forms.Label();
            this.lblTaxaJuros = new System.Windows.Forms.Label();
            this.lblNumParcelas = new System.Windows.Forms.Label();
            this.txtValorPrincipal = new System.Windows.Forms.TextBox();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.txtNumParcelas = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValorPrincipal
            // 
            this.lblValorPrincipal.AutoSize = true;
            this.lblValorPrincipal.Location = new System.Drawing.Point(105, 45);
            this.lblValorPrincipal.Name = "lblValorPrincipal";
            this.lblValorPrincipal.Size = new System.Drawing.Size(74, 13);
            this.lblValorPrincipal.TabIndex = 0;
            this.lblValorPrincipal.Text = "Valor Principal";
            // 
            // lblTaxaJuros
            // 
            this.lblTaxaJuros.AutoSize = true;
            this.lblTaxaJuros.Location = new System.Drawing.Point(325, 45);
            this.lblTaxaJuros.Name = "lblTaxaJuros";
            this.lblTaxaJuros.Size = new System.Drawing.Size(104, 13);
            this.lblTaxaJuros.TabIndex = 1;
            this.lblTaxaJuros.Text = "Taxa de Juros Anual";
            // 
            // lblNumParcelas
            // 
            this.lblNumParcelas.AutoSize = true;
            this.lblNumParcelas.Location = new System.Drawing.Point(569, 45);
            this.lblNumParcelas.Name = "lblNumParcelas";
            this.lblNumParcelas.Size = new System.Drawing.Size(103, 13);
            this.lblNumParcelas.TabIndex = 2;
            this.lblNumParcelas.Text = "Número de Parcelas";
            // 
            // txtValorPrincipal
            // 
            this.txtValorPrincipal.Location = new System.Drawing.Point(92, 93);
            this.txtValorPrincipal.Name = "txtValorPrincipal";
            this.txtValorPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtValorPrincipal.TabIndex = 3;
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(328, 93);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaJuros.TabIndex = 4;
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.Location = new System.Drawing.Point(572, 93);
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtNumParcelas.TabIndex = 5;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(340, 179);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(325, 285);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtNumParcelas);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.txtValorPrincipal);
            this.Controls.Add(this.lblNumParcelas);
            this.Controls.Add(this.lblTaxaJuros);
            this.Controls.Add(this.lblValorPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorPrincipal;
        private System.Windows.Forms.Label lblTaxaJuros;
        private System.Windows.Forms.Label lblNumParcelas;
        private System.Windows.Forms.TextBox txtValorPrincipal;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.TextBox txtNumParcelas;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

