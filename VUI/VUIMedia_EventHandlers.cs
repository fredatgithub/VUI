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
        internal override async Task InternalOnPlay()
        {
            if (MediaState == "Play")
            {
            }
            else
            {
                if (SkipStates.Contains("All") ||
                    SkipStates.Contains("Play"))
                {
                    return;
                }

                MediaState = "Play";
            }


            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    if (OnPlay.HasDelegate)
                    {
                        await OnPlay.InvokeAsync(this);
                    }

                    break;
            }
        }

        internal override async Task InternalOnPause()
        {
            if (MediaState == "Pause")
            {
            }
            else
            {
                if (SkipStates.Contains("All") ||
                    SkipStates.Contains("Pause"))
                {
                    return;
                }

                MediaState = "Pause";
            }


            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    if (OnPause.HasDelegate)
                    {
                        await OnPause.InvokeAsync(this);
                    }

                    break;
            }
        }

        internal override async Task InternalOnEnded()
        {
            if (MediaState == "End")
            {
            }
            else
            {
                if (SkipStates.Contains("All") ||
                    SkipStates.Contains("End"))
                {
                    return;
                }

                MediaState = "End";
            }


            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    if (OnEnd.HasDelegate)
                    {
                        await OnEnd.InvokeAsync(this);
                    }

                    break;
            }
        }


        internal override async Task InternalOnTimeUpdate()
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
