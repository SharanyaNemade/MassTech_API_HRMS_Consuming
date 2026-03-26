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
    public class AttendanceService : IAttendanceInterface
    {
        ApplicationDbContext db;
        IMapper mapper;
        IMemoryCache cache;

        public AttendanceService(ApplicationDbContext db, IMapper mapper, IMemoryCache cache)
        {
            this.db = db;
            this.mapper = mapper;
            this.cache = cache;
        }



        public List<AttendanceReportDTO> FetchAttendanceReports(int page, int pageSize)
        {
            string key = $"AttendanceReport_{page}_{pageSize}";


            if (!cache.TryGetValue(key, out List<AttendanceReportDTO>? data))
            {
                var dbData = db.AttendanceReports
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
                data = mapper.Map<List<AttendanceReportDTO>>(dbData);

                cache.Set(key, data, TimeSpan.FromMinutes(2));
            }
            return data!;



            //var data = db.AttendanceReports.ToList();

            //var mappedData = mapper.Map<List<AttendanceReportDTO>>(data);

            //return mappedData;
        }

        
    }
}
