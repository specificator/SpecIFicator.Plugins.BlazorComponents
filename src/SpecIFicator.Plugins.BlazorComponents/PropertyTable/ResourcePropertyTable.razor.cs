using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;

namespace SpecIFicator.Plugins.BlazorComponents.PropertyTable
{
    public partial class ResourcePropertyTable
    {
        [Parameter]
        public ResourceViewModel DataContext { get; set; }

        public bool IsCollapsed { get; set; } = false;

        private void OnButtonClick()
        {
            IsCollapsed = !IsCollapsed;
        }
    }
}