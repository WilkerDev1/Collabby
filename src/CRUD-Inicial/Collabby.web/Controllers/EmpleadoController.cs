using Microsoft.AspNetCore.Mvc;

using Collabby.web.Data;
using Collabby.web.Models;
using Microsoft.EntityFrameworkCore;

namespace Collabby.web.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly AppDBContext _appDbContext;
        public EmpleadoController(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Empleado> lista = await _appDbContext.Empleados.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Nuevo()
        {
            return View();
        }
    }
}
