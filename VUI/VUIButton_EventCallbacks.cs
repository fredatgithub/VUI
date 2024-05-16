using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIButton : IUIElement
    {
        [Parameter] public EventCallback<VUIButton> OnClicked { get; set; }
        [Parameter] public EventCallback<VUIButton> OnToggled { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseEnter { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseLeave { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseUp { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseDown { get; set; }
    }
}
