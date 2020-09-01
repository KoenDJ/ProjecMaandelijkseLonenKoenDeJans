namespace ProjecMaandelijkseLonenKoenDeJans
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbWerknemerGegevens = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnWerknemerAanmaken = new System.Windows.Forms.Button();
            this.btnWerkNemerAanpassen = new System.Windows.Forms.Button();
            this.btnVerwijderenWerknemer = new System.Windows.Forms.Button();
            this.btnLoonbriefAanmaken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.lblGeboorteDatumInvullen = new System.Windows.Forms.Label();
            this.lblRijksregisterInvullen = new System.Windows.Forms.Label();
            this.lblInvullenDatIndiest = new System.Windows.Forms.Label();
            this.lblInvullenIbanNr = new System.Windows.Forms.Label();
            this.btnBasisloonAanpassen = new System.Windows.Forms.Button();
            this.gbWerknemerGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Werknemer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geslacht:                           ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(12, 39);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(121, 24);
            this.cbWerknemers.TabIndex = 2;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // gbWerknemerGegevens
            // 
            this.gbWerknemerGegevens.Controls.Add(this.lblInvullenIbanNr);
            this.gbWerknemerGegevens.Controls.Add(this.lblInvullenDatIndiest);
            this.gbWerknemerGegevens.Controls.Add(this.lblRijksregisterInvullen);
            this.gbWerknemerGegevens.Controls.Add(this.lblGeboorteDatumInvullen);
            this.gbWerknemerGegevens.Controls.Add(this.lblGeslacht);
            this.gbWerknemerGegevens.Controls.Add(this.label6);
            this.gbWerknemerGegevens.Controls.Add(this.label5);
            this.gbWerknemerGegevens.Controls.Add(this.label4);
            this.gbWerknemerGegevens.Controls.Add(this.label3);
            this.gbWerknemerGegevens.Controls.Add(this.label2);
            this.gbWerknemerGegevens.Location = new System.Drawing.Point(12, 217);
            this.gbWerknemerGegevens.Name = "gbWerknemerGegevens";
            this.gbWerknemerGegevens.Size = new System.Drawing.Size(561, 183);
            this.gbWerknemerGegevens.TabIndex = 3;
            this.gbWerknemerGegevens.TabStop = false;
            this.gbWerknemerGegevens.Text = "Gegevens";
            this.gbWerknemerGegevens.Enter += new System.EventHandler(this.gbWerknemerGegevens_Enter);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnWerknemerAanmaken
            // 
            this.btnWerknemerAanmaken.Location = new System.Drawing.Point(169, 41);
            this.btnWerknemerAanmaken.Name = "btnWerknemerAanmaken";
            this.btnWerknemerAanmaken.Size = new System.Drawing.Size(234, 23);
            this.btnWerknemerAanmaken.TabIndex = 4;
            this.btnWerknemerAanmaken.Text = "Aanmaken nieuwe Werknemer";
            this.btnWerknemerAanmaken.UseVisualStyleBackColor = true;
            this.btnWerknemerAanmaken.Click += new System.EventHandler(this.btnWerknemerAanmaken_Click);
            // 
            // btnWerkNemerAanpassen
            // 
            this.btnWerkNemerAanpassen.Location = new System.Drawing.Point(169, 70);
            this.btnWerkNemerAanpassen.Name = "btnWerkNemerAanpassen";
            this.btnWerkNemerAanpassen.Size = new System.Drawing.Size(234, 23);
            this.btnWerkNemerAanpassen.TabIndex = 5;
            this.btnWerkNemerAanpassen.Text = "Aanpassen Werknemer";
            this.btnWerkNemerAanpassen.UseVisualStyleBackColor = true;
            this.btnWerkNemerAanpassen.Click += new System.EventHandler(this.btnWerkNemerAanpassen_Click);
            // 
            // btnVerwijderenWerknemer
            // 
            this.btnVerwijderenWerknemer.Location = new System.Drawing.Point(169, 99);
            this.btnVerwijderenWerknemer.Name = "btnVerwijderenWerknemer";
            this.btnVerwijderenWerknemer.Size = new System.Drawing.Size(234, 23);
            this.btnVerwijderenWerknemer.TabIndex = 6;
            this.btnVerwijderenWerknemer.Text = "Verwijderen  Werknemer";
            this.btnVerwijderenWerknemer.UseVisualStyleBackColor = true;
            this.btnVerwijderenWerknemer.Click += new System.EventHandler(this.btnVerwijderenWerknemer_Click);
            // 
            // btnLoonbriefAanmaken
            // 
            this.btnLoonbriefAanmaken.Location = new System.Drawing.Point(169, 188);
            this.btnLoonbriefAanmaken.Name = "btnLoonbriefAanmaken";
            this.btnLoonbriefAanmaken.Size = new System.Drawing.Size(234, 23);
            this.btnLoonbriefAanmaken.TabIndex = 7;
            this.btnLoonbriefAanmaken.Text = "Loonbrief Aanmaken";
            this.btnLoonbriefAanmaken.UseVisualStyleBackColor = true;
            this.btnLoonbriefAanmaken.Click += new System.EventHandler(this.btnLoonbriefAanmaken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geboortedatum:                ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rijksregister nr.:               ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum van indiensttreding: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "IBAN nr.:                             ";
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.AutoSize = true;
            this.lblGeslacht.Location = new System.Drawing.Point(214, 35);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(113, 17);
            this.lblGeslacht.TabIndex = 2;
            this.lblGeslacht.Text = "invullen geslacht";
            this.lblGeslacht.Click += new System.EventHandler(this.lblGeslacht_Click);
            // 
            // lblGeboorteDatumInvullen
            // 
            this.lblGeboorteDatumInvullen.AutoSize = true;
            this.lblGeboorteDatumInvullen.Location = new System.Drawing.Point(214, 61);
            this.lblGeboorteDatumInvullen.Name = "lblGeboorteDatumInvullen";
            this.lblGeboorteDatumInvullen.Size = new System.Drawing.Size(156, 17);
            this.lblGeboorteDatumInvullen.TabIndex = 12;
            this.lblGeboorteDatumInvullen.Text = "invullen geboortedatum";
            // 
            // lblRijksregisterInvullen
            // 
            this.lblRijksregisterInvullen.AutoSize = true;
            this.lblRijksregisterInvullen.Location = new System.Drawing.Point(214, 92);
            this.lblRijksregisterInvullen.Name = "lblRijksregisterInvullen";
            this.lblRijksregisterInvullen.Size = new System.Drawing.Size(138, 17);
            this.lblRijksregisterInvullen.TabIndex = 13;
            this.lblRijksregisterInvullen.Text = "invullen Rijksregister";
            // 
            // lblInvullenDatIndiest
            // 
            this.lblInvullenDatIndiest.AutoSize = true;
            this.lblInvullenDatIndiest.Location = new System.Drawing.Point(214, 118);
            this.lblInvullenDatIndiest.Name = "lblInvullenDatIndiest";
            this.lblInvullenDatIndiest.Size = new System.Drawing.Size(196, 17);
            this.lblInvullenDatIndiest.TabIndex = 14;
            this.lblInvullenDatIndiest.Text = "invullen datum indiensttreding";
            // 
            // lblInvullenIbanNr
            // 
            this.lblInvullenIbanNr.AutoSize = true;
            this.lblInvullenIbanNr.Location = new System.Drawing.Point(214, 145);
            this.lblInvullenIbanNr.Name = "lblInvullenIbanNr";
            this.lblInvullenIbanNr.Size = new System.Drawing.Size(108, 17);
            this.lblInvullenIbanNr.TabIndex = 15;
            this.lblInvullenIbanNr.Text = "invullen Iban nr.";
            // 
            // btnBasisloonAanpassen
            // 
            this.btnBasisloonAanpassen.Location = new System.Drawing.Point(169, 144);
            this.btnBasisloonAanpassen.Name = "btnBasisloonAanpassen";
            this.btnBasisloonAanpassen.Size = new System.Drawing.Size(234, 23);
            this.btnBasisloonAanpassen.TabIndex = 8;
            this.btnBasisloonAanpassen.Text = "Aanpassen Basisloon";
            this.btnBasisloonAanpassen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 522);
            this.Controls.Add(this.btnBasisloonAanpassen);
            this.Controls.Add(this.btnLoonbriefAanmaken);
            this.Controls.Add(this.btnVerwijderenWerknemer);
            this.Controls.Add(this.btnWerkNemerAanpassen);
            this.Controls.Add(this.btnWerknemerAanmaken);
            this.Controls.Add(this.gbWerknemerGegevens);
            this.Controls.Add(this.cbWerknemers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWerknemerGegevens.ResumeLayout(false);
            this.gbWerknemerGegevens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbWerknemerGegevens;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnWerknemerAanmaken;
        private System.Windows.Forms.Button btnWerkNemerAanpassen;
        private System.Windows.Forms.Button btnVerwijderenWerknemer;
        private System.Windows.Forms.Button btnLoonbriefAanmaken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGeslacht;
        private System.Windows.Forms.Button btnBasisloonAanpassen;
        private System.Windows.Forms.Label lblInvullenIbanNr;
        private System.Windows.Forms.Label lblInvullenDatIndiest;
        private System.Windows.Forms.Label lblRijksregisterInvullen;
        private System.Windows.Forms.Label lblGeboorteDatumInvullen;
    }
}

