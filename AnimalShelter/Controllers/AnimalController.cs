using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Cors;


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
    [EnableCors("Open")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }
    [EnableCors("Open")]
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetById(int id)
    {
      Animal target = await _db.Animals.FindAsync(id);
      if(target == null)
      {
        return NotFound();
      }
      return target;
    }
    [EnableCors("Open")]
    [HttpGet("type/{type}")]
    public async Task<ActionResult<IEnumerable<Animal>>> GetByType(string type)
    {
      var query = _db.Animals.AsQueryable();
      query = query.Where(a=>a.Type == type);
      return await query.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal input)
    {
      _db.Animals.Add(input);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new{id=input.AnimalId}, input);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal target)
    {
      if (id != target.AnimalId)
      {
        return BadRequest();
      }
      _db.Entry(target).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch(DbUpdateConcurrencyException)
      {
        if(!_db.Animals.Any(a=>a.AnimalId==id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      
      return RedirectToAction("Get", new{id=id});
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      Animal target = await _db.Animals.FindAsync(id);
      if(target == null)
      {
        return NotFound();
      }
      _db.Animals.Remove(target);
      await _db.SaveChangesAsync();
      return NoContent();
    }

  }
}