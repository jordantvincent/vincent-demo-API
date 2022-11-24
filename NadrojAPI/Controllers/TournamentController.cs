using System.Data;
using Microsoft.AspNetCore.Mvc;
using NadrojAPI.Models;
using Npgsql;
using Dapper;
using NadrojAPI.Repositories;

namespace NadrojAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TournamentController : ControllerBase
{
    private readonly ITournamentRepo _tournament;
    private readonly ILogger<TournamentController> _logger;

    public TournamentController(ILogger<TournamentController> logger, ITournamentRepo tournament)
    {
        _logger = logger;
        _tournament = tournament;       

    }

    [HttpGet(Name = "GetTournament")]
    public IEnumerable<TournamentModel> Get()
    {
        return _tournament.GetAll().ToArray();
              
    }


    [HttpGet("{id}")]
   
    public TournamentModel Get(int Id)
    {
        var tourney = _tournament.GetById(Id);
        return tourney;
    }

    [HttpPost]
    public IActionResult Create(TournamentModel tournament)
    {
        _tournament.Insert(tournament);

        return Ok(tournament);
    }
}

