using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEnfermeria.AppDbContext;
using WebEnfermeria.DTOs.Person;
using WebEnfermeria.Entities.Person;

namespace WebEnfermeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public PersonController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            var employees = await _context.Persons.ToListAsync();

            return mapper.Map<List<PersonDTO>>(employees);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDTO persondto)
        {
            var existCompany = await _context.Companies
                .AnyAsync(x => x.CompanyName == persondto.CUI);

            if (existCompany)
            {
                return BadRequest($"Ya Existe Una Empresa con el Mismo Nombre: {persondto.CUI}");
            }
            var company = mapper.Map<PersonEntity>(persondto);

            _context.Add(company);

            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
