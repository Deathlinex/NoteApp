using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{

    public partial class MainForm : Form
    {
        // Список заметок, которые необходимо отобразить на форме.
        private Project _project;

        public MainForm()
        {
            InitializeComponent();

            _project = ProjectManager.LoadFromFile(ProjectManager._defaultPath);
            UpdateNotesListBox();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));

            ChangeVisiblePanel(false);
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            NotesListBox.Items.Clear();

            for (int i = 0; i < _project.Notes.Count; i++)
            {
                NotesListBox.Items.Add(_project.Notes[i].Name);
            }
        }

        /// <summary>
        /// Добавление заметки.
        /// </summary>
        private void AddNote()
        {
            var addForm = new NoteForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                var addedNote = addForm.Note;

                _project.Notes.Add(addedNote);
                NotesListBox.Items.Add(addedNote);
                UpdateNotesListBox();
            }
            else return;

            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
        }

        /// <summary>
        /// Редактирование заметки.
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No entries selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedNote = _project.Notes[selectedIndex];

            var editForm = new NoteForm();
            editForm.Note = selectedNote;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var editedNote = editForm.Note;

                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, editedNote);
                NotesListBox.Items.Insert(selectedIndex, editedNote.Name);
                UpdateNotesListBox();
                NotesListBox.SetSelected(selectedIndex, true);
            }
            else return;

            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        private void RemoveNote()
        {
            var selectedIdex = NotesListBox.SelectedIndex;
            if (selectedIdex == -1)
            {
                MessageBox.Show("No entries selected for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Do you really want to delete the entry?", "Delete entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                _project.Notes.RemoveAt(selectedIdex);
                UpdateNotesListBox();
            }

            ChangeVisiblePanel(false);
            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
        }

        /// <summary>
        /// Изменение видимости информации на главной форме.
        /// </summary>
        private void ChangeVisiblePanel(bool isVisible)
        {
            InfoPanel.Visible = isVisible;
        }

        /// <summary>
        /// Обработка события выбора заметки из списка.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedNote = _project.Notes[NotesListBox.SelectedIndex];
                TitleLabel.Text = selectedNote.Name;
                CategoryLabel.Text = selectedNote.Category.ToString();
                CreatedDateTimePicker.Value = selectedNote.TimeOfCreation;
                ModifiedDateTimePicker.Value = selectedNote.TimeOfEdit;
                TextBox.Text = selectedNote.Text;
                ChangeVisiblePanel(true);

            }
            catch
            {
                MessageBox.Show("Entry not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
            Close();
        }

        private void AddNoteMainMenuStrip_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteMainMenuStrip_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteMainMenuStrip_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void aboutMainMenuStrip_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

    }
}
