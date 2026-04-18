namespace LogiN
{
    partial class TelaPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidos));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtBuscaPedidos = new TextBox();
            dgvPedidos = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CadastrarNovoCliente = new GroupBox();
            txtValorPedidos = new TextBox();
            comboBoxClientePedidos = new ComboBox();
            comboBoxTipodeServicoP = new ComboBox();
            comboBoxStatusPedidos = new ComboBox();
            label11 = new Label();
            btnExcluirP = new Button();
            btnSalvarP = new Button();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelMenuP = new Panel();
            btnServicosP = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedidosP = new Button();
            btnClientesP = new Button();
            btnEstoqueP = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            CadastrarNovoCliente.SuspendLayout();
            panelMenuP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtBuscaPedidos);
            panel3.Location = new Point(397, 442);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 63);
            panel3.TabIndex = 32;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // txtBuscaPedidos
            // 
            txtBuscaPedidos.BackColor = Color.White;
            txtBuscaPedidos.Location = new Point(59, 11);
            txtBuscaPedidos.Multiline = true;
            txtBuscaPedidos.Name = "txtBuscaPedidos";
            txtBuscaPedidos.Size = new Size(957, 39);
            txtBuscaPedidos.TabIndex = 0;
            txtBuscaPedidos.TextChanged += txtBuscaPedidos_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.WhiteSmoke;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPedidos.ColumnHeadersHeight = 50;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle9;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.Location = new Point(397, 528);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 45;
            dgvPedidos.RowTemplate.Height = 40;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1026, 300);
            dgvPedidos.TabIndex = 31;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cliente";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tipo de serviço";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Valor";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F);
            label10.Location = new Point(397, 54);
            label10.Name = "label10";
            label10.Size = new Size(182, 21);
            label10.TabIndex = 30;
            label10.Text = "Analise seus pedidos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(397, 13);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 29;
            label9.Text = "Pedidos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(757, 461);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 28;
            // 
            // CadastrarNovoCliente
            // 
            CadastrarNovoCliente.Controls.Add(txtValorPedidos);
            CadastrarNovoCliente.Controls.Add(comboBoxClientePedidos);
            CadastrarNovoCliente.Controls.Add(comboBoxTipodeServicoP);
            CadastrarNovoCliente.Controls.Add(comboBoxStatusPedidos);
            CadastrarNovoCliente.Controls.Add(label11);
            CadastrarNovoCliente.Controls.Add(btnExcluirP);
            CadastrarNovoCliente.Controls.Add(btnSalvarP);
            CadastrarNovoCliente.Controls.Add(label5);
            CadastrarNovoCliente.Controls.Add(label4);
            CadastrarNovoCliente.Controls.Add(label7);
            CadastrarNovoCliente.Controls.Add(label6);
            CadastrarNovoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CadastrarNovoCliente.Location = new Point(397, 84);
            CadastrarNovoCliente.Margin = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Name = "CadastrarNovoCliente";
            CadastrarNovoCliente.Padding = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Size = new Size(1026, 325);
            CadastrarNovoCliente.TabIndex = 27;
            CadastrarNovoCliente.TabStop = false;
            // 
            // txtValorPedidos
            // 
            txtValorPedidos.Location = new Point(23, 197);
            txtValorPedidos.Margin = new Padding(3, 4, 3, 4);
            txtValorPedidos.Name = "txtValorPedidos";
            txtValorPedidos.Size = new Size(436, 29);
            txtValorPedidos.TabIndex = 15;
            // 
            // comboBoxClientePedidos
            // 
            comboBoxClientePedidos.FormattingEnabled = true;
            comboBoxClientePedidos.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxClientePedidos.Location = new Point(23, 103);
            comboBoxClientePedidos.Name = "comboBoxClientePedidos";
            comboBoxClientePedidos.Size = new Size(436, 29);
            comboBoxClientePedidos.TabIndex = 14;
            // 
            // comboBoxTipodeServicoP
            // 
            comboBoxTipodeServicoP.FormattingEnabled = true;
            comboBoxTipodeServicoP.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxTipodeServicoP.Location = new Point(558, 104);
            comboBoxTipodeServicoP.Name = "comboBoxTipodeServicoP";
            comboBoxTipodeServicoP.Size = new Size(436, 29);
            comboBoxTipodeServicoP.TabIndex = 13;
            // 
            // comboBoxStatusPedidos
            // 
            comboBoxStatusPedidos.FormattingEnabled = true;
            comboBoxStatusPedidos.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxStatusPedidos.Location = new Point(558, 197);
            comboBoxStatusPedidos.Name = "comboBoxStatusPedidos";
            comboBoxStatusPedidos.Size = new Size(436, 29);
            comboBoxStatusPedidos.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(558, 169);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 11;
            label11.Text = "Status";
            // 
            // btnExcluirP
            // 
            btnExcluirP.BackColor = Color.White;
            btnExcluirP.FlatAppearance.BorderSize = 0;
            btnExcluirP.FlatStyle = FlatStyle.Flat;
            btnExcluirP.Font = new Font("Century Gothic", 10F);
            btnExcluirP.Location = new Point(887, 264);
            btnExcluirP.Name = "btnExcluirP";
            btnExcluirP.Size = new Size(107, 35);
            btnExcluirP.TabIndex = 9;
            btnExcluirP.Text = "Excluir";
            btnExcluirP.UseVisualStyleBackColor = false;
            btnExcluirP.Click += btnExcluirP_Click;
            // 
            // btnSalvarP
            // 
            btnSalvarP.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarP.FlatAppearance.BorderSize = 0;
            btnSalvarP.FlatStyle = FlatStyle.Flat;
            btnSalvarP.Font = new Font("Century Gothic", 10F);
            btnSalvarP.Location = new Point(738, 264);
            btnSalvarP.Name = "btnSalvarP";
            btnSalvarP.Size = new Size(107, 35);
            btnSalvarP.TabIndex = 8;
            btnSalvarP.Text = "Salvar";
            btnSalvarP.UseVisualStyleBackColor = false;
            btnSalvarP.Click += btnSalvarP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(23, 171);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 1;
            label5.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(23, 77);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 0;
            label4.Text = "Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 28);
            label7.Name = "label7";
            label7.Size = new Size(215, 23);
            label7.TabIndex = 2;
            label7.Text = "Cadastre seu pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(558, 77);
            label6.Name = "label6";
            label6.Size = new Size(136, 21);
            label6.TabIndex = 1;
            label6.Text = "Tipo de serviço";
            // 
            // panelMenuP
            // 
            panelMenuP.BackColor = Color.WhiteSmoke;
            panelMenuP.Controls.Add(btnServicosP);
            panelMenuP.Controls.Add(label1);
            panelMenuP.Controls.Add(pictureBox1);
            panelMenuP.Controls.Add(btnPedidosP);
            panelMenuP.Controls.Add(btnClientesP);
            panelMenuP.Controls.Add(btnEstoqueP);
            panelMenuP.Dock = DockStyle.Left;
            panelMenuP.Location = new Point(0, 0);
            panelMenuP.Name = "panelMenuP";
            panelMenuP.Size = new Size(336, 827);
            panelMenuP.TabIndex = 33;
            // 
            // btnServicosP
            // 
            btnServicosP.BackColor = Color.WhiteSmoke;
            btnServicosP.FlatAppearance.BorderSize = 0;
            btnServicosP.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicosP.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicosP.FlatStyle = FlatStyle.Flat;
            btnServicosP.Font = new Font("Century Gothic", 12F);
            btnServicosP.Image = (Image)resources.GetObject("btnServicosP.Image");
            btnServicosP.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosP.Location = new Point(26, 539);
            btnServicosP.Name = "btnServicosP";
            btnServicosP.Size = new Size(291, 64);
            btnServicosP.TabIndex = 6;
            btnServicosP.Text = "Serviços";
            btnServicosP.UseVisualStyleBackColor = false;
            btnServicosP.Click += btnServicosP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            label1.Location = new Point(47, 165);
            label1.Name = "label1";
            label1.Size = new Size(253, 26);
            label1.TabIndex = 5;
            label1.Text = "Bem-vinda ao Sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnPedidosP
            // 
            btnPedidosP.BackColor = Color.WhiteSmoke;
            btnPedidosP.FlatAppearance.BorderSize = 0;
            btnPedidosP.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosP.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosP.FlatStyle = FlatStyle.Flat;
            btnPedidosP.Font = new Font("Century Gothic", 12F);
            btnPedidosP.Image = (Image)resources.GetObject("btnPedidosP.Image");
            btnPedidosP.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosP.Location = new Point(26, 646);
            btnPedidosP.Name = "btnPedidosP";
            btnPedidosP.Size = new Size(291, 64);
            btnPedidosP.TabIndex = 2;
            btnPedidosP.Text = "Pedidos";
            btnPedidosP.UseVisualStyleBackColor = false;
            // 
            // btnClientesP
            // 
            btnClientesP.BackColor = Color.WhiteSmoke;
            btnClientesP.FlatAppearance.BorderSize = 0;
            btnClientesP.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientesP.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientesP.FlatStyle = FlatStyle.Flat;
            btnClientesP.Font = new Font("Century Gothic", 12F);
            btnClientesP.Image = (Image)resources.GetObject("btnClientesP.Image");
            btnClientesP.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesP.Location = new Point(26, 436);
            btnClientesP.Name = "btnClientesP";
            btnClientesP.Size = new Size(291, 64);
            btnClientesP.TabIndex = 1;
            btnClientesP.Text = "Clientes";
            btnClientesP.UseVisualStyleBackColor = false;
            btnClientesP.Click += btnClientesP_Click;
            // 
            // btnEstoqueP
            // 
            btnEstoqueP.BackColor = Color.WhiteSmoke;
            btnEstoqueP.FlatAppearance.BorderSize = 0;
            btnEstoqueP.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueP.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueP.FlatStyle = FlatStyle.Flat;
            btnEstoqueP.Font = new Font("Century Gothic", 12F);
            btnEstoqueP.ForeColor = Color.Black;
            btnEstoqueP.Image = (Image)resources.GetObject("btnEstoqueP.Image");
            btnEstoqueP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoqueP.Location = new Point(26, 331);
            btnEstoqueP.Name = "btnEstoqueP";
            btnEstoqueP.Size = new Size(291, 64);
            btnEstoqueP.TabIndex = 0;
            btnEstoqueP.Text = "Estoque";
            btnEstoqueP.UseVisualStyleBackColor = false;
            btnEstoqueP.Click += btnEstoqueP_Click;
            // 
            // TelaPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 827);
            Controls.Add(panelMenuP);
            Controls.Add(panel3);
            Controls.Add(dgvPedidos);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CadastrarNovoCliente);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaPedidos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            CadastrarNovoCliente.ResumeLayout(false);
            CadastrarNovoCliente.PerformLayout();
            panelMenuP.ResumeLayout(false);
            panelMenuP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox txtBuscaPedidos;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox CadastrarNovoCliente;
        private ComboBox comboBoxStatusPedidos;
        private Label label11;
        private Button btnExcluirP;
        private Button btnSalvarP;
        private Label label5;
        private Label label4;
        private Label label7;
        private ComboBox comboBoxTipodeServicoP;
        private Label label6;
        private TextBox txtValorPedidos;
        private ComboBox comboBoxClientePedidos;
        private Panel panelMenuP;
        private Button btnServicosP;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPedidosP;
        private Button btnClientesP;
        private Button btnEstoqueP;
    }
}