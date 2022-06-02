namespace CursoWindowsForms
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.Location = new System.Drawing.Point(18, 9);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(229, 20);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você deseja validar o CPF?";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(147, 60);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(115, 23);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "Sim. Continue";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(147, 98);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Não. Pare";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Image = global::CursoWindowsForms.Properties.Resources.icons8_question_mark_96;
            this.Pic_Imagem.Location = new System.Drawing.Point(22, 52);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(100, 87);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_Imagem.TabIndex = 3;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Lbl_Questao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questao;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox Pic_Imagem;
    }
}