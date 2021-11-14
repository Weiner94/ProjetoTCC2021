
namespace ProjetoTCC.Forms
{
    partial class frmRegVendas
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
            this.components = new System.ComponentModel.Container();
            this.TxbProduto = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.TxbIdVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbPreco = new System.Windows.Forms.TextBox();
            this.BtnRemoverItem = new MetroFramework.Controls.MetroButton();
            this.BtnAdicionarItem = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbQuantidade = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemlucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbUnidadeKg = new System.Windows.Forms.TextBox();
            this.TxbPrecoTotal = new System.Windows.Forms.TextBox();
            this.TxbTotalVenda = new System.Windows.Forms.TextBox();
            this.BtnNovaVenda = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkvendausuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.produtoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.ProdutoTableAdapter();
            this.vendaTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.VendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbProduto
            // 
            this.TxbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.TxbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "nome", true));
            this.TxbProduto.Location = new System.Drawing.Point(104, 41);
            this.TxbProduto.Name = "TxbProduto";
            this.TxbProduto.Size = new System.Drawing.Size(289, 20);
            this.TxbProduto.TabIndex = 0;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // dBTCCDataSet
            // 
            this.dBTCCDataSet.DataSetName = "DBTCCDataSet";
            this.dBTCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxbIdVenda
            // 
            this.TxbIdVenda.Location = new System.Drawing.Point(815, 41);
            this.TxbIdVenda.Name = "TxbIdVenda";
            this.TxbIdVenda.ReadOnly = true;
            this.TxbIdVenda.Size = new System.Drawing.Size(85, 20);
            this.TxbIdVenda.TabIndex = 1;
            this.TxbIdVenda.TextChanged += new System.EventHandler(this.TxbIdVenda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTRO DE VENDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRODUTO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 80);
            this.panel1.TabIndex = 5;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1416, 30);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(158, 41);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxbPreco);
            this.panel2.Controls.Add(this.BtnRemoverItem);
            this.panel2.Controls.Add(this.BtnAdicionarItem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxbProduto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxbIdVenda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 113);
            this.panel2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PREÇO: ";
            // 
            // TxbPreco
            // 
            this.TxbPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_venda", true));
            this.TxbPreco.Location = new System.Drawing.Point(485, 41);
            this.TxbPreco.Name = "TxbPreco";
            this.TxbPreco.ReadOnly = true;
            this.TxbPreco.Size = new System.Drawing.Size(157, 20);
            this.TxbPreco.TabIndex = 11;
            // 
            // BtnRemoverItem
            // 
            this.BtnRemoverItem.Location = new System.Drawing.Point(1275, 30);
            this.BtnRemoverItem.Name = "BtnRemoverItem";
            this.BtnRemoverItem.Size = new System.Drawing.Size(104, 41);
            this.BtnRemoverItem.TabIndex = 7;
            this.BtnRemoverItem.Text = "REMOVER";
            this.BtnRemoverItem.UseSelectable = true;
            this.BtnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // BtnAdicionarItem
            // 
            this.BtnAdicionarItem.Location = new System.Drawing.Point(1088, 30);
            this.BtnAdicionarItem.Name = "BtnAdicionarItem";
            this.BtnAdicionarItem.Size = new System.Drawing.Size(158, 41);
            this.BtnAdicionarItem.TabIndex = 6;
            this.BtnAdicionarItem.Text = "ADICIONAR PRODUTO";
            this.BtnAdicionarItem.UseSelectable = true;
            this.BtnAdicionarItem.Click += new System.EventHandler(this.BtnAdicionarItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CÓDIGO DA VENDA: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "QUANTIDADE: ";
            // 
            // TxbQuantidade
            // 
            this.TxbQuantidade.Location = new System.Drawing.Point(288, 76);
            this.TxbQuantidade.Multiline = true;
            this.TxbQuantidade.Name = "TxbQuantidade";
            this.TxbQuantidade.Size = new System.Drawing.Size(98, 30);
            this.TxbQuantidade.TabIndex = 8;
            this.TxbQuantidade.TextChanged += new System.EventHandler(this.TxbQuantidade_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 707);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precocompraDataGridViewTextBoxColumn,
            this.precovendaDataGridViewTextBoxColumn,
            this.porcentagemlucroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 707);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "PRODUTO";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // precocompraDataGridViewTextBoxColumn
            // 
            this.precocompraDataGridViewTextBoxColumn.DataPropertyName = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.HeaderText = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.Name = "precocompraDataGridViewTextBoxColumn";
            this.precocompraDataGridViewTextBoxColumn.Visible = false;
            // 
            // precovendaDataGridViewTextBoxColumn
            // 
            this.precovendaDataGridViewTextBoxColumn.DataPropertyName = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.HeaderText = "PREÇO";
            this.precovendaDataGridViewTextBoxColumn.Name = "precovendaDataGridViewTextBoxColumn";
            // 
            // porcentagemlucroDataGridViewTextBoxColumn
            // 
            this.porcentagemlucroDataGridViewTextBoxColumn.DataPropertyName = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.HeaderText = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.Name = "porcentagemlucroDataGridViewTextBoxColumn";
            this.porcentagemlucroDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE ESTOQUE";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // fkprodutoidFornecedorDataGridViewTextBoxColumn
            // 
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.DataPropertyName = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.HeaderText = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.Name = "fkprodutoidFornecedorDataGridViewTextBoxColumn";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(539, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1161, 707);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.TxbUnidadeKg);
            this.panel6.Controls.Add(this.TxbQuantidade);
            this.panel6.Controls.Add(this.TxbPrecoTotal);
            this.panel6.Controls.Add(this.TxbTotalVenda);
            this.panel6.Controls.Add(this.BtnNovaVenda);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1159, 705);
            this.panel6.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "VALOR UNIDADE/Kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TOTAL PRODUTO: ";
            // 
            // TxbUnidadeKg
            // 
            this.TxbUnidadeKg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_venda", true));
            this.TxbUnidadeKg.Location = new System.Drawing.Point(288, 155);
            this.TxbUnidadeKg.Multiline = true;
            this.TxbUnidadeKg.Name = "TxbUnidadeKg";
            this.TxbUnidadeKg.ReadOnly = true;
            this.TxbUnidadeKg.Size = new System.Drawing.Size(98, 30);
            this.TxbUnidadeKg.TabIndex = 15;
            // 
            // TxbPrecoTotal
            // 
            this.TxbPrecoTotal.Location = new System.Drawing.Point(288, 227);
            this.TxbPrecoTotal.Multiline = true;
            this.TxbPrecoTotal.Name = "TxbPrecoTotal";
            this.TxbPrecoTotal.ReadOnly = true;
            this.TxbPrecoTotal.Size = new System.Drawing.Size(98, 30);
            this.TxbPrecoTotal.TabIndex = 14;
            // 
            // TxbTotalVenda
            // 
            this.TxbTotalVenda.Location = new System.Drawing.Point(272, 319);
            this.TxbTotalVenda.Multiline = true;
            this.TxbTotalVenda.Name = "TxbTotalVenda";
            this.TxbTotalVenda.ReadOnly = true;
            this.TxbTotalVenda.Size = new System.Drawing.Size(135, 28);
            this.TxbTotalVenda.TabIndex = 3;
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(232, 395);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(175, 69);
            this.BtnNovaVenda.TabIndex = 4;
            this.BtnNovaVenda.Text = "NOVA VENDA";
            this.BtnNovaVenda.UseSelectable = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOTAL: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1154, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 707);
            this.panel5.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn,
            this.datavendaDataGridViewTextBoxColumn,
            this.valorungDataGridViewTextBoxColumn,
            this.fkvendausuarioDataGridViewTextBoxColumn,
            this.codvendaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vendaBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(546, 707);
            this.dataGridView3.TabIndex = 1;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "IdVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "IdVenda";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "PRODUTO";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            this.quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn1.HeaderText = "QUANTIDADE";
            this.quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // datavendaDataGridViewTextBoxColumn
            // 
            this.datavendaDataGridViewTextBoxColumn.DataPropertyName = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.HeaderText = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.Name = "datavendaDataGridViewTextBoxColumn";
            this.datavendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorungDataGridViewTextBoxColumn
            // 
            this.valorungDataGridViewTextBoxColumn.DataPropertyName = "valor_un_g";
            this.valorungDataGridViewTextBoxColumn.HeaderText = "valor_un_g";
            this.valorungDataGridViewTextBoxColumn.Name = "valorungDataGridViewTextBoxColumn";
            this.valorungDataGridViewTextBoxColumn.Visible = false;
            // 
            // fkvendausuarioDataGridViewTextBoxColumn
            // 
            this.fkvendausuarioDataGridViewTextBoxColumn.DataPropertyName = "fk_venda_usuario";
            this.fkvendausuarioDataGridViewTextBoxColumn.HeaderText = "fk_venda_usuario";
            this.fkvendausuarioDataGridViewTextBoxColumn.Name = "fkvendausuarioDataGridViewTextBoxColumn";
            this.fkvendausuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // codvendaDataGridViewTextBoxColumn
            // 
            this.codvendaDataGridViewTextBoxColumn.DataPropertyName = "cod_venda";
            this.codvendaDataGridViewTextBoxColumn.HeaderText = "cod_venda";
            this.codvendaDataGridViewTextBoxColumn.Name = "codvendaDataGridViewTextBoxColumn";
            this.codvendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 707);
            this.dataGridView2.TabIndex = 0;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegVendas";
            this.Text = "frmRegVendas";
            this.Load += new System.EventHandler(this.FrmRegVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxbProduto;
        private System.Windows.Forms.TextBox TxbIdVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton BtnRemoverItem;
        private MetroFramework.Controls.MetroButton BtnAdicionarItem;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton BtnNovaVenda;
        private System.Windows.Forms.TextBox TxbTotalVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbQuantidade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBTCCDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox TxbPreco;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroButton BtnCancelar;
        private System.Windows.Forms.TextBox TxbPrecoTotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TxbUnidadeKg;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DBTCCDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemlucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkprodutoidFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkvendausuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codvendaDataGridViewTextBoxColumn;
    }
}