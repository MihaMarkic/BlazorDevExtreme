using Microsoft.JSInterop;

namespace BlazorDevExtreme
{
    public static class JSRuntime
    {
        private static IJSRuntime _current;

        public static IJSRuntime Current
        {
            get;set;
        }
    }
}
