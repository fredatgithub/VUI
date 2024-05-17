using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IUIElement
    {
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

    }
}
