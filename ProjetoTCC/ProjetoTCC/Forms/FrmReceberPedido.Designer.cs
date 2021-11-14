
namespace ProjetoTCC.Forms
{
    partial class FrmReceberPedido
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
            this.relacaoPedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTCCDataSet = new ProjetoTCC.DBTCCDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.ProdutoTableAdapter();
            this.fornecedorTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.FornecedorTableAdapter();
            this.relacao_Pedido_ProdutoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.Relacao_Pedido_ProdutoTableAdapter();
            this.PnlCompProduto = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataGridViewRPP = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbCodPP = new System.Windows.Forms.TextBox();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridViewPP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pedido_ProdutoTableAdapter = new ProjetoTCC.DBTCCDataSetTableAdapters.Pedido_ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoPedidoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.PnlCompProduto.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRPP)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoProdutoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // relacaoPedidoProdutoBindingSource
            // 
            this.relacaoPedidoProdutoBindingSource.DataMember = "Relacao_Pedido_Produto";
            this.relacaoPedidoProdutoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // dBTCCDataSet
            // 
            this.dBTCCDataSet.DataSetName = "DBTCCDataSet";
            this.dBTCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // relacao_Pedido_ProdutoTableAdapter
            // 
            this.relacao_Pedido_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // PnlCompProduto
            // 
            this.PnlCompProduto.Controls.Add(this.panel5);
            this.PnlCompProduto.Controls.Add(this.panel4);
            this.PnlCompProduto.Controls.Add(this.panel3);
            this.PnlCompProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCompProduto.Location = new System.Drawing.Point(0, 68);
            this.PnlCompProduto.Name = "PnlCompProduto";
            this.PnlCompProduto.Size = new System.Drawing.Size(1309, 496);
            this.PnlCompProduto.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DataGridViewRPP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 306);
            this.panel5.TabIndex = 2;
            // 
            // DataGridViewRPP
            // 
            this.DataGridViewRPP.AllowUserToAddRows = false;
            this.DataGridViewRPP.AllowUserToDeleteRows = false;
            this.DataGridViewRPP.AllowUserToOrderColumns = true;
            this.DataGridViewRPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewRPP.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewRPP.Name = "DataGridViewRPP";
            this.DataGridViewRPP.ReadOnly = true;
            this.DataGridViewRPP.Size = new System.Drawing.Size(628, 306);
            this.DataGridViewRPP.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TxbCodPP);
            this.panel4.Controls.Add(this.BtnReceber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 190);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 65);
            this.label6.TabIndex = 10;
            this.label6.Text = "!IMPORTANTE:  OBVERVE CALA ITEM DA LISTA DE PRODUTOS ABAIXO\r\nEM RELAÇÃO AO PEDIDO" +
    " À DIREITA!\r\n\r\nFAVORE CONFERIR SE OS ITENS A RECEBER ESTÃO DE ACORDO COM OS\r\nITE" +
    "S CADASTRADOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL DO PEDIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUANTIDADE DE PRODUTOS: ";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoProdutoBindingSource, "IdPedidoProduto", true));
            this.textBox3.Location = new System.Drawing.Point(187, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // pedidoProdutoBindingSource
            // 
            this.pedidoProdutoBindingSource.DataMember = "Pedido_Produto";
            this.pedidoProdutoBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoProdutoBindingSource, "IdPedidoProduto", true));
            this.textBox2.Location = new System.Drawing.Point(187, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoProdutoBindingSource, "IdPedidoProduto", true));
            this.textBox1.Location = new System.Drawing.Point(470, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTRO POR FORNECEDOR: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDO:";
            // 
            // TxbCodPP
            // 
            this.TxbCodPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoProdutoBindingSource, "IdPedidoProduto", true));
            this.TxbCodPP.Location = new System.Drawing.Point(470, 74);
            this.TxbCodPP.Name = "TxbCodPP";
            this.TxbCodPP.Size = new System.Drawing.Size(100, 20);
            this.TxbCodPP.TabIndex = 1;
            // 
            // BtnReceber
            // 
            this.BtnReceber.Location = new System.Drawing.Point(470, 118);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(118, 52);
            this.BtnReceber.TabIndex = 0;
            this.BtnReceber.Text = "RECEBER";
            this.BtnReceber.UseVisualStyleBackColor = true;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataGridViewPP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(628, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 496);
            this.panel3.TabIndex = 0;
            // 
            // DataGridViewPP
            // 
            this.DataGridViewPP.AllowUserToAddRows = false;
            this.DataGridViewPP.AllowUserToDeleteRows = false;
            this.DataGridViewPP.AllowUserToOrderColumns = true;
            this.DataGridViewPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPP.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewPP.Name = "DataGridViewPP";
            this.DataGridViewPP.ReadOnly = true;
            this.DataGridViewPP.Size = new System.Drawing.Size(681, 496);
            this.DataGridViewPP.TabIndex = 0;
            this.DataGridViewPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPP_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 68);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "RECEBER PEDIDO";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dBTCCDataSet;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(219)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 34);
            this.panel2.TabIndex = 5;
            // 
            // pedido_ProdutoTableAdapter
            // 
            this.pedido_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReceberPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 598);
            this.Controls.Add(this.PnlCompProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReceberPedido";
            this.Text = "FrmReceberPedido";
            this.Load += new System.EventHandler(this.FrmReceberPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relacaoPedidoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.PnlCompProduto.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRPP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoProdutoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource relacaoPedidoProdutoBindingSource;
        private DBTCCDataSet dBTCCDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBTCCDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private DBTCCDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private DBTCCDataSetTableAdapters.Relacao_Pedido_ProdutoTableAdapter relacao_Pedido_ProdutoTableAdapter;
        private System.Windows.Forms.Panel PnlCompProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DataGridViewRPP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGridViewPP;
        private System.Windows.Forms.BindingSource pedidoProdutoBindingSource;
        private DBTCCDataSetTableAdapters.Pedido_ProdutoTableAdapter pedido_ProdutoTableAdapter;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.TextBox TxbCodPP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}