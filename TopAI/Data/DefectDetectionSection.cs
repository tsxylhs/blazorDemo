using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class DefectDetectionSection
    {
        public static IList<Section> DefectDetectionSets { get; private set; }
        static DefectDetectionSection()
        {
            DefectDetectionSets = new List<Section>();
            DefectDetectionSets.Add(new Section
            {
                Name = "字符缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zifuquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "圆弧边缘缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuanhubianyuanquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "直线边缘缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhixianbianyuanduiquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "圆弧对缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuanhuduiquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "直线对缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhixianduiquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "边缘组合缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanzuhequexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "边缘对组合缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanduizuhequexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "边缘模型缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanmoxingquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "边缘对模型缺陷检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanduimoxingquexian_a.png"
            });
            DefectDetectionSets.Add(new Section
            {
                Name = "缺陷对比",
                Location = "test",
                Details = "test",
                ImageUrl = "img/quexianduibi_a.png"
            });
        }

    }
}