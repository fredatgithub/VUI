namespace VUI
{
    public partial class VUIButton
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Cursor = "pointer";
            Text = "Button";
        }
    }
}