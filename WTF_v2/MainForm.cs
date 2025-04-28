using LibraryForWTF_v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WTF_v2
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        const string Path = "FolderLists\\Disciple.txt";

        storage AllDiscipline = new storage();
        storage NecesseryQuestions = new storage();

        QuestionStreamReader ReaderDisciplines = new QuestionStreamReader();
        QuestionStreamReader ReaderQuestions = new QuestionStreamReader();

        TestStreamWriter QuestionForTest = new TestStreamWriter();
        TestStreamWriter TestForStudent = new TestStreamWriter();
        TestStreamWriter TestForTeacher = new TestStreamWriter();

        private void InitializeForm()
        {
            // Заполнение ComboBox дисциплинами
            ReaderDisciplines.ReadDisciplines(Path, AllDiscipline);
            foreach (var discipline in AllDiscipline.getDiscipline())
            {
                ListDisciplines_comboBox.Items.Add(discipline);
            }

            ListDisciplines_comboBox.SelectedIndexChanged += ListDisciplines_comboBox_SelectedIndexChanged;
            ListQuestions_checkedListBox.SelectedIndexChanged += ListQuestions_checkedListBox_SelectedIndexChanged;
        }
        private void ListDisciplines_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка ListQuestions_checkedListBox перед загрузкой новых вопросов
            ListQuestions_checkedListBox.Items.Clear();

            // Проверка, что выбран элемент
            //Если SelectedItem = null,то ничего не выбрано, и код не будет выполнен
            if (ListDisciplines_comboBox.SelectedItem != null)
            {
                string selectedDiscipline = ListDisciplines_comboBox.SelectedItem.ToString();
                // выгрузка вопросов
                storage AllQuestions = new storage();
                AllQuestions = ReaderQuestions.ReadListQuestions(selectedDiscipline, AllQuestions);
                //проходит по вопросам и загружает их в ListQuestions_checkedListBox
                foreach (var question in AllQuestions.getListQuiestions())
                {
                    string formattedText = question.Replace("\n", " | ");
                    ListQuestions_checkedListBox.Items.Add(formattedText);
                }
            }
        }
        private void ListQuestions_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListQuestions_checkedListBox.SelectedIndex != -1)
            {
                string itemText = ListQuestions_checkedListBox.SelectedItem.ToString();

                if (itemText.Contains("Такого файла не существует!") || itemText.Contains("Файл пуст"))
                {
                    ListQuestions_checkedListBox.SelectedIndex = -1; // Снимаем выделение
                }
            }
        }

        private void recording_test_button_Click(object sender, EventArgs e)
        {
            string NameTest = NameTest_textBox.Text;
            if (ListDisciplines_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите дисциплину", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NameTest == string.Empty)
            {
                MessageBox.Show("Пустые значения недопустимы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (StringIsSpaces(NameTest))
            {
                MessageBox.Show("У Вас одни пробелы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ListQuestions_checkedListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Не выбран ни один вопрос!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NameTest = NameTest.TrimEnd().TrimStart();


            List<int> selectedIndex = new List<int>();
            for(int i = 0; i < ListQuestions_checkedListBox.Items.Count; i++)
            {
                if (ListQuestions_checkedListBox.GetItemChecked(i))
                {
                    selectedIndex.Add(i);
                }
            }
            string selectedDiscipline = ListDisciplines_comboBox.SelectedItem.ToString();
            QuestionForTest.NecessaryQuestions(selectedDiscipline, selectedIndex, NecesseryQuestions);

            string recordForSt = TestForStudent.WriteTestForStudent(selectedDiscipline, NameTest, NecesseryQuestions);
            string recordForTch = TestForTeacher.WriteTestForTeacher(selectedDiscipline, NameTest, NecesseryQuestions);


            resultForm FormRes = new resultForm(recordForSt, recordForTch);
            FormRes.ShowDialog();
            
        }
        private bool StringIsSpaces(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char symbol = str[i];
                if (symbol != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ListDisciplines_comboBox.Text = "";
            ListQuestions_checkedListBox.Items.Clear();
            NameTest_textBox.Text = "";
            /*resultForm openResultForm = Application.OpenForms.OfType<resultForm>().FirstOrDefault();
            openResultForm?.ClearResults();*/
        }
    }
}
