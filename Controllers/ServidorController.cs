using aula1911.DataContexts;
using aula1911.DTOs;
using aula1911.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace aula1911.Controllers
{
    [ApiController]
    [Route("servidores")]
    public class ServidorController : Controller
    {

        private readonly AppDBContext _context;

        public ServidorController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listaServidores = await _context.Servidor.ToListAsync();

                return Ok(listaServidores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var servidor = await _context.Servidor.Where(s => s.Id == id).FirstOrDefaultAsync();
                if(servidor == null)
                {
                    return NotFound("Servidor não encontrado!");
                }

                return Ok(servidor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }  
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ServidorDTO item)
        {
            try
            {
                var servidor = new Servidor()
                {
                    Nome = item.Nome,
                    CPF = item.CPF,
                    SIAPE = item.SIAPE,
                };

                await _context.Servidor.AddAsync(servidor);
                await _context.SaveChangesAsync();

                return Ok(servidor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ServidorDTO item)
        {
            try
            {
                var servidor = await _context.Servidor.FindAsync(id);

                if (servidor is null)
                {
                    return NotFound();
                }

                servidor.Nome = item.Nome;
                servidor.CPF = item.CPF;
                servidor.SIAPE = item.SIAPE;

                _context.Servidor.Update(servidor);
                await _context.SaveChangesAsync();

                return Ok(servidor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var servidor = await _context.Servidor.FindAsync(id);

                if (servidor is null)
                {
                    return NotFound();
                }

                _context.Servidor.Remove(servidor);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
