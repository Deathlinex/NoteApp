namespace NoteAppUI
{
    partial class AboutForm
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
            this.AutorBottomLabel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EmaleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmaleLabel = new System.Windows.Forms.Label();
            this.AutorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AutorBottomLabel
            // 
            this.AutorBottomLabel.AutoSize = true;
            this.AutorBottomLabel.Location = new System.Drawing.Point(13, 240);
            this.AutorBottomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AutorBottomLabel.Name = "AutorBottomLabel";
            this.AutorBottomLabel.Size = new System.Drawing.Size(116, 13);
            this.AutorBottomLabel.TabIndex = 15;
            this.AutorBottomLabel.Text = "2020 Ilya Adamchuk ©";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(60, 169);
            this.GitHubLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(197, 13);
            this.GitHubLinkLabel.TabIndex = 14;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/Deathlinex/NoteApp";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // EmaleLinkLabel
            // 
            this.EmaleLinkLabel.AutoSize = true;
            this.EmaleLinkLabel.Location = new System.Drawing.Point(112, 151);
            this.EmaleLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmaleLinkLabel.Name = "EmaleLinkLabel";
            this.EmaleLinkLabel.Size = new System.Drawing.Size(99, 13);
            this.EmaleLinkLabel.TabIndex = 13;
            this.EmaleLinkLabel.TabStop = true;
            this.EmaleLinkLabel.Text = "fake_mail@gmail.ru";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(13, 169);
            this.GitHubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(43, 13);
            this.GitHubLabel.TabIndex = 12;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // EmaleLabel
            // 
            this.EmaleLabel.AutoSize = true;
            this.EmaleLabel.Location = new System.Drawing.Point(13, 151);
            this.EmaleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmaleLabel.Name = "EmaleLabel";
            this.EmaleLabel.Size = new System.Drawing.Size(100, 13);
            this.EmaleLabel.TabIndex = 11;
            this.EmaleLabel.Text = "e-mail for feedback:";
            // 
            // AutorLabel
            // 
            this.AutorLabel.AutoSize = true;
            this.AutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorLabel.Location = new System.Drawing.Point(13, 95);
            this.AutorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AutorLabel.Name = "AutorLabel";
            this.AutorLabel.Size = new System.Drawing.Size(108, 13);
            this.AutorLabel.TabIndex = 10;
            this.AutorLabel.Text = "Autor: Ilya Adamchuk";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(13, 39);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(41, 13);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "V 1.0.0";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(11, 9);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(115, 29);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 286);
            this.Controls.Add(this.AutorBottomLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmaleLinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmaleLabel);
            this.Controls.Add(this.AutorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximumSize = new System.Drawing.Size(330, 325);
            this.MinimumSize = new System.Drawing.Size(330, 325);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutorBottomLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.LinkLabel EmaleLinkLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.Label EmaleLabel;
        private System.Windows.Forms.Label AutorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}