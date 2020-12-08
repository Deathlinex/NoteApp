using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    /// <summary>
    /// Класс заметки.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private DateTime _create = DateTime.Now;

        /// <summary>
        /// Время изменения заметки.
        /// </summary>
        private DateTime _modify = DateTime.Now;

        /// <summary>
        /// Категории заметок.
        /// </summary>
        private NoteCategory _category;
        
        /// <summary>
        /// Свойство названия заметки.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Note title is limited to 50 characters. Your number of characters: " + value.Length);
                }
                else
                {
                    if (value != String.Empty)
                    {
                        _name = value;
                    }
                    else _name = "Без названия";
                    TimeOfEdit = DateTime.Now;
                }
            }
        }

        public NoteCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
                TimeOfEdit = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство текста заметки.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                TimeOfEdit = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство времени создания заметки.
        /// </summary>
        public DateTime TimeOfCreation
        {
            get { return _create; }
            set
            {
                _create = value;
            }
        }

        /// <summary>
        /// Свойство изменения времени заметки.
        /// </summary>
        public DateTime TimeOfEdit
        {
            get { return _modify; }
            set
            {
                _modify = value;
            }
        }

        /// <summary>
        /// Метод клонирования объекта класса.
        /// </summary>
        /// <returns>
        /// Возвращение копии объекта класса.
        /// </returns>
        public object Clone()
        {
            return new Note
            {
                Name = this.Name,
                Text = this.Text,
                Category = this.Category,
                TimeOfEdit = this.TimeOfEdit
            };
        }
    }
}