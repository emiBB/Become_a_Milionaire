using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeMilionaire
{
    public abstract class QuestionsWithLevelDifficulty
    {
        public int QuestionsNumber { get; }
        protected abstract void AddNewQuestion(int numQuestion, string text);
        protected abstract void OpenQuestionsFile();
        protected abstract void SelectRandomQuestions();
        protected abstract void GetQuestionsFromFile(int[] selectedQuestionsFromFile);
        protected abstract string GetQustionAtPosition(int pos, int numberOfQuestion);
        public abstract void ReadQuestions();
    }
}
