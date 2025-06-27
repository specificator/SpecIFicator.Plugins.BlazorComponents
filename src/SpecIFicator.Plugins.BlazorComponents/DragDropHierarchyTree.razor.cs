using MDD4All.SpecIF.ViewModels;
using MDD4All.UI.DataModels.Tree;
using Microsoft.AspNetCore.Components;

namespace SpecIFicator.Plugins.BlazorComponents
{
    public partial class DragDropHierarchyTree
    {
        [CascadingParameter]
        public HierarchyViewModel DataContext { get; set; }

        protected override void OnInitialized()
        {
            DataContext.PropertyChanged += OnPropertyChanged;
        }

        void OnSelectionChanged(ITreeNode node)
        {
            DataContext.SelectedNode = node as NodeViewModel;
        }

        private void OnPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs arguments)
        {
            StateHasChanged();
        }
    }
}