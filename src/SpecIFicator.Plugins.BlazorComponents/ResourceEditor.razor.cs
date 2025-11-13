using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace SpecIFicator.Plugins.BlazorComponents
{
    public partial class ResourceEditor
    {
        [CascadingParameter]
        public HierarchyViewModel DataContext { get; set; }

        [Inject]
        private IStringLocalizer<ResourceEditor> L { get; set; } = null!;

        private async Task OnEditDialogClose(bool accepted)
        {
            if (accepted)
            {
                DataContext.ConfirmEditResourceCommand.Execute(null);
            }
            else
            {
                DataContext.CancelEditResourceCommand.Execute(null);
            }
            StateHasChanged();
        }
    }
}