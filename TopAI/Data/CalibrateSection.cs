using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class CalibrateSection
    {
        public static IList<Section> CalibrateSets { get; private set; }
        static CalibrateSection()
        {
            CalibrateSets = new List<Section>();
            CalibrateSets.Add(new Section
            {
                Name = "标定板标定",
                Location = "test",
                Details = "test",
                ImageUrl = "img/biaodingbanbiaoding_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "N点标定",
                Location = "test",
                Details = "test",
                ImageUrl = "img/ndianbiaoding_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "标定转换",
                Location = "test",
                Details = "test",
                ImageUrl = "img/biaodingzhuanhuan_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "单位转换",
                Location = "test",
                Details = "test",
                ImageUrl = "img/danweizhuanhuan_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "畸变标定",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jibianbiaoding_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "畸变校正",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jibianjiaozheng_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "映射标定",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yingshebiaoding_a.png"
            });
            CalibrateSets.Add(new Section
            {
                Name = "N图像标定",
                Location = "test",
                Details = "test",
                ImageUrl = "img/ntuxiangbiaoding_a.png"
            });
        }

    }
}