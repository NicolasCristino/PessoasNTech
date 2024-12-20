using ListarPessoaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListarPessoaApp.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PessoaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var pessoas = await _context.Pessoa.ToListAsync();
            return View(pessoas);
        }
        public IActionResult Detalhe(int id)
        {
            var pessoa = _context.Pessoa.FirstOrDefault(p => p.PESSOA_ID == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Gravar(Pessoa model)
        {
            var pessoa = _context.Pessoa.FirstOrDefault(p => p.PESSOA_ID == model.PESSOA_ID);
            if (pessoa == null)
            {
                return NotFound();
            }

            pessoa.NOME_FANTASIA = model.NOME_FANTASIA;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
