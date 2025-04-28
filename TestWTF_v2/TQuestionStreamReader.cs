using System;
using LibraryForWTF_v2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace TestWTF_v2
{
    [TestClass]
    public class TQuestionStreamReader
    {
        [TestMethod]
        [DataRow("гео", "1 Столица России - ?\nПравильный ответ: Москва \nВсе ответы: \nОмск\nТверь\nМосква\nТоржок\n")]
        [DataRow("матем", "1 2 + 2 = ?\nПравильный ответ: 4 \nВсе ответы: \n2\n0\n4\n1\n" +
                          "2 15 * 4 = ?\nПравильный ответ: 60 \nВсе ответы: \n30\n60\n40\n22\n" +
                          "3 100 : 20 = ?\nПравильный ответ: 5 \nВсе ответы: \n6\n4\n20\n5")]
        [DataRow("invalid_file", "Такого файла не существует!")]
        [DataRow("пустой", "Файл пуст")]
        public void TReadListQuestions(string validFilename, string expectedValidOutput)
        {
            // Вызов метода
            storage validStorage = new storage();
            QuestionStreamReader validQSR = new QuestionStreamReader();

            validQSR.ReadListQuestions(validFilename, validStorage);

            if (validStorage.getListQuiestions().Count > 1)
            {
                //удаляю возможные лишнии переносы 
                string actualOutput = string.Join("", validStorage.getListQuiestions()
                                            .Select(q => q.TrimEnd('\n', '\r') + "\n"));
                string normalizedExpected = expectedValidOutput.TrimEnd('\n', '\r');
                string normalizedActual = actualOutput.TrimEnd('\n', '\r');
                Assert.AreEqual(normalizedExpected, normalizedActual);
            }
            else Assert.AreEqual(expectedValidOutput, validStorage.getListQuiestions()[0]);
        }
    }
}
