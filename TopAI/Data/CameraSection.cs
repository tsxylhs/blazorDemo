using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public static class CameraSection
    {
        public static IList<Section> Cameras{get;private set;}
        static CameraSection(){
            Cameras=new List<Section>();
            Cameras.Add(new Section{
                    Name="图像源",
                    Location="test",
                    Details="test",
                     ImageUrl = "img/heart.png"
                });
            Cameras.Add(new Section{
                    Name="裁切",
                    Location="test",
                    Details="test",
                     ImageUrl = "img/heart.png"
                });
        }

        
    }
}