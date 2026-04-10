namespace LogiN
{
    partial class TelaEstoque
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            btnAbrirCadastro = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnServicos = new Button();
            btnClientes = new Button();
            btnEstoque = new Button();
            panelCadastro = new Panel();
            groupBox1 = new GroupBox();
            btnCancelarEstoque = new Button();
            btnSalvarEstoque = new Button();
            label6 = new Label();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            txtNomeItem = new TextBox();
            label7 = new Label();
            Quantidade = new NumericUpDown();
            btnVoltar = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantidade).BeginInit();
            SuspendLayout();
            // 
            // btnAbrirCadastro
            // 
            btnAbrirCadastro.BackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatAppearance.BorderSize = 0;
            btnAbrirCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatStyle = FlatStyle.Flat;
            btnAbrirCadastro.Font = new Font("Century Gothic", 12F);
            btnAbrirCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCadastro.Location = new Point(1227, 63);
            btnAbrirCadastro.Name = "btnAbrirCadastro";
            btnAbrirCadastro.Size = new Size(215, 49);
            btnAbrirCadastro.TabIndex = 18;
            btnAbrirCadastro.Text = "+ Adicionar Item";
            btnAbrirCadastro.UseVisualStyleBackColor = false;
            btnAbrirCadastro.Click += btnAbrirCadastro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(407, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1026, 548);
            dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantidade";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBusca);
            panel2.Location = new Point(398, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 63);
            panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 39);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(59, 11);
            txtBusca.Multiline = true;
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(979, 39);
            txtBusca.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(407, 63);
            label3.Name = "label3";
            label3.Size = new Size(327, 21);
            label3.TabIndex = 16;
            label3.Text = "Gerencie seus materiais e aviamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(407, 22);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 15;
            label2.Text = "Controle de Estoque";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnServicos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnEstoque);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 826);
            panel1.TabIndex = 14;
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
            // btnServicos
            // 
            btnServicos.BackColor = Color.WhiteSmoke;
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Century Gothic", 12F);
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(26, 558);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(291, 64);
            btnServicos.TabIndex = 2;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.WhiteSmoke;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 12F);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(26, 441);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(291, 64);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Century Gothic", 12F);
            btnEstoque.ForeColor = Color.Black;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(26, 330);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(291, 64);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            // 
            // panelCadastro
            // 
            panelCadastro.Controls.Add(groupBox1);
            panelCadastro.Controls.Add(btnVoltar);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Location = new Point(342, 0);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(1133, 829);
            panelCadastro.TabIndex = 20;
            panelCadastro.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelarEstoque);
            groupBox1.Controls.Add(btnSalvarEstoque);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtNomeItem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Quantidade);
            groupBox1.Location = new Point(56, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1035, 303);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // btnCancelarEstoque
            // 
            btnCancelarEstoque.BackColor = Color.White;
            btnCancelarEstoque.FlatAppearance.BorderSize = 0;
            btnCancelarEstoque.FlatStyle = FlatStyle.Flat;
            btnCancelarEstoque.Font = new Font("Century Gothic", 10F);
            btnCancelarEstoque.Location = new Point(902, 239);
            btnCancelarEstoque.Name = "btnCancelarEstoque";
            btnCancelarEstoque.Size = new Size(107, 34);
            btnCancelarEstoque.TabIndex = 7;
            btnCancelarEstoque.Text = "Cancelar";
            btnCancelarEstoque.UseVisualStyleBackColor = false;
            btnCancelarEstoque.Click += btnCancelarEstoque_Click;
            // 
            // btnSalvarEstoque
            // 
            btnSalvarEstoque.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarEstoque.FlatAppearance.BorderSize = 0;
            btnSalvarEstoque.FlatStyle = FlatStyle.Flat;
            btnSalvarEstoque.Font = new Font("Century Gothic", 10F);
            btnSalvarEstoque.Location = new Point(729, 239);
            btnSalvarEstoque.Name = "btnSalvarEstoque";
            btnSalvarEstoque.Size = new Size(107, 34);
            btnSalvarEstoque.TabIndex = 6;
            btnSalvarEstoque.Text = "Salvar";
            btnSalvarEstoque.UseVisualStyleBackColor = false;
            btnSalvarEstoque.Click += btnSalvarEstoque_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F);
            label6.Location = new Point(53, 77);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 3;
            label6.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F);
            label8.Location = new Point(744, 79);
            label8.Name = "label8";
            label8.Size = new Size(96, 21);
            label8.TabIndex = 5;
            label8.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            cmbCategoria.Location = new Point(744, 104);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(238, 28);
            cmbCategoria.TabIndex = 1;
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(49, 102);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(238, 27);
            txtNomeItem.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F);
            label7.Location = new Point(386, 79);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 4;
            label7.Text = "Quantidade";
            // 
            // Quantidade
            // 
            Quantidade.Location = new Point(386, 102);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(235, 27);
            Quantidade.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Century Gothic", 12F);
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(876, 73);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(215, 49);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "+ Adicionar Item";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F);
            label4.Location = new Point(56, 73);
            label4.Name = "label4";
            label4.Size = new Size(327, 21);
            label4.TabIndex = 20;
            label4.Text = "Gerencie seus materiais e aviamentos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label5.Location = new Point(56, 32);
            label5.Name = "label5";
            label5.Size = new Size(278, 32);
            label5.TabIndex = 19;
            label5.Text = "Controle de Estoque";
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1475, 826);
            Controls.Add(panelCadastro);
            Controls.Add(btnAbrirCadastro);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirCadastro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBusca;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnServicos;
        private Button btnClientes;
        private Button btnEstoque;
        private Panel panelCadastro;
        private Button btnVoltar;
        private Label label4;
        private Label label5;
        private Label label8;
        private ComboBox cmbCategoria;
        private Label label7;
        private NumericUpDown Quantidade;
        private Label label6;
        private TextBox txtNomeItem;
        private GroupBox groupBox1;
        private Button btnSalvarEstoque;
        private Button btnCancelarEstoque;
    }
}