using MDD4All.SpecIF.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using MDD4All.SpecIF.DataModels.Manipulation;

namespace SpecIFicator.Plugins.BlazorComponents.PropertyTable
{
    public partial class PropertyEditorTableRow
    {
        [Parameter]
        public PropertyViewModel DataContext { get; set; }

        [Parameter]
        public string PrimaryLanguage { get; set; } = "en";

        private string SelectedEnumValue
        {
            get
            {
                return DataContext.Property.GetSingleEnumerationValue();
            }

            set
            {
                DataContext.SetSingleEnumerationValue(value);
            }
        }

        private string[] SelectedEnumValues
        {

            get
            {
                string[] result = { };

                List<string> values = new List<string>();

                values = DataContext.Property.GetMultipleEnumerationValue();

                return values.ToArray();
            }

            set
            {
                DataContext.SetMultipleEnumerationValue(new List<string>(value));
            }
        }
    }
}