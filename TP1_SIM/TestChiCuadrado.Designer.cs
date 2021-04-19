namespace TP1_SIM
{
    partial class TestChiCuadrado
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
            this.gdrChiCuadrado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd20Intervalos = new System.Windows.Forms.RadioButton();
            this.rd15Intervalos = new System.Windows.Forms.RadioButton();
            this.rd10Intervalos = new System.Windows.Forms.RadioButton();
            this.rd5intervalos = new System.Windows.Forms.RadioButton();
            this.btnCalcularChi = new System.Windows.Forms.Button();
            this.gdrAleatorios = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_ValidarHipotesis = new System.Windows.Forms.Button();
            this.cmb_Significancia = new System.Windows.Forms.ComboBox();
            this.Hipotesis = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Estadistico = new System.Windows.Forms.TextBox();
            this.txt_Libertad = new System.Windows.Forms.TextBox();
            this.txt_ValorTabulado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrChiCuadrado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrAleatorios)).BeginInit();
            this.Hipotesis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdrChiCuadrado
            // 
            this.gdrChiCuadrado.AllowUserToAddRows = false;
            this.gdrChiCuadrado.AllowUserToDeleteRows = false;
            this.gdrChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrChiCuadrado.Location = new System.Drawing.Point(12, 82);
            this.gdrChiCuadrado.Name = "gdrChiCuadrado";
            this.gdrChiCuadrado.ReadOnly = true;
            this.gdrChiCuadrado.Size = new System.Drawing.Size(345, 287);
            this.gdrChiCuadrado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test de bondad: Chi Cuadrado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd20Intervalos);
            this.groupBox1.Controls.Add(this.rd15Intervalos);
            this.groupBox1.Controls.Add(this.rd10Intervalos);
            this.groupBox1.Controls.Add(this.rd5intervalos);
            this.groupBox1.Location = new System.Drawing.Point(368, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 43);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de intervalos";
            // 
            // rd20Intervalos
            // 
            this.rd20Intervalos.AutoSize = true;
            this.rd20Intervalos.Location = new System.Drawing.Point(274, 19);
            this.rd20Intervalos.Name = "rd20Intervalos";
            this.rd20Intervalos.Size = new System.Drawing.Size(85, 17);
            this.rd20Intervalos.TabIndex = 0;
            this.rd20Intervalos.TabStop = true;
            this.rd20Intervalos.Text = "20 intervalos";
            this.rd20Intervalos.UseVisualStyleBackColor = true;
            // 
            // rd15Intervalos
            // 
            this.rd15Intervalos.AutoSize = true;
            this.rd15Intervalos.Location = new System.Drawing.Point(183, 19);
            this.rd15Intervalos.Name = "rd15Intervalos";
            this.rd15Intervalos.Size = new System.Drawing.Size(85, 17);
            this.rd15Intervalos.TabIndex = 0;
            this.rd15Intervalos.TabStop = true;
            this.rd15Intervalos.Text = "15 intervalos";
            this.rd15Intervalos.UseVisualStyleBackColor = true;
            // 
            // rd10Intervalos
            // 
            this.rd10Intervalos.AutoSize = true;
            this.rd10Intervalos.Location = new System.Drawing.Point(92, 20);
            this.rd10Intervalos.Name = "rd10Intervalos";
            this.rd10Intervalos.Size = new System.Drawing.Size(85, 17);
            this.rd10Intervalos.TabIndex = 0;
            this.rd10Intervalos.TabStop = true;
            this.rd10Intervalos.Text = "10 intervalos";
            this.rd10Intervalos.UseVisualStyleBackColor = true;
            // 
            // rd5intervalos
            // 
            this.rd5intervalos.AutoSize = true;
            this.rd5intervalos.Checked = true;
            this.rd5intervalos.Location = new System.Drawing.Point(7, 20);
            this.rd5intervalos.Name = "rd5intervalos";
            this.rd5intervalos.Size = new System.Drawing.Size(79, 17);
            this.rd5intervalos.TabIndex = 0;
            this.rd5intervalos.TabStop = true;
            this.rd5intervalos.Text = "5 intervalos";
            this.rd5intervalos.UseVisualStyleBackColor = true;
            // 
            // btnCalcularChi
            // 
            this.btnCalcularChi.Location = new System.Drawing.Point(33, 53);
            this.btnCalcularChi.Name = "btnCalcularChi";
            this.btnCalcularChi.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularChi.TabIndex = 3;
            this.btnCalcularChi.Text = "Calcular";
            this.btnCalcularChi.UseVisualStyleBackColor = true;
            this.btnCalcularChi.Click += new System.EventHandler(this.btnCalcularChi_Click);
            // 
            // gdrAleatorios
            // 
            this.gdrAleatorios.AllowUserToAddRows = false;
            this.gdrAleatorios.AllowUserToDeleteRows = false;
            this.gdrAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrAleatorios.Location = new System.Drawing.Point(739, 6);
            this.gdrAleatorios.Name = "gdrAleatorios";
            this.gdrAleatorios.ReadOnly = true;
            this.gdrAleatorios.Size = new System.Drawing.Size(49, 31);
            this.gdrAleatorios.TabIndex = 0;
            this.gdrAleatorios.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(368, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(420, 287);
            this.reportViewer1.TabIndex = 4;
            // 
            // btn_ValidarHipotesis
            // 
            this.btn_ValidarHipotesis.Location = new System.Drawing.Point(680, 13);
            this.btn_ValidarHipotesis.Name = "btn_ValidarHipotesis";
            this.btn_ValidarHipotesis.Size = new System.Drawing.Size(90, 53);
            this.btn_ValidarHipotesis.TabIndex = 5;
            this.btn_ValidarHipotesis.Text = "Validar Hipotesis";
            this.btn_ValidarHipotesis.UseVisualStyleBackColor = true;
            this.btn_ValidarHipotesis.Click += new System.EventHandler(this.btn_ValidarHipotesis_Click);
            // 
            // cmb_Significancia
            // 
            this.cmb_Significancia.FormattingEnabled = true;
            this.cmb_Significancia.Items.AddRange(new object[] {
            "0.995",
            "0.99",
            "0.975",
            "0,950",
            "0.900",
            "0.750",
            "0.500",
            "0.250",
            "0.100",
            "0.050",
            "0.025",
            "0.010",
            "0.005"});
            this.cmb_Significancia.Location = new System.Drawing.Point(391, 17);
            this.cmb_Significancia.Name = "cmb_Significancia";
            this.cmb_Significancia.Size = new System.Drawing.Size(121, 21);
            this.cmb_Significancia.TabIndex = 6;
            this.cmb_Significancia.SelectedIndexChanged += new System.EventHandler(this.cmb_Significancia_SelectedIndexChanged);
            // 
            // Hipotesis
            // 
            this.Hipotesis.Controls.Add(this.txt_ValorTabulado);
            this.Hipotesis.Controls.Add(this.txt_Libertad);
            this.Hipotesis.Controls.Add(this.txt_Estadistico);
            this.Hipotesis.Controls.Add(this.label5);
            this.Hipotesis.Controls.Add(this.label4);
            this.Hipotesis.Controls.Add(this.label3);
            this.Hipotesis.Controls.Add(this.label2);
            this.Hipotesis.Controls.Add(this.cmb_Significancia);
            this.Hipotesis.Controls.Add(this.btn_ValidarHipotesis);
            this.Hipotesis.Location = new System.Drawing.Point(12, 375);
            this.Hipotesis.Name = "Hipotesis";
            this.Hipotesis.Size = new System.Drawing.Size(776, 72);
            this.Hipotesis.TabIndex = 7;
            this.Hipotesis.TabStop = false;
            this.Hipotesis.Text = "Hipotesis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Significancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "G. Libertad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estadistico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Tabulado";
            // 
            // txt_Estadistico
            // 
            this.txt_Estadistico.Location = new System.Drawing.Point(83, 19);
            this.txt_Estadistico.Name = "txt_Estadistico";
            this.txt_Estadistico.Size = new System.Drawing.Size(100, 20);
            this.txt_Estadistico.TabIndex = 11;
            // 
            // txt_Libertad
            // 
            this.txt_Libertad.Location = new System.Drawing.Point(83, 42);
            this.txt_Libertad.Name = "txt_Libertad";
            this.txt_Libertad.Size = new System.Drawing.Size(100, 20);
            this.txt_Libertad.TabIndex = 12;
            // 
            // txt_ValorTabulado
            // 
            this.txt_ValorTabulado.Location = new System.Drawing.Point(391, 42);
            this.txt_ValorTabulado.Name = "txt_ValorTabulado";
            this.txt_ValorTabulado.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorTabulado.TabIndex = 13;
            // 
            // TestChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hipotesis);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCalcularChi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdrAleatorios);
            this.Controls.Add(this.gdrChiCuadrado);
            this.Name = "TestChiCuadrado";
            this.Text = "Test - Chi Cuadrado";
            this.Load += new System.EventHandler(this.TestChiCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrChiCuadrado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrAleatorios)).EndInit();
            this.Hipotesis.ResumeLayout(false);
            this.Hipotesis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrChiCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd20Intervalos;
        private System.Windows.Forms.RadioButton rd15Intervalos;
        private System.Windows.Forms.RadioButton rd10Intervalos;
        private System.Windows.Forms.RadioButton rd5intervalos;
        private System.Windows.Forms.Button btnCalcularChi;
        private System.Windows.Forms.DataGridView gdrAleatorios;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_ValidarHipotesis;
        private System.Windows.Forms.ComboBox cmb_Significancia;
        private System.Windows.Forms.GroupBox Hipotesis;
        private System.Windows.Forms.TextBox txt_ValorTabulado;
        private System.Windows.Forms.TextBox txt_Libertad;
        private System.Windows.Forms.TextBox txt_Estadistico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}