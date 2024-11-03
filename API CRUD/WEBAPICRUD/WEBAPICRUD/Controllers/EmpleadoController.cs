using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WEBAPICRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace WEBAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly PruebaContext dbContext;

        public EmpleadoController(PruebaContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Get()
        {
            var listaEmpleado = await dbContext.Empleados.ToListAsync();
            return StatusCode(StatusCodes.Status200OK, listaEmpleado);
        }



        [HttpPost]
        [Route("Nuevo")]
        public async Task<IActionResult> Nuevo([FromBody] Empleado objeto)
        {
            await dbContext.Empleados.AddAsync(objeto);
            await dbContext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok"});
        }


    }
}
