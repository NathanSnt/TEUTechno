using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmFrutas : Form
    {
        public frmFrutas()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int operador;

            operador = int.Parse(txtSelecionar.Text);
            string frutas = "";

            switch (operador)
            {
                case 1:
                    frutas = "Banana";
                    break;
                case 2:
                    frutas = "Maçã";
                    break;
                case 3:
                    frutas = "Pêra";
                    break;
                case 4:
                    frutas = "Melância";
                    break;
                case 5:
                    Close();
                    break;
                default:
                    frutas = "Nenhuma fruta Selecionada";
                    break;
            }
            txtFrutaSelecionada.Text = frutas;
            
            txtSelecionar.Clear();
            txtSelecionar.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        // Criar um método para limpar os componentes
        public void limparCampos()
        {
            txtFrutaSelecionada.Clear();
            txtSelecionar.Clear();
            ltbFrutas.Items.Clear();
            cbbFrutasListadas.Items.Clear();
            cbbFrutasListadas.Text = "";
            txtSelecionar.Focus(); // Focar no campo de inserção de texto
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtFrutaSelecionada.Text != "")
            {
                if (!ltbFrutas.Items.Contains(txtFrutaSelecionada.Text))
                {
                    ltbFrutas.Items.Add(txtFrutaSelecionada.Text);
                }
                if (!cbbFrutasListadas.Items.Contains(txtFrutaSelecionada.Text))
                {
                    cbbFrutasListadas.Items.Add(txtFrutaSelecionada.Text);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // formas de sair
            //Close();
            //this.Close();
            //Application.Exit();

            DialogResult resposta;

            resposta = MessageBox.Show( // Exibe uma caixa de mensagem
                "Deseja mesmo sair?", // Mensagem a ser exibida
                "Mensagem do sistema", // Titulo da janela
                MessageBoxButtons.YesNo, // Quais botões vão ser exibidos
                MessageBoxIcon.Exclamation, // Qual icone irá ser exibido
                MessageBoxDefaultButton.Button2); // Botão pré-selecionado

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }

        private void txtSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.Focus();
            }
        }
    }
}
