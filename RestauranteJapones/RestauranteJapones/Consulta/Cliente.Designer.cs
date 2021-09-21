namespace RestauranteJapones.Consulta
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_rua_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento_rua_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCli
            // 
            this.dgvCli.AllowUserToAddRows = false;
            this.dgvCli.AllowUserToDeleteRows = false;
            this.dgvCli.AllowUserToResizeColumns = false;
            this.dgvCli.AllowUserToResizeRows = false;
            this.dgvCli.BackgroundColor = System.Drawing.Color.White;
            this.dgvCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nome_cliente,
            this.sobrenome_cliente,
            this.telefone_cliente,
            this.celular_cliente,
            this.email_cliente,
            this.cpf_cliente,
            this.rua_cliente,
            this.numero_rua_cliente,
            this.complemento_rua_cliente,
            this.cep_cliente,
            this.bairro_cliente,
            this.cidade_cliente,
            this.uf_cliente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCli.Location = new System.Drawing.Point(12, 121);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.ReadOnly = true;
            this.dgvCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCli.Size = new System.Drawing.Size(906, 317);
            this.dgvCli.TabIndex = 0;
            this.dgvCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCli_CellContentClick);
            // 
            // id_cliente
            // 
            this.id_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "ID";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_cliente.Width = 45;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.HeaderText = "Nome";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Width = 69;
            // 
            // sobrenome_cliente
            // 
            this.sobrenome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sobrenome_cliente.DataPropertyName = "sobrenome_cliente";
            this.sobrenome_cliente.HeaderText = "Sobrenome";
            this.sobrenome_cliente.Name = "sobrenome_cliente";
            this.sobrenome_cliente.ReadOnly = true;
            this.sobrenome_cliente.Width = 102;
            // 
            // telefone_cliente
            // 
            this.telefone_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefone_cliente.DataPropertyName = "telefone_cliente";
            this.telefone_cliente.HeaderText = "Telefone";
            this.telefone_cliente.Name = "telefone_cliente";
            this.telefone_cliente.ReadOnly = true;
            this.telefone_cliente.Width = 84;
            // 
            // celular_cliente
            // 
            this.celular_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.celular_cliente.DataPropertyName = "celular_cliente";
            this.celular_cliente.HeaderText = "Celular";
            this.celular_cliente.Name = "celular_cliente";
            this.celular_cliente.ReadOnly = true;
            this.celular_cliente.Width = 75;
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email_cliente.DataPropertyName = "email_cliente";
            this.email_cliente.HeaderText = "Email";
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.ReadOnly = true;
            this.email_cliente.Width = 64;
            // 
            // cpf_cliente
            // 
            this.cpf_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cpf_cliente.DataPropertyName = "cpf_cliente";
            this.cpf_cliente.HeaderText = "CPF";
            this.cpf_cliente.Name = "cpf_cliente";
            this.cpf_cliente.ReadOnly = true;
            this.cpf_cliente.Width = 55;
            // 
            // rua_cliente
            // 
            this.rua_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rua_cliente.DataPropertyName = "rua_cliente";
            this.rua_cliente.HeaderText = "Rua";
            this.rua_cliente.Name = "rua_cliente";
            this.rua_cliente.ReadOnly = true;
            this.rua_cliente.Width = 55;
            // 
            // numero_rua_cliente
            // 
            this.numero_rua_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numero_rua_cliente.DataPropertyName = "numero_rua_cliente";
            this.numero_rua_cliente.HeaderText = "Nº da Rua";
            this.numero_rua_cliente.Name = "numero_rua_cliente";
            this.numero_rua_cliente.ReadOnly = true;
            this.numero_rua_cliente.Width = 90;
            // 
            // complemento_rua_cliente
            // 
            this.complemento_rua_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.complemento_rua_cliente.DataPropertyName = "complemento_rua_cliente";
            this.complemento_rua_cliente.HeaderText = "Complemento";
            this.complemento_rua_cliente.Name = "complemento_rua_cliente";
            this.complemento_rua_cliente.ReadOnly = true;
            this.complemento_rua_cliente.Width = 119;
            // 
            // cep_cliente
            // 
            this.cep_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cep_cliente.DataPropertyName = "cep_cliente";
            this.cep_cliente.HeaderText = "CEP";
            this.cep_cliente.Name = "cep_cliente";
            this.cep_cliente.ReadOnly = true;
            this.cep_cliente.Width = 55;
            // 
            // bairro_cliente
            // 
            this.bairro_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bairro_cliente.DataPropertyName = "bairro_cliente";
            this.bairro_cliente.HeaderText = "Bairro";
            this.bairro_cliente.Name = "bairro_cliente";
            this.bairro_cliente.ReadOnly = true;
            this.bairro_cliente.Width = 67;
            // 
            // cidade_cliente
            // 
            this.cidade_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidade_cliente.DataPropertyName = "cidade_cliente";
            this.cidade_cliente.HeaderText = "Cidade";
            this.cidade_cliente.Name = "cidade_cliente";
            this.cidade_cliente.ReadOnly = true;
            this.cidade_cliente.Width = 77;
            // 
            // uf_cliente
            // 
            this.uf_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.uf_cliente.DataPropertyName = "uf_cliente";
            this.uf_cliente.HeaderText = "UF";
            this.uf_cliente.Name = "uf_cliente";
            this.uf_cliente.ReadOnly = true;
            this.uf_cliente.Width = 47;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(519, 69);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 31);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Listar Todos";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnBuscarNome.FlatAppearance.BorderSize = 0;
            this.btnBuscarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNome.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNome.Location = new System.Drawing.Point(438, 69);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(75, 31);
            this.btnBuscarNome.TabIndex = 2;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = false;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(248, 75);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(184, 21);
            this.txtBusca.TabIndex = 3;
            // 
            // cbBusca
            // 
            this.cbBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Sobrenome",
            "CPF"});
            this.cbBusca.Location = new System.Drawing.Point(128, 72);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(114, 24);
            this.cbBusca.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox9.Image = global::RestauranteJapones.Properties.Resources.minimizar3;
            this.pictureBox9.Location = new System.Drawing.Point(863, 1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 28);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox10.Image = global::RestauranteJapones.Properties.Resources.fechar2;
            this.pictureBox10.Location = new System.Drawing.Point(895, 1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
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
            this.msPrincipal.TabIndex = 16;
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
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.btnBuscarNome);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnBuscarNome;
		private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_rua_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento_rua_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_cliente;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
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
    }
}