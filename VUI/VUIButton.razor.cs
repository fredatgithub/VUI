using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIButton
    {
        [Parameter] public string Text { get; set; } = "Button";


        protected override void OnInitialized()
        {
            base.OnInitialized();

            Cursor = "pointer";
        }
    }
}