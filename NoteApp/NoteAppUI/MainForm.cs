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
        private Project _dataList;

        public MainForm()
        {
            InitializeComponent();

            _dataList = ProjectManager.LoadFromFile();
            if (_dataList == null)
               _dataList = new Project();
            UpdateNotesListBox();

            CategoryComboBox.Items.Add(NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteCategory.Finances);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteCategory.People);
            CategoryComboBox.Items.Add(NoteCategory.Work);

            ChangeVisiblePanel(false);
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateNotesListBox()
        {
            NotesListBox.Items.Clear();
            if (_dataList != null)
            {
                for (int i = 0; i < _dataList.Notes.Count; i++)
                {
                    if (_dataList.Notes[i].Name != "")
                        NotesListBox.Items.Add(_dataList.Notes[i].Name);
                    else
                        NotesListBox.Items.Add("Без названия");
                }

            }
        }
        
        private void AddNote()
        {
            var addForm = new NoteForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                var addedNote = addForm.NoteData;

                _dataList.Notes.Add(addedNote);
                NotesListBox.Items.Add(addedNote);
                UpdateNotesListBox();
            }
            else return;

            ProjectManager.SaveToFile(_dataList);
        }
        
        private void EditNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedNote = _dataList.Notes[selectedIndex];

                var editForm = new NoteForm();
                editForm.NoteData = selectedNote;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.NoteData;

                    _dataList.Notes.Insert(selectedIndex, editedNote);
                    NotesListBox.Items.Insert(selectedIndex, editedNote.Name);
                    _dataList.Notes.RemoveAt(selectedIndex + 1);
                    UpdateNotesListBox();
                    NotesListBox.SetSelected(selectedIndex, true);
                }
                else return;
            }
            catch
            {
                MessageBox.Show("Запись не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ProjectManager.SaveToFile(_dataList);
        }
                
        private void RemoveNote()
        {
            var selectedIdex = NotesListBox.SelectedIndex;
            if (selectedIdex == -1)
            {
                MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Вы дейcтвительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                _dataList.Notes.RemoveAt(selectedIdex);
                UpdateNotesListBox();
            }

            ChangeVisiblePanel(false);
            ProjectManager.SaveToFile(_dataList);
        }

        /// <summary>
        /// Изменение видимости информации на главной форме.
        /// </summary>
        private void ChangeVisiblePanel(bool isVisible)
        {
            TitleLabel.Visible = isVisible;
            CategoryLabel.Visible = isVisible;
            CreatedTimeLabel.Visible = isVisible;
            CreatedDateTimePicker.Visible = isVisible;
            ModifiedTimeLabel.Visible = isVisible;
            ModifiedDateTimePicker.Visible = isVisible;
        }

        /// <summary>
        /// Обработка события выбора заметки из списка.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var selectedNote = _dataList.Notes[NotesListBox.SelectedIndex];

                if (selectedNote.Name != "")
                    TitleLabel.Text = selectedNote.Name;
                else
                    TitleLabel.Text = "Без названия";

                CategoryLabel.Text = selectedNote.Category.ToString();
                CreatedDateTimePicker.Value = selectedNote.TimeOfCreation;
                ModifiedDateTimePicker.Value = selectedNote.TimeOfEdit;
                TextBox.Text = selectedNote.Text;
                ChangeVisiblePanel(true);
            }
            catch
            {
                MessageBox.Show("Запись не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
