using System.Collections.Generic;
using System.Linq;

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

        public List<Note> SortingByEditing(List<Note> _notesToSort)
        {
            return _notesToSort = _notesToSort.OrderByDescending(item => item.TimeOfEdit).ToList();
        }
        public List<Note> SortingByEditing(List<Note> _notesToSort, NoteCategory category)
        {
            return _notesToSort = _notesToSort.Where(item => item.Category == category).OrderByDescending(item => item.TimeOfEdit).ToList();
        }
    }
}