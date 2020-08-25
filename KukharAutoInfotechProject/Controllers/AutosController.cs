using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KukharAutoInfotechProject.Data;
using KukharAutoInfotechProject.Models;

namespace KukharAutoInfotechProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutosController : Controller
    {
        private KukharAutoInfotechProjectContext _context{get;}
        public AutosController(KukharAutoInfotechProjectContext context)
        {
            _context = context;
        }
        //  [HttpGet]
        //   public async Task<ActionResult<IEnumerable<Autos>>> GetAllAutos()
        //  {
        //      return await _context.Autos.Select(x => ItemToAutos(x))
        //          .ToListAsync();
        //   }
        //GET:api/Autos/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Autos>>GetAutos(int id)
        {
            var autoss = await _context.Autos.FindAsync(id);
            if(autoss == null)
            {
                return NotFound();
            }
            return autoss;
        }
    }
}
