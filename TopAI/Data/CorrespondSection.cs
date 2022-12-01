using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class CorrespondSection
    {
        public static IList<Section> CorrespondSets { get; private set; }
        static CorrespondSection()
        {
            CorrespondSets = new List<Section>();
            CorrespondSets.Add(new Section
            {
                Name = "接收数据",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jieshoushuju_a.png"
            });
            CorrespondSets.Add(new Section
            {
                Name = "发送数据",
                Location = "test",
                Details = "test",
                ImageUrl = "img/fasongshuju_a.png"
            });
            CorrespondSets.Add(new Section
            {
                Name = "相机IO通信",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xiangjiio_a.png"
            });
        }

    }
}