using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class MenuList
    {
        public static Dictionary<string, MenuModel> MenuListDatas { get; private set; }


        static MenuList()
        {
            MenuListDatas = new Dictionary<string, MenuModel>();
            MenuListDatas.Add("collection", new MenuModel
            {
                Name = "采集",
                Icon = "img/caiji_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("positioning", new MenuModel
            {
                Name = "定位",
                Icon = "img/dingwei_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("measure", new MenuModel
            {
                Name = "测量",
                Icon = "img/celiang_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("recognize", new MenuModel
            {
                Name = "识别",
                Icon = "img/shibie_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("calibrate", new MenuModel
            {
                Name = "标定",
                Icon = "img/biaoding_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("counterpoint", new MenuModel
            {
                Name = "对位",
                Icon = "img/duiwei_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("pictureProcess", new MenuModel
            {
                Name = "图像处理",
                Icon = "img/tuxiangchuli_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("colorProcess", new MenuModel
            {
                Name = "色彩处理",
                Icon = "img/yansechuli_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("defectDetection", new MenuModel
            {
                Name = "缺陷检测",
                Icon = "img/quexianjiance_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("logicTool", new MenuModel
            {
                Name = "逻辑工具",
                Icon = "img/luojigongju_a.png",
                Detail = "test"
            });
            MenuListDatas.Add("correspond", new MenuModel
            {
                Name = "通信",
                Icon = "img/tongxin_a.png",
                Detail = "test"
            });
        }

    }
}