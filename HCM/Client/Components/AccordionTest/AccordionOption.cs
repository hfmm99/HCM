using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCM.Client.Components.AccordionTest
{
    public class AccordionOption : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public List<GqlSubSkill> Subskills { get; set; }

        [CascadingParameter()]
        public AccordionTest AccordionTest { get; set; }

        protected override Task OnInitializedAsync()
        {
            AccordionTest.Options.Add(this);
            return base.OnInitializedAsync();
        }
    }
}
