namespace VUI
{
    public partial class VUIButton
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Cursor = "pointer";
            Border = "1px Solid";
        }
    }
}