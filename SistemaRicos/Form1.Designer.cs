namespace SistemaRicos
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
            this.comboRef = new System.Windows.Forms.ComboBox();
            this.ComboBeb = new System.Windows.Forms.ComboBox();
            this.Refeicao = new System.Windows.Forms.Label();
            this.Bebida = new System.Windows.Forms.Label();
            this.Mesa = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Extra = new System.Windows.Forms.Label();
            this.ComboExtra = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AdicionarRef = new System.Windows.Forms.Button();
            this.AdicionarBeb = new System.Windows.Forms.Button();
            this.AdicionarExt = new System.Windows.Forms.Button();
            this.sobremesa = new System.Windows.Forms.Label();
            this.comboSobrem = new System.Windows.Forms.ComboBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.AdicionarSobrem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRef
            // 
            this.comboRef.FormattingEnabled = true;
            this.comboRef.Location = new System.Drawing.Point(48, 100);
            this.comboRef.Name = "comboRef";
            this.comboRef.Size = new System.Drawing.Size(121, 24);
            this.comboRef.TabIndex = 0;
            this.comboRef.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboBeb
            // 
            this.ComboBeb.FormattingEnabled = true;
            this.ComboBeb.Location = new System.Drawing.Point(48, 168);
            this.ComboBeb.Name = "ComboBeb";
            this.ComboBeb.Size = new System.Drawing.Size(121, 24);
            this.ComboBeb.TabIndex = 1;
            this.ComboBeb.SelectedIndexChanged += new System.EventHandler(this.ComboBeb_SelectedIndexChanged);
            // 
            // Refeicao
            // 
            this.Refeicao.AutoSize = true;
            this.Refeicao.Location = new System.Drawing.Point(45, 74);
            this.Refeicao.Name = "Refeicao";
            this.Refeicao.Size = new System.Drawing.Size(62, 16);
            this.Refeicao.TabIndex = 2;
            this.Refeicao.Text = "Refeição";
            this.Refeicao.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bebida
            // 
            this.Bebida.AutoSize = true;
            this.Bebida.Location = new System.Drawing.Point(45, 149);
            this.Bebida.Name = "Bebida";
            this.Bebida.Size = new System.Drawing.Size(51, 16);
            this.Bebida.TabIndex = 3;
            this.Bebida.Text = "Bebida";
            // 
            // Mesa
            // 
            this.Mesa.AutoSize = true;
            this.Mesa.Location = new System.Drawing.Point(45, 30);
            this.Mesa.Name = "Mesa";
            this.Mesa.Size = new System.Drawing.Size(56, 16);
            this.Mesa.TabIndex = 4;
            this.Mesa.Text = "Mesa nº";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 100);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(35, 22);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(191, 169);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(33, 22);
            this.numericUpDown3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 22);
            this.textBox1.TabIndex = 10;
            // 
            // Extra
            // 
            this.Extra.AutoSize = true;
            this.Extra.Location = new System.Drawing.Point(45, 277);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(37, 16);
            this.Extra.TabIndex = 11;
            this.Extra.Text = "Extra";
            // 
            // ComboExtra
            // 
            this.ComboExtra.FormattingEnabled = true;
            this.ComboExtra.Location = new System.Drawing.Point(48, 296);
            this.ComboExtra.Name = "ComboExtra";
            this.ComboExtra.Size = new System.Drawing.Size(121, 24);
            this.ComboExtra.TabIndex = 12;
            this.ComboExtra.SelectedIndexChanged += new System.EventHandler(this.ComboExtra_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 296);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(33, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // AdicionarRef
            // 
            this.AdicionarRef.Location = new System.Drawing.Point(254, 99);
            this.AdicionarRef.Name = "AdicionarRef";
            this.AdicionarRef.Size = new System.Drawing.Size(75, 23);
            this.AdicionarRef.TabIndex = 14;
            this.AdicionarRef.Text = "Adicionar";
            this.AdicionarRef.UseVisualStyleBackColor = true;
            // 
            // AdicionarBeb
            // 
            this.AdicionarBeb.Location = new System.Drawing.Point(254, 169);
            this.AdicionarBeb.Name = "AdicionarBeb";
            this.AdicionarBeb.Size = new System.Drawing.Size(75, 23);
            this.AdicionarBeb.TabIndex = 15;
            this.AdicionarBeb.Text = "Adicionar";
            this.AdicionarBeb.UseVisualStyleBackColor = true;
            // 
            // AdicionarExt
            // 
            this.AdicionarExt.Location = new System.Drawing.Point(254, 295);
            this.AdicionarExt.Name = "AdicionarExt";
            this.AdicionarExt.Size = new System.Drawing.Size(75, 23);
            this.AdicionarExt.TabIndex = 16;
            this.AdicionarExt.Text = "Adicionar";
            this.AdicionarExt.UseVisualStyleBackColor = true;
            // 
            // sobremesa
            // 
            this.sobremesa.AutoSize = true;
            this.sobremesa.Location = new System.Drawing.Point(45, 214);
            this.sobremesa.Name = "sobremesa";
            this.sobremesa.Size = new System.Drawing.Size(78, 16);
            this.sobremesa.TabIndex = 17;
            this.sobremesa.Text = "Sobremesa";
            // 
            // comboSobrem
            // 
            this.comboSobrem.FormattingEnabled = true;
            this.comboSobrem.Location = new System.Drawing.Point(48, 233);
            this.comboSobrem.Name = "comboSobrem";
            this.comboSobrem.Size = new System.Drawing.Size(121, 24);
            this.comboSobrem.TabIndex = 18;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(193, 233);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(33, 22);
            this.numericUpDown4.TabIndex = 19;
            // 
            // AdicionarSobrem
            // 
            this.AdicionarSobrem.Location = new System.Drawing.Point(254, 232);
            this.AdicionarSobrem.Name = "AdicionarSobrem";
            this.AdicionarSobrem.Size = new System.Drawing.Size(75, 23);
            this.AdicionarSobrem.TabIndex = 20;
            this.AdicionarSobrem.Text = "Adicionar";
            this.AdicionarSobrem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.AdicionarSobrem);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.comboSobrem);
            this.Controls.Add(this.sobremesa);
            this.Controls.Add(this.AdicionarExt);
            this.Controls.Add(this.AdicionarBeb);
            this.Controls.Add(this.AdicionarRef);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ComboExtra);
            this.Controls.Add(this.Extra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.Mesa);
            this.Controls.Add(this.Bebida);
            this.Controls.Add(this.Refeicao);
            this.Controls.Add(this.ComboBeb);
            this.Controls.Add(this.comboRef);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRef;
        private System.Windows.Forms.ComboBox ComboBeb;
        private System.Windows.Forms.Label Refeicao;
        private System.Windows.Forms.Label Bebida;
        private System.Windows.Forms.Label Mesa;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Extra;
        private System.Windows.Forms.ComboBox ComboExtra;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AdicionarRef;
        private System.Windows.Forms.Button AdicionarBeb;
        private System.Windows.Forms.Button AdicionarExt;
        private System.Windows.Forms.Label sobremesa;
        private System.Windows.Forms.ComboBox comboSobrem;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button AdicionarSobrem;
    }
}