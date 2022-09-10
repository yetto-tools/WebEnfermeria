using AutoMapper;
using WebEnfermeria.Entities.Company;
using WebEnfermeria.Entities.Employee;
using WebEnfermeria.DTOs.Company;
using WebEnfermeria.DTOs.Employee;
using WebEnfermeria.DTOs;

namespace WebEnfermeria.Utilities
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            //Mapped to Read
            CreateMap<CompanyEntity, CompanyDTO>();
            //Mapped to Write 
            CreateMap<CompanyDTO, CompanyEntity>();

            //Mapped to Write
            CreateMap<EmployeeEntity, EmployeeDTO>();
            //Mapped to Write
            CreateMap<EmployeeDTO, EmployeeEntity>();

            //Mapped to Write
            CreateMap<RecordCompanyEntity, RecordCompanyDTO>();
            //Mapped to Write
            CreateMap<RecordCompanyDTO, RecordCompanyEntity>();



        }
    }
}
