using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BlazorDevExtreme.Components
{
    public abstract class DxBlazorComponent<TOptions>: ComponentBase
    {
        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        public static int Index { get; private set; }
        protected bool isInitialized;
        public string Id { get; }
        public DxBlazorComponent(string coreId)
        {
            Id = $"{coreId}_{Index++}";
            Console.WriteLine($"Constructor for {coreId}");
        }
        protected abstract TOptions CreateOptions();
        protected abstract ValueTask<object> Init(TOptions options);

        protected override async Task OnAfterRenderAsync(bool firstTime)
        {
            // hack to get to the jsruntime:
            JSRuntime.Current = JsRuntime;

            Debug.WriteLine($"Button Id is {Id}");
            while (!isInitialized)
            {
                try
                {
                    var options = CreateOptions();
                    await Init(options);
                    isInitialized = true;
                }
                catch
                {
                    Debug.WriteLine($"DX component initialization for {Id} failed, will retry in 200ms. This is normal if it happens few times.");
                    await Task.Delay(200);
                }
            }
            Debug.WriteLine($"Button {Id} is initialized");
        }
    }
}
