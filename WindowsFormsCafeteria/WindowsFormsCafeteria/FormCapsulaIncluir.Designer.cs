namespace WindowsFormsCafeteria
{
    partial class FormCapsulaIncluir
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxForca = new System.Windows.Forms.ComboBox();
            this.lblForca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(187, 119);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(125, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir Cápsula";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(12, 25);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(300, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(111, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição da Cápsula";
            // 
            // cbxForca
            // 
            this.cbxForca.FormattingEnabled = true;
            this.cbxForca.Items.AddRange(new object[] {
            "Selecione um valor para força : ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxForca.Location = new System.Drawing.Point(12, 74);
            this.cbxForca.Name = "cbxForca";
            this.cbxForca.Size = new System.Drawing.Size(300, 21);
            this.cbxForca.TabIndex = 3;
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.Location = new System.Drawing.Point(9, 58);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(90, 13);
            this.lblForca.TabIndex = 4;
            this.lblForca.Text = "Força da Cápsula";
            // 
            // FormCapsulaIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 164);
            this.Controls.Add(this.lblForca);
            this.Controls.Add(this.cbxForca);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FormCapsulaIncluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cápsulas de Café";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbxForca;
        private System.Windows.Forms.Label lblForca;
    }
}