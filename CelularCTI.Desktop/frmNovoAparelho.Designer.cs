namespace CelularCTI.Desktop
{
    partial class frmNovoAparelho
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
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numEspessura = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(107, 33);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(218, 21);
            this.cmbFabricante.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fabricante:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(106, 84);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(340, 20);
            this.txtModelo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modelo:";
            // 
            // numLargura
            // 
            this.numLargura.DecimalPlaces = 2;
            this.numLargura.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLargura.Location = new System.Drawing.Point(107, 140);
            this.numLargura.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(71, 20);
            this.numLargura.TabIndex = 16;
            this.numLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLargura.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Largura (cm) :";
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAltura.Location = new System.Drawing.Point(107, 192);
            this.numAltura.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(71, 20);
            this.numAltura.TabIndex = 18;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAltura.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Altura (cm)";
            // 
            // numEspessura
            // 
            this.numEspessura.DecimalPlaces = 2;
            this.numEspessura.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEspessura.Location = new System.Drawing.Point(107, 237);
            this.numEspessura.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numEspessura.Name = "numEspessura";
            this.numEspessura.Size = new System.Drawing.Size(71, 20);
            this.numEspessura.TabIndex = 20;
            this.numEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEspessura.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Espessura (cm) :";
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPeso.Location = new System.Drawing.Point(107, 283);
            this.numPeso.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(71, 20);
            this.numPeso.TabIndex = 22;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPeso.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Peso (g)";
            // 
            // numQuantidade
            // 
            this.numQuantidade.DecimalPlaces = 2;
            this.numQuantidade.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQuantidade.Location = new System.Drawing.Point(363, 142);
            this.numQuantidade.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            65536});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(71, 20);
            this.numQuantidade.TabIndex = 24;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuantidade.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantidade:";
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPreco.Location = new System.Drawing.Point(363, 192);
            this.numPreco.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(71, 20);
            this.numPreco.TabIndex = 26;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPreco.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Preço:";
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 2;
            this.numDesconto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDesconto.Location = new System.Drawing.Point(363, 237);
            this.numDesconto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(71, 20);
            this.numDesconto.TabIndex = 28;
            this.numDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDesconto.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Desconto ( % ) :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(287, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 28);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(82, 351);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 28);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNovoAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 447);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numDesconto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numEspessura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLargura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label3);
            this.Name = "frmNovoAparelho";
            this.Text = "Cadastrar Novo Aparelho";
            this.Load += new System.EventHandler(this.frmNovoAparelho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEspessura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}