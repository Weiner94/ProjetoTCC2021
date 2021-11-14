
namespace ProjetoTCC.Forms
{
    partial class FrmTelaDemanda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GraficoDemanda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataGridProduto = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemlucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxbProdutoSelecionado = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.CbxFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxbIdFornecedor = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.ProdutoTableAdapter();
            this.fornecedorTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.FornecedorTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoDemanda)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 63);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEMANDA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 866);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1700, 34);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GraficoDemanda);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 803);
            this.panel2.TabIndex = 8;
            // 
            // GraficoDemanda
            // 
            this.GraficoDemanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.GraficoDemanda.ChartAreas.Add(chartArea1);
            this.GraficoDemanda.Location = new System.Drawing.Point(553, 116);
            this.GraficoDemanda.Name = "GraficoDemanda";
            this.GraficoDemanda.Size = new System.Drawing.Size(1123, 580);
            this.GraficoDemanda.TabIndex = 2;
            this.GraficoDemanda.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.DataGridProduto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 737);
            this.panel5.TabIndex = 1;
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.AllowUserToAddRows = false;
            this.DataGridProduto.AllowUserToDeleteRows = false;
            this.DataGridProduto.AllowUserToOrderColumns = true;
            this.DataGridProduto.AutoGenerateColumns = false;
            this.DataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precocompraDataGridViewTextBoxColumn,
            this.precovendaDataGridViewTextBoxColumn,
            this.porcentagemlucroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.fkprodutoidFornecedorDataGridViewTextBoxColumn});
            this.DataGridProduto.DataSource = this.produtoBindingSource;
            this.DataGridProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridProduto.Location = new System.Drawing.Point(0, 0);
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.ReadOnly = true;
            this.DataGridProduto.Size = new System.Drawing.Size(547, 737);
            this.DataGridProduto.TabIndex = 0;
            this.DataGridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProduto_CellContentClick);
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
            this.precocompraDataGridViewTextBoxColumn.HeaderText = "preco_compra";
            this.precocompraDataGridViewTextBoxColumn.Name = "precocompraDataGridViewTextBoxColumn";
            this.precocompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precocompraDataGridViewTextBoxColumn.Visible = false;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.TxbProdutoSelecionado);
            this.panel4.Controls.Add(this.BtnLimpar);
            this.panel4.Controls.Add(this.CbxFornecedor);
            this.panel4.Controls.Add(this.TxbIdFornecedor);
            this.panel4.Controls.Add(this.BtnSair);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.BtnCalcular);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1700, 66);
            this.panel4.TabIndex = 0;
            // 
            // TxbProdutoSelecionado
            // 
            this.TxbProdutoSelecionado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.TxbProdutoSelecionado.Location = new System.Drawing.Point(189, 24);
            this.TxbProdutoSelecionado.Name = "TxbProdutoSelecionado";
            this.TxbProdutoSelecionado.Size = new System.Drawing.Size(480, 20);
            this.TxbProdutoSelecionado.TabIndex = 3;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(1257, 11);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(114, 46);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "LIMPAR FILTROS";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // CbxFornecedor
            // 
            this.CbxFornecedor.DataSource = this.fornecedorBindingSource;
            this.CbxFornecedor.DisplayMember = "nome_fornecedor";
            this.CbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxFornecedor.FormattingEnabled = true;
            this.CbxFornecedor.Location = new System.Drawing.Point(797, 25);
            this.CbxFornecedor.Name = "CbxFornecedor";
            this.CbxFornecedor.Size = new System.Drawing.Size(156, 21);
            this.CbxFornecedor.TabIndex = 10;
            this.CbxFornecedor.SelectedIndexChanged += new System.EventHandler(this.CbxFornecedor_SelectedIndexChanged);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // TxbIdFornecedor
            // 
            this.TxbIdFornecedor.Location = new System.Drawing.Point(969, 26);
            this.TxbIdFornecedor.Name = "TxbIdFornecedor";
            this.TxbIdFornecedor.ReadOnly = true;
            this.TxbIdFornecedor.Size = new System.Drawing.Size(55, 20);
            this.TxbIdFornecedor.TabIndex = 9;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(1574, 11);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(114, 46);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FORNECEDOR: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUTO SELECIONADO: ";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(1415, 11);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(114, 46);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "CALCULAR DEMANDA";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTelaDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaDemanda";
            this.Text = "FrmTelaDemanda";
            this.Load += new System.EventHandler(this.FrmTelaDemanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoDemanda)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView DataGridProduto;
        private System.Windows.Forms.Panel panel4;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBTCCDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoDemanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private DBTCCDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        public System.Windows.Forms.TextBox TxbIdFornecedor;
        private System.Windows.Forms.ComboBox CbxFornecedor;
        private System.Windows.Forms.Button BtnLimpar;
        public System.Windows.Forms.TextBox TxbProdutoSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemlucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkprodutoidFornecedorDataGridViewTextBoxColumn;
    }
}