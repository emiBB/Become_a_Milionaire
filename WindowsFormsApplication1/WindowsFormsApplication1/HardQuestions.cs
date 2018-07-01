using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BecomeMilionaire
{
    public class HardQuestions : QuestionsWithLevelDifficulty
    {
        private Question[] hQuestions;
        private int numberQuestions;
        private string[] hardQuestionsFileContent;
        private Answers hardQuestionsAnswers;

        public HardQuestions()
        {
            hQuestions = new Question[5];
            numberQuestions = 5;
            hardQuestionsFileContent = null;
            hardQuestionsAnswers = new Answers(5);
        }
        public int QuestionsNumber
        {
            get
            {
                return numberQuestions;
            }
        }
        public Question[] HQuestions
        {
            set
            {
                for (int i = 0; i < QuestionsNumber; i++)
                {
                    hQuestions[i].Text = value[i].Text;
                    hQuestions[i].Difficulty = value[i].Difficulty;
                }
            }
            get
            {
                try
                {
                    return hQuestions;
                }
                catch (StackOverflowException e)
                {
                    MessageBox.Show("The array is too big!\n");
                    return null;
                }
            }
        }
        public Answers HardQuestionsAnswers
        {
            set
            {
                for (int i = 0; i < QuestionsNumber; i++)
                {
                    hardQuestionsAnswers.CorrectAnswer[i] = value.CorrectAnswer[i];
                }
            }
            get
            {
                return hardQuestionsAnswers;
            }
        }
        override protected void AddNewQuestion(int numQuestion, string text)
        {
            Question tmpQuestion;

            if (numQuestion > QuestionsNumber || numberQuestions < 0)
            {
                throw new ArgumentException("You are trying to add more than the chosen number questions!\n");
            }

            tmpQuestion = new Question(text, LevelDifficulty.HARD);

            hQuestions[numQuestion] = tmpQuestion;
        }

        override protected void OpenQuestionsFile()
        {
            try
            {
                hardQuestionsFileContent = System.IO.File.ReadAllLines(@"C:\Users\Emi\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\Questions\hard_questions.txt");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("The hard questions file was not found!\n");
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
                totalQuestionsInFile = Int32.Parse(hardQuestionsFileContent[0]);

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

            for (int i = 1; i < hardQuestionsFileContent.Length; i += 6)
            {
                if (pos == (i / 6) + 1 || pos == 1)
                {
                    question = hardQuestionsFileContent[i];
                    question += '\n' + hardQuestionsFileContent[i + 1];
                    question += '\n' + hardQuestionsFileContent[i + 2];
                    question += '\n' + hardQuestionsFileContent[i + 3];
                    question += '\n' + hardQuestionsFileContent[i + 4];

                    HardQuestionsAnswers.CorrectAnswer[numberOfQuestion] = char.Parse(hardQuestionsFileContent[i + 5]);
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
                MessageBox.Show("Hard questions file is empty!\n");
            }
        }
    }
}
