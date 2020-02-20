using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCM.Client.Components.ScoreRating
{
    public class ScoreRatingOption : ComponentBase
    {
        [CascadingParameter()]
        public ScoreRating ScoreRating { get; set; }

        protected override Task OnInitializedAsync()
        {
            Console.WriteLine(ScoreRating != null);
            ScoreRating.Options.Add(this);
            return base.OnInitializedAsync();
        }
    }
}
