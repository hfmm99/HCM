using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace HCM.Client.Components.Grid
{
    public class GridColumn : ComponentBase
    {
        [Parameter]
        public string Field { get; set; }

        [Parameter]
        public string Title { get; set; }

        [CascadingParameter()]
        public Grid Grid { get; set; }

        protected override Task OnInitializedAsync()
        {
            Grid.Columns.Add(this);
            return base.OnInitializedAsync();
        }
    }
}