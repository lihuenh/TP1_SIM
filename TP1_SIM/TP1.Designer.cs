namespace TP1_SIM
{
    partial class TP1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCteK = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCteG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCteM = new System.Windows.Forms.TextBox();
            this.txtCteC = new System.Windows.Forms.TextBox();
            this.txtCteA = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdrMixto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rdMixto = new System.Windows.Forms.RadioButton();
            this.btnUnoMas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChiCuadrado = new System.Windows.Forms.Button();
            this.btnKS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMixto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCteK);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMuestra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCteG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCteM);
            this.groupBox1.Controls.Add(this.txtCteC);
            this.groupBox1.Controls.Add(this.txtCteA);
            this.groupBox1.Controls.Add(this.txtSemilla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constantes";
            // 
            // txtCteK
            // 
            this.txtCteK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCteK.Location = new System.Drawing.Point(507, 20);
            this.txtCteK.Name = "txtCteK";
            this.txtCteK.Size = new System.Drawing.Size(78, 22);
            this.txtCteK.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(594, 46);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(158, 22);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "[k]:";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuestra.Location = new System.Drawing.Point(673, 21);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(79, 22);
            this.txtMuestra.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Muestra [n]:";
            // 
            // txtCteG
            // 
            this.txtCteG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCteG.Location = new System.Drawing.Point(508, 45);
            this.txtCteG.Name = "txtCteG";
            this.txtCteG.Size = new System.Drawing.Size(78, 22);
            this.txtCteG.TabIndex = 3;
            this.txtCteG.TextChanged += new System.EventHandler(this.txtCteG_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "[g]:";
            // 
            // txtCteM
            // 
            this.txtCteM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCteM.Location = new System.Drawing.Point(353, 45);
            this.txtCteM.Name = "txtCteM";
            this.txtCteM.Size = new System.Drawing.Size(100, 22);
            this.txtCteM.TabIndex = 1;
            // 
            // txtCteC
            // 
            this.txtCteC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCteC.Location = new System.Drawing.Point(353, 18);
            this.txtCteC.Name = "txtCteC";
            this.txtCteC.Size = new System.Drawing.Size(100, 22);
            this.txtCteC.TabIndex = 1;
            // 
            // txtCteA
            // 
            this.txtCteA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCteA.Location = new System.Drawing.Point(127, 46);
            this.txtCteA.Name = "txtCteA";
            this.txtCteA.Size = new System.Drawing.Size(100, 22);
            this.txtCteA.TabIndex = 1;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(127, 16);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 22);
            this.txtSemilla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modulo [m]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cte. Aditiva [c]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Semilla [X]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicador [a]:";
            // 
            // gdrMixto
            // 
            this.gdrMixto.AllowUserToAddRows = false;
            this.gdrMixto.AllowUserToDeleteRows = false;
            this.gdrMixto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMixto.Location = new System.Drawing.Point(12, 204);
            this.gdrMixto.Name = "gdrMixto";
            this.gdrMixto.ReadOnly = true;
            this.gdrMixto.Size = new System.Drawing.Size(462, 240);
            this.gdrMixto.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdMultiplicativo);
            this.groupBox2.Controls.Add(this.rdMixto);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método";
            // 
            // rdMultiplicativo
            // 
            this.rdMultiplicativo.AutoSize = true;
            this.rdMultiplicativo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultiplicativo.Location = new System.Drawing.Point(141, 20);
            this.rdMultiplicativo.Name = "rdMultiplicativo";
            this.rdMultiplicativo.Size = new System.Drawing.Size(169, 19);
            this.rdMultiplicativo.TabIndex = 0;
            this.rdMultiplicativo.Text = "Congruente multiplicativo";
            this.rdMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // rdMixto
            // 
            this.rdMixto.AutoSize = true;
            this.rdMixto.Checked = true;
            this.rdMixto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMixto.Location = new System.Drawing.Point(9, 20);
            this.rdMixto.Name = "rdMixto";
            this.rdMixto.Size = new System.Drawing.Size(126, 19);
            this.rdMixto.TabIndex = 0;
            this.rdMixto.TabStop = true;
            this.rdMixto.Text = "Congruente mixto";
            this.rdMixto.UseVisualStyleBackColor = true;
            // 
            // btnUnoMas
            // 
            this.btnUnoMas.Location = new System.Drawing.Point(13, 175);
            this.btnUnoMas.Name = "btnUnoMas";
            this.btnUnoMas.Size = new System.Drawing.Size(75, 23);
            this.btnUnoMas.TabIndex = 3;
            this.btnUnoMas.Text = "Continuar";
            this.btnUnoMas.UseVisualStyleBackColor = true;
            this.btnUnoMas.Click += new System.EventHandler(this.btnUnoMas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(201, 176);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(60, 22);
            this.txtPromedio.TabIndex = 1;
            // 
            // txtVarianza
            // 
            this.txtVarianza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarianza.Location = new System.Drawing.Point(341, 176);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.Size = new System.Drawing.Size(61, 22);
            this.txtVarianza.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Varianza:";
            // 
            // btnChiCuadrado
            // 
            this.btnChiCuadrado.Location = new System.Drawing.Point(14, 39);
            this.btnChiCuadrado.Name = "btnChiCuadrado";
            this.btnChiCuadrado.Size = new System.Drawing.Size(263, 74);
            this.btnChiCuadrado.TabIndex = 4;
            this.btnChiCuadrado.Text = "Test - Chi Cuadrado";
            this.btnChiCuadrado.UseVisualStyleBackColor = true;
            this.btnChiCuadrado.Click += new System.EventHandler(this.btnChiCuadrado_Click);
            // 
            // btnKS
            // 
            this.btnKS.Location = new System.Drawing.Point(14, 147);
            this.btnKS.Name = "btnKS";
            this.btnKS.Size = new System.Drawing.Size(263, 74);
            this.btnKS.TabIndex = 4;
            this.btnKS.Text = "Test - Kolmogorov Smirnov";
            this.btnKS.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChiCuadrado);
            this.groupBox3.Controls.Add(this.btnKS);
            this.groupBox3.Location = new System.Drawing.Point(491, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 240);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tests de bondad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Números aleatorios:";
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUnoMas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gdrMixto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVarianza);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label10);
            this.Name = "TP1";
            this.Text = "TP1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMixto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCteK;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCteG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCteM;
        private System.Windows.Forms.TextBox txtCteC;
        private System.Windows.Forms.TextBox txtCteA;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdrMixto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdMultiplicativo;
        private System.Windows.Forms.RadioButton rdMixto;
        private System.Windows.Forms.Button btnUnoMas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChiCuadrado;
        private System.Windows.Forms.Button btnKS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
    }
}

