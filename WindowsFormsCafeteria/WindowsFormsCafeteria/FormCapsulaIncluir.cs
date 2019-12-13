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
    public partial class FormCapsulaIncluir : Form
    {
        public FormCapsulaIncluir()
        {
            InitializeComponent();
            cbxForca.SelectedIndex = 0;
        }

        private void IncluirCapsulas()
        {
            if (string.IsNullOrEmpty(tbxDescricao.Text))
            {
                MessageBox.Show("Digite uma descrição para a Cápsula!");
                tbxDescricao.Focus();
                return;
            }
            else if(cbxForca.SelectedIndex < 1)
            {
                MessageBox.Show("Escolha uma força para a Cápsula!");
                cbxForca.Focus();
                return;
            }
            else
            {
                try
                {
                    Capsula capsula = new Capsula();
                    capsula.Descricao = tbxDescricao.Text;
                    capsula.Forca = cbxForca.SelectedIndex;
                    string result = capsula.IncluirCapsula(capsula);
                    if(result == "ok")
                    {
                        MessageBox.Show("Cápsula Inserida com sucesso!");
                        LimparFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.ToString());
                    throw;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirCapsulas();
        }

        private void LimparFormulario()
        {
            tbxDescricao.Text = string.Empty;
            cbxForca.SelectedIndex = 0;
        }
    }
}
