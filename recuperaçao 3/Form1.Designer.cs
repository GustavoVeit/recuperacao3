namespace recuperaçao_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbQuadrilatero = new System.Windows.Forms.RadioButton();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.btnCalcularCirculo = new System.Windows.Forms.Button();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado1Quadri = new System.Windows.Forms.TextBox();
            this.txtLado2Quadri = new System.Windows.Forms.TextBox();
            this.txtLado3Quadri = new System.Windows.Forms.TextBox();
            this.txtLado4Quadri = new System.Windows.Forms.TextBox();
            this.btnCalcularTriangulo = new System.Windows.Forms.Button();
            this.btnCalcularQuadrilatero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTriangulo.Location = new System.Drawing.Point(349, 61);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(92, 24);
            this.rbTriangulo.TabIndex = 0;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triângulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCirculo.Location = new System.Drawing.Point(106, 61);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(75, 24);
            this.rbCirculo.TabIndex = 1;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbQuadrilatero
            // 
            this.rbQuadrilatero.AutoSize = true;
            this.rbQuadrilatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuadrilatero.Location = new System.Drawing.Point(595, 61);
            this.rbQuadrilatero.Name = "rbQuadrilatero";
            this.rbQuadrilatero.Size = new System.Drawing.Size(111, 24);
            this.rbQuadrilatero.TabIndex = 2;
            this.rbQuadrilatero.TabStop = true;
            this.rbQuadrilatero.Text = "quadrilatero";
            this.rbQuadrilatero.UseVisualStyleBackColor = true;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(77, 132);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(100, 20);
            this.txtDiametro.TabIndex = 3;
            // 
            // btnCalcularCirculo
            // 
            this.btnCalcularCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCirculo.Location = new System.Drawing.Point(60, 319);
            this.btnCalcularCirculo.Name = "btnCalcularCirculo";
            this.btnCalcularCirculo.Size = new System.Drawing.Size(103, 42);
            this.btnCalcularCirculo.TabIndex = 4;
            this.btnCalcularCirculo.Text = "Calcular";
            this.btnCalcularCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularCirculo.Click += new System.EventHandler(this.btnCalcularCirculo_Click);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(340, 128);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 5;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(340, 179);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 6;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(340, 232);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 7;
            // 
            // txtLado1Quadri
            // 
            this.txtLado1Quadri.Location = new System.Drawing.Point(595, 124);
            this.txtLado1Quadri.Name = "txtLado1Quadri";
            this.txtLado1Quadri.Size = new System.Drawing.Size(100, 20);
            this.txtLado1Quadri.TabIndex = 9;
            // 
            // txtLado2Quadri
            // 
            this.txtLado2Quadri.Location = new System.Drawing.Point(595, 182);
            this.txtLado2Quadri.Name = "txtLado2Quadri";
            this.txtLado2Quadri.Size = new System.Drawing.Size(100, 20);
            this.txtLado2Quadri.TabIndex = 10;
            // 
            // txtLado3Quadri
            // 
            this.txtLado3Quadri.Location = new System.Drawing.Point(595, 235);
            this.txtLado3Quadri.Name = "txtLado3Quadri";
            this.txtLado3Quadri.Size = new System.Drawing.Size(100, 20);
            this.txtLado3Quadri.TabIndex = 11;
            // 
            // txtLado4Quadri
            // 
            this.txtLado4Quadri.Location = new System.Drawing.Point(595, 275);
            this.txtLado4Quadri.Name = "txtLado4Quadri";
            this.txtLado4Quadri.Size = new System.Drawing.Size(100, 20);
            this.txtLado4Quadri.TabIndex = 12;
            // 
            // btnCalcularTriangulo
            // 
            this.btnCalcularTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTriangulo.Location = new System.Drawing.Point(349, 330);
            this.btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            this.btnCalcularTriangulo.Size = new System.Drawing.Size(103, 42);
            this.btnCalcularTriangulo.TabIndex = 13;
            this.btnCalcularTriangulo.Text = "Calcular";
            this.btnCalcularTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularTriangulo.Click += new System.EventHandler(this.btnCalcularTriangulo_Click);
            // 
            // btnCalcularQuadrilatero
            // 
            this.btnCalcularQuadrilatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularQuadrilatero.Location = new System.Drawing.Point(567, 330);
            this.btnCalcularQuadrilatero.Name = "btnCalcularQuadrilatero";
            this.btnCalcularQuadrilatero.Size = new System.Drawing.Size(103, 42);
            this.btnCalcularQuadrilatero.TabIndex = 14;
            this.btnCalcularQuadrilatero.Text = "Calcular";
            this.btnCalcularQuadrilatero.UseVisualStyleBackColor = true;
            this.btnCalcularQuadrilatero.Click += new System.EventHandler(this.btnCalcularQuadrilatero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "diametro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "lado 1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "lado 2 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "lado 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "lado 1 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "lado 2 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "lado 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "lado 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularQuadrilatero);
            this.Controls.Add(this.btnCalcularTriangulo);
            this.Controls.Add(this.txtLado4Quadri);
            this.Controls.Add(this.txtLado3Quadri);
            this.Controls.Add(this.txtLado2Quadri);
            this.Controls.Add(this.txtLado1Quadri);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.btnCalcularCirculo);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.rbQuadrilatero);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.rbTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbQuadrilatero;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.Button btnCalcularCirculo;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado1Quadri;
        private System.Windows.Forms.TextBox txtLado2Quadri;
        private System.Windows.Forms.TextBox txtLado3Quadri;
        private System.Windows.Forms.TextBox txtLado4Quadri;
        private System.Windows.Forms.Button btnCalcularTriangulo;
        private System.Windows.Forms.Button btnCalcularQuadrilatero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

