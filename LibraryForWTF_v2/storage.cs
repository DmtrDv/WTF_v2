using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForWTF_v2
{
    public class storage
    {
        List<string> Discipline = new List<string>();

        List<string> ListQuiestions = new List<string>();

        List<string> ListNecessaryQuestions = new List<string>();
        public List<string> getDiscipline()
        {
            return Discipline;
        }
        public List<string> getListQuiestions()
        {
            return ListQuiestions;
        }
        public List<string> getNecesseryQuestion()
        {
            return ListNecessaryQuestions;
        }
        public void AddDiscipline(string List)
        {
            Discipline.Add(List);
        }
        public void AddQuestion(string List)
        {
            ListQuiestions.Add(List);
        }
        public void AddNecessaryQuestion(string List)
        {
            ListNecessaryQuestions.Add(List);
        }
    }
}
