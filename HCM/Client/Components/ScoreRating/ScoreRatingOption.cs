using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCM.Client.Components.ScoreRating
{
    public class ScoreRatingOption : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Color { get; set; }

        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public bool Checked { get; set; }
    
        [CascadingParameter()]
        public ScoreRating ScoreRating { get; set; }

        protected override Task OnInitializedAsync()
        {
            ScoreRating.Options.Add(this);
            return base.OnInitializedAsync();
        }
    }
}
