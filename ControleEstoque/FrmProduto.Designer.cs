namespace ControleEstoque1
{
    partial class FrmProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Validade = new System.Windows.Forms.TextBox();
            this.txt_Fabricante = new System.Windows.Forms.TextBox();
            this.txt_Codigobarras = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.datagridview2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Validade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo Barras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(65, 130);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(163, 20);
            this.txt_Id.TabIndex = 9;
            // 
            // txt_Validade
            // 
            this.txt_Validade.Location = new System.Drawing.Point(104, 283);
            this.txt_Validade.Name = "txt_Validade";
            this.txt_Validade.Size = new System.Drawing.Size(153, 20);
            this.txt_Validade.TabIndex = 10;
            // 
            // txt_Fabricante
            // 
            this.txt_Fabricante.Location = new System.Drawing.Point(104, 254);
            this.txt_Fabricante.Name = "txt_Fabricante";
            this.txt_Fabricante.Size = new System.Drawing.Size(153, 20);
            this.txt_Fabricante.TabIndex = 11;
            // 
            // txt_Codigobarras
            // 
            this.txt_Codigobarras.Location = new System.Drawing.Point(104, 215);
            this.txt_Codigobarras.Name = "txt_Codigobarras";
            this.txt_Codigobarras.Size = new System.Drawing.Size(153, 20);
            this.txt_Codigobarras.TabIndex = 12;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(65, 174);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(163, 20);
            this.txt_Nome.TabIndex = 13;
            // 
            // datagridview2
            // 
            this.datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview2.Location = new System.Drawing.Point(28, 317);
            this.datagridview2.Name = "datagridview2";
            this.datagridview2.Size = new System.Drawing.Size(640, 121);
            this.datagridview2.TabIndex = 14;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridview2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Codigobarras);
            this.Controls.Add(this.txt_Fabricante);
            this.Controls.Add(this.txt_Validade);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_Id, 0);
            this.Controls.SetChildIndex(this.txt_Validade, 0);
            this.Controls.SetChildIndex(this.txt_Fabricante, 0);
            this.Controls.SetChildIndex(this.txt_Codigobarras, 0);
            this.Controls.SetChildIndex(this.txt_Nome, 0);
            this.Controls.SetChildIndex(this.datagridview2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Validade;
        private System.Windows.Forms.TextBox txt_Fabricante;
        private System.Windows.Forms.TextBox txt_Codigobarras;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.DataGridView datagridview2;
    }
}
