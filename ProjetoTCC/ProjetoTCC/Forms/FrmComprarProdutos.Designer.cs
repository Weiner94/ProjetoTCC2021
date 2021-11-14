
namespace ProjetoTCC.Forms
{
    partial class frmComprarProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNemuPP = new System.Windows.Forms.Panel();
            this.BtnCancelarPedido = new System.Windows.Forms.Button();
            this.BtnFinalizarPedido = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodPedido = new System.Windows.Forms.TextBox();
            this.TxbIdFornecededor = new System.Windows.Forms.TextBox();
            this.CbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.BtnNovoPedido = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.PnlCompProduto = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbTotalVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbTotalProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlProdutosPedidos = new System.Windows.Forms.Panel();
            this.dataGridViewRPP = new System.Windows.Forms.DataGridView();
            this.PnlProdutos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemlucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.ProdutoTableAdapter();
            this.fornecedorTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.FornecedorTableAdapter();
            this.relacaoPedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacao_Pedido_ProdutoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.Relacao_Pedido_ProdutoTableAdapter();
            this.panel1.SuspendLayout();
            this.PnlNemuPP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            this.PnlCompProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.PnlProdutosPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRPP)).BeginInit();
            this.PnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoPedidoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 80);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(415, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "COMPRAR PRODUTOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 866);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 34);
            this.panel2.TabIndex = 1;
            // 
            // PnlNemuPP
            // 
            this.PnlNemuPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNemuPP.Controls.Add(this.BtnCancelarPedido);
            this.PnlNemuPP.Controls.Add(this.BtnFinalizarPedido);
            this.PnlNemuPP.Controls.Add(this.label8);
            this.PnlNemuPP.Controls.Add(this.label7);
            this.PnlNemuPP.Controls.Add(this.label1);
            this.PnlNemuPP.Controls.Add(this.CodPedido);
            this.PnlNemuPP.Controls.Add(this.TxbIdFornecededor);
            this.PnlNemuPP.Controls.Add(this.CbFornecedor);
            this.PnlNemuPP.Controls.Add(this.BtnNovoPedido);
            this.PnlNemuPP.Controls.Add(this.BtnRemover);
            this.PnlNemuPP.Controls.Add(this.BtnAdicionar);
            this.PnlNemuPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNemuPP.Location = new System.Drawing.Point(0, 80);
            this.PnlNemuPP.Name = "PnlNemuPP";
            this.PnlNemuPP.Size = new System.Drawing.Size(1700, 64);
            this.PnlNemuPP.TabIndex = 2;
            // 
            // BtnCancelarPedido
            // 
            this.BtnCancelarPedido.Location = new System.Drawing.Point(1204, 11);
            this.BtnCancelarPedido.Name = "BtnCancelarPedido";
            this.BtnCancelarPedido.Size = new System.Drawing.Size(108, 37);
            this.BtnCancelarPedido.TabIndex = 10;
            this.BtnCancelarPedido.Text = "CANCELAR PEDIDO";
            this.BtnCancelarPedido.UseVisualStyleBackColor = true;
            this.BtnCancelarPedido.Click += new System.EventHandler(this.BtnCancelarPedido_Click);
            // 
            // BtnFinalizarPedido
            // 
            this.BtnFinalizarPedido.Location = new System.Drawing.Point(1412, 12);
            this.BtnFinalizarPedido.Name = "BtnFinalizarPedido";
            this.BtnFinalizarPedido.Size = new System.Drawing.Size(118, 38);
            this.BtnFinalizarPedido.TabIndex = 9;
            this.BtnFinalizarPedido.Text = "FINALIZAR PEDIDO";
            this.BtnFinalizarPedido.UseVisualStyleBackColor = true;
            this.BtnFinalizarPedido.Click += new System.EventHandler(this.BtnFinalizarPedido_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "CÓDIGO DO FORNECEDOR: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "SELECIONE UM FORNECEDOR: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÓDIGO DO PEDIDO: ";
            // 
            // CodPedido
            // 
            this.CodPedido.Location = new System.Drawing.Point(538, 27);
            this.CodPedido.Name = "CodPedido";
            this.CodPedido.Size = new System.Drawing.Size(65, 20);
            this.CodPedido.TabIndex = 5;
            this.CodPedido.TextChanged += new System.EventHandler(this.CodPedido_TextChanged);
            // 
            // TxbIdFornecededor
            // 
            this.TxbIdFornecededor.Location = new System.Drawing.Point(353, 27);
            this.TxbIdFornecededor.Name = "TxbIdFornecededor";
            this.TxbIdFornecededor.ReadOnly = true;
            this.TxbIdFornecededor.Size = new System.Drawing.Size(58, 20);
            this.TxbIdFornecededor.TabIndex = 4;
            this.TxbIdFornecededor.TextChanged += new System.EventHandler(this.TxbIdFornecededor_TextChanged);
            // 
            // CbFornecedor
            // 
            this.CbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "IdFornecedor", true));
            this.CbFornecedor.DataSource = this.fornecedorBindingSource;
            this.CbFornecedor.DisplayMember = "nome_fornecedor";
            this.CbFornecedor.FormattingEnabled = true;
            this.CbFornecedor.Location = new System.Drawing.Point(14, 28);
            this.CbFornecedor.Name = "CbFornecedor";
            this.CbFornecedor.Size = new System.Drawing.Size(180, 21);
            this.CbFornecedor.TabIndex = 3;
            this.CbFornecedor.ValueMember = "IdFornecedor";
            this.CbFornecedor.SelectedIndexChanged += new System.EventHandler(this.CbFornecedor_SelectedIndexChanged);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // dBTCCDataSet
            // 
            this.dBTCCDataSet.DataSetName = "DBTCCDataSet";
            this.dBTCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnNovoPedido
            // 
            this.BtnNovoPedido.Location = new System.Drawing.Point(1008, 12);
            this.BtnNovoPedido.Name = "BtnNovoPedido";
            this.BtnNovoPedido.Size = new System.Drawing.Size(108, 38);
            this.BtnNovoPedido.TabIndex = 2;
            this.BtnNovoPedido.Text = "NOVO PEDIDO";
            this.BtnNovoPedido.UseVisualStyleBackColor = true;
            this.BtnNovoPedido.Click += new System.EventHandler(this.BtnNovoPedido_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(850, 10);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(89, 38);
            this.BtnRemover.TabIndex = 1;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(711, 12);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(88, 38);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "ADICIONAR";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // PnlCompProduto
            // 
            this.PnlCompProduto.Controls.Add(this.label6);
            this.PnlCompProduto.Controls.Add(this.TxbTotalVenda);
            this.PnlCompProduto.Controls.Add(this.label5);
            this.PnlCompProduto.Controls.Add(this.TxbTotalProduto);
            this.PnlCompProduto.Controls.Add(this.label4);
            this.PnlCompProduto.Controls.Add(this.label3);
            this.PnlCompProduto.Controls.Add(this.txbQuantidadeProduto);
            this.PnlCompProduto.Controls.Add(this.txbPreco);
            this.PnlCompProduto.Controls.Add(this.txbProduto);
            this.PnlCompProduto.Controls.Add(this.label2);
            this.PnlCompProduto.Controls.Add(this.PnlProdutosPedidos);
            this.PnlCompProduto.Controls.Add(this.PnlProdutos);
            this.PnlCompProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCompProduto.Location = new System.Drawing.Point(0, 144);
            this.PnlCompProduto.Name = "PnlCompProduto";
            this.PnlCompProduto.Size = new System.Drawing.Size(1700, 722);
            this.PnlCompProduto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "VALOR TOTAL DO PEDIDO:";
            // 
            // TxbTotalVenda
            // 
            this.TxbTotalVenda.Location = new System.Drawing.Point(873, 423);
            this.TxbTotalVenda.Multiline = true;
            this.TxbTotalVenda.Name = "TxbTotalVenda";
            this.TxbTotalVenda.ReadOnly = true;
            this.TxbTotalVenda.Size = new System.Drawing.Size(160, 30);
            this.TxbTotalVenda.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL: ";
            // 
            // TxbTotalProduto
            // 
            this.TxbTotalProduto.Location = new System.Drawing.Point(873, 351);
            this.TxbTotalProduto.Multiline = true;
            this.TxbTotalProduto.Name = "TxbTotalProduto";
            this.TxbTotalProduto.ReadOnly = true;
            this.TxbTotalProduto.Size = new System.Drawing.Size(160, 30);
            this.TxbTotalProduto.TabIndex = 8;
            this.TxbTotalProduto.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "QUANTIDADE A COMPRAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PREÇO:";
            // 
            // txbQuantidadeProduto
            // 
            this.txbQuantidadeProduto.Location = new System.Drawing.Point(873, 277);
            this.txbQuantidadeProduto.Multiline = true;
            this.txbQuantidadeProduto.Name = "txbQuantidadeProduto";
            this.txbQuantidadeProduto.Size = new System.Drawing.Size(160, 30);
            this.txbQuantidadeProduto.TabIndex = 5;
            this.txbQuantidadeProduto.TextChanged += new System.EventHandler(this.TxbQuantidadeProduto_TextChanged);
            // 
            // txbPreco
            // 
            this.txbPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_compra", true));
            this.txbPreco.Location = new System.Drawing.Point(873, 204);
            this.txbPreco.Multiline = true;
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.ReadOnly = true;
            this.txbPreco.Size = new System.Drawing.Size(160, 30);
            this.txbPreco.TabIndex = 4;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // txbProduto
            // 
            this.txbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.txbProduto.Location = new System.Drawing.Point(812, 138);
            this.txbProduto.Multiline = true;
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(289, 30);
            this.txbProduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUTO:";
            // 
            // PnlProdutosPedidos
            // 
            this.PnlProdutosPedidos.Controls.Add(this.dataGridViewRPP);
            this.PnlProdutosPedidos.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlProdutosPedidos.Location = new System.Drawing.Point(1166, 0);
            this.PnlProdutosPedidos.Name = "PnlProdutosPedidos";
            this.PnlProdutosPedidos.Size = new System.Drawing.Size(534, 722);
            this.PnlProdutosPedidos.TabIndex = 1;
            // 
            // dataGridViewRPP
            // 
            this.dataGridViewRPP.AllowUserToAddRows = false;
            this.dataGridViewRPP.AllowUserToDeleteRows = false;
            this.dataGridViewRPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRPP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRPP.Name = "dataGridViewRPP";
            this.dataGridViewRPP.ReadOnly = true;
            this.dataGridViewRPP.Size = new System.Drawing.Size(534, 722);
            this.dataGridViewRPP.TabIndex = 0;
            this.dataGridViewRPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRPP_CellClick);
          
            // 
            // PnlProdutos
            // 
            this.PnlProdutos.AutoScroll = true;
            this.PnlProdutos.Controls.Add(this.dataGridView1);
            this.PnlProdutos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlProdutos.Location = new System.Drawing.Point(0, 0);
            this.PnlProdutos.Name = "PnlProdutos";
            this.PnlProdutos.Size = new System.Drawing.Size(646, 722);
            this.PnlProdutos.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 722);
            this.dataGridView1.TabIndex = 0;
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
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 400;
            // 
            // precocompraDataGridViewTextBoxColumn
            // 
            this.precocompraDataGridViewTextBoxColumn.DataPropertyName = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.HeaderText = "PREÇO";
            this.precocompraDataGridViewTextBoxColumn.Name = "precocompraDataGridViewTextBoxColumn";
            this.precocompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precovendaDataGridViewTextBoxColumn
            // 
            this.precovendaDataGridViewTextBoxColumn.DataPropertyName = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.HeaderText = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.Name = "precovendaDataGridViewTextBoxColumn";
            this.precovendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precovendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // porcentagemlucroDataGridViewTextBoxColumn
            // 
            this.porcentagemlucroDataGridViewTextBoxColumn.DataPropertyName = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.HeaderText = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.Name = "porcentagemlucroDataGridViewTextBoxColumn";
            this.porcentagemlucroDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentagemlucroDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE EM ESTOQUE";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkprodutoidFornecedorDataGridViewTextBoxColumn
            // 
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.DataPropertyName = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.HeaderText = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.Name = "fkprodutoidFornecedorDataGridViewTextBoxColumn";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // relacaoPedidoProdutoBindingSource
            // 
            this.relacaoPedidoProdutoBindingSource.DataMember = "Relacao_Pedido_Produto";
            this.relacaoPedidoProdutoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // relacao_Pedido_ProdutoTableAdapter
            // 
            this.relacao_Pedido_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // frmComprarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.PnlCompProduto);
            this.Controls.Add(this.PnlNemuPP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComprarProdutos";
            this.Text = "frmComprarProdutos";
            this.Load += new System.EventHandler(this.frmComprarProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlNemuPP.ResumeLayout(false);
            this.PnlNemuPP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            this.PnlCompProduto.ResumeLayout(false);
            this.PnlCompProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.PnlProdutosPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRPP)).EndInit();
            this.PnlProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoPedidoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNemuPP;
        private System.Windows.Forms.Panel PnlCompProduto;
        private System.Windows.Forms.Button BtnNovoPedido;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Panel PnlProdutosPedidos;
        private System.Windows.Forms.Panel PnlProdutos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBTCCDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.ComboBox CbFornecedor;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private DBTCCDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.TextBox TxbIdFornecededor;
        private System.Windows.Forms.DataGridView dataGridViewRPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodPedido;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbQuantidadeProduto;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbTotalProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbTotalVenda;
        private System.Windows.Forms.BindingSource relacaoPedidoProdutoBindingSource;
        private DBTCCDataSetTableAdapters.Relacao_Pedido_ProdutoTableAdapter relacao_Pedido_ProdutoTableAdapter;
        private System.Windows.Forms.Button BtnFinalizarPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelarPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemlucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkprodutoidFornecedorDataGridViewTextBoxColumn;
    }
}