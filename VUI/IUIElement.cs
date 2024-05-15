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


        string MouseEnter_BackgroundColor { get; set; }
        string MouseLeave_BackgroundColor { get; set; }
        string Normal_BackgroundColor { get; set; }
        string Clicked_BackgroundColor { get; set; }
        string Toggled_BackgroundColor { get; set; }

        string BackgroundColor { get; set; }

        bool IsTransitioned { get; set; }

        /// <summary>
        /// Represents the transition of a UI element. 
        /// The possible transitions are:
        /// <list type="bullet">
        /// 
        /// <item>
        /// <description>"None": This will not cause any action when 
        /// a change between states of the UI element occurs.</description>
        /// </item>
        /// 
        /// <item>
        /// <description>"Color": This will change the foreground and background colors of 
        /// one state to match the colors of another state.</description>
        /// </item>
        /// 
        /// </list>
        /// </summary>
        string Transition { get; set; }


        /// <summary>
        /// Represents the transition type of a UI element. 
        /// The possible transition types are:
        /// <list type="bullet">
        /// 
        /// <item>
        /// <description>"UIState": This is triggered when 
        /// a state change occurs in the UI element.</description>
        /// </item>
        /// 
        /// <item>
        /// <description>"UserDecision": This allows users to decide 
        /// the action when a state change in the UI element.</description>
        /// </item>
        /// 
        /// </list>
        /// </summary>
        string TransitionType { get; set; }


        //
        // Define the methods that all UI elements should implement
        //
        Task InternalOnClicked();
        Task InternalOnMouseEnter();
        Task InternalOnMouseLeave();


        /// <summary>
        /// Invoking this function changes the InteractionState to the provided _interactionState.
        /// It also prevents further changes to the InteractionState by users.
        /// Developers can resume changes to the InteractionState by calling the StopTransition() method.
        /// </summary>
        /// <param name="_interactionState">The state to which the InteractionState will transition.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        Task TransitionTo(string _interactionState);

        void StopTransition();
    }
}
