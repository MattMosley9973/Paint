//Name: David Mosley
//Date: 9/29/2020
//Description: This is the implementation of the large brush, and allows it to change the size of brush to large.

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class largeBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can) // change large brush size
        {
            can.DefaultDrawingAttributes.Width = 5;
            can.DefaultDrawingAttributes.Height = 5;
        }
    }
}
