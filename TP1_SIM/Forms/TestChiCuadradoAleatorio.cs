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
    public partial class TestChiCuadrado : Form
    {
        List<decimal> rndLista = new List<decimal>();
         //realizando pruebas para git. borrar luego
        public TestChiCuadrado()
        {
            InitializeComponent();
            cmb_Significancia.SelectedIndex = -1;
            cmb_Significancia.Enabled = false;
        }

        private void TestChiCuadrado_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnCalcularChi_Click(object sender, EventArgs e)
        {
            if (txt_cantNum.Value==0)
            {
                MessageBox.Show("Error!, debe seleccionar la cantidad de numeros a generar.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmb_Significancia.SelectedIndex = -1;
                txt_ValorTabulado.Value = 0;
                int CantNumeros = Convert.ToInt32(this.txt_cantNum.Text);
                rndLista.Clear();
                gdrAleatorios.Rows.Clear();

                generarRandom(CantNumeros);
                int cantIntervalos;
                double tamIntervalo;

                if (rd5intervalos.Checked == true)
                {
                    cantIntervalos = 5;
                    tamIntervalo = 1 / (double)cantIntervalos;
                    calChiCuadrado(cantIntervalos, tamIntervalo);
                }
                if (rd10Intervalos.Checked == true)
                {
                    cantIntervalos = 10;
                    tamIntervalo = 1 / (double)cantIntervalos;
                    calChiCuadrado(cantIntervalos, tamIntervalo);
                }
                if (rd15Intervalos.Checked == true)
                {
                    cantIntervalos = 15;
                    tamIntervalo = 1 / (double)cantIntervalos;
                    calChiCuadrado(cantIntervalos, tamIntervalo);
                }
                if (rd20Intervalos.Checked == true)
                {
                    cantIntervalos = 20;
                    tamIntervalo = 1 / (double)cantIntervalos;
                    calChiCuadrado(cantIntervalos, tamIntervalo);
                }
            }
        }
        private void generarRandom(int CantNumeros)
        {
            Random rnd = new Random();
            for (int i = 0; i < CantNumeros; i++)
            {
                double num = rnd.NextDouble();
                num = (Math.Truncate(num * 10000) / 10000);
                rndLista.Add((decimal)num);
                gdrAleatorios.Rows.Add((i + 1) + ") \t" + num);
            }
        }
        private void calChiCuadrado(int cantIntervalo, double tamaño)
        {
            DataTable tabla = new DataTable();
            double fe = rndLista.Count / cantIntervalo;
            double desde, hasta, chiCuadrado = 0, ac = 0;

            desde = 0;

            // Nombres de las columnas
            tabla.Columns.Add("Desde");
            tabla.Columns.Add("Hasta");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("FO");
            tabla.Columns.Add("FE");
            tabla.Columns.Add("Chi-Cuadrado");
            tabla.Columns.Add("Acumulador");

            for (int i = 0; i < cantIntervalo; i++)
            {
                int fo = 0;
                hasta = Math.Truncate((desde + tamaño) * 10000) / 10000;
                for (int j = 0; j < rndLista.Count; j++)
                {
                    double rnd = double.Parse(rndLista[j].ToString());
                    if (rnd >= desde && rnd < hasta)
                    {
                        fo++;
                    }
                }
                chiCuadrado = Math.Truncate((Math.Pow(fo - fe, 2) / fe) * 10000) / 10000;
                ac = ac + chiCuadrado;

                tabla.Rows.Add(desde, hasta, ((desde + hasta) / 2), fo, fe, chiCuadrado, ac);
                desde = hasta;
            }
            gdrChiCuadrado.DataSource = tabla;
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_SIM.Report.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();

            txt_Estadistico.Text = (string)tabla.Rows[cantIntervalo-1]["Acumulador"];
            txt_Libertad.Value = (tabla.Rows.Count - 1);
            cmb_Significancia.Enabled = true;

        }

        private void cmb_Significancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Significancia.SelectedIndex != -1 )
            {
                double n = ((double)txt_Libertad.Value);
                double significancia = double.Parse(cmb_Significancia.Text);
                txt_ValorTabulado.Value = (decimal)Math.Round(MathNet.Numerics.Distributions.ChiSquared.InvCDF(n, significancia), 4);
            }

        }
        private void btn_ValidarHipotesis_Click(object sender, EventArgs e)
        {
            if (gdrAleatorios.Rows.Count == 0)
            {
                MessageBox.Show("¡ERROR!, primero debe generar los numeros pseudo-aleatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmb_Significancia.SelectedIndex == -1)
                {
                    MessageBox.Show("¡ERROR!, seleccione el grado de significancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((txt_ValorTabulado.Value) >= (txt_Estadistico.Value))
                    {
                        MessageBox.Show("Como el valor de Ho= " + txt_Estadistico.Value + " es menor que el valor de Ha= " + txt_ValorTabulado.Value + ". No hay evidencia suficiente para rechazar la Hipotesis nula", "¡NO SE RECHAZA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Como el valor de Ho= " + txt_Estadistico.Value + " es mayor que el valor de Ha= " + txt_ValorTabulado.Value + ". Se rechaza la Hipotesis nula", "¡SE RECHAZA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
