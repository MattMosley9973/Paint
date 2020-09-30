using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class mediumBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can)
        {
            can.DefaultDrawingAttributes.Width = 3;
            can.DefaultDrawingAttributes.Height = 3;
        }
    }
}
