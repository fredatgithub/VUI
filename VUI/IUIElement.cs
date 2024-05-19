using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public interface IUIElement
    {
        //
        // Define the properties that all UI elements should have
        //

        string ID { get; set; }


        /// <summary>
        /// Represents the interaction state of a UI element. 
        /// The possible states are:
        /// <list type="bullet">
        /// <item>
        /// <description>"All": Represents all possible states of the UI element. 
        /// Useful for operations that all to all states.</description>
        /// </item>
        /// <item>
        /// <description>"Normal": The default state of the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"Clicked": The state when 
        /// the UI element is clicked.</description>
        /// </item>
        /// <item>
        /// <description>"Toggled": The state when 
        /// the UI elemnt is toggled on or off.</description>
        /// </item>
        /// <item>
        /// <description>"MouseEnter": The state when 
        /// the mouse pointer enters the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseLeave": The state when 
        /// the mouse pointer leaves the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseDown": This state is triggered when 
        /// the mouse button is pressed while the cursor is over the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseUp": This state is triggered when 
        /// the mouse button is released after it was pressed over the UI element.</description>
        /// </item>
        /// </list>
        /// </summary>
        string InteractionState { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <description>"Play": This state is activated when 
        /// the UIElement is playing media content.</description>
        /// </item>        
        /// <item>
        /// <description>"Pause": This state is activated when 
        /// the UIElement has paused the media playback.</description>
        /// </item>
        /// <item>
        /// <description>"End": This state is activated when 
        /// the UIElement has ended the media playback, resetting it to the beginning.</description>
        /// </item>
        /// </list>
        /// </summary>
        string MediaState { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <description>"Normal": The default state of the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"Text": the UIElement contains text content.</description>
        /// </item>
        /// <item>
        /// <description>"Image": the UIElement displays an image.</description>
        /// </item>
        /// <item>
        /// <description>"Video": the UIElement plays a video.</description>
        /// </item>
        /// <item>
        /// <description>"Audio": the UIElement plays an audio file.</description>
        /// </item>
        /// </list>
        /// </summary>
        string ContentType { get; set; }


        /// <summary>
        /// Gets or sets the path to the content file. 
        /// This property is used for various content types 
        /// such as music, video, images, etc.
        /// The value should be a valid file path pointing to the content file.
        /// </summary>
        string ContentPath { get; set; }


        string MouseEnter_BackgroundColor { get; set; }
        string MouseLeave_BackgroundColor { get; set; }
        string MouseDown_BackgroundColor { get; set; }
        string MouseUp_BackgroundColor { get; set; }

        string Normal_BackgroundColor { get; set; }
        string Clicked_BackgroundColor { get; set; }
        string Toggled_BackgroundColor { get; set; }

        string BackgroundColor { get; set; }


        string MouseEnter_Color { get; set; }
        string MouseLeave_Color { get; set; }
        string MouseDown_Color { get; set; }
        string MouseUp_Color { get; set; }

        string Normal_Color { get; set; }
        string Clicked_Color { get; set; }
        string Toggled_Color { get; set; }

        string Color { get; set; }



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
        /// <description>"MediaState": This value is used when 
        /// a state change occurs in a Media element. 
        /// The possible state transitions for a Media element are as follows:
        /// <para>Normal -> Play/PlayAt -> Pause -> Play -> Stop: 
        /// This represents a typical sequence of states for a media playback scenario.</para>
        /// <para>Normal -> Play/PlayAt -> Stop: 
        /// This represents a scenario where the media is played and 
        /// then stopped without being paused.</para>
        /// </description>
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


        /// <summary>
        /// Stores a list of transition states that should be skipped or ignored in some process.
        /// </summary>
        string[] SkipTransitionStates { get; set; }

        string Border { get; set; }
        string Display { get; set; }
        string Width { get; set; }
        string Height { get; set; }
        string Cursor { get; set; }
        string Position { get; set; }
        string VerticalAlign { get; set; }
        string HorizontalAlign { get; set; }


        //
        // Media
        //
        double Duration { get; set; }
        double CurrentTime {  get; set; }


        //
        // Define the methods that all UI elements should implement
        //
        Task InternalOnClicked();
        Task InternalOnMouseEnter();
        Task InternalOnMouseLeave();

        Task InternalOnPlay();
        Task InternalOnTimeUpdate();        
    }
}
