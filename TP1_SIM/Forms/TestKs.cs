using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TP1_SIM
{
    public partial class TestKs: Form
    {
        
        public TestKs(DataTable table)
        {
            InitializeComponent();
            gdrAleatorios.DataSource = table;
            //gdrAleatorios.Sort(gdrAleatorios.Columns[2], ListSortDirection.Ascending);
            cmb_Significancia.SelectedIndex = -1;
        }

        private void TestChiCuadrado_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private void calKS(int cantIntervalo, double tamaño)
        {
            DataTable tabla = new DataTable();
            double fe = gdrAleatorios.Rows.Count / cantIntervalo;
            double desde, hasta, KS = 0, ProbO = 0, ProbE = 0, acPO=0, acPE=0, ValAbs=0;

            desde = 0;

            // Nombres de las columnas
            tabla.Columns.Add("Desde");
            tabla.Columns.Add("Hasta");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("FO");
            tabla.Columns.Add("FE");
            tabla.Columns.Add("PO");
            tabla.Columns.Add("PE");
            tabla.Columns.Add("PO(ac)");
            tabla.Columns.Add("PE(ac)");
            tabla.Columns.Add("|PO(ac)-PE(ac)|");
            tabla.Columns.Add("KS");

            for (int i = 0; i < cantIntervalo; i++)
            {
                double fo = 0;
                hasta = desde + tamaño;
                for (int j = 0; j < gdrAleatorios.Rows.Count; j++)
                {
                    double rnd = double.Parse(gdrAleatorios.Rows[j].Cells[2].Value.ToString());
                    if (rnd >= desde && rnd < hasta)
                    {
                        fo++;   
                    }     
                }
                ProbO = Math.Truncate((fo / gdrAleatorios.Rows.Count)*10000)/10000;
                ProbE = Math.Truncate((fe / gdrAleatorios.Rows.Count)*10000)/10000;
                acPO = ProbO + acPO;
                acPE = ProbE + acPE;
                ValAbs = Math.Truncate(Math.Abs(acPO - acPE)*10000)/10000;
                KS = Math.Max(ValAbs, KS);
                tabla.Rows.Add(desde, hasta, (desde + hasta) / 2, fo, fe, ProbO, ProbE, acPO, acPE, ValAbs, KS);
                desde = hasta;
            }
            gdrKs.DataSource = tabla;

            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_SIM.Report.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();

            txt_Estadistico.Text = tabla.Rows[cantIntervalo-1]["KS"].ToString();
            txt_Libertad.Text = (tabla.Rows.Count - 1).ToString();

        }

        private void cmb_Significancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Significancia.SelectedIndex != -1)
            {
                double n = double.Parse(txt_Libertad.Text.Trim());
                double significancia = double.Parse(cmb_Significancia.Text);
                txt_ValorTabulado.Text = Math.Round(MathNet.Numerics.Distributions.ChiSquared.InvCDF(n, significancia), 4).ToString();
            }

        }

        private void btn_ValidarHipotesis_Click(object sender, EventArgs e)
        {
            if (double.Parse(txt_ValorTabulado.Text) >= double.Parse(txt_Estadistico.Text))
            {
                MessageBox.Show("Como el valor de Ho= " + txt_Estadistico.Text + " es menor que el valor de Ha= " + txt_ValorTabulado.Text + ". No hay evidencia suficiente para rechazar la Hipotesis nula", "¡NO SE RECHAZA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Como el valor de Ho= " + txt_Estadistico.Text + " es mayor que el valor de Ha= " + txt_ValorTabulado.Text + ". Se rechaza la Hipotesis nula", "¡SE RECHAZA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalcularKS_Click(object sender, EventArgs e)
        {
            int cantIntervalos;
            double tamIntervalo;

            if (rd5intervalos.Checked == true)
            {
                cantIntervalos = 5;
                tamIntervalo = 1 / (double)cantIntervalos;
                calKS(cantIntervalos, tamIntervalo);
            }
            if (rd10Intervalos.Checked == true)
            {
                cantIntervalos = 10;
                tamIntervalo = 1 / (double)cantIntervalos;
                calKS(cantIntervalos, tamIntervalo);
            }
            if (rd15Intervalos.Checked == true)
            {
                cantIntervalos = 15;
                tamIntervalo = 1 / cantIntervalos;
                calKS(cantIntervalos, tamIntervalo);
            }
            if (rd20Intervalos.Checked == true)
            {
                cantIntervalos = 20;
                tamIntervalo = 1 / cantIntervalos;
                calKS(cantIntervalos, tamIntervalo);
            }
        }
    }

}
