using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class smallBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can)
        {
            can.DefaultDrawingAttributes.Width = 1;
            can.DefaultDrawingAttributes.Height = 1;
        }
    }
}
