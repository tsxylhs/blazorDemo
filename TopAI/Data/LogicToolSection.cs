using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class LogicToolSection
    {
        public static IList<Section> LogicToolSets { get; private set; }
        static LogicToolSection()
        {
            LogicToolSets = new List<Section>();
            LogicToolSets.Add(new Section
            {
                Name = "条件检测",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tiaojianjiance_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "分支模块",
                Location = "test",
                Details = "test",
                ImageUrl = "img/fenzhimokuai_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "分支字符",
                Location = "test",
                Details = "test",
                ImageUrl = "img/fenzhizifu_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "文本保存",
                Location = "test",
                Details = "test",
                ImageUrl = "img/wenbenbaocun_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "逻辑",
                Location = "test",
                Details = "test",
                ImageUrl = "img/luoji_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "格式化",
                Location = "test",
                Details = "test",
                ImageUrl = "img/geshihua_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "变量计算",
                Location = "test",
                Details = "test",
                ImageUrl = "img/bianliangjisuan_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "字符比较",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zifubijiao_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "脚本",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jiaoben_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "Group",
                Location = "test",
                Details = "test",
                ImageUrl = "img/group_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "点集",
                Location = "test",
                Details = "test",
                ImageUrl = "img/dianji_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "耗时统计",
                Location = "test",
                Details = "test",
                ImageUrl = "img/haoshitongji_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "数据集合",
                Location = "test",
                Details = "test",
                ImageUrl = "img/shujujihe_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "协议解析",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xieyijiexi_a.png"
            });
            LogicToolSets.Add(new Section
            {
                Name = "协议组装",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xieyizuzhuang_a.png"
            });
        }

    }
}