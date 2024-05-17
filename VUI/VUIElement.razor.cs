using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        private string contentType = "Text";
        [Parameter]
        public string ContentType
        {
            get => contentType;
            set
            {
                if (contentType != value && !string.IsNullOrEmpty(value))
                {
                    contentType = value;
                }
            }
        }


        [Parameter] public string Text { get; set; } = "Button";


        public string contentPath = string.Empty;
        [Parameter]
        public string ContentPath
        {
            get => contentPath;
            set
            {
                if (contentPath != value && !string.IsNullOrEmpty(value))
                {
                    contentPath = value;
                    StateHasChanged();
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
                if (interactionState != value && !string.IsNullOrEmpty(value))
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


        string[] skipTransitionStates = [];
        [Parameter]
        public string[] SkipTransitionStates
        {
            get => skipTransitionStates;
            set
            {
                skipTransitionStates = value;
                StateHasChanged();
            }
        }


        protected override void OnInitialized()
        {
            base.OnInitialized();

            InteractionState = "Normal";
            BackgroundColor = normal_BackgroundColor;
        }
    }
}