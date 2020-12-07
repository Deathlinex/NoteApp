using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTests
    {
        Project notes = new Project();
        private Note _note;
       
        [Test]
        public void Project_CorrectProject_NotNull()
        {
            // Act
            notes.Notes.Add(_note);
            
            // Assert
            Assert.NotNull(notes);
        }
    }
}