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
            if (SkipTransitionStates.Contains("All") ||
                SkipTransitionStates.Contains("Play"))
            {
                return;
            }

            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    MediaState = "Play";

                    if (OnPlay.HasDelegate)
                    {
                        await OnPlay.InvokeAsync(this);
                    }

                    break;
            }
        }

        public override async Task InternalOnPause()
        {
            if (SkipTransitionStates.Contains("All") ||
                SkipTransitionStates.Contains("Pause"))
            {
                return;
            }

            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    MediaState = "Pause";

                    if (OnPause.HasDelegate)
                    {
                        await OnPause.InvokeAsync(this);
                    }

                    break;
            }
        }

        public override async Task InternalOnEnded()
        {
            if (SkipTransitionStates.Contains("All") ||
                SkipTransitionStates.Contains("End"))
            {
                return;
            }

            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    MediaState = "End";

                    if (OnEnd.HasDelegate)
                    {
                        await OnEnd.InvokeAsync(this);
                    }

                    MediaState = "Normal";
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
