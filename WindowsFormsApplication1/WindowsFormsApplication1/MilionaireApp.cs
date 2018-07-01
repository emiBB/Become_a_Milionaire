using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BecomeMilionaire;

namespace BecomeMilionaire
{
    public partial class MilionaireApp : Form
    {
        private QuestionsGame game;
        private int hintCounter;
        public MilionaireApp()
        {
            InitializeComponent();
            game = new QuestionsGame();
            hintCounter = 0;
        }
        private void richTxtScreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnAnswerA.BackColor = Color.Beige;
                btnAnswerB.BackColor = Color.Beige;
                btnAnswerC.BackColor = Color.Beige;
                btnAnswerD.BackColor = Color.Beige;
                richTxtScreen.Text = game.AllQuestions[game.CurrentQuestionNumber].Text;
                richTxtScreen.SelectAll();
                richTxtScreen.SelectionAlignment = HorizontalAlignment.Center;
                lblCurrentMoney_Click(sender, e);
            }
            catch (ArgumentNullException a)
            {
                Console.WriteLine("No valid question to get.\n");
                return;
            }
            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine("Invalid question number.\n");
            }
            catch (FileNotFoundException a)
            {
                Console.WriteLine("Couldn't find a file to read questions from.\n");
                return;
            }
            catch (NullReferenceException a)
            {
                Console.WriteLine("There is no question to get.\n");
                return;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                game.AddQuestions();
                game.AddAswers();
                MessageBox.Show("You have 15 questions. Answer them and get your price! You have a 3 hints that will give you the answer but it will cost you.. Let's begin!");
                richTxtScreen_TextChanged(sender, e);
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("No question is null.\n");
            }
            catch (NullReferenceException a)
            {
                MessageBox.Show("No question found.\n");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (game.CurrentQuestionNumber == 14)
            {
                MessageBox.Show("Congratulations! You won!!! :)");
                this.Close();
            }
            else
            {
                string message = "You lost!";
                if (game.WonMoney < 0)
                {
                    message += string.Format("\nYou owe us {0} leva", Convert.ToString(game.WonMoney * (-1)));
                }
                else
                {
                    message += string.Format("\nYour price is {0} leva\n", (game.WonMoney / 2));
                }
                MessageBox.Show(message);
                this.Close();
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (hintCounter > 2)
            {
                MessageBox.Show("You don't have more hints!\n");
                return;
            }

            char correctAnswer = game.AllAnswers.CorrectAnswer[game.CurrentQuestionNumber];
            game.SetHintTaxAccordingNumQuestion(game.CurrentQuestionNumber + 1);
            game.WonMoney -= game.HintTax;
            lblCurrentMoney_Click(sender, e);

            MessageBox.Show(string.Format("The correct answer is {0}\nMinus {1} leva", correctAnswer, game.HintTax));
            hintCounter++;
        }
        private void IfCorrectAnswer(object sender, EventArgs e)
        {
            try
            {
                game.SetPriceAccordingNumQuestion(game.CurrentQuestionNumber);
                MessageBox.Show(string.Format("You have won {0} leva", game.WonMoney));
                lblCurrentMoney_Click(sender, e);
            }
            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show(a.Message);
            }

            if (game.CheckIfWon())
            {
                btnQuit_Click(sender, e);
            }
            game.CurrentQuestionNumber++;
            richTxtScreen_TextChanged(sender, e);
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            char correctAnswer = game.AllAnswers.CorrectAnswer[game.CurrentQuestionNumber];

            if ('A' == correctAnswer)
            {
                btnAnswerA.BackColor = Color.Green;
                IfCorrectAnswer(sender, e);
            }
            else
            {
                btnAnswerA.BackColor = Color.Red;
                MessageBox.Show(string.Format("Ooops.. Wrong answer! The correct answer is: {0}", correctAnswer.ToString()));
                btnQuit_Click(sender, e);
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            char correctAnswer = game.AllAnswers.CorrectAnswer[game.CurrentQuestionNumber];

            if ('B' == correctAnswer)
            {
                btnAnswerB.BackColor = Color.Green;
                IfCorrectAnswer(sender, e);
            }
            else
            {
                btnAnswerB.BackColor = Color.Red;
                MessageBox.Show(string.Format("Ooops.. Wrong answer! The correct answer is: {0}", correctAnswer.ToString()));
                btnQuit_Click(sender, e);
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            char correctAnswer = game.AllAnswers.CorrectAnswer[game.CurrentQuestionNumber];

            if ('C' == correctAnswer)
            {
                btnAnswerC.BackColor = Color.Green;
                IfCorrectAnswer(sender, e);
            }
            else
            {
                btnAnswerC.BackColor = Color.Red;
                MessageBox.Show(string.Format("Ooops.. Wrong answer! The correct answer is: {0}", correctAnswer.ToString()));
                btnQuit_Click(sender, e);
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            char correctAnswer = game.AllAnswers.CorrectAnswer[game.CurrentQuestionNumber];

            if ('D' == correctAnswer)
            {
                btnAnswerD.BackColor = Color.Green;
                IfCorrectAnswer(sender, e);
            }
            else
            {
                btnAnswerD.BackColor = Color.Red;
                MessageBox.Show(string.Format("Ooops.. Wrong answer! The correct answer is: {0}", correctAnswer.ToString()));
                btnQuit_Click(sender, e);
            }
        }

        private void lblCurrentMoney_Click(object sender, EventArgs e)
        {
            lblCurrentMoney.Text = string.Format("{0}\n{1}", game.WonMoney.ToString(), " lv");
        }
    }
}
