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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapsulaIncluir form = new FormCapsulaIncluir();
            form.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda estamos trabalhando neste módulo!");
        }
    }
}
