using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using ClassLibrary.Data;


namespace LottoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LottoszamokController : ControllerBase
    {
        private readonly AdatbazisKapcsolat _context;

        public LottoszamokController(AdatbazisKapcsolat context)
        {
            _context = context;
        }

        // GET: api/Lottoszamok
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lottoszam>>> GetLottoszam()
        {
            return await _context.Lottoszam.ToListAsync();
        }

        // GET: api/Lottoszamok/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lottoszam>> GetLottoszam(int id)
        {
            var lottoszam = await _context.Lottoszam.FindAsync(id);

            if (lottoszam == null)
            {
                return NotFound();
            }

            return lottoszam;
        }

        // PUT: api/Lottoszamok/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLottoszam(int id, Lottoszam lottoszam)
        {
            if (id != lottoszam.Id)
            {
                return BadRequest();
            }

            _context.Entry(lottoszam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LottoszamExists(id))
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

        // POST: api/Lottoszamok
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lottoszam>> PostLottoszam(Lottoszam lottoszam)
        {
            _context.Lottoszam.Add(lottoszam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLottoszam", new { id = lottoszam.Id }, lottoszam);
        }

        // DELETE: api/Lottoszamok/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLottoszam(int id)
        {
            var lottoszam = await _context.Lottoszam.FindAsync(id);
            if (lottoszam == null)
            {
                return NotFound();
            }

            _context.Lottoszam.Remove(lottoszam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LottoszamExists(int id)
        {
            return _context.Lottoszam.Any(e => e.Id == id);
        }
    }
}
