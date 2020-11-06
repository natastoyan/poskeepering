using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace roads.blazor.shared.DomProperties
{
    public class DomPropertiesProvider
    {
        private readonly IJSRuntime _jSRuntime;

        public DomPropertiesProvider(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        public static async Task<DomElementProperties> GetElementProperties(IJSRuntime jsRuntime, object element)
        {
            return await jsRuntime.InvokeAsync<DomElementProperties>("Roads.getElementProperties", element);
        }
        public async Task<DomElementProperties> GetElementProperties(object element)
        {
            return await GetElementProperties(_jSRuntime, element);
        }
        public static async Task SetElementHeight(IJSRuntime jsRuntime, object element, float height)
        {
            await jsRuntime.InvokeVoidAsync("Roads.setElementHeight", element, height);
        }

        public async Task SetElementHeight(object element, float height)
        {
            await SetElementHeight(_jSRuntime, element, height);
        }

        public static async Task SetWindowTitle(IJSRuntime jsRuntime, string title)
        {
            await jsRuntime.InvokeAsync<string>("Roads.setWindowTitle", title);
        }

        public async Task SetWindowTitle(string title)
        {
            await SetWindowTitle(_jSRuntime, title);
        }
    }
}