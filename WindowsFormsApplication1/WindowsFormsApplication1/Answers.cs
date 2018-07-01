using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BecomeMilionaire
{
    public class Answers
    {
        private char[] correctAnswers;
        private int numberAnswers;

        public Answers(int numAnswers)
        {
            correctAnswers = new char[numAnswers];
            NumberAnswers = numAnswers;
        }
        public char[] CorrectAnswer
        {
            set
            {
                for (int i = 0; i < 5; i++)
                {
                    if (value[i] != 'A' && value[i] != 'B'
                        && value[i] != 'C' && value[i] != 'D')
                    {
                        throw new ArgumentException("The answer you have given is not from the possible ones!\n");
                    }
                    correctAnswers[i] = value[i];
                }
            }
            get
            {
                return correctAnswers;
            }
        }
        public int NumberAnswers
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of answers!\n");
                }
                numberAnswers = value;
            }
        }
    }
}
