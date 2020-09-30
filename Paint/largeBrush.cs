using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class largeBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can)
        {
            can.DefaultDrawingAttributes.Width = 5;
            can.DefaultDrawingAttributes.Height = 5;
        }
    }
}
