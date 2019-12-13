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
    public partial class FormCafeteira : Form
    {
        public FormCafeteira()
        {
            InitializeComponent();
            LimparFormulario();
        }

        private void btnFazerCafe_Click(object sender, EventArgs e)
        {
            FazerCafe();
        }

        private void FazerCafe()
        {
            if (string.IsNullOrEmpty(tbxQuantidade.Text))
            {
                MessageBox.Show("Digite uma descrição para a Cápsula!");
                tbxQuantidade.Focus();
                return;
            }
            else if (cbxTipoDeCapsula.SelectedIndex < 1)
            {
                MessageBox.Show("Escolha uma força para a Cápsula!");
                cbxTipoDeCapsula.Focus();
                return;
            }
            else
            {
                int quantidadeXicaras = Convert.ToInt32(tbxQuantidade.Text);
                int capsulaId = Convert.ToInt32(cbxTipoDeCapsula.SelectedValue.ToString());
                Estoque estoque = new Estoque();

                if( estoque.VerificarCapulasNoEstoque(capsulaId, quantidadeXicaras) )
                {
                    if( estoque.ExcluirCapsulasDoEstoque(capsulaId,quantidadeXicaras) )
                    {
                        MessageBox.Show("Seu Café será servido!");
                    }
                    else
                    {
                        MessageBox.Show("Houve Algum Problema");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Não existe capsulas suficientes para fazer o seu café!");
                }
            }
        }

        private void LimparFormulario()
        {
            PreencheCbxTipoDeCapsula();
            tbxQuantidade.Text = string.Empty;
            cbxTipoDeCapsula.SelectedIndex = -1;
        }

        private void PreencheCbxTipoDeCapsula()
        {
            Capsula capsula = new Capsula();
            DataTable dtCapsula = capsula.ListarCapsulas();
            cbxTipoDeCapsula.DataSource = dtCapsula;
            cbxTipoDeCapsula.DisplayMember = "descricao";
            cbxTipoDeCapsula.ValueMember = "capsula_id";
        }
    }
}
