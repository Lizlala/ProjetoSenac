using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogiN
{
    public partial class TelaPedidos : Form
    {
        public TelaPedidos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += TelaPedidos_Load;
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            ConfigurarColunasPedidos();

            comboBoxClientePedidos.Items.Clear();
            comboBoxClientePedidos.Items.AddRange(new string[] { "Maria Silva", "João Santos", "Ana Costa" });

            comboBoxTipodeServicoP.Items.Clear();
            comboBoxTipodeServicoP.Items.AddRange(new string[] {
                "Colocar zíper",
                "Ajuste de barra de calça",
                "Confecção de saia"
            });

            comboBoxStatusPedidos.Items.Clear();
            comboBoxStatusPedidos.Items.AddRange(new string[] {
                "Em andamento",
                "Finalizado",
                "Pronto"
            });

            dgvPedidos.Rows.Add("Maria Silva", "Colocar zíper", "R$ 35,00", "Em andamento");
            dgvPedidos.Rows.Add("Ana Costa", "Ajuste de barra de calça", "R$ 20,00", "Finalizado");
        }

        private void ConfigurarColunasPedidos()
        {
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Servico", "Tipo de Serviço");
            dgvPedidos.Columns.Add("Valor", "Valor");
            dgvPedidos.Columns.Add("Status", "Status");

            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedidos.GridColor = Color.FromArgb(245, 245, 245);

            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPedidos.ColumnHeadersHeight = 50;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                SelectionBackColor = Color.White
            };
            dgvPedidos.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowTemplate.Height = 45;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 165, 187),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            dgvPedidos.DefaultCellStyle = cellStyle;

            dgvPedidos.AllowUserToAddRows = false;
        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            string cliente = comboBoxClientePedidos.SelectedItem?.ToString() ?? "";
            string servico = comboBoxTipodeServicoP.SelectedItem?.ToString() ?? "";
            string status = comboBoxStatusPedidos.SelectedItem?.ToString() ?? "";
            string valor = txtValorPedidos.Text;

            if (!string.IsNullOrWhiteSpace(cliente) &&
                !string.IsNullOrWhiteSpace(servico) &&
                !string.IsNullOrWhiteSpace(status) &&
                !string.IsNullOrWhiteSpace(valor))
            {
                dgvPedidos.Rows.Add(cliente, servico, valor, status);
                dgvPedidos.Refresh();

                comboBoxClientePedidos.SelectedIndex = -1;
                comboBoxTipodeServicoP.SelectedIndex = -1;
                comboBoxStatusPedidos.SelectedIndex = -1;
                txtValorPedidos.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //PROCURAR PEDIDOS
        private void txtBuscaPedidos_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaPedidos.Text.ToLower();

            foreach (DataGridViewRow linha in dgvPedidos.Rows)
            {
                if (linha.IsNewRow) continue;

                string cliente = linha.Cells["Cliente"].Value?.ToString().ToLower() ?? "";
                string servico = linha.Cells["Servico"].Value?.ToString().ToLower() ?? "";
                string valor = linha.Cells["Valor"].Value?.ToString().ToLower() ?? "";
                string status = linha.Cells["Status"].Value?.ToString().ToLower() ?? "";

                if (string.IsNullOrWhiteSpace(termo))
                {
                    linha.Visible = true;
                }
                else
                {
                    linha.Visible =
                        cliente.Contains(termo) ||
                        servico.Contains(termo) ||
                        valor.Contains(termo) ||
                        status.Contains(termo);
                }
            }
        }

        //PANEL MENU LATERAL
        private void btnEstoqueP_Click(object sender, EventArgs e)
        {
            TelaEstoque tela = new TelaEstoque();
            tela.Show();
            this.Hide();
        }

        private void btnClientesP_Click(object sender, EventArgs e)
        {
            TelaClientes tela = new TelaClientes();
            tela.Show();
            this.Hide();
        }

        private void btnServicosP_Click(object sender, EventArgs e)
        {
            TelaServicos tela = new TelaServicos();
            tela.Show();
            this.Hide();
        }

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow linha in dgvPedidos.SelectedRows)
                {
                    if (!linha.IsNewRow)
                    {
                        dgvPedidos.Rows.Remove(linha);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para excluir.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
