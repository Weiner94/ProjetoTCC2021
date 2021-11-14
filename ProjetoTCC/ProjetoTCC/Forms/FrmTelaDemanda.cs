using System;
using System.Activities.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using ProjetoTCC.Connector;
using ProjetoTCC.Controlers;
using ProjetoTCC.Forms;

namespace ProjetoTCC.Forms
{
    public partial class FrmTelaDemanda : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Conector con = new Conector();
        DAOConnector DAO = new DAOConnector();
        Controle controle = new Controle();
        DataTable dt;
        ModeloAR modelo = new ModeloAR();
        CalculoMatriz calculoMatriz = new CalculoMatriz();

        int TamanhoImput = 4;
        int TamanhoOutput = 0;
        int delay = 2;

        public FrmTelaDemanda()
        {
            InitializeComponent();

        }

        private void FrmTelaDemanda_Load(object sender, EventArgs e)
        {
            
            CbxFornecedor.Text = null;
            TxbProdutoSelecionado.Text = null;
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dBTCCDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário. 
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);

        }



        public void PreencherGraficoTeste()
        {
            double[] ResultadoPrevisao = new double[] { 12, 10, 5, 9, 2, 7, 4, 2 };
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Black;
            GraficoDemanda.Titles.Add(title);

            GraficoDemanda.Series.Add("vendas");
            GraficoDemanda.Series["vendas"].LegendText = "Vendas";

            GraficoDemanda.Series["vendas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            GraficoDemanda.Series["vendas"].BorderWidth = 2;
           


        }

        public void PreencherGraficoDemanda(string produto, float[] previsao)
        {


            cmd.CommandText = @"select count(*) as QtdeLinhas from(select data_venda, SUM(quantidade) as quantidade from dbo.Venda where produto = @produto group by data_venda) as quantidade;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Connection = con.Conectar();
            int TamanhoDados = (int)cmd.ExecuteScalar();
            con.Desconectar();
            double[] QUANTIDADE = new double[TamanhoDados];
            DateTime[] DATAVENDA = new DateTime[TamanhoDados];

            //double[] ResultadoPrevisao = new double[] { 12, 10, 5, 9, 2, 7, 4, 2 };// dados de teste
            float[] ResultadoPrevisao = previsao;
            DateTime[] dataResultado = new DateTime[previsao.Length];

            Console.WriteLine("PREENCHER GRAFICO - PRODUTO RECEBIDO:  " + produto);
            if (!(string.IsNullOrEmpty(produto)))
            {
                GraficoDemanda.Series.Clear();
                try
                {
                    //DADOS DE VENDAS ANTERIORES
                    con.Conectar();
                    cmd.CommandText = @"select data_venda as DATA, sum(quantidade) as QUANTIDADE_VENDIDA from dbo.Venda where produto = @produto group by data_venda;";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@produto", produto);
                    cmd.Connection = con.Conectar();
                    dr = cmd.ExecuteReader();
                    GraficoDemanda.Series.Add("VENDAS");
                    GraficoDemanda.Series["VENDAS"].LegendText = "VENDAS";
                    //GraficoDemanda.Series["DEMANDA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                    GraficoDemanda.Series["VENDAS"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GraficoDemanda.Series["VENDAS"].BorderWidth = 4;
                    int i = 0;
                    while (dr.Read())
                    {
                        string quantidade = dr["QUANTIDADE_VENDIDA"].ToString();
                        string data = dr["DATA"].ToString(); ;
                        QUANTIDADE[i] = (Double.Parse(quantidade));
                        DATAVENDA[i] = (Convert.ToDateTime(data));
                        i++;
                    }
                    Console.WriteLine("datas vendas: ");
                    for (i = 0; i < QUANTIDADE.Length; i++)
                    {
                        Console.WriteLine(QUANTIDADE[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (i = 0; i < DATAVENDA.Length; i++)
                    {
                        Console.WriteLine(DATAVENDA[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    GraficoDemanda.Series["VENDAS"].Points.DataBindXY(DATAVENDA, QUANTIDADE);
                    dr.Close();
                    con.Desconectar();                    
                    Console.WriteLine("datas Previsões: ");
                    for (i = 0; i < ResultadoPrevisao.Length; i++)
                    {                       
                        dataResultado[i] = DATAVENDA[DATAVENDA.Length-1].AddDays((i+1));
                        Console.WriteLine(dataResultado[i]);
                    }
                    GraficoDemanda.Series.Add("Resultado");
                    GraficoDemanda.Series["Resultado"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GraficoDemanda.Series["Resultado"].BorderWidth = 5;
                    GraficoDemanda.Series["Resultado"].LegendText = "Resultado";
                    GraficoDemanda.Series["Resultado"].Points.DataBindXY(dataResultado, ResultadoPrevisao);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                finally
                {
                    con.Desconectar(); // Fecha a conexão com o BD
                    cmd.Parameters.Clear();
                }
            }
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double[] resultadoPrevisao = new double[TamanhoImput];
            float[] resultadoPrevisaoGrafico = new float[delay + 1];
            if ( String.IsNullOrEmpty(TxbIdFornecedor.Text) || Int32.Parse(TxbIdFornecedor.Text)<=0)
            {
                MessageBox.Show("POR FAVOR SELECIONE UM PRODUTO PARA A PREVISÃO DE DEMANDA");
                Console.WriteLine("POR FAVOR SELECIONE UM PRODUTO PARA A PREVISÃO DE DEMANDA");
            }
            else if(!(String.IsNullOrEmpty(TxbProdutoSelecionado.Text)) && !(String.IsNullOrEmpty(TxbIdFornecedor.Text))&& Int32.Parse(TxbIdFornecedor.Text) > 0)
            {
               
                if ((DAO.VerificaThetaProduto(DAO.IdProdutoCorrente(TxbProdutoSelecionado.Text, Convert.ToInt32(TxbIdFornecedor.Text)))) == true || (DAO.VerificaDadoK(DAO.IdProdutoCorrente(TxbProdutoSelecionado.Text, Convert.ToInt32(TxbIdFornecedor.Text)))) == true)
                {                                      
                    resultadoPrevisao = controle.AtualizaTheta(Convert.ToInt32(TxbIdFornecedor.Text), TxbProdutoSelecionado.Text, TamanhoImput, TamanhoOutput, delay);
                    for (int i = 0; i < resultadoPrevisaoGrafico.Length; i++)
                    {
                        Console.WriteLine("indice >>>>" + i);
                        if (resultadoPrevisao[i] <= 0)
                        {
                            resultadoPrevisaoGrafico[i] = 0;
                        }
                        else
                        {
                            resultadoPrevisaoGrafico[i] = Convert.ToSingle(resultadoPrevisao[i]);
                        }
                    }
                    Array.Reverse(resultadoPrevisaoGrafico);
                    for (int i = 0; i < resultadoPrevisaoGrafico.Length; i++)
                    {
                        Console.WriteLine(" result " + resultadoPrevisaoGrafico[i]);
                    }
                }
                else
                {
                   
                    resultadoPrevisao = controle.PrimeiroTheta(Convert.ToInt32(TxbIdFornecedor.Text), TxbProdutoSelecionado.Text, TamanhoImput, TamanhoOutput, delay);
                   
                    for (int i = 0; i < resultadoPrevisao.Length; i++)
                    {
                        Console.WriteLine("  | " + resultadoPrevisao[i]);
                    }

                    for (int i = 0; i < 1; i++)
                    {
                        if (resultadoPrevisao[i] <= 0)
                        {
                            resultadoPrevisaoGrafico[i] = 0;                            
                        }
                        else
                        {
                            resultadoPrevisaoGrafico[i] = Convert.ToSingle(resultadoPrevisao[i]);
                        }
                    }
                    
                    for (int i = 0; i < resultadoPrevisaoGrafico.Length; i++)
                    {
                        Console.WriteLine(" result " + resultadoPrevisaoGrafico[i]);
                    }                    
                    Console.WriteLine();
                    Console.WriteLine("FIM PRIMEIRO THETA");
                }
                GraficoDemanda.Series.Clear();
                PreencherGraficoDemanda(Convert.ToString(TxbProdutoSelecionado.Text), resultadoPrevisaoGrafico);
            }

        }

        private void TxbProduto_TextChanged(object sender, EventArgs e)
        {
            cmd.Connection = con.Conectar();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select *  from dbo.Produto", cmd.Connection))
                {
                    dt = new System.Data.DataTable("dbo.Produto");
                    da.Fill(dt);
                    DataGridProduto.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("nome like '%{0}%'", TxbProduto.Text);
            DataGridProduto.DataSource = dv.ToTable();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxbIdFornecedor.Text = null;
            CbxFornecedor.Text = null;
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            TxbIdFornecedor.Text = DataGridProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtoTableAdapter.FillByIdFornecedor(this.dBTCCDataSet.Produto, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxbIdFornecedor.Text, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CbxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxbProdutoSelecionado = null;
            TxbIdFornecedor.Text = DAO.CodFornecedor(CbxFornecedor.Text);
            this.produtoTableAdapter.FillByIdFornecedor(this.dBTCCDataSet.Produto, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxbIdFornecedor.Text, typeof(int))))));          
            TxbProdutoSelecionado = null;
        }




    }
}
