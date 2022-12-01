using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class PositioningSection
    {
      public static IList<Section> PositioningSets{get;private set;}
        static PositioningSection(){
            PositioningSets=new List<Section>();
            PositioningSets.Add(new Section{
                    Name="高精度匹配",
                    Location="test",
                    Details="test",
                    ImageUrl= "img/tezhengpipei_a.png"
            });
            PositioningSets.Add(new Section{
                    Name="快速匹配",
                    Location="test",
                    Details="test",
                    ImageUrl = "img/tezhengpipei_a.png"
                });
            PositioningSets.Add(new Section{
                    Name="灰度匹配",
                    Location="test",
                    Details="test",
                     ImageUrl = "img/huidupipei_a.png"
                });
            PositioningSets.Add(new Section{
                    Name="圆形定位",
                    Location="test",
                    Details="test",
                     ImageUrl = "img/yuanxingdingwei_a.png"
                });
            PositioningSets.Add(new Section
            {
                Name = "圆查找",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuanchazhao_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "直线查找",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhixianchazhao_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "BLOB分析",
                Location = "test",
                Details = "test",
                ImageUrl = "img/blob.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "卡尺工具",
                Location = "test",
                Details = "test",
                ImageUrl = "img/kachigongju_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "边缘查找",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanchazhao_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "间距检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jianjujiance_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "位置修正",
                Location = "test",
                Details = "test",
                ImageUrl = "img/weizhixiuzheng_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "矩形检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/juxingdingwei_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "顶点检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dingdianjiance_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "边缘交点",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianyuanjiaodian_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "平行线查找",
                Location = "test",
                Details = "test",
                ImageUrl = "img/pingxingxianchazhao_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "直线查找组合",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhixianchazhaozuhe_a.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "BLOB标签分析",
                Location = "test",
                Details = "test",
                ImageUrl = "img/blob.png"
            });
            PositioningSets.Add(new Section
            {
                Name = "路径提取",
                Location = "test",
                Details = "test",
                ImageUrl = "img/lujingtiqu_a.png"
            });
        }

    }
}