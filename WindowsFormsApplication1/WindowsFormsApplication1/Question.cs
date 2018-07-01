using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeMilionaire
{
    public class Question
    {
        private string text;
        private LevelDifficulty difficulty;

        public Question()
        {
            text = string.Empty;
        }

        public Question(string question, LevelDifficulty ld)
        {
            Text = question;
            Difficulty = ld;
        }
        public string Text
        {
            set
            {
                try
                {
                    text = value;
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show("Trying to write an empty question!\n");
                }
            }
            get
            {
                return text;
            }
        }
        public LevelDifficulty Difficulty
        {
            set
            { 
                switch (value)
                {
                    case LevelDifficulty.HARD:
                        difficulty = LevelDifficulty.HARD; break;
                    case LevelDifficulty.MEDIUM:
                        difficulty = LevelDifficulty.MEDIUM; break;
                    case LevelDifficulty.EASY:
                        difficulty = LevelDifficulty.EASY; break;
                }
            }
            get
            {
                return difficulty;
            }
        }
    }
}
