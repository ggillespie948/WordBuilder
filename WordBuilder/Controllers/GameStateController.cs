using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordBuilderAPI.GameState;
using WordBuilderAPI.GameState.Interfaces;

namespace WordBuilder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameStateController : ControllerBase
    {
        private WordBuilderAPI.WordBuilder _wordBuilderApi;
        private readonly ILogger<GameStateController> _logger;

        public GameStateController(ILogger<GameStateController> logger)
        {
            _logger = logger;
            _wordBuilderApi = new WordBuilderAPI.WordBuilder();
        }

        [HttpGet]
        public IGameState GetNewGame() => _wordBuilderApi.CreateNewGame("playerId");
    }
}
