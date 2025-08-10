using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using MoviesMostenAPI.Context;
using MoviesMostenAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using MoviesMostenAPI.Models;

namespace MoviesMostenAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmeSerieController : ControllerBase
{
    private readonly FilmeSerieContext _context;
    private readonly IMapper _mapper;

    public FilmeSerieController(FilmeSerieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<FilmeSerieDTO>>> Get()
    {
        if (_context.FilmeSeries.Count() == 0)
            return NotFound("Não há registros a serem exibidos");

        return await _context.FilmeSeries
            .ProjectTo<FilmeSerieDTO>(_mapper.ConfigurationProvider)
            .OrderBy(fs => fs.Titulo)
            .ToListAsync();
    }

    [HttpGet("{id:int}", Name = "GetFilmeSerieById")]
    public async Task<ActionResult<FilmeSerieDTO>> GetFilmeSerieById(int id)
    {
        var filmeSerie = await _context.FilmeSeries
            .ProjectTo<FilmeSerieDTO>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(fs => fs.Id == id);

        if (filmeSerie is null)
            return NotFound("Registro não encontrado");

        return Ok(filmeSerie);
    }

    [HttpGet("filtro")]
    public async Task<ActionResult<List<FilmeSerieDTO>>> GetFiltered(string titulo)
    {
        var query = _context.FilmeSeries.AsQueryable();

        if (!string.IsNullOrEmpty(titulo))
            query = query.Where(fs => fs.Titulo.ToLower().Contains(titulo.ToLower()));

        var resultado = await query
            .ProjectTo<FilmeSerieDTO>(_mapper.ConfigurationProvider)
            .OrderBy(fs => fs.Titulo)
            .ToListAsync();

        return Ok(resultado);
    }

    [HttpGet("total-votos")]
    public async Task<IActionResult> GetTodosOsVotos()
    {
        var filmesSeries = await _context.FilmeSeries.ToListAsync();
        int totalVotos = 0;

        foreach (var filmeSerie in filmesSeries)
            totalVotos += filmeSerie.Gostei + filmeSerie.NaoGostei;

        return Ok(totalVotos);
    }

    [HttpGet("votos-positivos")]
    public async Task<IActionResult> GetVotosPositivos()
    {
        var filmesSeries = await _context.FilmeSeries.ToListAsync();
        int totalVotosPositivos = 0;

        foreach (var filmeSerie in filmesSeries)
            totalVotosPositivos += filmeSerie.Gostei;

        return Ok(totalVotosPositivos);
    }

    [HttpGet("votos-negativos")]
    public async Task<IActionResult> GetVotosNegativos()
    {
        var filmesSeries = await _context.FilmeSeries.ToListAsync();
        int totalVotosNegativos = 0;

        foreach (var filmeSerie in filmesSeries)
            totalVotosNegativos += filmeSerie.NaoGostei;

        return Ok(totalVotosNegativos);
    }

    [HttpPost]
    public async Task<ActionResult<FilmeSerieDTO>> Post([FromBody] CriarFilmeSerieDTO criacaoDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var filmeSerie = _mapper.Map<FilmeSerie>(criacaoDTO);

        _context.Add(filmeSerie);
        await _context.SaveChangesAsync();

        var dto = _mapper.Map<FilmeSerieDTO>(filmeSerie);
        return CreatedAtRoute("GetFilmeSerieById", new { id = dto.Id }, dto);
    }

    [HttpPost("like/{id:int}")]
    public async Task<IActionResult> Like(int id)
    {
        var filmeSerie = await _context.FilmeSeries.FirstOrDefaultAsync(fs => fs.Id == id);

        if (filmeSerie is null)
            return NotFound("Registro não encontrado");

        filmeSerie.Gostei += 1;
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("dislike/{id:int}")]
    public async Task<IActionResult> Dislike(int id)
    {
        var filmeSerie = await _context.FilmeSeries.FirstOrDefaultAsync(fs => fs.Id == id);

        if (filmeSerie is null)
            return NotFound("Registro não encontrado");

        filmeSerie.NaoGostei += 1;
        await _context.SaveChangesAsync();

        return Ok();
    }
}
