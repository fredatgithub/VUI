using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IUIElement
    {
        [Parameter] public EventCallback<VUIElement> OnClicked { get; set; }
        [Parameter] public EventCallback<VUIElement> OnToggled { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseEnter { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseLeave { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseUp { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseDown { get; set; }
    }
}
