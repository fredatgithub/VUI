using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        public async Task PlayMedia()
        {
            await JSRuntime.InvokeVoidAsync("playMedia", MediaID);
        }

        public async Task PauseMedia()
        {
            await JSRuntime.InvokeVoidAsync("pauseMedia", MediaID);
        }
    }
}
