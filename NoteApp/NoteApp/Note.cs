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
        private readonly DateTime _timeOfCreation = DateTime.Now;
        /// <summary>
        /// Время изменения заметки.
        /// </summary>
        private DateTime _timeOfEdit = DateTime.Now;
        /// <summary>
        /// Категории заметок.
        /// </summary>
        private NoteCategory _category;
        //private string _category2;

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
                    throw new ArgumentException("Название заметки ограничено 50 символами. Ваше количество символов: " + value.Length);
                }
                else
                {
                    if (value != String.Empty)
                    {
                        _name = value;
                    }
                    TimeOfEdit = DateTime.Now;
                }
            }
        }

        /*  public string Category2
          {
              get { return _category2; }
              set
              {
                  if ((value == "Работа")||(value == "Дом")||(value == "Здоровье и спорт")||(value == "Люди")||(value == "Документы")||(value =="Финансы")||(value == "Другое"))
                  {
                      _category2 = value;
                      EditTime = DateTime.Now;
                  }
                  else
                  {
                      throw new ArgumentException("Не корректное название категории.");
                  }

              }
          }
         */

        /// <summary>
        /// Свойство категорий заметок.
        /// </summary>
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
            get { return _timeOfCreation; }
        }

        /// <summary>
        /// Свойство изменения времени заметки.
        /// </summary>
        public DateTime TimeOfEdit
        {
            get { return _timeOfEdit; }
            set
            {
                _timeOfEdit = DateTime.Now;
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