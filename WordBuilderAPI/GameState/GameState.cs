using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordBuilderAPI.GameState.Interfaces;

namespace WordBuilderAPI.GameState
{
    public class GameState : IGameState
    {
        public string Id;
        public int Score;
        public int ClueIndex;

        public GameQuestion CurrentQuestion;
        public List<GameQuestion> GameQuestions;

        public List<string> AnsweredQuestionIds;
        public List<string> SkippedQuestionIds;

        public GameState(string id, List<GameQuestion> gameQuestions)
        {
            Id = id;
            GameQuestions = gameQuestions;
        }

        public GameQuestion GetNextQuestion()
        {
            return GameQuestions.FirstOrDefault(i => !AnsweredQuestionIds.Contains(i.Id) && !SkippedQuestionIds.Contains(i.Id) && CurrentQuestion.Id != i.Id);
        }

        public bool AnswerQuestion(string answer)
        {
            if(answer.Equals(CurrentQuestion.Answer, StringComparison.InvariantCultureIgnoreCase))
            {
                Score++;
                AnsweredQuestionIds.Add(CurrentQuestion.Id);
                ClueIndex = 0;
                CurrentQuestion = GetNextQuestion();
                return true;
            }

            return false;
        }

        public string GetNextClue()
        {
            if (ClueIndex < CurrentQuestion.Answer.Length)
                ClueIndex++;
            else
                ClueIndex = 0;

            return CurrentQuestion.Clues[ClueIndex];
        }

        public GameQuestion SkipQuestion()
        {
            SkippedQuestionIds?.Add(CurrentQuestion?.Id);
            return GetNextQuestion();
        }
    }
}
