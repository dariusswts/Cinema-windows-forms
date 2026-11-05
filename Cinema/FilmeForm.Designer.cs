namespace Cinema
{
    partial class FilmeForm
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
            this.lstFilme = new System.Windows.Forms.ListBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFilme
            // 
            this.lstFilme.FormattingEnabled = true;
            this.lstFilme.Location = new System.Drawing.Point(431, 79);
            this.lstFilme.Name = "lstFilme";
            this.lstFilme.Size = new System.Drawing.Size(120, 95);
            this.lstFilme.TabIndex = 0;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(455, 180);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 1;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            // 
            // FilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.lstFilme);
            this.Name = "FilmeForm";
            this.Text = "FilmeForm";
            this.Load += new System.EventHandler(this.FilmeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFilme;
        private System.Windows.Forms.Button btnAfisare;
    }
}