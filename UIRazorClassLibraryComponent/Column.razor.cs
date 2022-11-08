using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIRazorClassLibraryComponent
{
    public partial class Column<TItem>
    {
        [Parameter]
        public string Name { get; set; } // headeer column name
        [Parameter]
        public string Label { get; set; } // header label

        [CascadingParameter]
        public TItem Item { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
