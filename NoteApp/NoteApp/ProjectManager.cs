using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Имя файла для сериализации и десериализации данных.
        /// </summary>
        public static string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//NoteApp.notes";
        
        public static void CheckFile()
        {
            if (!File.Exists(_defaultPath))
                File.Create(_defaultPath).Close();
        }

        /// <summary>
        /// Метод сериализации данных.
        /// </summary>
        public static void SaveToFile(Project notes)
        {
           
            JsonSerializer serializer = new JsonSerializer();
            CheckFile();
            using (StreamWriter sw = new StreamWriter(_defaultPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Метод десериализации данных.
        /// </summary>
        public static Project LoadFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            Project project;

            CheckFile();
            try
            {
                using (StreamReader sr = new StreamReader(_defaultPath))
                using (JsonReader reader = new JsonTextReader(sr))
                    project = (Project) serializer.Deserialize<Project>(reader);
            }
            catch
            {
                project = new Project();
            }

            return project;
        }
    }
}