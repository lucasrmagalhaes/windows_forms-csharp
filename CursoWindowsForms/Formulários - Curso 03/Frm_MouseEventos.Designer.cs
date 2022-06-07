namespace CursoWindowsForms
{
    partial class Frm_MouseEventos
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
            this.Btn_Mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Mouse
            // 
            this.Btn_Mouse.Location = new System.Drawing.Point(148, 66);
            this.Btn_Mouse.Name = "Btn_Mouse";
            this.Btn_Mouse.Size = new System.Drawing.Size(272, 123);
            this.Btn_Mouse.TabIndex = 0;
            this.Btn_Mouse.UseVisualStyleBackColor = true;
            this.Btn_Mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Mouse_MouseDown);
            this.Btn_Mouse.MouseEnter += new System.EventHandler(this.Btn_Mouse_MouseEnter);
            this.Btn_Mouse.MouseLeave += new System.EventHandler(this.Btn_Mouse_MouseLeave);
            this.Btn_Mouse.MouseHover += new System.EventHandler(this.Btn_Mouse_MouseHover);
            this.Btn_Mouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Mouse_MouseUp);
            // 
            // Frm_MouseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 263);
            this.Controls.Add(this.Btn_Mouse);
            this.Name = "Frm_MouseEventos";
            this.Text = "Frm_MouseEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mouse;
    }
}