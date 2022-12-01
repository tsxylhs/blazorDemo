using TopAI.Data;
using TopAI.Models;
using TopAI.Models.Node;
using Blazor.Diagrams;
using Blazor.Diagrams.Core.Models;
using Microsoft.AspNetCore.Components.Web;


namespace TopAI.Pages.Home
{
    public partial class Index
    {
          private readonly BlazorDiagram _blazorDiagram = new BlazorDiagram();
        private readonly Dictionary<string, MenuModel> _menuMap = MenuList.MenuListDatas;
        private string _selectKey = "collection";
        private int? _draggedType;
        private Route _route = new Route
        {
            Title = "采集",
            Sections = CollectionSection.Collections,
            Type = ""
        };
        protected override void OnInitialized()
        {
            base.OnInitialized();
            /*       LayoutData.Title = "Drag & Drop";
                   LayoutData.Info = "A very simple drag & drop implementation using the HTML5 events.";
                   LayoutData.DataChanged();*/
            _blazorDiagram.RegisterComponent<BotAnswerNode, BotAnswerWidget>();

        
          
        }
   
    
        private BotAnswerNode NewNode(double x, double y)
        {
            var node = new BotAnswerNode(new Blazor.Diagrams.Core.Geometry.Point(x, y));
            node.AddPort(PortAlignment.Top);
            node.AddPort(PortAlignment.Bottom);
            return node;
        }
        private void OnDragStart(int e)
        {
            _draggedType = e;
        }
        private void OnDrop(Microsoft.AspNetCore.Components.Web.DragEventArgs e)
        {
            if (_draggedType == null)
            {
                return;
            }
            
            var position = _blazorDiagram.GetRelativeMousePoint(e.ClientX, e.ClientY);
            var node = _draggedType == 0?new NodeModel(position) : new BotAnswerNode(position);
            node.AddPort(PortAlignment.Top);
            node.AddPort(PortAlignment.Bottom);
            _blazorDiagram.Nodes.Add(node);
            _draggedType = null;
        }


        private void CheckMenu(AntDesign.MenuItem item)
        {
            _selectKey = item.Key;
            switch (_selectKey)
            {
                case "camera":
                    _route.Type = _selectKey;
                    _route.Title = "相机";
                    _route.Sections = CameraSection.Cameras;
                    break;
                case "collection":
                    _route.Type = _selectKey;
                    _route.Title = "采集";
                    _route.Sections = CollectionSection.Collections;
                    break;
                case "positioning":
                    _route.Type = _selectKey;
                    _route.Title = "定位";
                    _route.Sections = PositioningSection.PositioningSets;
                    break;

                case "measure":
                    _route.Type = _selectKey;
                    _route.Title = "测量";
                    _route.Sections = MeasureSection.MeasureSets;
                    break;

                case "recognize":
                    _route.Type = _selectKey;
                    _route.Title = "识别";
                    _route.Sections = RecognizeSection.RecognizeSets;
                    break;

                case "calibrate":
                    _route.Type = _selectKey;
                    _route.Title = "标定";
                    _route.Sections = CalibrateSection.CalibrateSets;
                    break;

                case "counterpoint":
                    _route.Type = _selectKey;
                    _route.Title = "对位";
                    _route.Sections = CounterpointSection.CounterpointSets;
                    break;

                case "pictureProcess":
                    _route.Type = _selectKey;
                    _route.Title = "图像处理";
                    _route.Sections = PictureProcessSection.PictureProcessSets;
                    break;

                case "colorProcess":
                    _route.Type = _selectKey;
                    _route.Title = "色彩处理";
                    _route.Sections = ColorProcessSection.ColorProcessSets;
                    break;

                case "defectDetection":
                    _route.Type = _selectKey;
                    _route.Title = "缺陷检测";
                    _route.Sections = DefectDetectionSection.DefectDetectionSets;
                    break;

                case "logicTool":
                    _route.Type = _selectKey;
                    _route.Title = "逻辑工具";
                    _route.Sections = LogicToolSection.LogicToolSets;
                    break;
                case "correspond":
                    _route.Type = _selectKey;
                    _route.Title = "通信";
                    _route.Sections = CorrespondSection.CorrespondSets;
                    break;
                default:

                    break;

            }
        }

    }
}