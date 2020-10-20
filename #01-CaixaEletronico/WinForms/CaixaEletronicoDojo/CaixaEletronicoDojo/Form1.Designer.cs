namespace CaixaEletronicoDojo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ValorSacar = new System.Windows.Forms.TextBox();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.txt_Notas100 = new System.Windows.Forms.TextBox();
            this.txt_Notas50 = new System.Windows.Forms.TextBox();
            this.txt_Notas20 = new System.Windows.Forms.TextBox();
            this.txt_Notas10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_NovoSaque = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual valor deseja sacar?";
            // 
            // txt_ValorSacar
            // 
            this.txt_ValorSacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorSacar.Location = new System.Drawing.Point(15, 37);
            this.txt_ValorSacar.Name = "txt_ValorSacar";
            this.txt_ValorSacar.Size = new System.Drawing.Size(142, 20);
            this.txt_ValorSacar.TabIndex = 1;
            this.txt_ValorSacar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorSacar_KeyPress);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Location = new System.Drawing.Point(15, 63);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(67, 23);
            this.btn_Sacar.TabIndex = 2;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // txt_Notas100
            // 
            this.txt_Notas100.Location = new System.Drawing.Point(15, 120);
            this.txt_Notas100.Name = "txt_Notas100";
            this.txt_Notas100.ReadOnly = true;
            this.txt_Notas100.Size = new System.Drawing.Size(32, 20);
            this.txt_Notas100.TabIndex = 3;
            // 
            // txt_Notas50
            // 
            this.txt_Notas50.Location = new System.Drawing.Point(15, 146);
            this.txt_Notas50.Name = "txt_Notas50";
            this.txt_Notas50.ReadOnly = true;
            this.txt_Notas50.Size = new System.Drawing.Size(32, 20);
            this.txt_Notas50.TabIndex = 4;
            // 
            // txt_Notas20
            // 
            this.txt_Notas20.Location = new System.Drawing.Point(15, 172);
            this.txt_Notas20.Name = "txt_Notas20";
            this.txt_Notas20.ReadOnly = true;
            this.txt_Notas20.Size = new System.Drawing.Size(32, 20);
            this.txt_Notas20.TabIndex = 5;
            // 
            // txt_Notas10
            // 
            this.txt_Notas10.Location = new System.Drawing.Point(15, 198);
            this.txt_Notas10.Name = "txt_Notas10";
            this.txt_Notas10.ReadOnly = true;
            this.txt_Notas10.Size = new System.Drawing.Size(32, 20);
            this.txt_Notas10.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "- Notas de 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "- Notas de 50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "- Notas de 20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "- Notas de 10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade de Notas.";
            // 
            // btn_NovoSaque
            // 
            this.btn_NovoSaque.Location = new System.Drawing.Point(15, 224);
            this.btn_NovoSaque.Name = "btn_NovoSaque";
            this.btn_NovoSaque.Size = new System.Drawing.Size(142, 23);
            this.btn_NovoSaque.TabIndex = 12;
            this.btn_NovoSaque.Text = "Novo saque?";
            this.btn_NovoSaque.UseVisualStyleBackColor = true;
            this.btn_NovoSaque.Click += new System.EventHandler(this.btn_NovoSaque_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(93, 253);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(64, 23);
            this.btn_Sair.TabIndex = 13;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(177, 281);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_NovoSaque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Notas10);
            this.Controls.Add(this.txt_Notas20);
            this.Controls.Add(this.txt_Notas50);
            this.Controls.Add(this.txt_Notas100);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.txt_ValorSacar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ValorSacar;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.TextBox txt_Notas100;
        private System.Windows.Forms.TextBox txt_Notas50;
        private System.Windows.Forms.TextBox txt_Notas20;
        private System.Windows.Forms.TextBox txt_Notas10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_NovoSaque;
        private System.Windows.Forms.Button btn_Sair;
    }
}

