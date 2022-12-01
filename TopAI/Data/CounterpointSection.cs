using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class CounterpointSection
    {
        public static IList<Section> CounterpointSets { get; private set; }
        static CounterpointSection()
        {
            CounterpointSets = new List<Section>();
            CounterpointSets.Add(new Section
            {
                Name = "相机映射",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xiangjiyingshe_a.png"
            });
            CounterpointSets.Add(new Section
            {
                Name = "单点对位",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dandianduiwei_a.png"
            });
            CounterpointSets.Add(new Section
            {
                Name = "点集对位",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dianjiduiwei_a.png"
            });
            CounterpointSets.Add(new Section
            {
                Name = "线对位",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xianduiwei_a.png"
            });
        }

    }
}