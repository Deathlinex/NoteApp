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

        private List<Note> _sortedNotes = new List<Note>();

        private List<Note> SortedNotes
        {
            get
            {
                return _sortedNotes;
            }
            set
            {
                _sortedNotes = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _project = ProjectManager.LoadFromFile(ProjectManager._defaultPath);

            CategoryComboBox.Items.Add("Work");
            CategoryComboBox.Items.Add("Home");
            CategoryComboBox.Items.Add("HealthAndSport");
            CategoryComboBox.Items.Add("People");
            CategoryComboBox.Items.Add("Documents");
            CategoryComboBox.Items.Add("Finances");
            CategoryComboBox.Items.Add("Other");
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.SelectedIndex = 7;
            // CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));

            _sortedNotes = _project.Notes;
            _sortedNotes = _project.SortByEdited(SortedNotes);
            
            UpdateNotesListBox();
            if (_sortedNotes.Count != 0)
            {
                LastNoteIndexSelect();
            }
           
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            _sortedNotes = _project.Notes;
            if (CategoryComboBox.SelectedIndex != 7)
            {
                _sortedNotes = _project.SortByEdited(_sortedNotes, (NoteCategory) CategoryComboBox.SelectedIndex);
            }
            else
            {
                _sortedNotes = _project.SortByEdited(_sortedNotes);
            }

            NotesListBox.Items.Clear();

            foreach (var Note in _sortedNotes)
            {
                NotesListBox.Items.Add(Note.Name);
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
                _sortedNotes.Add(addedNote);

                NotesListBox.Items.Add(addedNote);

                UpdateNotesListBox();

                if (NotesListBox.Items.Count != 0)
                {
                    NotesListBox.SelectedIndex = 0;
                }
            }
            else return;

            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
        }


        /// <summary>
        /// Последняя выбранная заметка.
        /// </summary>
        private void LastNoteIndexSelect()
        {
            try
            {
                NotesListBox.SelectedIndex = _project.CurrentNoteIndex;
            }
            catch (Exception)
            {
                ChangeVisiblePanel(false);
                return;
            }
        }

        /// <summary>
        /// Редактирование заметки.
        /// </summary>
        private void EditNote()
        {
            var sortedSelectedIndex = NotesListBox.SelectedIndex;
            if (sortedSelectedIndex == -1)
            {
                return;
            }

            var selectedNote = _sortedNotes[sortedSelectedIndex];
            var editForm = new NoteForm();
            editForm.Note = selectedNote;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var editedNote = editForm.Note;
                var notesSelectedIndex = _project.Notes.IndexOf(selectedNote);

                _sortedNotes.RemoveAt(sortedSelectedIndex);
                _project.Notes.RemoveAt(notesSelectedIndex);

                _sortedNotes.Insert(sortedSelectedIndex, editedNote);
                _project.Notes.Insert(notesSelectedIndex, editedNote);
                NotesListBox.Items.Insert(sortedSelectedIndex, editedNote.Name);

                UpdateNotesListBox();
                if (NotesListBox.Items.Count != 0)
                {
                    NotesListBox.SelectedIndex = 0;
                }
                _project.CurrentNoteIndex = NotesListBox.SelectedIndex;
            }
            else
            {
                return;
            }

            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        private void RemoveNote()
        {
            var selectedSortedIndex = NotesListBox.SelectedIndex;
            Note note = _sortedNotes[selectedSortedIndex];

            if (selectedSortedIndex == -1)
            {
                return;
            }

            var dialogResult = MessageBox.Show("Do you really want to delete the entry?", "Delete entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                var notesSelectedIndex = _project.Notes.IndexOf(note);
                _sortedNotes.RemoveAt(selectedSortedIndex);
                _project.Notes.RemoveAt(notesSelectedIndex);
                NotesListBox.Items.RemoveAt(selectedSortedIndex);
                UpdateNotesListBox();
                if (NotesListBox.Items.Count != 0)
                {
                    NotesListBox.SelectedIndex = 0;
                }
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
                var selectedSortedNote = _sortedNotes[NotesListBox.SelectedIndex];

                if (NotesListBox.SelectedIndex == -1)
                {
                    return;
                }
                _project.CurrentNoteIndex = NotesListBox.SelectedIndex;

                TitleLabel.Text = selectedSortedNote.Name;
                CategoryLabel.Text = selectedSortedNote.Category.ToString();
                CreatedDateTimePicker.Value = selectedSortedNote.TimeOfCreation;
                ModifiedDateTimePicker.Value = selectedSortedNote.TimeOfEdit;
                TextBox.Text = selectedSortedNote.Text;
                ChangeVisiblePanel(true);
            }
            catch
            {
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
            Close();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager._defaultPath);
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

        private void NotesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNotesListBox();
        }
    }
}
