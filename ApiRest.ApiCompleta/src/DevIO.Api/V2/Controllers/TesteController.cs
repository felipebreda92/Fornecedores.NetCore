using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using KissLog;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevIO.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;
        public TesteController(INotificador notificador
                               , IUser appUser
                               , ILogger logger) : base(notificador, appUser)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Valor()
        {
            try
            {
                int i = 0;
                var result = 42 / i;
            }
            catch (DivideByZeroException e)
            {
                _logger.Error(e.Message);
            }

            return "V2";
        }
    }
}