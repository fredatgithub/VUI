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

        private string interactionState = "Normal";
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

        private string mouseLeave_BackgroundColor;
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

        private string clicked_BackgroundColor;
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

        private string toggled_BackgroundColor;
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
                if (backgroundColor != value && value is not null)
                {
                    backgroundColor = value;
                }
            } 
        }

        private bool isTransitioned = false;

        public bool IsTransitioned
        {
            get => isTransitioned;

            set
            {
                isTransitioned = value;
            }
        }

        private string transition = "Color";
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
        public string TransitionType 
        { 
            get => transitionType; 
            set
            {
                if (transitionType != value && !string.IsNullOrEmpty(value))
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
            if (IsTransitioned) return;
            
            InteractionState = "Clicked";

            TransitionManager.Handle(this);

            if (OnClicked.HasDelegate)
            {
                await OnClicked.InvokeAsync(this);
            }

            await Task.Yield();
            StateHasChanged();
        }

        public async Task InternalOnMouseEnter()
        {
            if (IsTransitioned) return;

            InteractionState = "MouseEnter";

            TransitionManager.Handle(this);

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }

            await Task.Yield();
            StateHasChanged();
        }

        public async Task InternalOnMouseLeave()
        {
            if (IsTransitioned) return;

            InteractionState = "Normal";

            TransitionManager.Handle(this);

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }

            await Task.Yield();
            StateHasChanged();
        }

        public async Task InternalOnMouseUp()
        {
            if (IsTransitioned) return;

            InteractionState = "MouseUp";

            TransitionManager.Handle(this);

            if (OnMouseUp.HasDelegate)
            {
                await OnMouseUp.InvokeAsync(this);
            }

            await Task.Yield();
            StateHasChanged();
        }

        public async Task InternalOnMouseDown()
        {
            if (IsTransitioned) return;

            InteractionState = "MouseDown";

            TransitionManager.Handle(this);

            if (OnMouseDown.HasDelegate)
            {
                await OnMouseDown.InvokeAsync(this);
            }

            await Task.Yield();
            StateHasChanged();
        }


        public async Task TransitionTo(string _interactionState)
        {
            switch(_interactionState)
            {
                case "Toggled":

                    IsTransitioned = true;
                    InteractionState = _interactionState;

                    if (OnToggled.HasDelegate)
                    {
                        await OnToggled.InvokeAsync(this);
                    }

                    break;
            }
        }

        public void StopTransition()
        {
            isTransitioned = false;
        }
    }
}