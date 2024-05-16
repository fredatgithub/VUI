using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIButton : IUIElement
    {

        private string contentType = "text";

        /// <summary>
        /// <para>"text": the Button has the content as text.</para>
        /// </summary>
        [Parameter]
        public string ContentType
        {
            get => contentType;
            set
            {
                if (contentType != value && value is not null)
                {
                    contentType = value;
                }
            }
        }


        [Parameter] public string Text { get; set; } = "Button";
        [Parameter] public EventCallback<VUIButton> OnClicked { get; set; }
        [Parameter] public EventCallback<VUIButton> OnToggled { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseEnter { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseLeave { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseUp { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseDown { get; set; }


        private string mouseEnter_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when 
        /// the mouse enters the component's area.
        /// </summary>
        [Parameter]
        public string MouseEnter_BackgroundColor
        {
            get => mouseEnter_BackgroundColor;
            set
            {
                if (mouseEnter_BackgroundColor != value && value is not null)
                {
                    mouseEnter_BackgroundColor = value;
                }
            }
        }

        private string mouseLeave_BackgroundColor = "unset";
        [Parameter]
        public string MouseLeave_BackgroundColor
        {
            get => mouseLeave_BackgroundColor;
            set
            {
                if (mouseLeave_BackgroundColor != value && value is not null)
                {
                    mouseLeave_BackgroundColor = value;
                }
            }
        }

        private string mouseDown_BackgroundColor = "unset";
        [Parameter]
        public string MouseDown_BackgroundColor
        {
            get => mouseDown_BackgroundColor;
            set
            {
                if (mouseDown_BackgroundColor != value && value is not null)
                {
                    mouseDown_BackgroundColor = value;
                }
            }
        }

        private string mouseUp_BackgroundColor = "unset";
        [Parameter]
        public string MouseUp_BackgroundColor
        {
            get => mouseUp_BackgroundColor;
            set
            {
                if (mouseUp_BackgroundColor != value && value is not null)
                {
                    mouseUp_BackgroundColor = value;
                }
            }
        }


        private string normal_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when
        /// nothing happens on the component's area.
        /// </summary>
        [Parameter]
        public string Normal_BackgroundColor
        {
            get => normal_BackgroundColor;
            set
            {
                if (normal_BackgroundColor != value && value is not null)
                {
                    normal_BackgroundColor = value;
                }
            }
        }


        private string clicked_BackgroundColor = "unset";
        [Parameter]
        public string Clicked_BackgroundColor 
        {
            get => clicked_BackgroundColor;
            set
            {
                if (clicked_BackgroundColor != value && value is not null)
                {
                    clicked_BackgroundColor = value;
                }
            }
        }

        private string toggled_BackgroundColor = "unset";
        [Parameter]
        public string Toggled_BackgroundColor 
        {
            get => toggled_BackgroundColor;
            set
            {
                if (toggled_BackgroundColor != value && value is not null)
                {
                    toggled_BackgroundColor = value;
                }
            }
        }

        private string backgroundColor = "unset";

        [Parameter]
        public string BackgroundColor
        { 
            get => backgroundColor;
            
            set
            {
                if (backgroundColor != value && !string.IsNullOrEmpty(value))
                {
                    backgroundColor = value;
                    StateHasChanged();
                }
            } 
        }


        private string interactionState = "Normal";
        [Parameter]
        public string InteractionState
        {
            get => interactionState;
            set
            {
                if (interactionState != value && value is not null)
                {
                    interactionState = value;
                }
            }
        }


        private string transition = "Color";
        [Parameter]
        public string Transition 
        { 
            get => transition; 
            set
            {
                if (transition != value && !string.IsNullOrEmpty(value))
                {
                    transition = value;
                }
            }
        }

        private string transitionType = "UIState";
        [Parameter]
        public string TransitionType 
        { 
            get => transitionType; 
            set
            {
                if (transitionType != value && 
                    !string.IsNullOrEmpty(value))
                {
                    transitionType = value;
                }
            }
        }


        protected override void OnInitialized()
        {
            base.OnInitialized();

            InteractionState = "Normal";
            BackgroundColor = normal_BackgroundColor;
        }

        public async Task InternalOnClicked()
        {
            if (skipTransitionStates.Contains("All") || 
                skipTransitionStates.Contains("Clicked")) 
            { 
                return; 
            }
            
            InteractionState = "Clicked";

            TransitionManager.Handle(this);

            if (OnClicked.HasDelegate)
            {
                await OnClicked.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseEnter()
        {
            if (skipTransitionStates.Contains("All") || 
                skipTransitionStates.Contains("MouseEnter"))
            {
                return;
            }

            InteractionState = "MouseEnter";

            TransitionManager.Handle(this);

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseLeave()
        {
            if (skipTransitionStates.Contains("All") || 
                skipTransitionStates.Contains("MouseLeave"))
            {
                return;
            }

            InteractionState = "MouseLeave";

            TransitionManager.Handle(this);

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseUp()
        {
            if (skipTransitionStates.Contains("All") || 
                skipTransitionStates.Contains("MouseUp"))
            {
                return;
            }

            InteractionState = "MouseUp";

            TransitionManager.Handle(this);

            if (OnMouseUp.HasDelegate)
            {
                await OnMouseUp.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseDown()
        {
            if (skipTransitionStates.Contains("All") || 
                skipTransitionStates.Contains("MouseDown"))
            {
                return;
            }

            InteractionState = "MouseDown";

            TransitionManager.Handle(this);

            if (OnMouseDown.HasDelegate)
            {
                await OnMouseDown.InvokeAsync(this);
            }

            StateHasChanged();
        }

        string[] skipTransitionStates = [];
        public string[] SkipTransitionStates
        {
            get => skipTransitionStates;
            set
            {
                skipTransitionStates = value;
                StateHasChanged();
            }
        }        
    }
}