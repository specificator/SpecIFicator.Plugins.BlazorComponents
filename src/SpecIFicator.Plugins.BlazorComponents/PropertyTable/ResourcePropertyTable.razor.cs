using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;

namespace SpecIFicator.Plugins.BlazorComponents.PropertyTable
{
    public partial class ResourcePropertyTable
    {
        [Parameter]
        public ResourceViewModel DataContext { get; set; }

        [Parameter]
        public string PrimaryLanguage { get; set; } = "en";

        [Parameter]
        public string SecondaryLanguage { get; set; } = "de";

        public bool IsCollapsed { get; set; } = false;

        private void OnButtonClick()
        {
            IsCollapsed = !IsCollapsed;
        }
    }
}