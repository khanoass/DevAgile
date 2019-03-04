using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintPanelFinal
{
    public class Shape
    {
        public Point Location;

        public float Width;

        public Color Colour;

        public int ShapeNumber;        

        
        public Shape(Point L, float W, Color C, int S)
        {
            Location = L;               
            Width = W;                  
            Colour = C;                 
            ShapeNumber = S;            
        }
    }
}
