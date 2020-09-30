//Name: David Mosley
//Date: 9/29/2020
//Description: This is the implementation of the medium brush, and allows it to change the size of brush to medium.

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    class mediumBrush : Change_Brush_Size
    {
        public void changeSize(InkCanvas can) //change medium brush size
        {
            can.DefaultDrawingAttributes.Width = 3;
            can.DefaultDrawingAttributes.Height = 3;
        }
    }
}
