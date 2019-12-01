using System;
using System.Collections.Generic;
using System.Linq;

using SkiaSharp;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region skiasharp
            var surface = SkiaSharp.SKSurface.Create(new SkiaSharp.SKImageInfo(100,100));

            var canvas = surface.Canvas;

            canvas.Clear(SkiaSharp.SKColors.Transparent);

            var paint = new SkiaSharp.SKPaint { Color = SkiaSharp.SKColors.Blue };
            canvas.DrawCircle(50, 50, 45, paint);

            var image = surface.Snapshot();
            var data = image.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100);

            var base64 = Convert.ToBase64String(data.AsSpan().ToArray());

            Console.WriteLine("data:image/png;base64," + base64);
            #endregion
        }
    }
}
