using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Services;
using Models.Interfaces;

namespace BusinessFunctionApp
{
    public class BusinessFunction
    {
        private readonly IBusinessService service;
        public BusinessFunction(IBusinessService service)
        {
            this.service = service;
        }
        [FunctionName("Business")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "business")] HttpRequest req,
            ILogger log)
        {
            string countrycode = req.Query["countrycode"];

            IBusiness business = this.service.GetBusiness(countrycode);
            return new OkObjectResult(business);
        }
    }
}
