namespace ProjetoExemplo
{
    partial class frmExemplo
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
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncaucular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(271, 118);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(91, 13);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "Digite um Número";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(271, 149);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Digite outro Número";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(271, 186);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "Resultado";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(368, 115);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(137, 20);
            this.txtnumero1.TabIndex = 3;
            this.txtnumero1.TextChanged += new System.EventHandler(this.txtnumero1_TextChanged);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(378, 146);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(127, 20);
            this.txtnumero2.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(332, 183);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(173, 20);
            this.txtresultado.TabIndex = 5;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btncaucular
            // 
            this.btncaucular.Location = new System.Drawing.Point(274, 232);
            this.btncaucular.Name = "btncaucular";
            this.btncaucular.Size = new System.Drawing.Size(75, 23);
            this.btncaucular.TabIndex = 6;
            this.btncaucular.Text = "Calcular";
            this.btncaucular.UseVisualStyleBackColor = true;
            this.btncaucular.Click += new System.EventHandler(this.btncaucular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(430, 232);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(350, 282);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncaucular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblnumero1);
            this.Name = "frmExemplo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma de 2 Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncaucular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

