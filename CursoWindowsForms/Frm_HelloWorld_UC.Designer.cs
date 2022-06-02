namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(25, 100);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(653, 20);
            this.Txt_ConteudoLabel.TabIndex = 6;
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(25, 60);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.Btn_ModificaLabel.TabIndex = 5;
            this.Btn_ModificaLabel.Text = "Modifica Texto do Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(21, 26);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(711, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
        private System.Windows.Forms.Button Btn_ModificaLabel;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}
