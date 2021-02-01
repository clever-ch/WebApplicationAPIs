using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyWebApplication.Data;
using WebApplicationPaises.Models;

namespace WebApplicationPaises.Controllers
{
    public class CurrenciesController : ApiController
    {
        // GET: api/Currencies
        public IHttpActionResult GetCurrencies()
        {
            string response = "https://api.mercadolibre.com/currencies/";
            string json = new WebClient().DownloadString(response);

            string path = @"C:\currencies.json";
            System.IO.File.WriteAllText(path, json);

            return Ok("Exito");
        }
    }
}