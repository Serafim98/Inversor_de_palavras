namespace Exercicio4 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_original = new System.Windows.Forms.TextBox();
            this.BT_Processa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Invertida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase original";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_original
            // 
            this.TB_original.Location = new System.Drawing.Point(106, 29);
            this.TB_original.Name = "TB_original";
            this.TB_original.Size = new System.Drawing.Size(100, 20);
            this.TB_original.TabIndex = 1;
            // 
            // BT_Processa
            // 
            this.BT_Processa.Location = new System.Drawing.Point(258, 29);
            this.BT_Processa.Name = "BT_Processa";
            this.BT_Processa.Size = new System.Drawing.Size(75, 23);
            this.BT_Processa.TabIndex = 2;
            this.BT_Processa.Text = "Processa";
            this.BT_Processa.UseVisualStyleBackColor = true;
            this.BT_Processa.Click += new System.EventHandler(this.BT_Processa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase invertida";
            // 
            // TB_Invertida
            // 
            this.TB_Invertida.Location = new System.Drawing.Point(106, 66);
            this.TB_Invertida.Name = "TB_Invertida";
            this.TB_Invertida.Size = new System.Drawing.Size(100, 20);
            this.TB_Invertida.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 196);
            this.Controls.Add(this.TB_Invertida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Processa);
            this.Controls.Add(this.TB_original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_original;
        private System.Windows.Forms.Button BT_Processa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Invertida;
    }
}

