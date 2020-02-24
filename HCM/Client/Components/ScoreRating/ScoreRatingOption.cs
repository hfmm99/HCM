using Microsoft.AspNetCore.Components;
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

        [CascadingParameter()]
        public ScoreRating ScoreRating { get; set; }
       
        protected override Task OnInitializedAsync()
        {
            ScoreRating.Options.Add(this);
            return base.OnInitializedAsync();
        }
    }
}