using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех заметок в приложении.
        /// </summary>
        public List<Note> Notes = new List<Note>();


        /// <summary>
        /// Текущий индекс заметки
        /// </summary>
        public int CurrentNoteIndex { get; set; }

        public List<Note> SortByEdited(List<Note> notesToSort)
        {
            return notesToSort = notesToSort.OrderByDescending(item => item.TimeOfEdit).ToList();
        }
        public List<Note> SortByEdited(List<Note> notesToSort, NoteCategory category)
        {
            return notesToSort = notesToSort.Where(item => item.Category == category).OrderByDescending(item => item.TimeOfEdit).ToList();
        }
    }
}