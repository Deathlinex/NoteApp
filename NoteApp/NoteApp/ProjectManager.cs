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
        public static string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp";

        public static string DefaultfilePath = _defaultPath + "\\NoteApp.note";

        public static void CheckFile()
        {
            if (!Directory.Exists(_defaultPath))
            {
                Directory.CreateDirectory(_defaultPath);
            }
        }

        
        /// <summary>
        /// Метод сериализации данных.
        /// </summary>
        public static void SaveToFile(Project notes, string filepath)
        {
            CheckFile();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filepath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Метод десериализации данных.
        /// </summary>
        public static Project LoadFromFile(string filePath)
        {
            JsonSerializer serializer = new JsonSerializer();
            Project project = new Project();
            CheckFile();
            
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
                
            }
            catch
            {
                project = new Project();
            }
            return project;
        }
    }
}