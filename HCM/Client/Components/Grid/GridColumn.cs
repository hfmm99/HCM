using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace HCM.Client.Components.Grid
{
    public class GridColumn : ComponentBase
    {
        [Parameter]
        public string Field { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Format { get; set; }

        [Parameter]
        public RenderFragment<dynamic> Template { get; set; }

        [CascadingParameter()]
        public Grid Grid { get; set; }

        protected override Task OnInitializedAsync()
        {
            Grid.Columns.Add(this);
            return base.OnInitializedAsync();
        }
    }
}