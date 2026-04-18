namespace LogiN
{
    partial class TelaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaClientes));
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            btnNovoCliente = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscaCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelCadastroCliente = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CadastrarNovoCliente = new GroupBox();
            btnVoltarCliente = new Button();
            btnSalvarClientes = new Button();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            dataGridViewClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panelMenuC = new Panel();
            btnServicosC = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedidosC = new Button();
            btnClientesC = new Button();
            btnEstoqueC = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroCliente.SuspendLayout();
            CadastrarNovoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panelMenuC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Century Gothic", 12F);
            btnNovoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCliente.Location = new Point(1238, 60);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(215, 49);
            btnNovoCliente.TabIndex = 24;
            btnNovoCliente.Text = "+ Novo Cliente";
            btnNovoCliente.UseVisualStyleBackColor = false;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBuscaCliente);
            panel2.Location = new Point(409, 152);
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
            // txtBuscaCliente
            // 
            txtBuscaCliente.BackColor = Color.White;
            txtBuscaCliente.Location = new Point(59, 11);
            txtBuscaCliente.Multiline = true;
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(979, 39);
            txtBuscaCliente.TabIndex = 0;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(418, 60);
            label3.Name = "label3";
            label3.Size = new Size(195, 21);
            label3.TabIndex = 22;
            label3.Text = "Gerencie seus clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(418, 18);
            label2.Name = "label2";
            label2.Size = new Size(289, 32);
            label2.TabIndex = 21;
            label2.Text = "Cadastro de Clientes";
            // 
            // panelCadastroCliente
            // 
            panelCadastroCliente.Controls.Add(label10);
            panelCadastroCliente.Controls.Add(label9);
            panelCadastroCliente.Controls.Add(label8);
            panelCadastroCliente.Controls.Add(CadastrarNovoCliente);
            panelCadastroCliente.Location = new Point(342, 3);
            panelCadastroCliente.Margin = new Padding(3, 4, 3, 4);
            panelCadastroCliente.Name = "panelCadastroCliente";
            panelCadastroCliente.Size = new Size(1121, 827);
            panelCadastroCliente.TabIndex = 27;
            panelCadastroCliente.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F);
            label10.Location = new Point(49, 63);
            label10.Name = "label10";
            label10.Size = new Size(195, 21);
            label10.TabIndex = 23;
            label10.Text = "Gerencie seus clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 22);
            label9.Name = "label9";
            label9.Size = new Size(289, 32);
            label9.TabIndex = 22;
            label9.Text = "Cadastro de Clientes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 470);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 3;
            // 
            // CadastrarNovoCliente
            // 
            CadastrarNovoCliente.Controls.Add(btnVoltarCliente);
            CadastrarNovoCliente.Controls.Add(btnSalvarClientes);
            CadastrarNovoCliente.Controls.Add(txtTelefone);
            CadastrarNovoCliente.Controls.Add(txtCPF);
            CadastrarNovoCliente.Controls.Add(txtNomeCompleto);
            CadastrarNovoCliente.Controls.Add(label5);
            CadastrarNovoCliente.Controls.Add(label4);
            CadastrarNovoCliente.Controls.Add(label7);
            CadastrarNovoCliente.Controls.Add(label6);
            CadastrarNovoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CadastrarNovoCliente.Location = new Point(49, 159);
            CadastrarNovoCliente.Margin = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Name = "CadastrarNovoCliente";
            CadastrarNovoCliente.Padding = new Padding(3, 4, 3, 4);
            CadastrarNovoCliente.Size = new Size(1017, 431);
            CadastrarNovoCliente.TabIndex = 0;
            CadastrarNovoCliente.TabStop = false;
            // 
            // btnVoltarCliente
            // 
            btnVoltarCliente.BackColor = Color.White;
            btnVoltarCliente.FlatAppearance.BorderSize = 0;
            btnVoltarCliente.FlatStyle = FlatStyle.Flat;
            btnVoltarCliente.Font = new Font("Century Gothic", 10F);
            btnVoltarCliente.Location = new Point(888, 373);
            btnVoltarCliente.Name = "btnVoltarCliente";
            btnVoltarCliente.Size = new Size(107, 35);
            btnVoltarCliente.TabIndex = 9;
            btnVoltarCliente.Text = "Voltar";
            btnVoltarCliente.UseVisualStyleBackColor = false;
            btnVoltarCliente.Click += btnVoltarCliente_Click;
            // 
            // btnSalvarClientes
            // 
            btnSalvarClientes.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarClientes.FlatAppearance.BorderSize = 0;
            btnSalvarClientes.FlatStyle = FlatStyle.Flat;
            btnSalvarClientes.Font = new Font("Century Gothic", 10F);
            btnSalvarClientes.Location = new Point(752, 373);
            btnSalvarClientes.Name = "btnSalvarClientes";
            btnSalvarClientes.Size = new Size(107, 35);
            btnSalvarClientes.TabIndex = 8;
            btnSalvarClientes.Text = "Salvar";
            btnSalvarClientes.UseVisualStyleBackColor = false;
            btnSalvarClientes.Click += btnSalvarClientes_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(23, 197);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(972, 29);
            txtTelefone.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(23, 295);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(972, 29);
            txtCPF.TabIndex = 4;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(23, 104);
            txtNomeCompleto.Margin = new Padding(3, 4, 3, 4);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(972, 29);
            txtNomeCompleto.TabIndex = 3;            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(23, 171);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 1;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(23, 77);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 0;
            label4.Text = "Nome Completo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 28);
            label7.Name = "label7";
            label7.Size = new Size(239, 23);
            label7.TabIndex = 2;
            label7.Text = "Cadastrar Novo Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(23, 268);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 1;
            label6.Text = "CPF";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = Color.White;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewClientes.ColumnHeadersHeight = 50;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.Location = new Point(409, 232);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowHeadersWidth = 45;
            dataGridViewClientes.RowTemplate.Height = 40;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(1026, 548);
            dataGridViewClientes.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "CPF";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // panelMenuC
            // 
            panelMenuC.BackColor = Color.WhiteSmoke;
            panelMenuC.Controls.Add(btnServicosC);
            panelMenuC.Controls.Add(label1);
            panelMenuC.Controls.Add(pictureBox1);
            panelMenuC.Controls.Add(btnPedidosC);
            panelMenuC.Controls.Add(btnClientesC);
            panelMenuC.Controls.Add(btnEstoqueC);
            panelMenuC.Dock = DockStyle.Left;
            panelMenuC.Location = new Point(0, 0);
            panelMenuC.Name = "panelMenuC";
            panelMenuC.Size = new Size(336, 827);
            panelMenuC.TabIndex = 28;
            // 
            // btnServicosC
            // 
            btnServicosC.BackColor = Color.WhiteSmoke;
            btnServicosC.FlatAppearance.BorderSize = 0;
            btnServicosC.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicosC.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicosC.FlatStyle = FlatStyle.Flat;
            btnServicosC.Font = new Font("Century Gothic", 12F);
            btnServicosC.Image = (Image)resources.GetObject("btnServicosC.Image");
            btnServicosC.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosC.Location = new Point(26, 539);
            btnServicosC.Name = "btnServicosC";
            btnServicosC.Size = new Size(291, 64);
            btnServicosC.TabIndex = 6;
            btnServicosC.Text = "Serviços";
            btnServicosC.UseVisualStyleBackColor = false;
            btnServicosC.Click += btnServicosC_Click;
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
            // btnPedidosC
            // 
            btnPedidosC.BackColor = Color.WhiteSmoke;
            btnPedidosC.FlatAppearance.BorderSize = 0;
            btnPedidosC.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosC.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosC.FlatStyle = FlatStyle.Flat;
            btnPedidosC.Font = new Font("Century Gothic", 12F);
            btnPedidosC.Image = (Image)resources.GetObject("btnPedidosC.Image");
            btnPedidosC.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosC.Location = new Point(26, 646);
            btnPedidosC.Name = "btnPedidosC";
            btnPedidosC.Size = new Size(291, 64);
            btnPedidosC.TabIndex = 2;
            btnPedidosC.Text = "Pedidos";
            btnPedidosC.UseVisualStyleBackColor = false;
            btnPedidosC.Click += btnPedidosC_Click;
            // 
            // btnClientesC
            // 
            btnClientesC.BackColor = Color.WhiteSmoke;
            btnClientesC.FlatAppearance.BorderSize = 0;
            btnClientesC.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientesC.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientesC.FlatStyle = FlatStyle.Flat;
            btnClientesC.Font = new Font("Century Gothic", 12F);
            btnClientesC.Image = (Image)resources.GetObject("btnClientesC.Image");
            btnClientesC.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesC.Location = new Point(26, 436);
            btnClientesC.Name = "btnClientesC";
            btnClientesC.Size = new Size(291, 64);
            btnClientesC.TabIndex = 1;
            btnClientesC.Text = "Clientes";
            btnClientesC.UseVisualStyleBackColor = false;
            // 
            // btnEstoqueC
            // 
            btnEstoqueC.BackColor = Color.WhiteSmoke;
            btnEstoqueC.FlatAppearance.BorderSize = 0;
            btnEstoqueC.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueC.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueC.FlatStyle = FlatStyle.Flat;
            btnEstoqueC.Font = new Font("Century Gothic", 12F);
            btnEstoqueC.ForeColor = Color.Black;
            btnEstoqueC.Image = (Image)resources.GetObject("btnEstoqueC.Image");
            btnEstoqueC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoqueC.Location = new Point(26, 331);
            btnEstoqueC.Name = "btnEstoqueC";
            btnEstoqueC.Size = new Size(291, 64);
            btnEstoqueC.TabIndex = 0;
            btnEstoqueC.Text = "Estoque";
            btnEstoqueC.UseVisualStyleBackColor = false;
            btnEstoqueC.Click += btnEstoqueC_Click;
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 827);
            Controls.Add(panelMenuC);
            Controls.Add(panelCadastroCliente);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnNovoCliente);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaClientes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroCliente.ResumeLayout(false);
            panelCadastroCliente.PerformLayout();
            CadastrarNovoCliente.ResumeLayout(false);
            CadastrarNovoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panelMenuC.ResumeLayout(false);
            panelMenuC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoCliente;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBuscaCliente;
        private Label label3;
        private Label label2;
        private Panel panelCadastroCliente;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox CadastrarNovoCliente;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtNomeCompleto;
        private Button btnSalvarClientes;
        private Button btnVoltarCliente;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panelMenuC;
        private Button btnServicosC;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPedidosC;
        private Button btnClientesC;
        private Button btnEstoqueC;
    }
}