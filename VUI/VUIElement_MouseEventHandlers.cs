using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IUIElement
    {
        public async Task InternalOnClicked()
        {
            if (InteractionState == "Clicked")
            {
            }
            else 
            {
                if (skipTransitionStates.Contains("All") ||
                    skipTransitionStates.Contains("Clicked"))
                {
                    return;
                }

                InteractionState = "Clicked";
            }
            

            VUITransitionManager.Handle(this);

            if (OnClicked.HasDelegate)
            {
                await OnClicked.InvokeAsync(this);
            }
        }

        public async Task InternalOnMouseEnter()
        {
            if (InteractionState == "MouseEnter")
            {
            }
            else
            {
                if (skipTransitionStates.Contains("All") ||
                    skipTransitionStates.Contains("MouseEnter"))
                {
                    return;
                }

                InteractionState = "MouseEnter";
            }


            VUITransitionManager.Handle(this);

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }
        }

        public async Task InternalOnMouseLeave()
        {
            if (InteractionState == "MouseLeave")
            {
            }
            else
            {
                if (skipTransitionStates.Contains("All") ||
                    skipTransitionStates.Contains("MouseLeave"))
                {
                    return;
                }

                InteractionState = "MouseLeave";
            }


            VUITransitionManager.Handle(this);

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }
        }

        public async Task InternalOnMouseUp()
        {
            if (InteractionState == "MouseUp")
            {
            }
            else
            {
                if (skipTransitionStates.Contains("All") ||
                    skipTransitionStates.Contains("MouseUp"))
                {
                    return;
                }

                InteractionState = "MouseUp";
            }

            
            VUITransitionManager.Handle(this);

            if (OnMouseUp.HasDelegate)
            {
                await OnMouseUp.InvokeAsync(this);
            }
        }

        public async Task InternalOnMouseDown()
        {
            if (InteractionState == "MouseDown")
            {
            }
            else
            {
                if (skipTransitionStates.Contains("All") ||
                    skipTransitionStates.Contains("MouseDown"))
                {
                    return;
                }

                InteractionState = "MouseDown";
            }


            VUITransitionManager.Handle(this);

            if (OnMouseDown.HasDelegate)
            {
                await OnMouseDown.InvokeAsync(this);
            }
        }
    }
}
