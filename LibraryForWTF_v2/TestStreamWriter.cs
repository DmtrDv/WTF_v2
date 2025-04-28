using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForWTF_v2
{
    public class TestStreamWriter
    {
        /*public List<int> NubsToMassive(string NumberToMassive)
        {
            string[] stringMas = NumberToMassive.Split(',');
            List<int> intMas = new List<int>();
            for (int i = 0; i < stringMas.Length; i++)
            {
                intMas.Add(int.Parse(stringMas[i]));
            }
            return intMas;
        }*/
        public storage NecessaryQuestions(string PartPathToListQuestions, List<int> NubsQuestions, storage NecessaryQuestions)
        {
            string PathToListQuestion = $"FolderLists\\{PartPathToListQuestions}\\{PartPathToListQuestions}.txt";

            using (StreamReader SR = new StreamReader(PathToListQuestion))
            {
                string readable = Convert.ToString(SR.ReadToEnd());

                string[] AlreadyReadStrings = readable.Split('\n');

                int index = 0;
                for (int i = 0; i <= NubsQuestions.Max(); i++)
                {
                    if (i == NubsQuestions[index])
                    {
                        NecessaryQuestions.AddNecessaryQuestion(AlreadyReadStrings[i] + "\n");
                        index++;
                    }
                }
            }
            return NecessaryQuestions;
        }

        public string WriteTestForStudent(string PartPathToListQuestions, string NameTest, storage NecessaryQuestions)
        {
            string PathToSaveTest = $"FolderLists\\{PartPathToListQuestions}\\{PartPathToListQuestions}Tests\\{PartPathToListQuestions} - {NameTest}ForStudent.txt";

            List<string> ListQuestion = NecessaryQuestions.getNecesseryQuestion();
            string recordable = null;
            string[] SplittingIntoParts;
            for (int i = 0; i < ListQuestion.Count; i++)
            {
                if (ListQuestion[i] == "") { }
                else
                {
                    SplittingIntoParts = ListQuestion[i].Split('~');
                    string VarintsAnswer = null;
                    for (int j = 2; j < SplittingIntoParts.Length; j++)
                    {
                        VarintsAnswer += SplittingIntoParts[j] + '\n';
                    }
                    recordable += '\n' + SplittingIntoParts[0] + '\n' + VarintsAnswer;
                }
            }
            using (StreamWriter writer = new StreamWriter(PathToSaveTest, true))
            {
                writer.Write(recordable);
                writer.Close();
            }
            return recordable;
        }
        public string WriteTestForTeacher(string PartPathToListQuestions, string NameTest, storage NecessaryQuestions)
        {
            string PathToSaveTest = $"FolderLists\\{PartPathToListQuestions}\\{PartPathToListQuestions}Tests\\{PartPathToListQuestions} - {NameTest}ForTeacher.txt";

            List<string> ListQuestion = NecessaryQuestions.getNecesseryQuestion();
            string recordable = null;
            string[] SplittingIntoParts;
            for (int i = 0; i < ListQuestion.Count; i++)
            {
                string data = ListQuestion[i];
                if (ListQuestion[i] == "") { }
                else
                {
                    SplittingIntoParts = ListQuestion[i].Split('~');
                    recordable += "\n" + SplittingIntoParts[0] + "\n" + " Правильный ответ: " + SplittingIntoParts[1] + "\n";
                }
            }
            using (StreamWriter writer = new StreamWriter(PathToSaveTest, true))
            {
                writer.Write(recordable);
                writer.Close();
            }
            return recordable;
        }
    }
}
