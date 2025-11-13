using Microsoft.AspNetCore.Components;
using MDD4All.SpecIF.ViewModels;

namespace SpecIFicator.Plugins.BlazorComponents
{
    public partial class ResourceView
    {
        [CascadingParameter]
        public HierarchyViewModel DataContext { get; set; } = null!;

        ResourceViewModel? SelectedResource
        {
            get
            {
                ResourceViewModel? result = null;
                if(DataContext != null && DataContext.SelectedNode != null)
                {
                    NodeViewModel selectedNode = (NodeViewModel)DataContext.SelectedNode;

                    result = selectedNode.ReferencedResource;
                }

                return result;
            }
        }
                
    }
}