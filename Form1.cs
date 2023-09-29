using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace integraExcel
{
    public partial class frmIntegra : Form
    {
        Excel.Application app = new Excel.Application();
        Workbook pasta;
        Worksheet plan;
        string path = @"C:\Users\hendr\Desktop\Jose Luiz\Aula08\integraExcel\integraExcel\resultado";

        public frmIntegra()
        {
            InitializeComponent();
            CarregarPlanilha();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método não tem código neste momento.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Este método não tem código neste momento.
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            CarregarPlanilha();
        }

        private void CarregarPlanilha()
        {
            lblStatus.Text = "Abrindo planilha de resultado";
            try
            {
                pasta = app.Workbooks.Open(path);
                plan = pasta.Worksheets["plan1"];
                lblStatus.Text = "Carregando receitas";

                // Carga das receitas
                txtFaturamento.Text = plan.Cells[5, 3].Value.ToString("N2");
                lblDev.Text = plan.Cells[6, 3].Value.ToString("N2");
                lblTotrec.Text = plan.Cells[7, 3].Value.ToString("N2");

                lblStatus.Text = "Carregando despesas";
                // Carga das despesas
                txtCom.Text = plan.Cells[10, 3].Value.ToString("N2");
                txtCustoP.Text = plan.Cells[11, 3].Value.ToString("N2");
                lblImposto.Text = plan.Cells[12, 3].Value.ToString("N2");
                txtDespAdm.Text = plan.Cells[13, 3].Value.ToString("N2");
                lblTotDesp.Text = plan.Cells[14, 3].Value.ToString("N2");
                //
                lblStatus.Text = "Carregando resultado";
                //Carga do resultado
                lblResultOper.Text = plan.Cells[16, 3].Value.ToString("N2");
                // Calcula a comissão como 10% do faturamento
                decimal faturamento = Convert.ToDecimal(txtFaturamento.Text);
                decimal comissao = 0.10m * faturamento;
                txtCom.Text = comissao.ToString("N2");
                //Permitir digitação no campo Faturamento

                //txtFaturamento.Enabled = true;

                //lblStatus.Text = "Pronto!!!";

                if (pasta.ReadOnly)
                {
                    txtFaturamento.Enabled = false;
                    btnSalvar.Enabled = false;
                    lblStatus.Text = "Pronto somente para leitura!";
                }
                else
                {
                    txtFaturamento.Enabled = true;
                    btnSalvar .Enabled = true;
                    txtFaturamento.Focus();
                    lblStatus.Text = "Pronto";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar planilha: " + ex.Message);
            }
        }

        private void frmIntegra_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pasta != null)
            {
                pasta.Close(true);
                app.Quit();

                plan = null;
                pasta = null;
                app = null;

                lblStatus.Text = "Pronto";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPlanilha();
        }

        private void SalvarPlanilha()
        {
            lblStatus.Text = "Salvando planilha de resultados. Aguarde!";
            try
            {
                // Receitas
                plan.Cells[5, 3].Value = Convert.ToDecimal("0" + txtFaturamento.Text);
                pasta.Save();
                MessageBox.Show("Planilha foi Salva");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar planilha: " + ex.Message);
            }

            lblStatus.Text = "Pronto!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}


