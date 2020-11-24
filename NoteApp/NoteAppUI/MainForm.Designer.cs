namespace NoteAppUI
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteTMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CategoryComboLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTimeLabel = new System.Windows.Forms.Label();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(834, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolMainMenuStrip});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem.Text = "File";
            // 
            // exitToolMainMenuStrip
            // 
            this.exitToolMainMenuStrip.Name = "exitToolMainMenuStrip";
            this.exitToolMainMenuStrip.Size = new System.Drawing.Size(93, 22);
            this.exitToolMainMenuStrip.Text = "Exit";
            this.exitToolMainMenuStrip.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteMainMenuStrip,
            this.EditNoteTMainMenuStrip,
            this.RemoveNoteMainMenuStrip});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aboutToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteMainMenuStrip
            // 
            this.AddNoteMainMenuStrip.Name = "AddNoteMainMenuStrip";
            this.AddNoteMainMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.AddNoteMainMenuStrip.Text = "Add Note";
            this.AddNoteMainMenuStrip.Click += new System.EventHandler(this.AddNoteMainMenuStrip_Click);
            // 
            // EditNoteTMainMenuStrip
            // 
            this.EditNoteTMainMenuStrip.Name = "EditNoteTMainMenuStrip";
            this.EditNoteTMainMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.EditNoteTMainMenuStrip.Text = "Edit Note";
            this.EditNoteTMainMenuStrip.Click += new System.EventHandler(this.EditNoteMainMenuStrip_Click);
            // 
            // RemoveNoteMainMenuStrip
            // 
            this.RemoveNoteMainMenuStrip.Name = "RemoveNoteMainMenuStrip";
            this.RemoveNoteMainMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.RemoveNoteMainMenuStrip.Text = "Remove Note";
            this.RemoveNoteMainMenuStrip.Click += new System.EventHandler(this.RemoveNoteMainMenuStrip_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMainMenuStrip});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMainMenuStrip
            // 
            this.aboutMainMenuStrip.Name = "aboutMainMenuStrip";
            this.aboutMainMenuStrip.Size = new System.Drawing.Size(107, 22);
            this.aboutMainMenuStrip.Text = "About";
            this.aboutMainMenuStrip.Click += new System.EventHandler(this.aboutMainMenuStrip_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(600, 366);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RemoveButton);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddButton);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(834, 537);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Image = global::NoteAppUI.Properties.Resources.cancel_text_icon_icons_com_71506;
            this.RemoveButton.Location = new System.Drawing.Point(119, 488);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(50, 40);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(4, 34);
            this.NotesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(236, 446);
            this.NotesListBox.TabIndex = 2;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Image = global::NoteAppUI.Properties.Resources.notes_edit_button_icon_icons_com_71407;
            this.EditButton.Location = new System.Drawing.Point(65, 488);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 40);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Image = global::NoteAppUI.Properties.Resources.add_text_notes_icon_icons_com_71526;
            this.AddButton.Location = new System.Drawing.Point(11, 488);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CategoryComboLabel
            // 
            this.CategoryComboLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryComboLabel.AutoSize = true;
            this.CategoryComboLabel.Location = new System.Drawing.Point(4, 8);
            this.CategoryComboLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryComboLabel.Name = "CategoryComboLabel";
            this.CategoryComboLabel.Size = new System.Drawing.Size(82, 13);
            this.CategoryComboLabel.TabIndex = 1;
            this.CategoryComboLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(89, 6);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryComboBox.MaximumSize = new System.Drawing.Size(174, 0);
            this.CategoryComboBox.MinimumSize = new System.Drawing.Size(76, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(151, 21);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 31);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(78, 13);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category Label";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(85, 17);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title Label";
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(177, 60);
            this.ModifiedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedTimeLabel.TabIndex = 4;
            this.ModifiedTimeLabel.Text = "Modified:";
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(230, 58);
            this.ModifiedDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.ModifiedDateTimePicker.TabIndex = 3;
            // 
            // CreatedTimeLabel
            // 
            this.CreatedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTimeLabel.AutoSize = true;
            this.CreatedTimeLabel.Location = new System.Drawing.Point(5, 59);
            this.CreatedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedTimeLabel.Name = "CreatedTimeLabel";
            this.CreatedTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedTimeLabel.TabIndex = 2;
            this.CreatedTimeLabel.Text = "Created:";
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(56, 58);
            this.CreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.CreatedDateTimePicker.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Enabled = false;
            this.TextBox.Location = new System.Drawing.Point(4, 80);
            this.TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(581, 452);
            this.TextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NoteApp";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditNoteTMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMainMenuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Label CategoryComboLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label CreatedTimeLabel;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}