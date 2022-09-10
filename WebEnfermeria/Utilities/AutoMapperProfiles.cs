using AutoMapper;

using WebEnfermeria.DTOs.Company;
using WebEnfermeria.Entities.Company;

using WebEnfermeria.DTOs.Employee;
using WebEnfermeria.Entities.Employee;

using WebEnfermeria.DTOs.Person;
using WebEnfermeria.Entities.Person;

using WebEnfermeria.DTOs.CompaniesRecord;
using WebEnfermeria.Entities.CompaniesRecord;
using WebEnfermeria.Entities.Status;
using WebEnfermeria.DTOs.Status;

namespace WebEnfermeria.Utilities
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            /* Status is Required */
            //Mapped to Read
            CreateMap<StatusEmployeeEntity, StatusEmployeeDTO>();
            //Mapped to Write 
            CreateMap<StatusEmployeeDTO, StatusEmployeeEntity>();

            /* Company is Required */
            //Mapped to Read
            CreateMap<CompanyEntity, CompanyDTO>();
            //Mapped to Write 
            CreateMap<CompanyDTO, CompanyEntity>();
            
            /* Person is Required */
            //Mapped to Read 
            CreateMap<PersonEntity, PersonDTO>();
            //Mapped to Write 
            CreateMap<PersonDTO, PersonEntity>();

            //Company Redord Mapped to Write
            CreateMap<CompanyRecordEntity, EmployeeDTO>();
            //Company Record Mapped to Write
            CreateMap<EmployeeDTO,CompanyRecordEntity>();

            //Company Record Mapped to Write
            CreateMap<CompanyRecordEntity, CompaniesRecordDTO>();
            //Mapped to Write
            CreateMap<CompaniesRecordDTO, CompanyRecordEntity>();



        }
    }
}
