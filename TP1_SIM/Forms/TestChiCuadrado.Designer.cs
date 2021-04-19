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
            this.rd5intervalos = new System.Windows.Forms.RadioButton();
            this.rd15Intervalos = new System.Windows.Forms.RadioButton();
            this.rd10Intervalos = new System.Windows.Forms.RadioButton();
            this.btnCalcularChi = new System.Windows.Forms.Button();
            this.gdrAleatorios = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_ValidarHipotesis = new System.Windows.Forms.Button();
            this.cmb_Significancia = new System.Windows.Forms.ComboBox();
            this.Hipotesis = new System.Windows.Forms.GroupBox();
            this.txt_ValorTabulado = new System.Windows.Forms.TextBox();
            this.txt_Libertad = new System.Windows.Forms.TextBox();
            this.txt_Estadistico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gdrChiCuadrado.Location = new System.Drawing.Point(12, 98);
            this.gdrChiCuadrado.Name = "gdrChiCuadrado";
            this.gdrChiCuadrado.ReadOnly = true;
            this.gdrChiCuadrado.Size = new System.Drawing.Size(345, 301);
            this.gdrChiCuadrado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test de bondad: Chi Cuadrado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd20Intervalos);
            this.groupBox1.Controls.Add(this.rd5intervalos);
            this.groupBox1.Controls.Add(this.rd15Intervalos);
            this.groupBox1.Controls.Add(this.rd10Intervalos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de intervalos";
            // 
            // rd20Intervalos
            // 
            this.rd20Intervalos.AutoSize = true;
            this.rd20Intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd20Intervalos.Location = new System.Drawing.Point(339, 19);
            this.rd20Intervalos.Name = "rd20Intervalos";
            this.rd20Intervalos.Size = new System.Drawing.Size(107, 21);
            this.rd20Intervalos.TabIndex = 0;
            this.rd20Intervalos.TabStop = true;
            this.rd20Intervalos.Text = "20 intervalos";
            this.rd20Intervalos.UseVisualStyleBackColor = true;
            // 
            // rd5intervalos
            // 
            this.rd5intervalos.AutoSize = true;
            this.rd5intervalos.Checked = true;
            this.rd5intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd5intervalos.Location = new System.Drawing.Point(8, 19);
            this.rd5intervalos.Name = "rd5intervalos";
            this.rd5intervalos.Size = new System.Drawing.Size(99, 21);
            this.rd5intervalos.TabIndex = 0;
            this.rd5intervalos.TabStop = true;
            this.rd5intervalos.Text = "5 intervalos";
            this.rd5intervalos.UseVisualStyleBackColor = true;
            // 
            // rd15Intervalos
            // 
            this.rd15Intervalos.AutoSize = true;
            this.rd15Intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd15Intervalos.Location = new System.Drawing.Point(226, 19);
            this.rd15Intervalos.Name = "rd15Intervalos";
            this.rd15Intervalos.Size = new System.Drawing.Size(107, 21);
            this.rd15Intervalos.TabIndex = 0;
            this.rd15Intervalos.TabStop = true;
            this.rd15Intervalos.Text = "15 intervalos";
            this.rd15Intervalos.UseVisualStyleBackColor = true;
            // 
            // rd10Intervalos
            // 
            this.rd10Intervalos.AutoSize = true;
            this.rd10Intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd10Intervalos.Location = new System.Drawing.Point(113, 19);
            this.rd10Intervalos.Name = "rd10Intervalos";
            this.rd10Intervalos.Size = new System.Drawing.Size(107, 21);
            this.rd10Intervalos.TabIndex = 0;
            this.rd10Intervalos.TabStop = true;
            this.rd10Intervalos.Text = "10 intervalos";
            this.rd10Intervalos.UseVisualStyleBackColor = true;
            // 
            // btnCalcularChi
            // 
            this.btnCalcularChi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcularChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularChi.Location = new System.Drawing.Point(478, 49);
            this.btnCalcularChi.Name = "btnCalcularChi";
            this.btnCalcularChi.Size = new System.Drawing.Size(77, 43);
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_SIM.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(368, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(420, 301);
            this.reportViewer1.TabIndex = 4;
            // 
            // btn_ValidarHipotesis
            // 
            this.btn_ValidarHipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValidarHipotesis.Location = new System.Drawing.Point(617, 18);
            this.btn_ValidarHipotesis.Name = "btn_ValidarHipotesis";
            this.btn_ValidarHipotesis.Size = new System.Drawing.Size(90, 48);
            this.btn_ValidarHipotesis.TabIndex = 5;
            this.btn_ValidarHipotesis.Text = "Validar Hipotesis";
            this.btn_ValidarHipotesis.UseVisualStyleBackColor = true;
            this.btn_ValidarHipotesis.Click += new System.EventHandler(this.btn_ValidarHipotesis_Click);
            // 
            // cmb_Significancia
            // 
            this.cmb_Significancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Significancia.FormattingEnabled = true;
            this.cmb_Significancia.Items.AddRange(new object[] {
            "0,995",
            "0,990",
            "0,975",
            "0,950",
            "0,900",
            "0,750",
            "0,500",
            "0,250",
            "0,100",
            "0,050",
            "0,025",
            "0,010",
            "0,005"});
            this.cmb_Significancia.Location = new System.Drawing.Point(399, 18);
            this.cmb_Significancia.Name = "cmb_Significancia";
            this.cmb_Significancia.Size = new System.Drawing.Size(121, 24);
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
            this.Hipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hipotesis.Location = new System.Drawing.Point(12, 405);
            this.Hipotesis.Name = "Hipotesis";
            this.Hipotesis.Size = new System.Drawing.Size(776, 72);
            this.Hipotesis.TabIndex = 7;
            this.Hipotesis.TabStop = false;
            this.Hipotesis.Text = "Hipotesis";
            // 
            // txt_ValorTabulado
            // 
            this.txt_ValorTabulado.Enabled = false;
            this.txt_ValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorTabulado.Location = new System.Drawing.Point(399, 43);
            this.txt_ValorTabulado.Name = "txt_ValorTabulado";
            this.txt_ValorTabulado.Size = new System.Drawing.Size(121, 23);
            this.txt_ValorTabulado.TabIndex = 13;
            // 
            // txt_Libertad
            // 
            this.txt_Libertad.Enabled = false;
            this.txt_Libertad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Libertad.Location = new System.Drawing.Point(161, 43);
            this.txt_Libertad.Name = "txt_Libertad";
            this.txt_Libertad.Size = new System.Drawing.Size(100, 23);
            this.txt_Libertad.TabIndex = 12;
            // 
            // txt_Estadistico
            // 
            this.txt_Estadistico.Enabled = false;
            this.txt_Estadistico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estadistico.Location = new System.Drawing.Point(161, 19);
            this.txt_Estadistico.Name = "txt_Estadistico";
            this.txt_Estadistico.Size = new System.Drawing.Size(100, 23);
            this.txt_Estadistico.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Tabulado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estadistico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "G. Libertad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Significancia";
            // 
            // TestChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
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