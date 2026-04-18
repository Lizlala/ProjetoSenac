using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogiN
{
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Garante que o evento Load seja chamado
            this.Load += TelaClientes_Load;
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            ConfigurarColunasClientes();

            // Inicialmente mostra a lista e esconde o cadastro
            panelCadastroCliente.Visible = false;
            dataGridViewClientes.Visible = true;

            // Dados de exemplo
            dataGridViewClientes.Rows.Add("Maria Silva", "123.456.789-00", "(11) 98765-4321");
            dataGridViewClientes.Rows.Add("João Santos", "987.654.321-00", "(11) 91234-5678");
            dataGridViewClientes.Rows.Add("Ana Costa", "456.789.123-00", "(11) 99876-5432");
        }

        private void ConfigurarColunasClientes()
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Clear();

            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("CPF", "CPF");
            dataGridViewClientes.Columns.Add("Telefone", "Telefone");

            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientes.GridColor = Color.FromArgb(245, 245, 245);

            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientes.ColumnHeadersHeight = 50;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                SelectionBackColor = Color.White
            };
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = headerStyle;

            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowTemplate.Height = 45;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 165, 187),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            dataGridViewClientes.DefaultCellStyle = cellStyle;
        }

        // Botão para abrir o cadastro
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Visible = false;
            panelCadastroCliente.Visible = true;
            panelCadastroCliente.BringToFront();
        }

        // Botão salvar dentro do cadastro
        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompleto.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefone.Text;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cpf) &&
                !string.IsNullOrWhiteSpace(telefone))
            {
                dataGridViewClientes.Rows.Add(nome, cpf, telefone);

                txtNomeCompleto.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();

                panelCadastroCliente.Visible = false;
                dataGridViewClientes.Visible = true;
                dataGridViewClientes.BringToFront();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botão voltar/cancelar dentro do cadastro
        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();

            panelCadastroCliente.Visible = false;
            dataGridViewClientes.Visible = true;
            dataGridViewClientes.BringToFront();
        }

        // Busca em tempo real
        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaCliente.Text.ToLower();

            foreach (DataGridViewRow linha in dataGridViewClientes.Rows)
            {
                if (linha.IsNewRow) continue;

                string nome = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";
                string cpf = linha.Cells["CPF"].Value?.ToString().ToLower() ?? "";
                string telefone = linha.Cells["Telefone"].Value?.ToString().ToLower() ?? "";

                linha.Visible =
                    nome.Contains(termo) ||
                    cpf.Contains(termo) ||
                    telefone.Contains(termo);
            }
        }

        // Navegação lateral
        private void btnEstoqueC_Click(object sender, EventArgs e)
        {
            TelaEstoque tela = new TelaEstoque();
            tela.Show();
            this.Hide();
        }

        private void btnServicosC_Click(object sender, EventArgs e)
        {
            TelaServicos tela = new TelaServicos();
            tela.Show();
            this.Hide();
        }

        private void btnPedidosC_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.Show();
            this.Hide();
        }
    }
}
