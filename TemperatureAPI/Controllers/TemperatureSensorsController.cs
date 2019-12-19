using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemperatureAPI;
using TemperaturesNamespace;

namespace TemperatureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureSensorsController : ControllerBase
    {
        private readonly SmartHouseDBContext _context;

        public TemperatureSensorsController(SmartHouseDBContext context)
        {
            _context = context;
        }

        // GET: api/TemperatureSensors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TemperatureSensors>>> Gettemperatures()
        {
            return await _context.TemperaturesNamespace.ToListAsync();
        }

        // GET: api/TemperatureSensors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TemperatureSensors>> GetTemperatureSensors(Guid id)
        {
            var temperatureSensors = await _context.TemperaturesNamespace.FindAsync(id);

            if (temperatureSensors == null)
            {
                return NotFound();
            }

            return temperatureSensors;
        }

        // PUT: api/TemperatureSensors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTemperatureSensors(Guid id, TemperatureSensors temperatureSensors)
        {
            if (id != temperatureSensors.TemperatureId)
            {
                return BadRequest();
            }

            _context.Entry(temperatureSensors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemperatureSensorsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TemperatureSensors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TemperatureSensors>> PostTemperatureSensors(TemperatureSensors temperatureSensors)
        {
            _context.TemperaturesNamespace.Add(temperatureSensors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTemperatureSensors", new { id = temperatureSensors.TemperatureId }, temperatureSensors);
        }

        // DELETE: api/TemperatureSensors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TemperatureSensors>> DeleteTemperatureSensors(Guid id)
        {
            var temperatureSensors = await _context.TemperaturesNamespace.FindAsync(id);
            if (temperatureSensors == null)
            {
                return NotFound();
            }

            _context.TemperaturesNamespace.Remove(temperatureSensors);
            await _context.SaveChangesAsync();

            return temperatureSensors;
        }

        private bool TemperatureSensorsExists(Guid id)
        {
            return _context.TemperaturesNamespace.Any(e => e.TemperatureId == id);
        }
    }
}
