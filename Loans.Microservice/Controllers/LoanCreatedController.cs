using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Shared.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loans.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanCreatedController : ControllerBase
    {
        private readonly IBus _busService;
        public LoanCreatedController(IBus busService)
        {
            _busService = busService;
        }
        [HttpPost]
        public async Task<string> CreateLoan(LoanCreated loancreated)
        {
            if (loancreated != null)
            {
                loancreated.OrderDate = DateTime.Now;
                Uri uri = new Uri("rabbitmq://localhost/loanQueue");
                var endPoint = await _busService.GetSendEndpoint(uri);
                await endPoint.Send(loancreated);
                return "true";
            }
            return "false";
        }
    }
}