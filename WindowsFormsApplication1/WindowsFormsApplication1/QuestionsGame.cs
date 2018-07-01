using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeMilionaire
{
    public class QuestionsGame
    {
        private EasyQuestions easyQuestions;
        private MediumDifficultyQuestions medQuestions;
        private HardQuestions hardQuestions;
        private Question[] allQuestions;
        private Answers allAnswers;
        private int currentQuestionNumber;
        private int wonMoney;
        private int hintTax;

        public QuestionsGame()
        {
            easyQuestions = new EasyQuestions();
            medQuestions = new MediumDifficultyQuestions();
            hardQuestions = new HardQuestions();
            allQuestions = new Question[15];
            allAnswers = new Answers(15);
            currentQuestionNumber = 0;
            wonMoney = 0;
            hintTax = 0;
        }
        public Question[] AllQuestions
        {
            set
            {
                for (int i = 0; i < 15; i++)
                {
                    if (value[i].Text == null)
                    {
                        throw new ArgumentException("There's no text in the queastion!\n");
                    }
                    allQuestions[i] = value[i];
                }
            }
            get
            {
                return allQuestions;
            }
        }
        public Answers AllAnswers
        {
            set
            {
                for (int i = 0; i < 15; i++)
                {
                    allAnswers.CorrectAnswer[i] = value.CorrectAnswer[i];
                }
            }
            get
            {
                return allAnswers;
            }
        }
        public int CurrentQuestionNumber
        {
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("Invalid question number!\n");
                }
                currentQuestionNumber = value;
            }
            get
            {
                return currentQuestionNumber;
            }
        }
        public int WonMoney
        {
            set
            {
                wonMoney = Convert.ToInt32(value);
            }
            get
            {
                return wonMoney;
            }
        }
        public int HintTax
        {
            set
            {
                hintTax = Convert.ToInt32(value);
            }
            get
            {
                return hintTax;
            }
        }
        public void SetPriceAccordingNumQuestion(int numQuestion)
        {
            if (numQuestion >= 0 && numQuestion < 5)
            {
                WonMoney += 50;
            }
            else if (numQuestion >= 5 && numQuestion < 10)
            {
                WonMoney += 500;
            }
            else if (numQuestion >= 10 && numQuestion < 15)
            {
                WonMoney += 1000;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The question number is not correct!\n");
            }

            return;
        }
        public void SetHintTaxAccordingNumQuestion(int numQuestion)
        {
            if (numQuestion >= 0 && numQuestion < 5)
            {
                HintTax = 50;
            }
            else if (numQuestion >= 5 && numQuestion < 10)
            {
                HintTax = 500;
            }
            else if (numQuestion >= 10 && numQuestion < 15)
            {
                HintTax = 1000;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The question number is not correct!\n");
            }

            return;
        }
        public void AddQuestions()
        {
            easyQuestions.ReadQuestions();
            medQuestions.ReadQuestions();
            hardQuestions.ReadQuestions();

            for (int i = 0; i < 5; i++)
            {
                AllQuestions[i] = easyQuestions.EQuestions[i];
                AllQuestions[i + 5] = medQuestions.MQuestions[i];
                AllQuestions[i + 10] = hardQuestions.HQuestions[i];
            }
        }
        public void AddAswers()
        {
            for (int i = 0; i < 5; i++)
            {
                AllAnswers.CorrectAnswer[i] = easyQuestions.EasyQuestionsAnswers.CorrectAnswer[i];
                AllAnswers.CorrectAnswer[i + 5] = medQuestions.MedQuestionsAnswers.CorrectAnswer[i];
                AllAnswers.CorrectAnswer[i + 10] = hardQuestions.HardQuestionsAnswers.CorrectAnswer[i];
            }
        }
        public bool CheckIfWon()
        {
            if (CurrentQuestionNumber == 14)
            {
                return true;
            }
            return false;
        }
    }
}
