﻿using System;
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

    public partial class NoteForm : Form
    {
        private Note _note = new Note();

        /// <summary>
        /// Возвращает и задает данные формы
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = (Note)value.Clone();
                DisplayNote();
            }
        }

        public NoteForm()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        /// <summary>
        /// Отображение данных в заметке.
        /// </summary>
        public void DisplayNote()
        {
            if (_note == null)
            {
               return;
            }

            TitleTextBox.Text = _note.Name;
            CategoryComboBox.SelectedItem = _note.Category;
            CreatedDateTimePicker.Value = _note.TimeOfCreation;
            ModifiedDateTimePicker.Value = DateTime.Now;
            TextBox.Text = _note.Text;
        }

        private void ChangeVisiblePanel(bool isVisible)
        {
            ErrorLabel.Visible = isVisible;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Name = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
                ChangeVisiblePanel(false);
            }
            catch (Exception)
            {
                TitleTextBox.BackColor = Color.IndianRed;
                ChangeVisiblePanel(true);
                ErrorLabel.Text = "Maximum 50 characters!";
            }
        }

        /// <summary>
        /// Обработка события выбора новой категории из списка.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1) return;
            this._note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = TextBox.Text;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool check;
            try
            {
                check = true;
                Note.Name = TitleTextBox.Text;
                NoteCategory selectedNoteCategory = (NoteCategory) CategoryComboBox.SelectedItem;
                Note.Category = selectedNoteCategory;
                Note.TimeOfEdit = DateTime.Now;
                Note.Text = TextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                check = false;
            }

            if (check)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}