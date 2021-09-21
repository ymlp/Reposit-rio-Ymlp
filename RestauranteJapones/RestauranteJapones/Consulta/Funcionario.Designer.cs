namespace RestauranteJapones
{
    partial class Funcionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFunc = new System.Windows.Forms.Button();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.id_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_rua_funcionarior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento_rua_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_for_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.Location = new System.Drawing.Point(519, 69);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(102, 31);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Listar Todos";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.AllowUserToResizeColumns = false;
            this.dgvFunc.AllowUserToResizeRows = false;
            this.dgvFunc.BackgroundColor = System.Drawing.Color.White;
            this.dgvFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_funcionario,
            this.nome_funcionario,
            this.sobrenome_funcionario,
            this.telefone_funcionario,
            this.celular_funcionario,
            this.email_funcionario,
            this.rua_funcionario,
            this.numero_rua_funcionarior,
            this.complemento_rua_funcionario,
            this.cep_funcionario,
            this.bairro_funcionario,
            this.cidade_for_funcionario,
            this.uf_funcionario,
            this.usuario});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFunc.Location = new System.Drawing.Point(12, 121);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFunc.Size = new System.Drawing.Size(906, 317);
            this.dgvFunc.TabIndex = 1;
            // 
            // id_funcionario
            // 
            this.id_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_funcionario.DataPropertyName = "id_funcionario";
            this.id_funcionario.HeaderText = "ID";
            this.id_funcionario.Name = "id_funcionario";
            this.id_funcionario.ReadOnly = true;
            this.id_funcionario.Width = 43;
            // 
            // nome_funcionario
            // 
            this.nome_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nome_funcionario.DataPropertyName = "nome_funcionario";
            this.nome_funcionario.HeaderText = "Nome";
            this.nome_funcionario.Name = "nome_funcionario";
            this.nome_funcionario.ReadOnly = true;
            this.nome_funcionario.Width = 67;
            // 
            // sobrenome_funcionario
            // 
            this.sobrenome_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sobrenome_funcionario.DataPropertyName = "sobrenome_funcionario";
            this.sobrenome_funcionario.HeaderText = "Sobrenome";
            this.sobrenome_funcionario.Name = "sobrenome_funcionario";
            this.sobrenome_funcionario.ReadOnly = true;
            // 
            // telefone_funcionario
            // 
            this.telefone_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefone_funcionario.DataPropertyName = "telefone_funcionario";
            this.telefone_funcionario.HeaderText = "Telefone";
            this.telefone_funcionario.Name = "telefone_funcionario";
            this.telefone_funcionario.ReadOnly = true;
            this.telefone_funcionario.Width = 82;
            // 
            // celular_funcionario
            // 
            this.celular_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.celular_funcionario.DataPropertyName = "celular_funcionario";
            this.celular_funcionario.HeaderText = "Celular";
            this.celular_funcionario.Name = "celular_funcionario";
            this.celular_funcionario.ReadOnly = true;
            this.celular_funcionario.Width = 73;
            // 
            // email_funcionario
            // 
            this.email_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email_funcionario.DataPropertyName = "email_funcionario";
            this.email_funcionario.HeaderText = "Email";
            this.email_funcionario.Name = "email_funcionario";
            this.email_funcionario.ReadOnly = true;
            this.email_funcionario.Width = 62;
            // 
            // rua_funcionario
            // 
            this.rua_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rua_funcionario.DataPropertyName = "rua_funcionario";
            this.rua_funcionario.HeaderText = "Rua";
            this.rua_funcionario.Name = "rua_funcionario";
            this.rua_funcionario.ReadOnly = true;
            this.rua_funcionario.Width = 53;
            // 
            // numero_rua_funcionarior
            // 
            this.numero_rua_funcionarior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numero_rua_funcionarior.DataPropertyName = "numero_rua_funcionarior";
            this.numero_rua_funcionarior.HeaderText = "N° Rua";
            this.numero_rua_funcionarior.Name = "numero_rua_funcionarior";
            this.numero_rua_funcionarior.ReadOnly = true;
            this.numero_rua_funcionarior.Width = 70;
            // 
            // complemento_rua_funcionario
            // 
            this.complemento_rua_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.complemento_rua_funcionario.DataPropertyName = "complemento_rua_funcionario";
            this.complemento_rua_funcionario.HeaderText = "Complemento";
            this.complemento_rua_funcionario.Name = "complemento_rua_funcionario";
            this.complemento_rua_funcionario.ReadOnly = true;
            this.complemento_rua_funcionario.Width = 117;
            // 
            // cep_funcionario
            // 
            this.cep_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cep_funcionario.DataPropertyName = "cep_funcionario";
            this.cep_funcionario.HeaderText = "CEP";
            this.cep_funcionario.Name = "cep_funcionario";
            this.cep_funcionario.ReadOnly = true;
            this.cep_funcionario.Width = 53;
            // 
            // bairro_funcionario
            // 
            this.bairro_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bairro_funcionario.DataPropertyName = "bairro_funcionario";
            this.bairro_funcionario.HeaderText = "Bairro";
            this.bairro_funcionario.Name = "bairro_funcionario";
            this.bairro_funcionario.ReadOnly = true;
            this.bairro_funcionario.Width = 65;
            // 
            // cidade_for_funcionario
            // 
            this.cidade_for_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidade_for_funcionario.DataPropertyName = "cidade_for_funcionario";
            this.cidade_for_funcionario.HeaderText = "Cidade";
            this.cidade_for_funcionario.Name = "cidade_for_funcionario";
            this.cidade_for_funcionario.ReadOnly = true;
            this.cidade_for_funcionario.Width = 75;
            // 
            // uf_funcionario
            // 
            this.uf_funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.uf_funcionario.DataPropertyName = "uf_funcionario";
            this.uf_funcionario.HeaderText = "UF";
            this.uf_funcionario.Name = "uf_funcionario";
            this.uf_funcionario.ReadOnly = true;
            this.uf_funcionario.Width = 45;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 74;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Location = new System.Drawing.Point(438, 69);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 31);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(8, 72);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(118, 23);
            this.lblBusca.TabIndex = 3;
            this.lblBusca.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Sobrenome"});
            this.cbBusca.Location = new System.Drawing.Point(128, 72);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(114, 24);
            this.cbBusca.TabIndex = 4;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(248, 75);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(184, 21);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.msPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.caixaToolStripMenuItem1,
            this.ajustesToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(930, 29);
            this.msPrincipal.TabIndex = 18;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.comandaToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.reservaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.comandaToolStripMenuItem.Text = "Comanda";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1,
            this.comandaToolStripMenuItem1,
            this.itemToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.reservaToolStripMenuItem1});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            // 
            // comandaToolStripMenuItem1
            // 
            this.comandaToolStripMenuItem1.Name = "comandaToolStripMenuItem1";
            this.comandaToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.comandaToolStripMenuItem1.Text = "Comanda";
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.itemToolStripMenuItem1.Text = "Item";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.produtoToolStripMenuItem1.Text = "Produto";
            // 
            // reservaToolStripMenuItem1
            // 
            this.reservaToolStripMenuItem1.Name = "reservaToolStripMenuItem1";
            this.reservaToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.reservaToolStripMenuItem1.Text = "Reserva";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(68, 25);
            this.caixaToolStripMenuItem1.Text = "Caixa";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox9.Image = global::RestauranteJapones.Properties.Resources.minimizar3;
            this.pictureBox9.Location = new System.Drawing.Point(864, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 28);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox10.Image = global::RestauranteJapones.Properties.Resources.fechar2;
            this.pictureBox10.Location = new System.Drawing.Point(896, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.btnFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_rua_funcionarior;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento_rua_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_for_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}