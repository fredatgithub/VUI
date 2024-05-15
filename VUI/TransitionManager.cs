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
                        case "Normal_BackgroundColor":
                            e.BackgroundColor = e.Normal_BackgroundColor;
                            break;

                        case "MouseEnter_BackgroundColor":
                            e.BackgroundColor = e.MouseEnter_BackgroundColor;
                            break;

                        case "Clicked_BackgroundColor":
                            e.BackgroundColor = e.Clicked_BackgroundColor;
                            break;
                    }
                    break;
            }
        }
    }
}
