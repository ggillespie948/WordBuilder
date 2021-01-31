using System;
using System.Collections.Generic;
using WordBuilderAPI.GameState;
using WordBuilderAPI.GameState.Interfaces;
using GameState = WordBuilderAPI.GameState.GameState;

namespace WordBuilderAPI
{
    public class WordBuilder
    {
        public List<GameQuestion> GameQuestions = new List<GameQuestion>
        {
            new GameQuestion
            {
                Id = "1",
                Answer = "Ignite",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                { 
                    "Burn something",
                    "Firing (Engine)",
                    "Start of combustion"
                }
            },
            new GameQuestion
            {
                Id = "2",
                Answer = "Smite",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Hit, biblically!",
                }
            },
            new GameQuestion
            {
                Id = "3",
                Answer = "Guest",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Invited visitor",
                }
            },
            new GameQuestion
            {
                Id = "4",
                Answer = "Minute",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "60 seconds",
                }
            },
            new GameQuestion
            {
                Id = "5",
                Answer = "Strine",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Aussie dialect",
                }
            },
            new GameQuestion
            {
                Id = "6",
                Answer = "Signet",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Small seal",
                }
            },
            new GameQuestion
            {
                Id = "7",
                Answer = "String",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Thine",
                    "A cat's favourite toy",
                }
            },
            new GameQuestion
            {
                Id = "8",
                Answer = "Rusting",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Corroding",
                }
            },
            new GameQuestion
            {
                Id = "9",
                Answer = "Rusting",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Corroding",
                }
            },
            new GameQuestion
            {
                Id = "10",
                Answer = "Minster",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Large or important church",
                    "One letter different from an Irish provence",
                }
            },
            new GameQuestion
            {
                Id = "11",
                Answer = "Terminus",
                WordGrid = new char[,]{
                    { 'I', 'G', 'M' },
                    { 'N', 'T', 'E' },
                    { 'U', 'R', 'S' }
                },
                Clues = new string[]
                {
                    "Large or important church",
                    "One letter different from an Irish provence",
                }
            }
        };

        public IGameState CreateNewGame(string playerId) => new GameState.GameState(playerId, GameQuestions);
    }
}
