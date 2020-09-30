//Name: David Mosley
//Date: 9/29/2020
//Description: This is the interface that allows you to implement change brush size.

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Paint
{
    interface Change_Brush_Size // interface to implement the changing of the brush sizes.
    {
        void changeSize(InkCanvas can);
    }
}
