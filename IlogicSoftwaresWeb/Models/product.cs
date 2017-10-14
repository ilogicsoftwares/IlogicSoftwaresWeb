using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace IlogicSoftwaresWeb.Models
{
    public class product
    {
        public int id { get; set; }
        public string productid {get; set;}
        public string nombre { get; set; }
        public string url { get; set; }
    }
}