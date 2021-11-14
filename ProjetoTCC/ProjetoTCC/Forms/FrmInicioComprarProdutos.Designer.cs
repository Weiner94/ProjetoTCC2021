
namespace ProjetoTCC.Forms
{
    partial class FrmInicioComprarProdutos
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
            this.PnlPedidos = new System.Windows.Forms.Panel();
            this.DataGridViewPP = new System.Windows.Forms.DataGridView();
            this.idPedidoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarecebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.pedido_ProdutoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.Pedido_ProdutoTableAdapter();
            this.PnlRPP = new System.Windows.Forms.Panel();
            this.DataGridViewRPP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxbCodPedido = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnNovoPedido = new System.Windows.Forms.Button();
            this.CodPedido = new System.Windows.Forms.TextBox();
            this.PnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            this.PnlRPP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRPP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPedidos
            // 
            this.PnlPedidos.Controls.Add(this.DataGridViewPP);
            this.PnlPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlPedidos.Location = new System.Drawing.Point(0, 0);
            this.PnlPedidos.Name = "PnlPedidos";
            this.PnlPedidos.Size = new System.Drawing.Size(647, 605);
            this.PnlPedidos.TabIndex = 0;
            // 
            // DataGridViewPP
            // 
            this.DataGridViewPP.AllowUserToAddRows = false;
            this.DataGridViewPP.AllowUserToDeleteRows = false;
            this.DataGridViewPP.AutoGenerateColumns = false;
            this.DataGridViewPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoProdutoDataGridViewTextBoxColumn,
            this.datarecebimentoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.datapedidoDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn,
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn,
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn});
            this.DataGridViewPP.DataSource = this.pedidoProdutoBindingSource;
            this.DataGridViewPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPP.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewPP.Name = "DataGridViewPP";
            this.DataGridViewPP.ReadOnly = true;
            this.DataGridViewPP.Size = new System.Drawing.Size(647, 605);
            this.DataGridViewPP.TabIndex = 0;
            this.DataGridViewPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPP_CellContentClick);
            // 
            // idPedidoProdutoDataGridViewTextBoxColumn
            // 
            this.idPedidoProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdPedidoProduto";
            this.idPedidoProdutoDataGridViewTextBoxColumn.HeaderText = "IdPedidoProduto";
            this.idPedidoProdutoDataGridViewTextBoxColumn.Name = "idPedidoProdutoDataGridViewTextBoxColumn";
            this.idPedidoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPedidoProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // datarecebimentoDataGridViewTextBoxColumn
            // 
            this.datarecebimentoDataGridViewTextBoxColumn.DataPropertyName = "data_recebimento";
            this.datarecebimentoDataGridViewTextBoxColumn.HeaderText = "PREVISÃO RECEBIMENTO";
            this.datarecebimentoDataGridViewTextBoxColumn.Name = "datarecebimentoDataGridViewTextBoxColumn";
            this.datarecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO DO PEDIDO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datapedidoDataGridViewTextBoxColumn
            // 
            this.datapedidoDataGridViewTextBoxColumn.DataPropertyName = "data_pedido";
            this.datapedidoDataGridViewTextBoxColumn.HeaderText = "DATA DO PEDIDO";
            this.datapedidoDataGridViewTextBoxColumn.Name = "datapedidoDataGridViewTextBoxColumn";
            this.datapedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "PREVISÃO DE ENTREGA";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKPedidoProdutoUsuarioDataGridViewTextBoxColumn
            // 
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "FKPedidoProdutoUsuario";
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn.HeaderText = "FKPedidoProdutoUsuario";
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn.Name = "fKPedidoProdutoUsuarioDataGridViewTextBoxColumn";
            this.fKPedidoProdutoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKPedidoProdutoFornecedorDataGridViewTextBoxColumn
            // 
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "FKPedidoProdutoFornecedor";
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn.HeaderText = "FKPedidoProdutoFornecedor";
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn.Name = "fKPedidoProdutoFornecedorDataGridViewTextBoxColumn";
            this.fKPedidoProdutoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoProdutoBindingSource
            // 
            this.pedidoProdutoBindingSource.DataMember = "Pedido_Produto";
            this.pedidoProdutoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // dBTCCDataSet
            // 
            this.dBTCCDataSet.DataSetName = "DBTCCDataSet";
            this.dBTCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedido_ProdutoTableAdapter
            // 
            this.pedido_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // PnlRPP
            // 
            this.PnlRPP.Controls.Add(this.DataGridViewRPP);
            this.PnlRPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlRPP.Location = new System.Drawing.Point(647, 0);
            this.PnlRPP.Name = "PnlRPP";
            this.PnlRPP.Size = new System.Drawing.Size(672, 518);
            this.PnlRPP.TabIndex = 6;
            // 
            // DataGridViewRPP
            // 
            this.DataGridViewRPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewRPP.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewRPP.Name = "DataGridViewRPP";
            this.DataGridViewRPP.Size = new System.Drawing.Size(672, 518);
            this.DataGridViewRPP.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxbCodPedido);
            this.panel1.Controls.Add(this.BtnVoltar);
            this.panel1.Controls.Add(this.BtnNovoPedido);
            this.panel1.Controls.Add(this.CodPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(647, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 134);
            this.panel1.TabIndex = 8;
            // 
            // TxbCodPedido
            // 
            this.TxbCodPedido.AutoSize = true;
            this.TxbCodPedido.Location = new System.Drawing.Point(291, 52);
            this.TxbCodPedido.Name = "TxbCodPedido";
            this.TxbCodPedido.Size = new System.Drawing.Size(65, 13);
            this.TxbCodPedido.TabIndex = 9;
            this.TxbCodPedido.Text = "CodPedido: ";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(173, 45);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(112, 46);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnNovoPedido
            // 
            this.BtnNovoPedido.Location = new System.Drawing.Point(21, 45);
            this.BtnNovoPedido.Name = "BtnNovoPedido";
            this.BtnNovoPedido.Size = new System.Drawing.Size(126, 46);
            this.BtnNovoPedido.TabIndex = 7;
            this.BtnNovoPedido.Text = "NOVO PEDIDO";
            this.BtnNovoPedido.UseVisualStyleBackColor = true;
            this.BtnNovoPedido.Click += new System.EventHandler(this.BtnNovoPedido_Click);
            // 
            // CodPedido
            // 
            this.CodPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoProdutoBindingSource, "IdPedidoProduto", true));
            this.CodPedido.Location = new System.Drawing.Point(362, 49);
            this.CodPedido.Name = "CodPedido";
            this.CodPedido.Size = new System.Drawing.Size(100, 20);
            this.CodPedido.TabIndex = 8;
            // 
            // FrmInicioComprarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlRPP);
            this.Controls.Add(this.PnlPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicioComprarProdutos";
            this.Text = "FrmInicioComprarProduto";
            this.Load += new System.EventHandler(this.FrmInicioComprarProdutos_Load);
            this.PnlPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            this.PnlRPP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRPP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPedidos;
        private System.Windows.Forms.DataGridView DataGridViewPP;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.BindingSource pedidoProdutoBindingSource;
        private DBTCCDataSetTableAdapters.Pedido_ProdutoTableAdapter pedido_ProdutoTableAdapter;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKPedidoProdutoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKPedidoProdutoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PnlRPP;
        private System.Windows.Forms.DataGridView DataGridViewRPP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TxbCodPedido;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnNovoPedido;
        private System.Windows.Forms.TextBox CodPedido;
    }
}