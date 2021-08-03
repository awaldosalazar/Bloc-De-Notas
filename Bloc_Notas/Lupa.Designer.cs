namespace Bloc_Notas
{
    partial class Lupa
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
            this.textBoxLupa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLupa
            // 
            this.textBoxLupa.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLupa.ForeColor = System.Drawing.Color.Red;
            this.textBoxLupa.Location = new System.Drawing.Point(1, 2);
            this.textBoxLupa.Multiline = true;
            this.textBoxLupa.Name = "textBoxLupa";
            this.textBoxLupa.Size = new System.Drawing.Size(190, 140);
            this.textBoxLupa.TabIndex = 0;
            this.textBoxLupa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLupa.TextChanged += new System.EventHandler(this.textBoxLupa_TextChanged);
            // 
            // Lupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 142);
            this.Controls.Add(this.textBoxLupa);
            this.Name = "Lupa";
            this.Text = "Lupa";
            this.Load += new System.EventHandler(this.Lupa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLupa;
    }
}