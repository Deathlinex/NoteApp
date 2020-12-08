using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        public Project PrepareProject()
        {
            var sourceProject = new Project();
            sourceProject.Notes.Add(new Note()
            {
                Name = "Note",
                Text = "Text",
                Category = NoteCategory.Documents,
                TimeOfCreation = new DateTime(2020, 2, 20),
                TimeOfEdit = new DateTime(2020, 2, 21)
            });
            sourceProject.Notes.Add(new Note()
            {
                Name = "Note2",
                Text = "Text2",
                Category = NoteCategory.Finances,
                TimeOfCreation = new DateTime(2020, 2, 20),
                TimeOfEdit = new DateTime(2020, 2, 21)
            });
            return sourceProject;
        }
        
        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            // Setup
            var sourceProject = PrepareProject();
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var actualFilename = testDataFolder + @"\actualProject.json";
            var expectedFilename = testDataFolder + @"\expectedProject.json";

            if (File.Exists(actualFilename))
            {
                File.Delete(actualFilename);
            }

            // Act
            ProjectManager.SaveToFile(sourceProject, actualFilename);

            // Assert
            var actualFileContent = File.ReadAllText(actualFilename);
            var expectedFileContent = File.ReadAllText(expectedFilename);
            Assert.AreEqual(expectedFileContent,actualFileContent);
        }

        [Test]
        public void LoadFromFile_CorrectFile_FileLoadedCorrectly()
        {
            // Setup
            var sourceProject = PrepareProject();
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var expectedFilename = testDataFolder + @"\expectedProject.json";

            // Act
            var project = ProjectManager.LoadFromFile(expectedFilename);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(sourceProject.Notes.Count, project.Notes.Count);
                for (int i = 0; i != sourceProject.Notes.Count; i++)
                {
                    Assert.AreEqual(sourceProject.Notes[i].Name,project.Notes[i].Name);
                    Assert.AreEqual(sourceProject.Notes[i].Text, project.Notes[i].Text);
                    Assert.AreEqual(sourceProject.Notes[i].Category, project.Notes[i].Category);
                    Assert.AreEqual(sourceProject.Notes[i].TimeOfEdit, project.Notes[i].TimeOfEdit);
                    Assert.AreEqual(sourceProject.Notes[i].TimeOfCreation, project.Notes[i].TimeOfCreation);
                }
            });
        }

        [Test]
        public void LoadFromFile_WrongFile_FileNotLoadedCorrectly()
        {
            // Setup
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var expectedFileName = testDataFolder + @"\expectedProject2.json";

            // Act
            var project = ProjectManager.LoadFromFile(expectedFileName);

            // Assert
            Assert.NotNull(project);
        }
    }
}
