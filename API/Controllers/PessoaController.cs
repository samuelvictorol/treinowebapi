using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly Context _context;

        public PessoaController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        //o ActionResult vai ter como resultado uma lista de Pessoa
        public async Task<ActionResult<IEnumerable<Pessoa>>> PegarTodosAsync(){
            return await _context.Pessoas.ToListAsync();
        }

        //pegar pessoa pelo Id
        [HttpGet("{pessoaId}")]
        public async Task<ActionResult<Pessoa>> PegarPessoaPeloIdAsync(int pessoaId){
            Pessoa pessoa = await _context.Pessoas.FindAsync(pessoaId);

            //caso não exista
            if(pessoa== null){
                return NotFound();
                } else{
                    return pessoa;
                }
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> SalvarPessoaAsync(Pessoa pessoa){
            await _context.Pessoas.AddAsync(pessoa);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarPessoaAsync(Pessoa pessoa){
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{pessoaId}")]
        public async Task<ActionResult> ExcluirPessoaAsync(int pessoaId){
            Pessoa pessoa = await _context.Pessoas.FindAsync(pessoaId);
            _context.Remove(pessoa);

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

