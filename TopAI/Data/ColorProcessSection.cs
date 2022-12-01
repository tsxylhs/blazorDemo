using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class ColorProcessSection
    {
        public static IList<Section> ColorProcessSets { get; private set; }
        static ColorProcessSection()
        {
            ColorProcessSets = new List<Section>();
            ColorProcessSets.Add(new Section
            {
                Name = "颜色抽取",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yansechouqu_a.png"
            });
            ColorProcessSets.Add(new Section
            {
                Name = "颜色测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yanseceliang_a.png"
            });
            ColorProcessSets.Add(new Section
            {
                Name = "颜色转换",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yansezhuanhuan_a.png"
            });
            ColorProcessSets.Add(new Section
            {
                Name = "颜色识别",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yanseshibie_a.png"
            });
        }

    }
}