using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopAI.Models
{
    public class Route
    {
        public string Type{get;set;}
        public string Title{get;set;}
        public IList<Section> Sections{get;set;}
    }
}