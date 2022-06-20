using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using API.Models;
using API.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly Context _context;

        public ProfileController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        //o ActionResult vai ter como resultado uma lista de Profile
        public async Task<ActionResult<IEnumerable<Profile>>> PegarTodosAsync(){
            return await _context.Profiles.ToListAsync();

        }

        //pegar Profile pelo Id
        [HttpGet("{ProfileId}")]
        public async Task<ActionResult<Profile>> PegarProfilePeloIdAsync(int ProfileId){
            Profile Profile = await _context.Profiles.FindAsync(ProfileId);

            //caso não exista
            if(Profile == null){
                return NotFound();
                } else{
                    return Profile;
                }
        }

        [HttpPost]
        public async Task<ActionResult<Profile>> SalvarProfileAsync(Profile Profile){
            await _context.Profiles.AddAsync(Profile);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarProfileAsync(Profile Profile){
            _context.Profiles.Update(Profile);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{ProfileId}")]
        public async Task<ActionResult> ExcluirProfileAsync(int ProfileId){
            Profile Profile = await _context.Profiles.FindAsync(ProfileId);
            _context.Remove(Profile);

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
