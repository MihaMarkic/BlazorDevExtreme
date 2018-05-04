using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Threading.Tasks;

namespace BlazorDevExtreme.Components
{
    public abstract class DxBlazorCompoment<TOptions>: BlazorComponent
    {
        public static int Index { get; private set; }
        protected bool isInitialized;
        public string Id { get; }
        public DxBlazorCompoment(string coreId)
        {
            Id = $"{coreId}_{Index++}";
        }
        protected abstract TOptions CreateOptions();
        protected abstract void Init(TOptions options);
        protected override async Task OnInitAsync()
        {
            Console.WriteLine($"Button Id is {Id}");
            while (!isInitialized)
            {
                try
                {
                    var options = CreateOptions();
                    Init(options);
                    isInitialized = true;
                }
                catch (Exception ex)
                {
                    await Task.Delay(1000);
                }
            }
            Console.WriteLine($"Button {Id} is initialized");
        }
    }
}
