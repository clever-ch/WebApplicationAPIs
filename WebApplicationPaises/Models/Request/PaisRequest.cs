using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationPaises.Models.Request
{
    public class PaisRequest
    {
        public string CodigoId { get; set; }
        public string Name { get; set; }
        public string Local { get; set; }
        public string CurrencyId { get; set; }
    }
}