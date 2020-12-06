using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            // Setup
            var sourceProject = new Project();
            sourceProject.Notes.Add(new Note()
            {
                Name = "Note",
                Text = "Text",
                Category = NoteCategory.Documents,
            });
            sourceProject.Notes.Add(new Note()
            {
                Name = "Note2",
                Text = "Text2",
                Category = NoteCategory.Finances,
            });

            var filename = "";

            // Act
            ProjectManager.SaveToFile(sourceProject, filename);

            // Assert
        }

    }
}
