using Microsoft.JSInterop;
using System.Drawing;
using System.Threading.Tasks;

namespace SpecIFicator.Plugins.BlazorComponents
{
    public class SvgTextTool
    {
        private IJSRuntime _jsRuntime;

        public SvgTextTool(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Point MeasureText(string text, 
                                 string fontFamily,
                                 string fontSize)
        {
            Point result = new Point();

            ValueTask<Point> task = _jsRuntime.InvokeAsync<Point>("measureSvgTextSync", 
                                                                   text, 
                                                                   fontFamily, 
                                                                   fontSize);

            task.AsTask().Wait();

            result = task.Result;

            return result;
        }
    }
}
