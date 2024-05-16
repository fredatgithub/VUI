using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.TimeZoneInfo;

namespace VUI
{
    public static class TransitionManager
    {
        internal static void Handle(IUIElement e)
        {
            switch (e.TransitionType)
            {
                case "UIState":

                    Handle_UIState(e);
                    break;

                case "UserDecision":

                    Handle_UserDecision(e);
                    break;
            }
        }

        private static void Handle_UIState(IUIElement e)
        {
            switch (e.Transition)
            {
                case "Color":

                    switch (e.InteractionState + "_BackgroundColor")
                    {
                        case "MouseLeave_BackgroundColor":
                        case "Normal_BackgroundColor":
                            e.BackgroundColor = e.Normal_BackgroundColor;
                            break;
                        
                        case "MouseDown_BackgroundColor":
                            e.BackgroundColor = e.Clicked_BackgroundColor;
                            break;

                        case "MouseUp_BackgroundColor":
                        case "MouseEnter_BackgroundColor":
                            e.BackgroundColor = e.MouseEnter_BackgroundColor;
                            break;
                    }
                    break;
            }
        }

        private static void Handle_UserDecision(IUIElement e)
        {
            switch (e.Transition)
            {
                case "Color":

                    switch (e.InteractionState + "_BackgroundColor")
                    {
                        case "Normal_BackgroundColor":
                            e.BackgroundColor = e.Normal_BackgroundColor;
                            break;

                        case "Clicked_BackgroundColor":
                            e.BackgroundColor = e.Clicked_BackgroundColor;
                            break;

                        case "MouseLeave_BackgroundColor":
                            e.BackgroundColor = e.MouseLeave_BackgroundColor;
                            break;

                        case "MouseEnter_BackgroundColor":
                            e.BackgroundColor = e.MouseEnter_BackgroundColor;
                            break;

                        case "MouseDown_BackgroundColor":
                            e.BackgroundColor = e.MouseDown_BackgroundColor;
                            break;

                        case "MouseUp_BackgroundColor":
                            e.BackgroundColor = e.MouseUp_BackgroundColor;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Transitions the UI element to a specified interaction state 
        /// with optional delays and skipping certain states.
        /// </summary>
        /// <param name="e">The UI element that will be transitioned to a new InteractionState. 
        /// The TransitionManager's Handle function will be invoked for this element.</param>
        /// <param name="msDelayBefore">The delay in milliseconds before 
        /// the transition.</param>
        /// <param name="_interactionState">The interaction state to 
        /// transition to.</param>
        /// <param name="msDelayAfter">The delay in milliseconds after 
        /// the transition.</param>
        /// <param name="skipTransitionStates">The states to be 
        /// skipped during the transition.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public static async Task TransitionTo(IUIElement e, int msDelayBefore, string _interactionState, int msDelayAfter,
            string[] skipTransitionStates)
        {
            switch (e.TransitionType)
            {
                case "UIState":

                    break;

                case "UserDecision":

                    e.SkipTransitionStates = skipTransitionStates;

                    await Task.Delay(msDelayBefore);
                    e.InteractionState = _interactionState;

                    TransitionManager.Handle(e);

                    await Task.Delay(msDelayAfter);

                    break;
            }
        }

        public static void StopTransition(IUIElement e)
        {
            e.SkipTransitionStates = [];
        }
    }
}
