using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEnfermeria.AppDbContext;
using WebEnfermeria.DTOs.Company;
using WebEnfermeria.Entities.Company;

namespace WebEnfermeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<List<CompanyDTO>> Get()
        {
            var companies = await _context.Companies.OrderBy(x => x.CompanyName).ToListAsync();
            //if (!companies.Any())
            //{
            //}
            return mapper.Map<List<CompanyDTO>>(companies);

        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CompanyDTO companydto)
        {
            var existCompany = await _context.Companies
                .AnyAsync(x => x.CompanyName == companydto.CompanyName);

            if (existCompany)
            {
                return BadRequest($"Ya Existe Una Empresa con el Mismo Nombre: {companydto.CompanyName}");
            }
            var company = mapper.Map<CompanyEntity> (companydto);

            _context.Add(company);

            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
