namespace LogiN
{
    partial class TelaServicos
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaServicos));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnNovoServico = new Button();
            dataGridViewServicos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscaServico = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelCadastroServicos = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtBuscaCadastroS = new TextBox();
            dataGridViewCadastroS = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CadastrarNovoCliente = new GroupBox();
            comboBoxCliente = new ComboBox();
            comboBoxTiposdeServicos = new ComboBox();
            comboBoxStatus = new ComboBox();
            label11 = new Label();
            btnCancelarCliente = new Button();
            btnSalvarClientes = new Button();
            txtValor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelMenuS = new Panel();
            btnServicosS = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedidosS = new Button();
            btnClientesS = new Button();
            btnEstoqueS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroServicos.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroS).BeginInit();
            CadastrarNovoCliente.SuspendLayout();
            panelMenuS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNovoServico
            // 
            btnNovoServico.BackColor = Color.FromArgb(191, 165, 187);
            btnNovoServico.FlatAppearance.BorderSize = 0;
            btnNovoServico.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnNovoServico.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnNovoServico.FlatStyle = FlatStyle.Flat;
            btnNovoServico.Font = new Font("Century Gothic", 12F);
            btnNovoServico.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoServico.Location = new Point(1231, 59);
            btnNovoServico.Name = "btnNovoServico";
            btnNovoServico.Size = new Size(215, 49);
            btnNovoServico.TabIndex = 24;
            btnNovoServico.Text = "+ Novo serviço";
            btnNovoServico.UseVisualStyleBackColor = false;
            btnNovoServico.Click += btnNovoServico_Click;
            // 
            // dataGridViewServicos
            // 
            dataGridViewServicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewServicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewServicos.BorderStyle = BorderStyle.None;
            dataGridViewServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewServicos.ColumnHeadersHeight = 50;
            dataGridViewServicos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewServicos.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewServicos.EnableHeadersVisualStyles = false;
            dataGridViewServicos.Location = new Point(411, 249);
            dataGridViewServicos.Name = "dataGridViewServicos";
            dataGridViewServicos.RowHeadersVisible = false;
            dataGridViewServicos.RowHeadersWidth = 51;
            dataGridViewServicos.RowTemplate.Height = 40;
            dataGridViewServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServicos.Size = new Size(1026, 548);
            dataGridViewServicos.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cliente";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo de Serviço";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBuscaServico);
            panel2.Location = new Point(402, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 63);
            panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtBuscaServico
            // 
            txtBuscaServico.BackColor = Color.White;
            txtBuscaServico.Location = new Point(59, 11);
            txtBuscaServico.Multiline = true;
            txtBuscaServico.Name = "txtBuscaServico";
            txtBuscaServico.Size = new Size(979, 39);
            txtBuscaServico.TabIndex = 0;
            txtBuscaServico.TextChanged += txtBuscaServico_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(399, 51);
            label3.Name = "label3";
            label3.Size = new Size(365, 21);
            label3.TabIndex = 22;
            label3.Text = "Gerencie os seus trabalhos e encomendas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(399, 9);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 21;
            label2.Text = "Serviços";
            // 
            // panelCadastroServicos
            // 
            panelCadastroServicos.Controls.Add(panel3);
            panelCadastroServicos.Controls.Add(dataGridViewCadastroS);
            panelCadastroServicos.Controls.Add(label10);
            panelCadastroServicos.Controls.Add(label9);
            panelCadastroServicos.Controls.Add(label8);
            panelCadastroServicos.Controls.Add(CadastrarNovoCliente);
            panelCadastroServicos.Location = new Point(342, 0);
            panelCadastroServicos.Margin = new Padding(3, 4, 3, 4);
            panelCadastroServicos.Name = "panelCadastroServicos";
            panelCadastroServicos.Size = new Size(1134, 827);
            panelCadastroServicos.TabIndex = 28;
            panelCadastroServicos.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtBuscaCadastroS);
            panel3.Location = new Point(49, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 63);
            panel3.TabIndex = 26;
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
            // txtBuscaCadastroS
            // 
            txtBuscaCadastroS.BackColor = Color.White;
            txtBuscaCadastroS.Location = new Point(59, 11);
            txtBuscaCadastroS.Multiline = true;
            txtBuscaCadastroS.Name = "txtBuscaCadastroS";
            txtBuscaCadastroS.Size = new Size(957, 39);
            txtBuscaCadastroS.TabIndex = 0;
            // 
            // dataGridViewCadastroS
            // 
            dataGridViewCadastroS.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewCadastroS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCadastroS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCadastroS.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCadastroS.BorderStyle = BorderStyle.None;
            dataGridViewCadastroS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCadastroS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewCadastroS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCadastroS.ColumnHeadersHeight = 50;
            dataGridViewCadastroS.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewCadastroS.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCadastroS.EnableHeadersVisualStyles = false;
            dataGridViewCadastroS.Location = new Point(52, 520);
            dataGridViewCadastroS.Name = "dataGridViewCadastroS";
            dataGridViewCadastroS.RowHeadersVisible = false;
            dataGridViewCadastroS.RowHeadersWidth = 45;
            dataGridViewCadastroS.RowTemplate.Height = 40;
            dataGridViewCadastroS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCadastroS.Size = new Size(1026, 300);
            dataGridViewCadastroS.TabIndex = 25;
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
            label10.Location = new Point(50, 56);
            label10.Name = "label10";
            label10.Size = new Size(330, 21);
            label10.TabIndex = 23;
            label10.Text = "Gerencie seus trbalhos e encomendas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(50, 15);
            label9.Name = "label9";
            label9.Size = new Size(121, 32);
            label9.TabIndex = 22;
            label9.Text = "Serviços";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 463);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 3;
            // 
            // CadastrarNovoCliente
            // 
            CadastrarNovoCliente.Controls.Add(comboBoxCliente);
            CadastrarNovoCliente.Controls.Add(comboBoxTiposdeServicos);
            CadastrarNovoCliente.Controls.Add(comboBoxStatus);
            CadastrarNovoCliente.Controls.Add(label11);
            CadastrarNovoCliente.Controls.Add(btnCancelarCliente);
            CadastrarNovoCliente.Controls.Add(btnSalvarClientes);
            CadastrarNovoCliente.Controls.Add(txtValor);
            CadastrarNovoCliente.Controls.Add(label5);
            CadastrarNovoCliente.Controls.Add(label4);
            CadastrarNovoCliente.Controls.Add(label7);
            CadastrarNovoCliente.Controls.Add(label6);
            CadastrarNovoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CadastrarNovoCliente.Location = new Point(49, 85);
            CadastrarNovoCliente.Margin = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Name = "CadastrarNovoCliente";
            CadastrarNovoCliente.Padding = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Size = new Size(1026, 325);
            CadastrarNovoCliente.TabIndex = 0;
            CadastrarNovoCliente.TabStop = false;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxCliente.Location = new Point(23, 97);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(436, 29);
            comboBoxCliente.TabIndex = 14;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxTiposdeServicos
            // 
            comboBoxTiposdeServicos.FormattingEnabled = true;
            comboBoxTiposdeServicos.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxTiposdeServicos.Location = new Point(558, 104);
            comboBoxTiposdeServicos.Name = "comboBoxTiposdeServicos";
            comboBoxTiposdeServicos.Size = new Size(436, 29);
            comboBoxTiposdeServicos.TabIndex = 13;
            comboBoxTiposdeServicos.SelectedIndexChanged += comboBoxTiposdeServicos_SelectedIndexChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            comboBoxStatus.Location = new Point(558, 197);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(436, 29);
            comboBoxStatus.TabIndex = 12;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
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
            // btnCancelarCliente
            // 
            btnCancelarCliente.BackColor = Color.White;
            btnCancelarCliente.FlatAppearance.BorderSize = 0;
            btnCancelarCliente.FlatStyle = FlatStyle.Flat;
            btnCancelarCliente.Font = new Font("Century Gothic", 10F);
            btnCancelarCliente.Location = new Point(887, 258);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(107, 35);
            btnCancelarCliente.TabIndex = 9;
            btnCancelarCliente.Text = "Voltar";
            btnCancelarCliente.UseVisualStyleBackColor = false;
            btnCancelarCliente.Click += btnCancelarCliente_Click;
            // 
            // btnSalvarClientes
            // 
            btnSalvarClientes.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarClientes.FlatAppearance.BorderSize = 0;
            btnSalvarClientes.FlatStyle = FlatStyle.Flat;
            btnSalvarClientes.Font = new Font("Century Gothic", 10F);
            btnSalvarClientes.Location = new Point(739, 258);
            btnSalvarClientes.Name = "btnSalvarClientes";
            btnSalvarClientes.Size = new Size(107, 35);
            btnSalvarClientes.TabIndex = 8;
            btnSalvarClientes.Text = "Salvar";
            btnSalvarClientes.UseVisualStyleBackColor = false;
            btnSalvarClientes.Click += btnSalvarClientes_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(23, 197);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(436, 29);
            txtValor.TabIndex = 5;
            txtValor.TextChanged += txtValor_TextChanged;
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
            label7.Size = new Size(270, 23);
            label7.TabIndex = 2;
            label7.Text = "Cadastre seu novo serviço";
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
            // panelMenuS
            // 
            panelMenuS.BackColor = Color.WhiteSmoke;
            panelMenuS.Controls.Add(btnServicosS);
            panelMenuS.Controls.Add(label1);
            panelMenuS.Controls.Add(pictureBox1);
            panelMenuS.Controls.Add(btnPedidosS);
            panelMenuS.Controls.Add(btnClientesS);
            panelMenuS.Controls.Add(btnEstoqueS);
            panelMenuS.Dock = DockStyle.Left;
            panelMenuS.Location = new Point(0, 0);
            panelMenuS.Name = "panelMenuS";
            panelMenuS.Size = new Size(336, 827);
            panelMenuS.TabIndex = 29;
            // 
            // btnServicosS
            // 
            btnServicosS.BackColor = Color.WhiteSmoke;
            btnServicosS.FlatAppearance.BorderSize = 0;
            btnServicosS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicosS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicosS.FlatStyle = FlatStyle.Flat;
            btnServicosS.Font = new Font("Century Gothic", 12F);
            btnServicosS.Image = (Image)resources.GetObject("btnServicosS.Image");
            btnServicosS.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosS.Location = new Point(26, 539);
            btnServicosS.Name = "btnServicosS";
            btnServicosS.Size = new Size(291, 64);
            btnServicosS.TabIndex = 6;
            btnServicosS.Text = "Serviços";
            btnServicosS.UseVisualStyleBackColor = false;
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
            // btnPedidosS
            // 
            btnPedidosS.BackColor = Color.WhiteSmoke;
            btnPedidosS.FlatAppearance.BorderSize = 0;
            btnPedidosS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosS.FlatStyle = FlatStyle.Flat;
            btnPedidosS.Font = new Font("Century Gothic", 12F);
            btnPedidosS.Image = (Image)resources.GetObject("btnPedidosS.Image");
            btnPedidosS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosS.Location = new Point(26, 646);
            btnPedidosS.Name = "btnPedidosS";
            btnPedidosS.Size = new Size(291, 64);
            btnPedidosS.TabIndex = 2;
            btnPedidosS.Text = "Pedidos";
            btnPedidosS.UseVisualStyleBackColor = false;
            btnPedidosS.Click += btnPedidosS_Click;
            // 
            // btnClientesS
            // 
            btnClientesS.BackColor = Color.WhiteSmoke;
            btnClientesS.FlatAppearance.BorderSize = 0;
            btnClientesS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientesS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientesS.FlatStyle = FlatStyle.Flat;
            btnClientesS.Font = new Font("Century Gothic", 12F);
            btnClientesS.Image = (Image)resources.GetObject("btnClientesS.Image");
            btnClientesS.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesS.Location = new Point(26, 436);
            btnClientesS.Name = "btnClientesS";
            btnClientesS.Size = new Size(291, 64);
            btnClientesS.TabIndex = 1;
            btnClientesS.Text = "Clientes";
            btnClientesS.UseVisualStyleBackColor = false;
            btnClientesS.Click += btnClientesS_Click;
            // 
            // btnEstoqueS
            // 
            btnEstoqueS.BackColor = Color.WhiteSmoke;
            btnEstoqueS.FlatAppearance.BorderSize = 0;
            btnEstoqueS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueS.FlatStyle = FlatStyle.Flat;
            btnEstoqueS.Font = new Font("Century Gothic", 12F);
            btnEstoqueS.ForeColor = Color.Black;
            btnEstoqueS.Image = (Image)resources.GetObject("btnEstoqueS.Image");
            btnEstoqueS.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoqueS.Location = new Point(26, 331);
            btnEstoqueS.Name = "btnEstoqueS";
            btnEstoqueS.Size = new Size(291, 64);
            btnEstoqueS.TabIndex = 0;
            btnEstoqueS.Text = "Estoque";
            btnEstoqueS.UseVisualStyleBackColor = false;
            btnEstoqueS.Click += btnEstoqueS_Click;
            // 
            // TelaServicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 827);
            Controls.Add(panelMenuS);
            Controls.Add(panelCadastroServicos);
            Controls.Add(btnNovoServico);
            Controls.Add(dataGridViewServicos);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaServicos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroServicos.ResumeLayout(false);
            panelCadastroServicos.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastroS).EndInit();
            CadastrarNovoCliente.ResumeLayout(false);
            CadastrarNovoCliente.PerformLayout();
            panelMenuS.ResumeLayout(false);
            panelMenuS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoServico;
        private DataGridView dataGridViewServicos;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBuscaServico;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panelCadastroServicos;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox CadastrarNovoCliente;
        private Button btnCancelarCliente;
        private Button btnSalvarClientes;
        private TextBox txtValor;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label11;
        private DataGridView dataGridViewCadastroS;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox comboBoxStatus;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox txtBuscaCadastroS;
        private ComboBox comboBoxTiposdeServicos;
        private ComboBox comboBoxCliente;
        private Panel panelMenuS;
        private Button btnServicosS;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPedidosS;
        private Button btnClientesS;
        private Button btnEstoqueS;
    }
}