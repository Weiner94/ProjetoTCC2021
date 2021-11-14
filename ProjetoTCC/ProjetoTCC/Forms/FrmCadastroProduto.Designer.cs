
namespace ProjetoTCC.Forms
{
    partial class frmCadastroProduto
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
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalvar = new MetroFramework.Controls.MetroButton();
            this.BtnNovo = new MetroFramework.Controls.MetroButton();
            this.BtnSair = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemlucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TxbQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbPrecoVenda = new System.Windows.Forms.TextBox();
            this.TxbPrecoCompra = new System.Windows.Forms.TextBox();
            this.TxbProduto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDeletar = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.produtoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.ProdutoTableAdapter();
            this.fornecedorTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.FornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "CADASTRAR PRODUTO";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvar.Location = new System.Drawing.Point(418, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseSelectable = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNovo.Location = new System.Drawing.Point(233, 5);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 1;
            this.BtnNovo.Text = "NOVO ";
            this.BtnNovo.UseSelectable = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSair.Location = new System.Drawing.Point(136, 5);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseSelectable = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(559, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 461);
            this.dataGridView1.TabIndex = 11;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precocompraDataGridViewTextBoxColumn
            // 
            this.precocompraDataGridViewTextBoxColumn.DataPropertyName = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.HeaderText = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.Name = "precocompraDataGridViewTextBoxColumn";
            // 
            // precovendaDataGridViewTextBoxColumn
            // 
            this.precovendaDataGridViewTextBoxColumn.DataPropertyName = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.HeaderText = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.Name = "precovendaDataGridViewTextBoxColumn";
            // 
            // porcentagemlucroDataGridViewTextBoxColumn
            // 
            this.porcentagemlucroDataGridViewTextBoxColumn.DataPropertyName = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.HeaderText = "porcentagem_lucro";
            this.porcentagemlucroDataGridViewTextBoxColumn.Name = "porcentagemlucroDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // fkprodutoidFornecedorDataGridViewTextBoxColumn
            // 
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.DataPropertyName = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.HeaderText = "fk_produto_idFornecedor";
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn.Name = "fkprodutoidFornecedorDataGridViewTextBoxColumn";
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ComboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxbQuantidade);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxbPorcentagemLucro);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TxbPrecoVenda);
            this.panel3.Controls.Add(this.TxbPrecoCompra);
            this.panel3.Controls.Add(this.TxbProduto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 461);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "FORNECEDOR";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "fk_produto_idFornecedor", true));
            this.ComboBox1.DataSource = this.fornecedorBindingSource;
            this.ComboBox1.DisplayMember = "nome_fornecedor";
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(253, 383);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(188, 21);
            this.ComboBox1.TabIndex = 25;
            this.ComboBox1.ValueMember = "IdFornecedor";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "QUANTIDADE";
            // 
            // TxbQuantidade
            // 
            this.TxbQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "quantidade", true));
            this.TxbQuantidade.Location = new System.Drawing.Point(202, 328);
            this.TxbQuantidade.Name = "TxbQuantidade";
            this.TxbQuantidade.Size = new System.Drawing.Size(308, 20);
            this.TxbQuantidade.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "PORCENTATGEM";
            // 
            // TxbPorcentagemLucro
            // 
            this.TxbPorcentagemLucro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "porcentagem_lucro", true));
            this.TxbPorcentagemLucro.Location = new System.Drawing.Point(202, 268);
            this.TxbPorcentagemLucro.Name = "TxbPorcentagemLucro";
            this.TxbPorcentagemLucro.Size = new System.Drawing.Size(308, 20);
            this.TxbPorcentagemLucro.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "PRECO VENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "PRECO COMPRA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PRODUTO";
            // 
            // TxbPrecoVenda
            // 
            this.TxbPrecoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_venda", true));
            this.TxbPrecoVenda.Location = new System.Drawing.Point(202, 206);
            this.TxbPrecoVenda.Name = "TxbPrecoVenda";
            this.TxbPrecoVenda.Size = new System.Drawing.Size(308, 20);
            this.TxbPrecoVenda.TabIndex = 15;
            // 
            // TxbPrecoCompra
            // 
            this.TxbPrecoCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_compra", true));
            this.TxbPrecoCompra.Location = new System.Drawing.Point(202, 142);
            this.TxbPrecoCompra.Name = "TxbPrecoCompra";
            this.TxbPrecoCompra.Size = new System.Drawing.Size(308, 20);
            this.TxbPrecoCompra.TabIndex = 14;
            // 
            // TxbProduto
            // 
            this.TxbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.TxbProduto.Location = new System.Drawing.Point(202, 83);
            this.TxbProduto.Name = "TxbProduto";
            this.TxbProduto.Size = new System.Drawing.Size(308, 20);
            this.TxbProduto.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDeletar);
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Controls.Add(this.BtnNovo);
            this.panel2.Controls.Add(this.BtnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 34);
            this.panel2.TabIndex = 10;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeletar.Location = new System.Drawing.Point(326, 5);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 3;
            this.BtnDeletar.Text = "DELETAR";
            this.BtnDeletar.UseSelectable = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 80);
            this.panel1.TabIndex = 9;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroProduto";
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton BtnSalvar;
        private MetroFramework.Controls.MetroButton BtnNovo;
        private MetroFramework.Controls.MetroButton BtnSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBTCCDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemlucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkprodutoidFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbPrecoVenda;
        private System.Windows.Forms.TextBox TxbPrecoCompra;
        private System.Windows.Forms.TextBox TxbProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbPorcentagemLucro;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private DBTCCDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private MetroFramework.Controls.MetroButton BtnDeletar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox1;
    }
}