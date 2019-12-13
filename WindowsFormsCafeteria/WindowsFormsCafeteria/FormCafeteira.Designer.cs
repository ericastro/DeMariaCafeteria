namespace WindowsFormsCafeteria
{
    partial class FormCafeteira
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
            this.btnFazerCafe = new System.Windows.Forms.Button();
            this.lblTipoDeCapsula = new System.Windows.Forms.Label();
            this.cbxTipoDeCapsula = new System.Windows.Forms.ComboBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFazerCafe
            // 
            this.btnFazerCafe.Location = new System.Drawing.Point(214, 122);
            this.btnFazerCafe.Name = "btnFazerCafe";
            this.btnFazerCafe.Size = new System.Drawing.Size(98, 23);
            this.btnFazerCafe.TabIndex = 0;
            this.btnFazerCafe.Text = "FazerCafé";
            this.btnFazerCafe.UseVisualStyleBackColor = true;
            this.btnFazerCafe.Click += new System.EventHandler(this.btnFazerCafe_Click);
            // 
            // lblTipoDeCapsula
            // 
            this.lblTipoDeCapsula.AutoSize = true;
            this.lblTipoDeCapsula.Location = new System.Drawing.Point(12, 9);
            this.lblTipoDeCapsula.Name = "lblTipoDeCapsula";
            this.lblTipoDeCapsula.Size = new System.Drawing.Size(183, 13);
            this.lblTipoDeCapsula.TabIndex = 1;
            this.lblTipoDeCapsula.Text = "Selecione o Tipo de Cápsula de Café";
            // 
            // cbxTipoDeCapsula
            // 
            this.cbxTipoDeCapsula.FormattingEnabled = true;
            this.cbxTipoDeCapsula.Location = new System.Drawing.Point(12, 25);
            this.cbxTipoDeCapsula.Name = "cbxTipoDeCapsula";
            this.cbxTipoDeCapsula.Size = new System.Drawing.Size(300, 21);
            this.cbxTipoDeCapsula.TabIndex = 2;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(12, 77);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(300, 20);
            this.tbxQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(9, 61);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(121, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade de xícaras :";
            // 
            // FormCafeteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 168);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.cbxTipoDeCapsula);
            this.Controls.Add(this.lblTipoDeCapsula);
            this.Controls.Add(this.btnFazerCafe);
            this.Name = "FormCafeteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeteira DeMaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFazerCafe;
        private System.Windows.Forms.Label lblTipoDeCapsula;
        private System.Windows.Forms.ComboBox cbxTipoDeCapsula;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}