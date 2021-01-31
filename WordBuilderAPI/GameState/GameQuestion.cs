using System;
using System.Collections.Generic;
using System.Text;

namespace WordBuilderAPI.GameState
{
    public class GameQuestion
    {
        public string Id;
        public string Answer;
        public string[] Clues;
        public char[,] WordGrid;
        public int CurrentAnswerLetterCount => Answer.ToCharArray().Length;
    }
}
