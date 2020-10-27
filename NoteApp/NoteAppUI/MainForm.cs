using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс взаимодействия MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Note Note = new Note();
            Note.Name = textBox1.Text;
            Note.Text = textBox2.Text;
            Note.TimeOfEdit = DateTime.Now;

            string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NoteApp/";

            //Сериализация
            Project serialize = new Project {Notes = {Note}};
            ProjectManager.SaveToFile(serialize, defaultPath);

            //Десериализация
            Project deserialize = ProjectManager.LoadFromFile(defaultPath);
        }

    }
}