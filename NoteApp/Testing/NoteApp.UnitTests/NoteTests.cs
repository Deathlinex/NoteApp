using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestFixture]
    public class NoteTests
    {
        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            // Setup
            var note = new Note();
            var sourceName = "Заметка номер один";
            var expectedName = sourceName;

            // Act
            note.Name = sourceName;
            var actualName = note.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_EmptyName_ReturnsDefaultName()
        {
            // Setup
            var note = new Note();
            var sourceName = "";
            var expectedName = "Без названия";

            // Act
            note.Name = sourceName;
            var actualName = note.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_TooLongName_ThrowsException()
        {
            // Setup
            var note = new Note();
            var sourceName = "Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один, Заметка номер один.";
            
            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    // Act
                    note.Name = sourceName;
                }
            );
        }
    }

}
