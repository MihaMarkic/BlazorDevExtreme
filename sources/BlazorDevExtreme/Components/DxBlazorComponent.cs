using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Threading.Tasks;

namespace BlazorDevExtreme.Components
{
    public abstract class DxBlazorComponent<TOptions>: BlazorComponent
    {
        public static int Index { get; private set; }
        protected bool isInitialized;
        public string Id { get; }
        public DxBlazorComponent(string coreId)
        {
            Id = $"{coreId}_{Index++}";
            Console.WriteLine($"Constructor for {coreId}");
        }
        protected abstract TOptions CreateOptions();
        protected abstract Task Init(TOptions options);
        protected override async Task OnInitAsync()
        {
            Console.WriteLine($"Button Id is {Id}");
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
                    Console.WriteLine($"DX component initialization for {Id} failed, will retry in 200ms. This is normal if it happens few times.");
                    await Task.Delay(200);
                }
            }
            Console.WriteLine($"Button {Id} is initialized");
        }
    }
}
