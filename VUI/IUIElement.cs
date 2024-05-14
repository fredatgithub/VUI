using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    internal interface IUIElement
    {
        //
        // Define the properties that all UI elements should have
        //
        string InteractionState { get; set; }

        //
        // Define the methods that all UI elements should implement
        //
        Task InternalOnClick();
        Task InternalOnMouseEnter();
        Task InternalOnMouseLeave();
    }
}
