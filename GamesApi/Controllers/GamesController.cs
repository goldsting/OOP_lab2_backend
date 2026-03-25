using GamesApi.Models;
using GamesApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController :
ControllerBase {
    [HttpGet]
    public ActionResult<List<Game>> GetAll() {
        return Ok(GamesStore.Games);
    }

    [HttpGet("{id}")]
    public ActionResult<Game> GetById(int id) {
        var game = GamesStore.Games.FirstOrDefault(g => g.Id == id);
        if (game is null) {
            return NotFound(new { message = $"Игра с {id} не найдена!" });
        }
        return Ok(game);
    }

    [HttpPost]
    public ActionResult<Game> Create([FromBody] Game game) {
        game.Id = GamesStore.NextId();
        GamesStore.Games.Add(game);
        return CreatedAtAction(nameof(GetById), new{id = game.Id}, game);
    }
}