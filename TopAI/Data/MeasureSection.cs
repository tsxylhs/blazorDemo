using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class MeasureSection
    {
        public static IList<Section> MeasureSets { get; private set; }
        static MeasureSection()
        {
            MeasureSets = new List<Section>();
            MeasureSets.Add(new Section
            {
                Name = "线圆测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xianyuanceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "圆圆测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuanyuanceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "点圆测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dianyuanceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "点线测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dianxianceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "线线测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xianxianceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "点点测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/diandianceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "圆拟合",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuannihe_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "直线拟合",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhixiannihe_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "亮度测量",
                Location = "test",
                Details = "test",
                ImageUrl = "img/liangduceliang_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "像素统计",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xiangsutongji_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "直方图工具",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhifangtugongju_a.png"
            });
            MeasureSets.Add(new Section
            {
                Name = "几何创建",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jihechuangjian_a.png"
            });
        }

    }
}