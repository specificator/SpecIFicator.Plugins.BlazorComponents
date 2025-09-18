using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;

namespace SpecIFicator.Plugins.BlazorComponents.PropertyTable
{
    public partial class PropertyViewerTableRow
    {
        [Parameter]
        public PropertyViewModel DataContext { get; set; }

        [Parameter]
        public string PrimaryLanguage { get; set; } = "en";
    }
}