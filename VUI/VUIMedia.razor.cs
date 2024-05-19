using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace VUI
{
    public partial class VUIMedia
    {
        public override async Task Play()
        {
            await JSRuntime.InvokeVoidAsync("playMedia", MediaID);
        }

        public override async Task Pause()
        {
            await JSRuntime.InvokeVoidAsync("pauseMedia", MediaID);
        }

        public override async Task LoadDetails()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    Duration = await JSRuntime.InvokeAsync<double>(
                        "getMediaDuration", MediaID);

                    break;
            }
        }

        public override async Task GetCurrentTime()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    CurrentTime = await JSRuntime.InvokeAsync<int>(
                        "getMediaCurrentTime", MediaID);
                    break;
            }
        }

        public override async Task SetCurrentTime(double _t)
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    await JSRuntime.InvokeAsync<int>(
                        "setMediaCurrentTime", MediaID, _t);
                    break;
            }
        }

        public override async Task InternalOnPlay()
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