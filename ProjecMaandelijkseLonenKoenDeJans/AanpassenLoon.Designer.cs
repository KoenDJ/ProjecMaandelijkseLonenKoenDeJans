namespace ProjecMaandelijkseLonenKoenDeJans
{
    partial class AanpassenLoon
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBasisloon = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basisloon: ";
            // 
            // tbBasisloon
            // 
            this.tbBasisloon.Location = new System.Drawing.Point(85, 6);
            this.tbBasisloon.Name = "tbBasisloon";
            this.tbBasisloon.Size = new System.Drawing.Size(238, 22);
            this.tbBasisloon.TabIndex = 1;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 34);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(143, 30);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(161, 34);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(162, 30);
            this.btnOpslaan.TabIndex = 3;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // AanpassenLoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 76);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.tbBasisloon);
            this.Controls.Add(this.label1);
            this.Name = "AanpassenLoon";
            this.Text = "AanpassenLoon";
            this.Load += new System.EventHandler(this.AanpassenLoon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBasisloon;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnOpslaan;
    }
}