using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Infrastructure.Data;
using AutoMapper;
using Team1_HRMS.Application.DTO.Team1_HRMS.Application.DTO;
using Microsoft.Extensions.Caching.Memory;

namespace Team1_HRMS.Infrastructure.Services
{
    public class EmpService : IEmpInterface
    {
         
        ApplicationDbContext db;
        IMapper mapper;
        IMemoryCache cache;

        public EmpService(ApplicationDbContext db, IMapper mapper, IMemoryCache cache)
        {
            this.db = db;
            this.mapper = mapper;
            this.cache = cache;
        }

        public List<EmpReportDTO> FetchEmployeeReports(int page, int pageSize)
        {
            string key = $"EmpReport_{page}_{pageSize}";


            if (!cache.TryGetValue(key, out List<EmpReportDTO>? data))
            {
                var dbData = db.EmployeeReports
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
                data = mapper.Map<List<EmpReportDTO>>(dbData);

                cache.Set(key, data, TimeSpan.FromMinutes(2));
            }
            return data!;
        }

        // Fetch data from DB
        //var data = db.EmployeeReports.ToList();

            // Map Entity -> DTO using AutoMapper
            //var mappedData = mapper.Map<List<EmpReportDTO>>(data);

            //return mappedData;
       // }

        public EmployeeDashboardDTO GetEmployeeDashboard()
        {
            
            var employees = db.EmployeeReports.ToList();

            var dashboard = new EmployeeDashboardDTO
            {
                TotalEmployees = employees.Count(),

                TotalDepartments = employees
                    .Select(x => x.Department)
                    .Distinct()
                    .Count(),

                ActiveEmployees = employees
                    .Count(x => x.Status == "Active"),

                TotalRoles = employees
                    .Select(x => x.Role)   // make sure Role exists in DB
                    .Distinct()
                    .Count(),

                // Graph Data (example: month-wise or static)
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr" },

                ActiveData = new List<int> { 5, 3, 4, 6 },

                InactiveData = new List<int> { 2, 1, 1, 0 }
            };

            return dashboard;
        }
    }
}
