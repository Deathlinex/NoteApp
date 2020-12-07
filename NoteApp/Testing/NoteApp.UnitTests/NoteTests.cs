using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        public Note PrepareNote()
        {
            var sourceNote = new Note()
            {

                Name = "Имя заметки один два три",
                Category = NoteCategory.Finances,
                Text = "Текст заметки три два один",
                TimeOfCreation = DateTime.Now,
                TimeOfEdit = DateTime.Now
            };
            return sourceNote;
        }
        
        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceName = sourceNote.Name;
            var expectedName = sourceName;

            // Act
            sourceNote.Name = sourceName;
            var actualName = sourceNote.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_EmptyName_ReturnsDefaultName()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceName = "";
            var expectedName = "Без названия";

            // Act
            sourceNote.Name = sourceName;
            var actualName = sourceNote.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_TooLongName_ThrowsException()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceName = "Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один.";
            
            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    // Act
                    sourceNote.Name = sourceName;
                }
            );
        }

        [Test]
        public void Text_GoodText_ReturnsSameText()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceText = sourceNote.Text;
            var expectedText = sourceText;

            // Act
            sourceNote.Text = sourceText;
            var actualText = sourceNote.Text;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void Clone_GoodClone_ReturnsSameClone()
        {
            // Setup
            var sourceNote = PrepareNote();
            var expectedClone = (Note)sourceNote.Clone();

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedClone.Text, sourceNote.Text);
            NUnit.Framework.Assert.AreEqual(expectedClone.Name, sourceNote.Name);
            NUnit.Framework.Assert.AreEqual(expectedClone.Category, sourceNote.Category);
        }

        [Test]
        public void TimeOfCreation_GoodTime_ReturnsSameTime()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceCreation = sourceNote.TimeOfCreation;
            var expectedCreation = sourceNote.TimeOfCreation;

            // Act
            sourceNote.TimeOfCreation = sourceCreation;
            var actualCreation = sourceNote.TimeOfCreation;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedCreation, actualCreation);
        }

        [Test]
        public void TimeOfEdit_GoodTime_ReturnsSameTime()
        {
            // Setup
            var sourceNote = PrepareNote();
            var sourceEdit = sourceNote.TimeOfEdit;
            var expectedEdit = sourceNote.TimeOfEdit;

            // Act
            sourceNote.TimeOfEdit = sourceEdit;
            var actualEdit = sourceNote.TimeOfEdit;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedEdit, actualEdit);
        }
    }

}
