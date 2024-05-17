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
        public async Task PlayVideo()
        {
            await JSRuntime.InvokeVoidAsync("playVideo", MediaID);
        }

        public async Task PauseVideo()
        {
            await JSRuntime.InvokeVoidAsync("pauseVideo", MediaID);
        }
    }
}
