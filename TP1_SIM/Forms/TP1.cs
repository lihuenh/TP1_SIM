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
            txtCteA.Value = 13;
            txtSemilla.Value = 6;
            txtCteM.Value = 8;
            txtMuestra.Value = 20;
            txtCteC.Value = 7;
            table.Columns.Add("i");
            table.Columns.Add("X");
            table.Columns.Add("Num Aleatorio");
            table.Columns.Add("Acumulador media");
        }
        //-------------------------------------------------------------METODO PARA CALCULAR EL CONGRUENTE MIXTO
        private double CongruenteMixto(decimal semilla, decimal a, decimal c, decimal m, int n)
        {
            table.Rows.Clear();
            decimal sem, prom, random, preAc, ac;
            sem = (a * semilla + c) % (m);
            random = Math.Truncate((sem / (m)) * 10000) / 10000;
            table.Rows.Add(1, sem, random, random); 

            for (int i = 1; i < n; i++)
            {
                sem = ((a * decimal.Parse(table.Rows[i - 1]["X"].ToString())) + c) % (m);
                random = Math.Truncate((sem / (m) * 10000)) / 10000;

                // Programacion del acumulador promedio
                preAc = decimal.Parse(table.Rows[i-1]["Acumulador media"].ToString()) + random;

                // Programacion del acumulador varianza
                table.Rows.Add(i + 1, sem, random, preAc);
            }

            gdrMixto.DataSource = table;
            ac =decimal.Parse(table.Rows[n-1]["Acumulador media"].ToString());

            return (double)(prom = ac / table.Rows.Count);
        }
        //-------------------------------------------------------------METODO PARA CALCULAR EL MULTIPLICATIVO
        private double CongruenteMultiplicativo(decimal semilla, decimal a, decimal m, int n)
        {
            table.Rows.Clear();
            decimal sem, preAc, ac, prom;
            decimal random;
            sem = (a * semilla) % (m);
            random = Math.Truncate((sem / (m-1)) * 10000) / 10000;
            table.Rows.Add(1, sem, random, random);
            for (int i = 1; i < n; i++)
            {
                sem = ((a * decimal.Parse(table.Rows[i - 1]["X"].ToString()))) % (m);
                random = Math.Truncate((sem / (m-1) * 10000)) / 10000;

                // Programacion del acumulador promedio
                preAc = decimal.Parse(table.Rows[i - 1]["Acumulador media"].ToString()) + random;

                table.Rows.Add(i + 1, sem, random, preAc);

            }
            gdrMixto.DataSource = table;
            ac = decimal.Parse(table.Rows[n - 1]["Acumulador media"].ToString());

            return (double)(prom = ac / table.Rows.Count);
        }
        //-------------------------------------------------------------BOTON PARA GENERAR NUMEROS PSEUDOALEATORIOS
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            decimal a = txtCteA.Value; //Cte multiplicativa
            decimal c = txtCteC.Value; //Cte aditiva
            decimal m = txtCteM.Value; //Modulo
            decimal semilla = txtSemilla.Value; //Raiz o semilla
            decimal n = txtMuestra.Value; // Es la muestra

            decimal promedio;
          
            if (rdMixto.Checked == true)
            {
                if (txtSemilla.Value <= 0 || txtCteA.Value <= 0 || txtCteC.Value <= 0 || txtCteM.Value <= 0 || txtMuestra.Value <= 0)
                {
                    MessageBox.Show("ERROR!, los valores de: 'x', 'a', 'c', 'm' y 'n' deben ser mayores a 0.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    promedio = (decimal)CongruenteMixto(semilla, a, c, m, (int)n);
                    txtPromedio.Text = promedio.ToString(); 
                    txtVarianza.Text = calcularVarianza(promedio).ToString();
                }
            }
            else
            {
                if (txtSemilla.Value <= 0 || txtCteA.Value <= 0 || txtCteM.Value <= 0 || txtMuestra.Value <= 0)
                {
                    MessageBox.Show("ERROR!, los valores de: 'x', 'a', 'm' y 'n' deben ser mayores a 0.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    promedio = (decimal)CongruenteMultiplicativo(semilla, a, m, (int)n);
                    txtPromedio.Text = promedio.ToString();
                    txtVarianza.Text = calcularVarianza(promedio).ToString();
                }
            }
        }
        //-------------------------------------------------------------METODO PARA UN NUMERO MAS MIXTO
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
        //-------------------------------------------------------------METODO PARA UN NUMERO MAS MULTIPLICATIVO
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
        //-------------------------------------------------------------BOTON PARA GENERAR UN NUMERO MAS
        private void btnUnoMas_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe generar la serie de numeros Pseudoaleatorios","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
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
                    txtVarianza.Text = calcularVarianza((decimal)promedio).ToString();
                }
            }
        }
        //-------------------------------------------------------------METODO PARA CALCULAR LA VARIANZA
        private double calcularVarianza(decimal prom)
        {
            decimal varianza;
            decimal ac = (decimal)Math.Pow((double)((decimal.Parse(table.Rows[0]["Num Aleatorio"].ToString())) - prom), 2);
            for (int i = 1; i < table.Rows.Count; i++)
            {
                ac = ac + (decimal)Math.Pow((double)(decimal.Parse(table.Rows[i]["Num Aleatorio"].ToString()) - prom), 2);
            }
            return (double)(varianza = Math.Truncate((ac / table.Rows.Count) * 10000) / 10000);
        }
        //-------------------------------------------------------------BOTON PARA CALCULAR EL CHI-CUADRADO DE NUMEROS RANDOM
        private void btnChiCuadrado_Click(object sender, EventArgs e)
        {
            TestChiCuadrado ventana = new TestChiCuadrado();
            ventana.ShowDialog();
        }
        //-------------------------------------------------------------BOTON PARA CALCULAR EL CHI-CUADRADO DEL METODO CONGRUENCIAL MIXTO
        private void btn_chiCuadradoCongruencial_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("ERROR!, primero debe generar los numeros pseualeatorios","¡ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (rdMultiplicativo.Checked == true)
                {
                    MessageBox.Show("ERROR!, el metodo a utilizar debe ser el congruente mixto", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Forms.TestChiCuadradoCongruencial ventana = new Forms.TestChiCuadradoCongruencial(table);
                    ventana.ShowDialog();
                }
            }
        }
        //-------------------------------------------------------------ACCION AL SELECCIONAR UN NUMERO CONTANTE K
        private void txtCteK_ValueChanged(object sender, EventArgs e)
        {
            if (rdMixto.Checked==true)
            {
                txtCteA.Value = 1 + (4 * txtCteK.Value);
            }
            else
            {
                txtCteA.Value = 3 + (8 * txtCteK.Value);
            }
        }
        //-------------------------------------------------------------ACCION AL SELECCIONAR UN NUMERO CONSTANTE G
        private void txtCteG_ValueChanged(object sender, EventArgs e)
        {
            txtCteM.Value = (int)Math.Pow(2, (double)txtCteG.Value);
        }
        //-------------------------------------------------------------ACCION AL SELECCIONAR EL RADIUS MULTIPLICATIVO
        private void rdMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            txtCteC.Value = 0;
            txtCteC.Enabled = false;
        }
        //-------------------------------------------------------------ACCION AL SELECCIONAR EL RADIUS MIXTO
        private void rdMixto_CheckedChanged(object sender, EventArgs e)
        {
            txtCteC.Enabled = true;
        }
    }
}
