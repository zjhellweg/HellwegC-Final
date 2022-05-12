#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HellwegFinal.Data;
using HellwegFinal.Models;
using Microsoft.AspNetCore.Authorization;

namespace HellwegFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly DriverdatabaseContext _context;

        public DriversController(DriverdatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Drivers
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Driver>>> GetDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }

        // GET: api/Drivers/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetDriver(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);

            if (driver == null)
            {
                return NotFound();
            }

            return driver;
        }

        // GET: api/DriversCar/5
        [Authorize]
        [HttpGet("/Plate/{plate}")]
        public async Task<ActionResult<DriverCar>> GetPlate(String plate)
        {
            var driver = await _context.DriverCars.ToListAsync();

            var Result = driver.Find(
                delegate (DriverCar DC)
                {
                    return DC.VehiclePlate == plate;

                });

            if (Result == null)
            {
                return NotFound();
            }

            return Result;
        }

        // GET: api/DriversCar/5
        [Authorize]
        [HttpGet("/SSN/{ssn}")]
        public async Task<ActionResult<DriverCar>> GetSSN(String ssn)
        {
            var driver = await _context.DriverCars.ToListAsync();

            var Result = driver.Find(
                delegate (DriverCar DC)
                {
                    return DC.Ssn == ssn;

                });

            if (Result == null)
            {
                return NotFound();
            }

            return Result;
        }

        // GET: api/DriversCar/5
        [Authorize]
        [HttpGet("/Name/{first},{last}")]
        public async Task<ActionResult<DriverCar>> GetDriver(String first,String last)
        {
            var driver = await _context.DriverCars.ToListAsync();

            var Result = driver.Find(
                delegate (DriverCar DC)
                {
                    return DC.FirstName == first && DC.LastName == last;
                   

                });

            if (Result == null)
            {
                return NotFound();
            }

            return Result;
        }

        // GET: api/DriversCar/5
        [Authorize]
        [HttpPost("/All")]
        public async Task<ActionResult<IEnumerable<DriverCar>>> GetDriver(DriverCar data)
        {
            var driver = await _context.DriverCars.ToListAsync();

            var Result = driver.FindAll(
                delegate (DriverCar DC)
                {
                    return DC.VehiclePlate == data.VehiclePlate  || DC.Ssn == data.Ssn || (DC.FirstName == data.FirstName && DC.LastName == data.LastName);

                });

            if (Result == null)
            {
                return NotFound();
            }

            return Result;
        }

        // PUT: api/Drivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "dmv")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriver(int id, Driver driver)
        {
            if (id != driver.DriverIndex)
            {
                return BadRequest();
            }

            _context.Entry(driver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(id))
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

        // POST: api/Drivers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "dmv")]
        [HttpPost]
        public async Task<ActionResult<Driver>> PostDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DriverExists(driver.DriverIndex))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDriver", new { id = driver.DriverIndex }, driver);
        }

        // DELETE: api/Drivers/5
        [Authorize(Roles = "dmv")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DriverExists(int id)
        {
            return _context.Drivers.Any(e => e.DriverIndex == id);
        }
    }
}
