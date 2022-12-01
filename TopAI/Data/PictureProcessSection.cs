using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class PictureProcessSection
    {
        public static IList<Section> PictureProcessSets { get; private set; }
        static PictureProcessSection()
        {
            PictureProcessSets = new List<Section>();
            PictureProcessSets.Add(new Section
            {
                Name = "形态学处理",
                Location = "test",
                Details = "test",
                ImageUrl = "img/xingtaixuechuli_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像二值化",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangerzhihua_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像滤波",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxianglvbo_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像增强",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangzengqiang_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像运算",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangyunsuan_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "清晰度评估",
                Location = "test",
                Details = "test",
                ImageUrl = "img/qingxidu_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像修正",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangxiuzheng_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "阴影校正",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yinyingjiaozheng_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "仿射变换",
                Location = "test",
                Details = "test",
                ImageUrl = "img/fangshebianhuan_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "圆环展开",
                Location = "test",
                Details = "test",
                ImageUrl = "img/yuanhuanzhankai_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "拷贝填充",
                Location = "test",
                Details = "test",
                ImageUrl = "img/kaobeitianchong_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "帧平均",
                Location = "test",
                Details = "test",
                ImageUrl = "img/zhenpingjun_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像归一化",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangguiyihua_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像矫正",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangjiaozheng_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "几何变换",
                Location = "test",
                Details = "test",
                ImageUrl = "img/jihebianhuan_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "图像拼接",
                Location = "test",
                Details = "test",
                ImageUrl = "img/tuxiangpinjie_a.png"
            });
            PictureProcessSets.Add(new Section
            {
                Name = "多图融合",
                Location = "test",
                Details = "test",
                ImageUrl = "img/duoturonghe_a.png"
            });
        }

    }
}