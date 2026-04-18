using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogiN
{
    public partial class TelaServicos : Form
    {
        public TelaServicos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += TelaServicos_Load;
        }

        private void TelaServicos_Load(object sender, EventArgs e)
        {
            ConfigurarColunasServicos();

            panelCadastroServicos.Visible = false;
            dataGridViewServicos.Visible = true;

            comboBoxCliente.Items.Clear();
            comboBoxCliente.Items.AddRange(new string[] { "Maria Silva", "João Santos", "Ana Costa" });

            comboBoxTiposdeServicos.Items.Clear();
            comboBoxTiposdeServicos.Items.AddRange(new string[] {
        "Colocar zíper",
        "Ajuste de barra de calça",
        "Confecção de saia"
    });

            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.AddRange(new string[] {
        "Em andamento",
        "Finalizado",
        "Pronto"
    });

            // Dados de exemplo
            dataGridViewServicos.Rows.Add("Costura de Barra", "R$ 20,00", "Ajuste");
            dataGridViewServicos.Rows.Add("Troca de Zíper", "R$ 35,00", "Reparo");
            dataGridViewServicos.Rows.Add("Confecção de Saia", "R$ 120,00", "Confecção");
        }

        private void ConfigurarColunasServicos()
        {
            dataGridViewServicos.AutoGenerateColumns = false;
            dataGridViewServicos.Columns.Clear();

            dataGridViewServicos.Columns.Add("Nome", "Nome do Serviço");
            dataGridViewServicos.Columns.Add("Preco", "Preço");
            dataGridViewServicos.Columns.Add("Categoria", "Categoria");

            dataGridViewServicos.BackgroundColor = Color.White;
            dataGridViewServicos.BorderStyle = BorderStyle.None;
            dataGridViewServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewServicos.GridColor = Color.FromArgb(245, 245, 245);

            dataGridViewServicos.EnableHeadersVisualStyles = false;
            dataGridViewServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewServicos.ColumnHeadersHeight = 50;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                SelectionBackColor = Color.White
            };
            dataGridViewServicos.ColumnHeadersDefaultCellStyle = headerStyle;

            dataGridViewServicos.RowHeadersVisible = false;
            dataGridViewServicos.RowTemplate.Height = 45;
            dataGridViewServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServicos.AllowUserToResizeRows = false;
            dataGridViewServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 165, 187),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            dataGridViewServicos.DefaultCellStyle = cellStyle;

            // Remove linha fantasma
            dataGridViewServicos.AllowUserToAddRows = false;
        }

        // Botão para abrir cadastro
        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            dataGridViewServicos.Visible = false;
            panelCadastroServicos.Visible = true;
            panelCadastroServicos.BringToFront();
        }

        // Botão salvar dentro do cadastro
        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
            string cliente = comboBoxCliente.SelectedItem?.ToString() ?? "";
            string tipoServico = comboBoxTiposdeServicos.SelectedItem?.ToString() ?? "";
            string status = comboBoxStatus.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(cliente) &&
                !string.IsNullOrWhiteSpace(tipoServico) &&
                !string.IsNullOrWhiteSpace(status))
            {
                dataGridViewServicos.Rows.Add(tipoServico, cliente, status);
                dataGridViewServicos.Refresh();

                comboBoxCliente.SelectedIndex = -1;
                comboBoxTiposdeServicos.SelectedIndex = -1;
                comboBoxStatus.SelectedIndex = -1;

                panelCadastroServicos.Visible = false;
                dataGridViewServicos.Visible = true;
                dataGridViewServicos.BringToFront();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botão cancelar/voltar
        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            comboBoxCliente.SelectedIndex = -1;
            comboBoxTiposdeServicos.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            panelCadastroServicos.Visible = false;
            dataGridViewServicos.Visible = true;
            dataGridViewServicos.BringToFront();
        }

        // Busca em tempo real
        private void txtBuscaServico_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaServico.Text.ToLower();

            foreach (DataGridViewRow linha in dataGridViewServicos.Rows)
            {
                if (linha.IsNewRow) continue;

                string nome = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";
                string preco = linha.Cells["Preco"].Value?.ToString().ToLower() ?? "";
                string categoria = linha.Cells["Categoria"].Value?.ToString().ToLower() ?? "";

                if (string.IsNullOrWhiteSpace(termo))
                {
                    linha.Visible = true;
                }
                else
                {
                    linha.Visible =
                        nome.Contains(termo) ||
                        preco.Contains(termo) ||
                        categoria.Contains(termo);
                }
            }
        }

        // Navegação lateral
        private void btnEstoqueS_Click(object sender, EventArgs e)
        {
            TelaEstoque tela = new TelaEstoque();
            tela.Show();
            this.Hide();
        }

        private void btnClientesS_Click(object sender, EventArgs e)
        {
            TelaClientes tela = new TelaClientes();
            tela.Show();
            this.Hide();
        }

        private void btnPedidosS_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.Show();
            this.Hide();
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTiposdeServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
