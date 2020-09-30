//Name: David Mosley
//Date: 9/29/2020
//Description: This is the implementation of the small brush, and allows it to change the size of brush to small.

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class smallBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can) // change small brush size
        {
            can.DefaultDrawingAttributes.Width = 1;
            can.DefaultDrawingAttributes.Height = 1;
        }
    }
}
