namespace WindowsFormsCafeteria
{
    partial class FormEstoqueIncluir
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
            this.lblTipoDeCapsula = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.cbxTipoDeCapsula = new System.Windows.Forms.ComboBox();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(186, 183);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(129, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir Cápsula(s)";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblTipoDeCapsula
            // 
            this.lblTipoDeCapsula.AutoSize = true;
            this.lblTipoDeCapsula.Location = new System.Drawing.Point(12, 9);
            this.lblTipoDeCapsula.Name = "lblTipoDeCapsula";
            this.lblTipoDeCapsula.Size = new System.Drawing.Size(134, 13);
            this.lblTipoDeCapsula.TabIndex = 1;
            this.lblTipoDeCapsula.Text = "Escolha o Tipo de Cápsula";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(15, 79);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(300, 20);
            this.tbxQuantidade.TabIndex = 2;
            // 
            // cbxTipoDeCapsula
            // 
            this.cbxTipoDeCapsula.FormattingEnabled = true;
            this.cbxTipoDeCapsula.Location = new System.Drawing.Point(15, 25);
            this.cbxTipoDeCapsula.Name = "cbxTipoDeCapsula";
            this.cbxTipoDeCapsula.Size = new System.Drawing.Size(300, 21);
            this.cbxTipoDeCapsula.TabIndex = 3;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.Location = new System.Drawing.Point(12, 138);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(303, 20);
            this.dtpDataDeValidade.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 63);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.Location = new System.Drawing.Point(12, 122);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(89, 13);
            this.lblDataDeValidade.TabIndex = 6;
            this.lblDataDeValidade.Text = "Data de Validade";
            // 
            // FormEstoqueIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 224);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dtpDataDeValidade);
            this.Controls.Add(this.cbxTipoDeCapsula);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.lblTipoDeCapsula);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FormEstoqueIncluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblTipoDeCapsula;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.ComboBox cbxTipoDeCapsula;
        private System.Windows.Forms.DateTimePicker dtpDataDeValidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataDeValidade;
    }
}