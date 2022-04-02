using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmProduto : ControleEstoque1.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();

        }

        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoProduto2> lista = get.ListProduto();
            this.datagridview2.DataSource = lista;
            this.datagridview2.Refresh();
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto u = new DtoProduto();

                u.codigobarras = txt_Codigobarras.Text;
                u.fabricante = txt_Fabricante.Text;
                u.validade = txt_Validade.Text;
                u.nome = txt_Nome.Text;
                if (txt_Id.Text != string.Empty)
                {
                    u.id = int.Parse(txt_Id.Text);
                    set.EditProduto(u);
                }
                else
                {
                    set.SetProduto(u);
                }

                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region Tratamento Visual
        private void LilberaCampos()
        {
            txt_Id.Enabled = true;
            txt_Codigobarras.Enabled = true;
            txt_Fabricante.Enabled = true;
            txt_Validade.Enabled = true;
            txt_Fabricante.Enabled = true;
        }
        private void BloqueiaCampos()
        {
            txt_Id.Enabled = false;
            txt_Codigobarras.Enabled = false;
            txt_Fabricante.Enabled = false;
            txt_Validade.Enabled = false;
            txt_Fabricante.Enabled = false;
        }
        #endregion

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            LilberaCampos();
            txt_Nome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != string.Empty)
            {
                Model del = new Model();
                del.DeletarProduto(int.Parse(txt_Id.Text));
                BloqueiaCampos();
                CarregarGrid();
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (Int32)datagridview2.CurrentRow.Cells[0].Value;

            Model get = new Model();
            DtoProduto2 d = get.GetProdutoId(ID);
            txt_Id.Text = d.id.ToString();
            txt_Codigobarras.Text = d.codigobarras;
            LilberaCampos();
            txt_Nome.Focus();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            txt_Codigobarras.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Fabricante.Text = string.Empty;
            txt_Validade.Text = string.Empty;

            LilberaCampos();
            txt_Nome.Focus();
        }

           private void datagridview2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
            {
                int ID = (Int32)datagridview2.CurrentRow.Cells[0].Value;

                Model get = new Model();
                DtoProduto2 d = get.GetProdutoId(ID);
                txt_Id.Text = d.id.ToString();
                txt_Codigobarras.Text = d.codigobarras.ToString();


                LilberaCampos();
                txt_Nome.Focus();
                txt_Codigobarras.Focus();
            }
        }
    }

