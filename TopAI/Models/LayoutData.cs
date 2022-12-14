using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopAI.Models
{
    public class LayoutData
    {
        
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Date { get; set; }
        public string Info { get; set; }

        public Action OnDataChanged { get; set; }
        public void DataChanged() => OnDataChanged?.Invoke();
    }
}