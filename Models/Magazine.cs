using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TASK4.Models
{
    public class Magazine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
        public string Site { get; set; }
    }
}