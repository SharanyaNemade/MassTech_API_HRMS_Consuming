using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Domain.Models;
using Team1_HRMS.Infrastructure.Data;

namespace Team1_HRMS.Infrastructure.Services
{
    public class LeaveService : ILeaveInterface
    {
        ApplicationDbContext db;
        IMapper mapper;
        IMemoryCache cache;

        public LeaveService(ApplicationDbContext db, IMapper mapper, IMemoryCache cache)
        {
            this.db = db;
            this.mapper = mapper;
            this.cache = cache;
        }

        public List<LeaveReportDTO> FetchLeaveReports(int page, int pageSize)
        {
            string key = $"LeaveReport_{page}_{pageSize}";


            if (!cache.TryGetValue(key, out List<LeaveReportDTO>? data))
            {
                var dbData = db.LeaveReports
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
                data = mapper.Map<List<LeaveReportDTO>>(dbData);

                cache.Set(key, data, TimeSpan.FromMinutes(2));
            }
            return data!;


            //var data = db.LeaveReports.ToList();

            //var mappedData = mapper.Map<List<LeaveReportDTO>>(data);

            //return mappedData;
        }
    }
}