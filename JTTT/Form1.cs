using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace JTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<Task> listOfTasks = new BindingList<Task>();

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Console.ReadLine();
        }


        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                urlPage = textBoxUrl.Text,
                textLookingFor = textBoxTextLookingFor.Text.ToLower(),
                adressMail = textBoxMail.Text,
                nameOfTask = textBoxTaskName.Text,
                conditionTypeIndex = comboBoxConditionType.SelectedIndex,
                actionTypeIndex = comboBoxActionType.SelectedIndex
            };
            
            if (checkBoxIsCaseSensitive.Checked)
                task.textLookingFor = textBoxTextLookingFor.Text;

            //if(comboBoxConditionType.GetItemText)
            comboBoxConditionType.SelectedIndex = 0;
            MessageBox.Show(comboBoxConditionType.GetItemText(comboBoxConditionType.SelectedItem));

            listOfTasks.Add(task);

            listBoxTasksList.Items.Add(task);

            //listBoxTasksList.DataSource = listOfTasks;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxTasksList.Items.Clear();
            // :)
            listOfTasks.Clear();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {

            foreach (var task in listOfTasks)
            {
                string image = task.SearchForPicture(checkBoxIsCaseSensitive.Checked);

            if (image == "default")
            {
                MessageBox.Show("Obraz nie został znaleziony", "Bład podczas szukania obrazu!");
            }
            else
            {
                try
                {
                    Uri u = new Uri(image);
                    if (Task.DownloadRemoteImageFile(u.ToString(), "obrazekTmp.jpg") == false)
                        MessageBox.Show("Obraz nie został pobrany poprawnie", "Bład podczas pobierania obrazu!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Obraz nie został pobrany poprawnie. Szczegółowe informacje:" + ex.Message, "Bład podczas pobierania obrazu!");
                    throw ex;
                }
            }
            }
        }

        public void Save<T>(T file, String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, file);
            }
        }

        public object Read(String path, Type type)
        {
            // Create a new serializer
            var serializer = new XmlSerializer(type);

            // Create a StreamReader
            TextReader reader = new StreamReader(path);

            // Deserialize the file
            Object file;
            file = (Object)serializer.Deserialize(reader);

            // Close the reader
            reader.Close();

            // Return the object
            return file;
        }

        private void buttonDeSerialize_Click(object sender, EventArgs e)
        {
            listBoxTasksList.Items.Clear();

            BindingList<Task> listTemp = ((BindingList<Task>)Read("sciezka", listOfTasks.GetType()));

            foreach(var l in listTemp) {
            listBoxTasksList.Items.Add(l);
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            Save(listOfTasks, "sciezka");
        }
    }
}
