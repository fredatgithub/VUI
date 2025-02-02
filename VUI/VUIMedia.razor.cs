using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace VUI
{
    public partial class VUIMedia
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Transition = "None";
        }

        public override async Task Play()
        {
            await JSRuntime.InvokeVoidAsync("playMedia", MediaID);
        }

        public override async Task Pause()
        {
            await JSRuntime.InvokeVoidAsync("pauseMedia", MediaID);
        }

        internal override async Task LoadDetails()
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

        public override async Task<double> GetCurrentTime()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    CurrentTime = await JSRuntime.InvokeAsync<double>(
                        "getMediaCurrentTime", MediaID);
                    break;
            }

            return CurrentTime;
        }

        public override async Task SetCurrentTime(double _t)
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    await JSRuntime.InvokeVoidAsync(
                        "setMediaCurrentTime", MediaID, _t);
                    break;
            }
        }

        public override async Task<double> GetPlaybackRate()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    PlaybackRate = await JSRuntime.InvokeAsync<double>(
                        "getPlaybackRate", MediaID);
                    break;
            }

            return PlaybackRate;
        }

        public override async Task SetPlaybackRate(double _t)
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    await JSRuntime.InvokeVoidAsync(
                        "setPlaybackRate", MediaID, _t);
                    break;
            }
        }
    }
}