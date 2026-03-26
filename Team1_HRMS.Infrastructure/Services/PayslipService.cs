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
using Team1_HRMS.Application.DTO.Team1_HRMS.Application.DTO;


namespace Team1_HRMS.Infrastructure.Services
{
    public class PayslipService : IPayslipInterface
    {
        ApplicationDbContext db;
        IMapper mapper;
        IMemoryCache cache;

        public PayslipService(ApplicationDbContext db, IMapper mapper, IMemoryCache cache)
        {
            this.db = db;
            this.mapper = mapper;
            this.cache = cache;
        }

        public List<PayslipReportDTO> FetchPayslipReports(int page, int pageSize)
        {
            string key = $"PayslipReport_{page}_{pageSize}";


            if (!cache.TryGetValue(key, out List<PayslipReportDTO>? data))
            {
                var dbData = db.PayslipReports
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
                data = mapper.Map<List<PayslipReportDTO>>(dbData);

                cache.Set(key, data, TimeSpan.FromMinutes(2));
            }
            return data!;

            //var data = db.PayslipReports.ToList();

            //var mappedData = mapper.Map<List<PayslipReportDTO>>(data);

            //return mappedData;

        }
    }
}