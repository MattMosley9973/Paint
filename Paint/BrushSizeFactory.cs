using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class BrushSizeFactory
    {
        public Change_Brush_Size changeBrush(brushType size)
        {
            switch(size)
            {
                case 0:
                    Change_Brush_Size small = new smallBrush();
                    return small;
                case (brushType)1:
                    Change_Brush_Size medium = new mediumBrush();
                    return medium;
                case (brushType)2:
                    Change_Brush_Size large = new largeBrush();
                    return large;
                default:
                    return null;
            }
        }
    }
}
enum brushType { small, medium, large }