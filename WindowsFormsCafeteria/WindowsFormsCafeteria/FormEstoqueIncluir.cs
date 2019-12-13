using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCafeteria
{
    public partial class FormEstoqueIncluir : Form
    {
        public DataTable dtCapsulas;

        public FormEstoqueIncluir()
        {
            InitializeComponent();
            PreencheCbxTipoDeCapsula();
        }

        private void PreencheCbxTipoDeCapsula()
        {
            Capsula capsula = new Capsula();
            DataTable dtCapsula = capsula.ListarCapsulas();
            cbxTipoDeCapsula.DataSource = dtCapsula;
            cbxTipoDeCapsula.DisplayMember = "descricao";
            cbxTipoDeCapsula.ValueMember = "capsula_id";
        }

        private void LimparFormulario()
        {
            PreencheCbxTipoDeCapsula();
            tbxQuantidade.Text = string.Empty;
            cbxTipoDeCapsula.SelectedIndex = -1;
            dtpDataDeValidade.MinDate = DateTime.Now;
        }

        public void IncluirCapsulasNoEstoque()
        {
            if(string.IsNullOrEmpty(tbxQuantidade.Text))
            {
                MessageBox.Show("Digite uma quantidade para ser incluida no estoque!");
                tbxQuantidade.Focus();
                return;
            }
            else if(cbxTipoDeCapsula.SelectedIndex < 0 )
            {
                MessageBox.Show("Escolha um tipo de capsula para ser incluida no estoque!");
                cbxTipoDeCapsula.Focus();
                return;
            }
            else if(Convert.ToDateTime(dtpDataDeValidade.Text) < DateTime.Now)
            {
                MessageBox.Show("Não é permitida a inclusão de cápsulas com data de validade vencidas!");
                dtpDataDeValidade.Focus();
                return;
            }
            else
            {
                try
                {
                    Estoque estoque = new Estoque();
                    estoque.DataEntrada = DateTime.Now;
                    estoque.Quantidade = Convert.ToInt32(tbxQuantidade.Text);
                    estoque.Validade = Convert.ToDateTime(dtpDataDeValidade.Text);
                    estoque.CapsulaId = Convert.ToInt32(cbxTipoDeCapsula.SelectedValue.ToString());
                    string result = estoque.IncluirCapsulasNoEstoque(estoque);
                    if (result == "ok")
                    {
                        MessageBox.Show("( " + estoque.Quantidade.ToString() + " ) Cápsula(s) cadastras com sucesso no estoque!");
                        LimparFormulario();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO : " + ex.ToString());
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirCapsulasNoEstoque();
        }
    }
}
