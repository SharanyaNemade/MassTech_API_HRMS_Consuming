using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Infrastructure.Services;

namespace Team1_HRMS.Infrastructure.Services
{
    public class APIResponses<T>    
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }

            public string Error { get; set; }

            public static APIResponses<T> SuccessResponse(T data, string message)
            {
                return new APIResponses<T>
                {
                    Success = true,
                    Message = message,
                    Data = data,
                    Error = null
                };
            }
            public static APIResponses<T> ErrorResponse(string errorMessage)
            {
                return new APIResponses<T>
                {
                    Success = false,
                    Message = "Failed",
                    Data = default,
                    Error = errorMessage
                };
            }
        }
    }
