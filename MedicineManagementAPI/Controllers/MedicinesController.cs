using MedicineManagementApi.Models;
using MedicineManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicineManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicinesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicinesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicine>>> GetAll()
        {
            return await _context.Medicines.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Medicine>> GetById(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);
            if (medicine == null) return NotFound();
            return medicine;
        }

        [HttpPost]
        public async Task<ActionResult<Medicine>> Create(Medicine medicine)
        {
            _context.Medicines.Add(medicine);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = medicine.Id }, medicine);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Medicine medicine)
        {
            if (id != medicine.Id) return BadRequest();
            _context.Entry(medicine).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);
            if (medicine == null) return NotFound();
            _context.Medicines.Remove(medicine);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}