using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;
using System;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalController: ControllerBase
  {
    private readonly skylar_brockbankContext _db;
    public AnimalController(skylar_brockbankContext db)
    {
      _db=db;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> Get(int id)
    {
      Animal target = await _db.Animals.FindAsync(id);
      if(target == null)
      {
        return NotFound();
      }
      return target;
    }
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal input)
    {
      _db.Animals.Add(input);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new{id=input.AnimalId}, input);
    }

  }
}