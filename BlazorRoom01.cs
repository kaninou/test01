using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Country { get; set; }
        
         public float Price { get; set; }

          public string ZipCode { get; set; }
    }
}
