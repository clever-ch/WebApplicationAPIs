using System.Net;
using System.Web.Http;
using WebApplicationPaises.Models;
using WebApplicationPaises.Models.Request;

namespace WebApplicationPaises.Controllers
{
    public class PaisesController : ApiController
    {
        public string Get(string id)
        {
            string json;
            string response;

            if (id == "BR" || id == "CO")
            {
                return "error 401 unauthorized de http";
            }
            else
            {
                response = "https://api.mercadolibre.com/classified_locations/countries/" + id;
                json = new WebClient().DownloadString(response);

                string path = @"E:\Repositorios\usuarios.json";
                System.IO.File.WriteAllText(path, json);

                return json;
            }

        }
    }
}
