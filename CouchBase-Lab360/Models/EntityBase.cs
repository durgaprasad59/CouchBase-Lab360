using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchBase_Lab360.Models
{
    public class EntityBase<T>
    {
        public int gdp { get; set; }
        public DateTime created { get; set; }
        public int regionnumber { get; set; }
        public string name { get; set; }
        public string countrycode { get; set; }
        public string type { get; set; }
        public string id { get; set; }  
        public int population { get; set; }

    }
}