using KukharAutoInfotechProject.Data;
using KukharAutoInfotechProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : Controller
    {
        private KukharAutoInfotechProjectContext _context { get; }
        public OwnersController(KukharAutoInfotechProjectContext context)
        {
            _context = context;
        }
        //GET:api/Owners/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Owners>> GetOwners(int id)
        {
            var ownerss = await _context.Owners.FindAsync(id);
            if (ownerss == null)
            {
                return NotFound();
            }
            return ownerss;
        }

    }
}
