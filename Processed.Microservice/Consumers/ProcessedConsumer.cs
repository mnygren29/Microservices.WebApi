using MassTransit;
using Shared.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Processed.Microservice.Consumers
{
    public class ProcessedConsumer : IConsumer<LoanCreated>
    {
        public async Task Consume(ConsumeContext<LoanCreated> context)
        {
            var obj = context.Message;
        }
    }
}
