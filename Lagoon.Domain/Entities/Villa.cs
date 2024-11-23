using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagoon.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public string? Description { get; set; }    
        public double Price { get; set; }   
        public string? ImageUrl { get; set; }
        public int Sqft { get; set; }
        public int Ocuppancy { get; set; }
        public DateTime? OcuppancyDate { get;   set; }  
        public DateTime UpdateTime { get; set; }
    }
}
