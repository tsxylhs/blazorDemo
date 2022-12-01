using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class RecognizeSection
    {
        public static IList<Section> RecognizeSets { get; private set; }
        static RecognizeSection()
        {
            RecognizeSets = new List<Section>();
            RecognizeSets.Add(new Section
            {
                Name = "二维码识别",
                Location = "test",
                Details = "test",
                ImageUrl = "img/erweimashibie_a.png"
            });
            RecognizeSets.Add(new Section
            {
                Name = "条码识别",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tiaomashibie_a.png"
            });
            RecognizeSets.Add(new Section
            {
                Name = "字符识别",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zifushibie_a.png"
            });
        }

    }
}