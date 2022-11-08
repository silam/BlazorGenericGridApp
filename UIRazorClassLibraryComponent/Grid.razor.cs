using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIRazorClassLibraryComponent
{
    public partial class Grid<TItem>
    {
        [Parameter]
        public IList<TItem> Items { get; set; }

        [Parameter]

        public RenderFragment<TItem>? Columns { get; set; }
    }
}
