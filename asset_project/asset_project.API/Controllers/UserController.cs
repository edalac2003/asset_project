﻿using asset_project.API.Data;
using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("/api/users")]

    public class UserController :  ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.People.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var person = await _context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person is null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();
            return Ok(person);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var afectedRows = await _context.People
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Person person)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();
            return Ok(person);
        }
    }
}
