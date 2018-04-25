namespace Media
{
    partial class Form1
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.txb1Bim = new System.Windows.Forms.TextBox();
            this.lbl2Bim = new System.Windows.Forms.Label();
            this.txb2Bim = new System.Windows.Forms.TextBox();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.txb3Bim = new System.Windows.Forms.TextBox();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.txb4Bim = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(50, 52);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(80, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do Aluno";
            this.lblAluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(140, 49);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(12, 104);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl1Bim.TabIndex = 2;
            this.lbl1Bim.Text = "1º BIM";
            // 
            // txb1Bim
            // 
            this.txb1Bim.Location = new System.Drawing.Point(53, 104);
            this.txb1Bim.Name = "txb1Bim";
            this.txb1Bim.Size = new System.Drawing.Size(100, 20);
            this.txb1Bim.TabIndex = 3;
            // 
            // lbl2Bim
            // 
            this.lbl2Bim.AutoSize = true;
            this.lbl2Bim.Location = new System.Drawing.Point(182, 107);
            this.lbl2Bim.Name = "lbl2Bim";
            this.lbl2Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl2Bim.TabIndex = 4;
            this.lbl2Bim.Text = "2º BIM";
            // 
            // txb2Bim
            // 
            this.txb2Bim.Location = new System.Drawing.Point(223, 104);
            this.txb2Bim.Name = "txb2Bim";
            this.txb2Bim.Size = new System.Drawing.Size(100, 20);
            this.txb2Bim.TabIndex = 5;
            this.txb2Bim.TextChanged += new System.EventHandler(this.txb2bim_TextChanged);
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(12, 149);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl3Bim.TabIndex = 6;
            this.lbl3Bim.Text = "3º BIM";
            // 
            // txb3Bim
            // 
            this.txb3Bim.Location = new System.Drawing.Point(53, 149);
            this.txb3Bim.Name = "txb3Bim";
            this.txb3Bim.Size = new System.Drawing.Size(100, 20);
            this.txb3Bim.TabIndex = 7;
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(182, 156);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl4Bim.TabIndex = 8;
            this.lbl4Bim.Text = "4º BIM";
            // 
            // txb4Bim
            // 
            this.txb4Bim.Location = new System.Drawing.Point(223, 156);
            this.txb4Bim.Name = "txb4Bim";
            this.txb4Bim.Size = new System.Drawing.Size(100, 20);
            this.txb4Bim.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(157, 259);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 11;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(157, 304);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 13);
            this.lblMedia.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 387);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txb4Bim);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.txb3Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.txb2Bim);
            this.Controls.Add(this.lbl2Bim);
            this.Controls.Add(this.txb1Bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.TextBox txb1Bim;
        private System.Windows.Forms.Label lbl2Bim;
        private System.Windows.Forms.TextBox txb2Bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.TextBox txb3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.TextBox txb4Bim;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMedia;
    }
}

