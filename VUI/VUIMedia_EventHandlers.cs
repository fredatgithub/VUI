using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIMedia : VUIElement
    {
        public override async Task InternalOnPlay()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    //CurrentTime = await JSRuntime.InvokeAsync<double>(
                    //    "getMediaCurrentTime", MediaID);

                    //if (OnCurrentTimeUpdate.HasDelegate)
                    //{
                    //    await OnCurrentTimeUpdate.InvokeAsync(this);
                    //}

                    break;
            }
        }

        public override async Task InternalOnTimeUpdate()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    CurrentTime = await JSRuntime.InvokeAsync<double>(
                        "getMediaCurrentTime", MediaID);

                    if (OnCurrentTimeUpdate.HasDelegate)
                    {
                        await OnCurrentTimeUpdate.InvokeAsync(this);
                    }

                    break;
            }
        }
    }
}
