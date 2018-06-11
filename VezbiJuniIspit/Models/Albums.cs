using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VezbiJuniIspit.Models
{
    public class Albums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Year { get; set; }
        public float Rating { get; set; }
        public string ImgUrl { get; set; }
    }
}