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

        /// <summary>
        /// Represents the interaction state of a UI element. 
        /// The possible states are:
        /// <list type="bullet">
        /// <item>
        /// <description>"Normal": The default state of the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"Clicked": The state when the UI element is clicked.</description>
        /// </item>
        /// <item>
        /// <description>"Toggled": The state when the UI elemnt is toggled on or off.</description>
        /// </item>
        /// <item>
        /// <description>"MouseEnter": The state when the mouse pointer enters the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseLeave": The state when the mouse pointer leaves the UI element.</description>
        /// </item>
        /// </list>
        /// </summary>
        string InteractionState { get; set; }


        string ContentType { get; set; }


        //
        // Define the methods that all UI elements should implement
        //
        Task InternalOnClick();
        Task InternalOnMouseEnter();
        Task InternalOnMouseLeave();
    }
}
