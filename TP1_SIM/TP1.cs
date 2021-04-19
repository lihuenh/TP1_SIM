using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SIM
{
    public partial class TP1 : Form
    {
        DataTable table = new DataTable();
        
       
        public TP1()
        {
            InitializeComponent();
            txtCteA.Text = "13";
            txtSemilla.Text = "6";
            txtCteM.Text = "8";
            txtMuestra.Text = "20";
            txtCteC.Text = "7";
            table.Columns.Add("i");
            table.Columns.Add("X");
            table.Columns.Add("Num Aleatorio");
            table.Columns.Add("Acumulador media");


        }

        private void txtCteG_TextChanged(object sender, EventArgs e)
        {

            //txtCteM.Text = (int.Parse(txtCteG.Text) ^ 2).ToString();
     
        }

        private double CongruenteMixto(int semilla, int a, int c, int m, int n)
        {

            table.Rows.Clear();
            //if (gdrMixto.Columns.Count > 4)
            //{
            //    table.Columns.Add("Acumulador media");
            //}
            
            double sem, prom, random, preAc, preVarp, ac;



            sem = (a * semilla + c) % (m);
            random = Math.Truncate((sem / (m)) * 10000) / 10000;
            table.Rows.Add(1, sem, random, random);
            for (int i = 1; i < n; i++)
            {
                sem = ((a * double.Parse(table.Rows[i - 1]["X"].ToString())) + c) % (m);
                random = Math.Truncate((sem / (m) * 10000)) / 10000;

                // Programacion del acumulador promedio
                preAc = double.Parse(table.Rows[i-1]["Acumulador media"].ToString()) + random;


                // Programacion del acumulador varianza
                table.Rows.Add(i + 1, sem, random, preAc);


            }

            gdrMixto.DataSource = table;
            ac =double.Parse(table.Rows[n-1]["Acumulador media"].ToString());

            return prom = ac / table.Rows.Count;
        }

        private double CongruenteMultiplicativo(int semilla, int a, int m, int n)
        {


            table.Rows.Clear();
            double sem, preAc, ac, prom;
            double random;
            sem = (a * semilla) % (m);
            random = Math.Truncate((sem / (m-1)) * 10000) / 10000;
            table.Rows.Add(1, sem, random, random);
            for (int i = 1; i < n; i++)
            {
                sem = ((a * double.Parse(table.Rows[i - 1]["X"].ToString()))) % (m);
                random = Math.Truncate((sem / (m-1) * 10000)) / 10000;

                // Programacion del acumulador promedio
                preAc = double.Parse(table.Rows[i - 1]["Acumulador media"].ToString()) + random;


                table.Rows.Add(i + 1, sem, random, preAc);


            }

            gdrMixto.DataSource = table;
            ac = double.Parse(table.Rows[n - 1]["Acumulador media"].ToString());

            return prom = ac / table.Rows.Count;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtCteA.Text.Trim()); //Cte multiplicativa
            int c = int.Parse(txtCteC.Text.Trim()); //Cte aditiva
            int m = int.Parse(txtCteM.Text.Trim()); //Modulo
            int semilla = int.Parse(txtSemilla.Text.Trim()); //Raiz o semilla
            int n = int.Parse(txtMuestra.Text.Trim()); // Es la muestra

            double promedio;

            //gdrMixto.Rows.RemoveAt(1);           
            if (rdMixto.Checked == true)
                {
                promedio = CongruenteMixto(semilla, a, c, m, n);
                txtPromedio.Text = promedio.ToString(); //calcularPromedio(table).ToString();
                txtVarianza.Text = calcularVarianza(promedio).ToString();
                //gdrMixto.Columns.RemoveAt(3);
                }
            if (rdMultiplicativo.Checked==true)
            {
                promedio = CongruenteMultiplicativo(semilla, a, m, n);
                txtPromedio.Text = promedio.ToString();
                txtVarianza.Text = calcularVarianza(promedio).ToString();

            }
            
            
        }

        private double UnoMasMixto( int a, int c, int m)
        {
            int n = gdrMixto.Rows.Count;
            double sem;
            double random;
            double semilla;
            semilla = double.Parse(table.Rows[table.Rows.Count - 1]["X"].ToString());         
            sem = ((a * semilla) + c) % (m);
            random = Math.Truncate((sem / (m )) * 10000) / 10000;
            double preAc = double.Parse(table.Rows[table.Rows.Count - 1]["Acumulador media"].ToString()) + random;
            table.Rows.Add(n+1, sem, random, preAc);
            gdrMixto.DataSource = table;

            return preAc / table.Rows.Count;
            
        }

        private double UnoMasMultiplicativo(int a, int m)
        {
            int n = gdrMixto.Rows.Count;
            double sem;
            double random;
            double semilla;
            semilla = double.Parse(table.Rows[table.Rows.Count - 1]["X"].ToString());
            sem = (a * semilla) % (m);
            random = Math.Truncate((sem / (m)) * 10000) / 10000;
            double preAc = double.Parse(table.Rows[table.Rows.Count - 1]["Acumulador media"].ToString()) + random;
            table.Rows.Add(n + 1, sem, random, preAc);
            gdrMixto.DataSource = table;

            return preAc / gdrMixto.Rows.Count;

        }

        private void btnUnoMas_Click(object sender, EventArgs e)
        {
            //boton1mas
            int a = int.Parse(txtCteA.Text.Trim()); //Cte multiplicativa
            int c = int.Parse(txtCteC.Text.Trim()); //Cte aditiva
            int m = int.Parse(txtCteM.Text.Trim()); //Modulo
            double promedio;

            if (gdrMixto.Rows.Count > 0)
            {
                if (rdMixto.Checked == true)
                {
                    promedio = UnoMasMixto(a, c, m);
                }
                else
                {
                    promedio = UnoMasMultiplicativo(a, m);
                }
                txtPromedio.Text = (Math.Truncate(10000 * promedio) / 10000).ToString();
                txtVarianza.Text = calcularVarianza(promedio).ToString();
                
            }
        }

        private double calcularPromedio(DataTable tabla)
        {
            double prom = 0;
            double ac = double.Parse(tabla.Rows[0]["Num Aleatorio"].ToString());
            int n = tabla.Rows.Count;
            for (int i = 1; i < tabla.Rows.Count; i++)
            {
                ac = ac + double.Parse(tabla.Rows[i]["Num Aleatorio"].ToString());
            }

            prom = Math.Truncate((ac / n) * 10000) / 10000;
            return prom;
        }

        private double calcularVarianza(double prom)
        {
            double varianza;
            double ac = Math.Pow((double.Parse(table.Rows[0]["Num Aleatorio"].ToString())) - prom, 2);
            for (int i = 1; i < table.Rows.Count; i++)
            {
                ac = ac + Math.Pow((double.Parse(table.Rows[i]["Num Aleatorio"].ToString())) - prom, 2);
            }
            return varianza = Math.Truncate((ac / table.Rows.Count) * 10000) / 10000;
        }

        private void btnChiCuadrado_Click(object sender, EventArgs e)
        {
            TestChiCuadrado ventana = new TestChiCuadrado(table);
            ventana.ShowDialog();
        }
    }
}
