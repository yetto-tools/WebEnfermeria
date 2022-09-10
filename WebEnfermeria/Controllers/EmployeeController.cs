using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEnfermeria.AppDbContext;
using WebEnfermeria.DTOs.Employee;
using WebEnfermeria.Entities.CompaniesRecord;
using WebEnfermeria.Entities.Employee;

namespace WebEnfermeria.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public EmployeeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<List<EmployeeDTO>> Get()
        {
            var employees =  await _context.Employees.Include(x => x.CompaniesRecordId).ToListAsync();
           
            return mapper.Map<List<EmployeeDTO>>(employees);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeeDTO employeedto)
        {
            var existEmployCardNumber = await _context.Employees
                .AnyAsync(x => x.PersonId.FullName  == employeedto.PersonId.FullName );

            if (existEmployCardNumber)
            {
                return BadRequest($"Ya Existe Una Empresa con el Mismo Nombre: {employeedto.PersonId.FullName}");
            }
            var employee = mapper.Map<CompanyRecordEntity>(employeedto);

            _context.Add(employee);

            await _context.SaveChangesAsync();
            return Ok();

        }



    }

}
