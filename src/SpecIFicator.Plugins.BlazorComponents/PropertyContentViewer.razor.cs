using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using MDD4All.SpecIF.DataModels.Manipulation;

namespace SpecIFicator.Plugins.BlazorComponents
{
    public partial class PropertyContentViewer
    {
        [Parameter]
        public PropertyViewModel PropertyViewModel { get; set; }

        [Parameter]
        public string Language { get; set; } = "en";

        private string[] SelectedEnumValues
        {

            get
            {
                string[] result = { };

                List<string> values = new List<string>();

                values = PropertyViewModel.Property.GetMultipleEnumerationValue();

                return values.ToArray();
            }

            set
            {

            }
        }
    }
}