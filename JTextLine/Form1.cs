using System;
using System.Windows.Forms;

namespace JTextLine
{
    public partial class JTextLine : MetroFramework.Forms.MetroForm
    {
        public JTextLine()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var texto = txtTexto.Text.Trim().Replace('\r', ' ').Replace('\n', ' ');
            string novoTexto = "";
            char caracterAnterior = '%';

            // Adiciona um ESPACO após as virgulas para deixar tudo com um padrão só
            foreach (char caracter in texto)
            {
                novoTexto += caracter == ',' ? caracter.ToString()+ " " : caracter.ToString();    
            }

            texto = novoTexto.Trim();
            novoTexto = "";

            // Remove ESPACOS extras
            foreach (char caracter in texto)
            {
                if(caracter != caracterAnterior || caracter != ' ')
                {
                    caracterAnterior = caracter;
                    novoTexto += caracter;
                }
            }

            // Passando o Texto Formatado para o TextBox
            txtTexto.Text = novoTexto.Trim();
            txtTexto.Refresh();

            MetroFramework.MetroMessageBox.Show(this, "Processo Finalizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None, 100);
        }

        private void btnCopiarTexto_Click(object sender, EventArgs e)
        {
            var texto = txtTexto.Text.Trim();
            if(texto.Length > 0)
            {
                Clipboard.SetText(texto);
                MetroFramework.MetroMessageBox.Show(this, "Texto copiado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None,100);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Não existe Texto para ser copiado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error,100);
            }
        }
    }
}
