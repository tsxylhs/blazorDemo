using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopAI.Models;
namespace TopAI.Data
{
    public class CollectionSection
    {
      public static IList<Section> Collections{get;private set;}
        static CollectionSection(){
            Collections=new List<Section>();
            Collections.Add(new Section{
                    Name="图像源",
                    Location="test",
                    Code=0,
                    Details="test",
                     ImageUrl = "img/tuxiangyuan_a.png"
                });
            Collections.Add(new Section{
                    Name="多图采集",
                    Location="test",
                    Code= 1,
                    Details ="test",
                     ImageUrl = "img/duotucaiji_a.png"
                });
                 Collections.Add(new Section{
                    Name="输出图像",
                    Location="test",
                    Details="test",
                    ImageUrl= "img/shuchutuxiang_a.png"
                 });
                 Collections.Add(new Section{
                    Name="缓存图像",
                    Location="test",
                    Details="test",
                     ImageUrl = "img/huancuntuxiang_a.png"
                });
            Collections.Add(new Section
            {
                Name = "光源",
                Location = "test",
                Details = "test",
                ImageUrl = "img/guangyuan_a.png"
            });
        }

    }
}