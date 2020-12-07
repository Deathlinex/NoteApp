using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        private Note _note;
        
        [SetUp]
        public void InitNote()
        {
            // Данные для теста
            _note = new Note();
            _note.Name = "Имя заметки один два три";
            _note.Category = NoteCategory.Finances;
            _note.Text = "Текст заметки три два один";
            _note.TimeOfCreation = DateTime.Now;
            _note.TimeOfEdit = DateTime.Now;
        }

        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            // Setup
            var sourceName = _note.Name;
            var expectedName = sourceName;

            // Act
            _note.Name = sourceName;
            var actualName = _note.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_EmptyName_ReturnsDefaultName()
        {
            // Setup
            var sourceName = "";
            var expectedName = "Без названия";

            // Act
            _note.Name = sourceName;
            var actualName = _note.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_TooLongName_ThrowsException()
        {
            // Setup
            var sourceName = "Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один.";
            
            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    // Act
                    _note.Name = sourceName;
                }
            );
        }

        [Test]
        public void Text_GoodText_ReturnsSameText()
        {
            // Setup
            var sourceText = _note.Text;
            var expectedText = sourceText;

            // Act
            _note.Text = sourceText;
            var actualText = _note.Text;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void Clone_GoodClone_ReturnsSameClone()
        {
            // Setup
            var expectedClone = (Note)_note.Clone();

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedClone.Text, _note.Text);
            NUnit.Framework.Assert.AreEqual(expectedClone.Name, _note.Name);
            NUnit.Framework.Assert.AreEqual(expectedClone.Category, _note.Category);
        }

        [Test]
        public void TimeOfCreation_GoodTime_ReturnsSameTime()
        {
            // Setup
            var sourceCreation = _note.TimeOfCreation;
            var expectedCreation = _note.TimeOfCreation;

            // Act
            _note.TimeOfCreation = sourceCreation;
            var actualCreation = _note.TimeOfCreation;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedCreation, actualCreation);
        }

        [Test]
        public void TimeOfEdit_GoodTime_ReturnsSameTime()
        {
            // Setup
            var sourceEdit = _note.TimeOfEdit;
            var expectedEdit = _note.TimeOfEdit;

            // Act
            _note.TimeOfEdit = sourceEdit;
            var actualEdit = _note.TimeOfEdit;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedEdit, actualEdit);
        }
    }

}
