# SkiaSharp

Just click the `run` icon to get started

``` cs --region skiasharp --source-file .\myapp\Program.cs --project .\myapp\myapp.csproj 
var surface = SkiaSharp.SKSurface.Create(new SkiaSharp.SKImageInfo(100,100));

var canvas = surface.Canvas;

canvas.Clear(SkiaSharp.SKColors.Transparent);

var paint = new SkiaSharp.SKPaint { Color = SkiaSharp.SKColors.Blue };
canvas.DrawCircle(50, 50, 45, paint);

var image = surface.Snapshot();
var data = image.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100);

var base64 = Convert.ToBase64String(data.AsSpan().ToArray());

Console.WriteLine("data:image/png;base64," + base64);
```

To test out a preview of the image, run this from the console:

```js
var container = document.querySelector(".code-container-inline");
var output = document.querySelector(".trydotnet-output");
var image = document.createElement("img");
container.appendChild(image);

setInterval(function() {
    image.src = output.innerText;
}, 1000);
```
