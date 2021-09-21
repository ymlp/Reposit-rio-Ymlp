namespace RestauranteJapones
{
    partial class Fornecedor
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
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.id_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razao_social_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_rua_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento_rua_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnForn = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AllowUserToDeleteRows = false;
            this.dgvForn.AllowUserToResizeColumns = false;
            this.dgvForn.AllowUserToResizeRows = false;
            this.dgvForn.BackgroundColor = System.Drawing.Color.White;
            this.dgvForn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvForn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fornecedor,
            this.razao_social_fornecedor,
            this.cnpj_fornecedor,
            this.telefone_fornecedor,
            this.celular_fornecedor,
            this.email_fornecedor,
            this.rua_fornecedor,
            this.numero_rua_fornecedor,
            this.complemento_rua_fornecedor,
            this.cep_fornecedor,
            this.bairro_fornecedor,
            this.cidade_fornecedor,
            this.uf_fornecedor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvForn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvForn.Location = new System.Drawing.Point(12, 121);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.ReadOnly = true;
            this.dgvForn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvForn.Size = new System.Drawing.Size(906, 317);
            this.dgvForn.TabIndex = 0;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_fornecedor.DataPropertyName = "id_fornecedor";
            this.id_fornecedor.HeaderText = "ID";
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.ReadOnly = true;
            this.id_fornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_fornecedor.Width = 45;
            // 
            // razao_social_fornecedor
            // 
            this.razao_social_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.razao_social_fornecedor.DataPropertyName = "razao_social_fornecedor";
            this.razao_social_fornecedor.HeaderText = "Nome";
            this.razao_social_fornecedor.Name = "razao_social_fornecedor";
            this.razao_social_fornecedor.ReadOnly = true;
            this.razao_social_fornecedor.Width = 69;
            // 
            // cnpj_fornecedor
            // 
            this.cnpj_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnpj_fornecedor.DataPropertyName = "cnpj_fornecedor";
            this.cnpj_fornecedor.HeaderText = "CNPJ";
            this.cnpj_fornecedor.Name = "cnpj_fornecedor";
            this.cnpj_fornecedor.ReadOnly = true;
            this.cnpj_fornecedor.Width = 64;
            // 
            // telefone_fornecedor
            // 
            this.telefone_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefone_fornecedor.DataPropertyName = "telefone_fornecedor";
            this.telefone_fornecedor.HeaderText = "Telefone";
            this.telefone_fornecedor.Name = "telefone_fornecedor";
            this.telefone_fornecedor.ReadOnly = true;
            this.telefone_fornecedor.Width = 84;
            // 
            // celular_fornecedor
            // 
            this.celular_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.celular_fornecedor.DataPropertyName = "celular_fornecedor";
            this.celular_fornecedor.HeaderText = "Celular";
            this.celular_fornecedor.Name = "celular_fornecedor";
            this.celular_fornecedor.ReadOnly = true;
            this.celular_fornecedor.Width = 75;
            // 
            // email_fornecedor
            // 
            this.email_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email_fornecedor.DataPropertyName = "email_fornecedor";
            this.email_fornecedor.HeaderText = "Email";
            this.email_fornecedor.Name = "email_fornecedor";
            this.email_fornecedor.ReadOnly = true;
            this.email_fornecedor.Width = 64;
            // 
            // rua_fornecedor
            // 
            this.rua_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rua_fornecedor.DataPropertyName = "rua_fornecedor";
            this.rua_fornecedor.HeaderText = "Rua";
            this.rua_fornecedor.Name = "rua_fornecedor";
            this.rua_fornecedor.ReadOnly = true;
            this.rua_fornecedor.Width = 55;
            // 
            // numero_rua_fornecedor
            // 
            this.numero_rua_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numero_rua_fornecedor.DataPropertyName = "numero_rua_fornecedor";
            this.numero_rua_fornecedor.HeaderText = "N° Rua";
            this.numero_rua_fornecedor.Name = "numero_rua_fornecedor";
            this.numero_rua_fornecedor.ReadOnly = true;
            this.numero_rua_fornecedor.Width = 72;
            // 
            // complemento_rua_fornecedor
            // 
            this.complemento_rua_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.complemento_rua_fornecedor.DataPropertyName = "complemento_rua_fornecedor";
            this.complemento_rua_fornecedor.HeaderText = "Complemento Rua";
            this.complemento_rua_fornecedor.Name = "complemento_rua_fornecedor";
            this.complemento_rua_fornecedor.ReadOnly = true;
            this.complemento_rua_fornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complemento_rua_fornecedor.Width = 144;
            // 
            // cep_fornecedor
            // 
            this.cep_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cep_fornecedor.DataPropertyName = "cep_fornecedor";
            this.cep_fornecedor.HeaderText = "CEP";
            this.cep_fornecedor.Name = "cep_fornecedor";
            this.cep_fornecedor.ReadOnly = true;
            this.cep_fornecedor.Width = 55;
            // 
            // bairro_fornecedor
            // 
            this.bairro_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bairro_fornecedor.DataPropertyName = "bairro_fornecedor";
            this.bairro_fornecedor.HeaderText = "Bairro";
            this.bairro_fornecedor.Name = "bairro_fornecedor";
            this.bairro_fornecedor.ReadOnly = true;
            this.bairro_fornecedor.Width = 67;
            // 
            // cidade_fornecedor
            // 
            this.cidade_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidade_fornecedor.DataPropertyName = "cidade_fornecedor";
            this.cidade_fornecedor.HeaderText = "Cidade";
            this.cidade_fornecedor.Name = "cidade_fornecedor";
            this.cidade_fornecedor.ReadOnly = true;
            this.cidade_fornecedor.Width = 77;
            // 
            // uf_fornecedor
            // 
            this.uf_fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.uf_fornecedor.DataPropertyName = "uf_fornecedor";
            this.uf_fornecedor.HeaderText = "UF";
            this.uf_fornecedor.Name = "uf_fornecedor";
            this.uf_fornecedor.ReadOnly = true;
            this.uf_fornecedor.Width = 47;
            // 
            // btnForn
            // 
            this.btnForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnForn.FlatAppearance.BorderSize = 0;
            this.btnForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForn.ForeColor = System.Drawing.Color.White;
            this.btnForn.Location = new System.Drawing.Point(519, 69);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(102, 31);
            this.btnForn.TabIndex = 1;
            this.btnForn.Text = "Listar Todos";
            this.btnForn.UseVisualStyleBackColor = false;
            this.btnForn.Click += new System.EventHandler(this.btnForn_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(438, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "CNPJ"});
            this.cbBusca.Location = new System.Drawing.Point(128, 72);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(114, 24);
            this.cbBusca.TabIndex = 4;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(248, 75);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(184, 21);
            this.txtBusca.TabIndex = 5;
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
            this.msPrincipal.TabIndex = 17;
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
            this.pictureBox9.Location = new System.Drawing.Point(863, 1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 28);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 18;
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
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // Fornecedor
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.dgvForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.TextBox txtBusca;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razao_social_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_rua_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento_rua_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_fornecedor;
    }
}