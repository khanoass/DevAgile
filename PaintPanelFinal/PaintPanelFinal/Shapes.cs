using System;
using System.Collections.Generic;
using System.Drawing;


namespace PaintPanelFinal
{
    public class Shapes
    {
        private List<Shape> _Shapes;    //liste de shape

        public Shapes()
        {
            _Shapes = new List<Shape>();
        }
        
        public int NumberOfShapes()
        {
            return _Shapes.Count;
        }

        public void NewShape(Point L, float W, Color C, int S)
        {
            _Shapes.Add(new Shape(L, W, C, S));
        }

        public Shape GetShape(int Index)
        {
            return _Shapes[Index];
        }

        public void RemoveShape(Point L, float threshold)
        {
            for (int i = 0; i < _Shapes.Count; i++)
            {
                if ((Math.Abs(L.X - _Shapes[i].Location.X) < threshold) && (Math.Abs(L.Y - _Shapes[i].Location.Y) < threshold))
                {
                    _Shapes.RemoveAt(i);

                    for (int n = i; n < _Shapes.Count; n++)
                    {
                        _Shapes[n].ShapeNumber += 1;
                    }
                    i -= 1;
                }
            }
        }
    }
}
