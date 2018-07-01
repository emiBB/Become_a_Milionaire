using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace BecomeMilionaire
{
    public class EasyQuestions : QuestionsWithLevelDifficulty
    {
        private Question[] eQuestions;
        private int numberQuestions;
        private string[] easyQuestionsFileContent;
        public Answers easyQuestionsAnswers;

        public EasyQuestions()
        {
            eQuestions = new Question[5];
            numberQuestions = 5;
            easyQuestionsFileContent = null;
            easyQuestionsAnswers = new Answers(5);
        }
        public int QuestionsNumber
        {
            get
            {
                return numberQuestions;
            }
        }
        public Question[] EQuestions
        {
            set
            {
                try
                {
                    for (int i = 0; i < QuestionsNumber; i++)
                    {
                        eQuestions[i].Text = value[i].Text;
                        eQuestions[i].Difficulty = value[i].Difficulty;
                    }
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show("Trying to add empty question!\n");
                }
            }
            get
            {
                try
                {
                    return eQuestions;
                }
                catch (StackOverflowException e)
                {
                    MessageBox.Show("The array is too big!\n");
                    return null;
                }
            }
        }
        public Answers EasyQuestionsAnswers
        {
            set
            {
                for (int i = 0; i < 5; i++)
                {
                    easyQuestionsAnswers.CorrectAnswer[i] = value.CorrectAnswer[i];
                }
            }
            get
            {
                return easyQuestionsAnswers;
            }
        }
        override protected void AddNewQuestion(int numQuestion, string text)
        {
            Question tmpQuestion;

            if (numQuestion > QuestionsNumber || numberQuestions < 0)
            {
                throw new ArgumentException("You are trying to add more than the chosen number questions!\n");
            }

            tmpQuestion = new Question(text, LevelDifficulty.EASY);          
            eQuestions[numQuestion] = tmpQuestion;
        }

        override protected void OpenQuestionsFile()
        {
            try
            {
                easyQuestionsFileContent = System.IO.File.ReadAllLines(@"C:\Users\Emi\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\Questions\easy_questions.txt");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("The easy questions file was not found!\n");
            }
        }
        protected override void SelectRandomQuestions()
        {
            int[] selectedQuestionsNumbers = new int[5];
            int totalQuestionsInFile;
            int number;
            Random rnd = new Random();

            OpenQuestionsFile();
            try
            {
                totalQuestionsInFile = Int32.Parse(easyQuestionsFileContent[0]);
                
                for (int i = 0; i < 5; i++)
                {
                    number = rnd.Next(1, totalQuestionsInFile);
                    while (selectedQuestionsNumbers.Contains(number))
                    {
                        number = rnd.Next(1, totalQuestionsInFile + 1);
                    }
                    selectedQuestionsNumbers[i] = number;
                }

                GetQuestionsFromFile(selectedQuestionsNumbers);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Something went wrong with parsing the number of questions:\n{0}\n", e.Message);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Something went wrong with parsing the number of questions:\n{0}\n", e.Message);
            }
            catch (OverflowException e)
            {
                MessageBox.Show("Something went wrong with parsing the number of questions:\n{0}\n", e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("Index is out if range:\n{0}\n", e.Message);
            }
        }
        protected override void GetQuestionsFromFile(int[] selectedQuestionsFromFile)
        {
            int counterQuestions = 0;
            string questionAndPossibleAnswrs;

            while (counterQuestions < 5)
            {
                questionAndPossibleAnswrs = GetQustionAtPosition(selectedQuestionsFromFile[counterQuestions], counterQuestions);
                AddNewQuestion(counterQuestions, questionAndPossibleAnswrs);
                counterQuestions++;
            }
        }
        protected override string GetQustionAtPosition(int pos, int numberOfQuestion)
        {
            string question;

            for (int i = 1; i < easyQuestionsFileContent.Length; i+=6)
            {
                if (pos == (i / 6) + 1 || pos == 1)
                {
                    question = easyQuestionsFileContent[i];
                    question += '\n' + easyQuestionsFileContent[i + 1];
                    question += '\n' + easyQuestionsFileContent[i + 2];
                    question += '\n' + easyQuestionsFileContent[i + 3];
                    question += '\n' + easyQuestionsFileContent[i + 4];

                    EasyQuestionsAnswers.CorrectAnswer[numberOfQuestion] = char.Parse(easyQuestionsFileContent[i + 5]);

                    return question;
                }
            }
            return string.Empty;
        }
        override public void ReadQuestions()
        {
            try
            {
                SelectRandomQuestions();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Easy questions file is empty!\n");
            }
        }
    }
}
