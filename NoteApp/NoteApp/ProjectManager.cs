using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Имя файла для сериализации и десериализации данных.
        /// </summary>
        private const string FileName = "NoteApp.notes";

        /// <summary>
        /// Метод сериализации данных.
        /// </summary>
        public static void SaveToFile(Project project, string path)
        {
            path += FileName;
            Directory.CreateDirectory(path);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonTextWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод десериализации данных.
        /// </summary>
        public static Project LoadFromFile(string path)
        {
            path += FileName;
            Project project;
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonTextReader reader = new JsonTextReader(sr))

                    project = (Project) serializer.Deserialize<Project>(reader);
                if (project == null)
                {
                    project = new Project();
                }
            }
            catch
            {
                throw new ArgumentException("Ошибка загрузки файла ");
            }

            return project;
        }
    }
}