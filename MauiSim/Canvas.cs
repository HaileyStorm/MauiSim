using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Maui.Graphics.Platform;

namespace MauiSim
{
    public class GraphicsDrawable : IDrawable
    {
        private static bool initialized = false;
        public static int frameCt = 0;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (!initialized)
            {
                initialized = true;
                canvas.StrokeColor = Colors.Red;
                canvas.StrokeSize = 6;

                //byte[] x = { 0,0,0,0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                //Stream stream = new MemoryStream(x);
                //var img = PlatformImage.FromStream(stream);

                //canvas.DrawImage(img, 0, 0, 5, 5);
            } else
            {
                canvas.DrawLine(0, frameCt, frameCt, 0);
            }
            
            

        }
    }

}
