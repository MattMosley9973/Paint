//Name: David Mosley
//Date: 9/29/2020
//Description: This is the interface that allows you to implement change brush size.

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
                    Change_Brush_Size small = new smallBrush(); // small brush change
                    return small;
                case (brushType)1:
                    Change_Brush_Size medium = new mediumBrush(); // medium brush change
                    return medium;
                case (brushType)2:
                    Change_Brush_Size large = new largeBrush(); // large brush change
                    return large;
                default:
                    return null; //easiest to do
            }
        }
    }
}
enum brushType { small, medium, large }