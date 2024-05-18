namespace VUI
{
    public partial class VUIButton
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Cursor = "pointer";
            Text = "Button";
            Border = "1px Solid";
        }
    }
}