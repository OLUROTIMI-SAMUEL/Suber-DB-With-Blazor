// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SuperDB.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using SuperDB.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using SuperDB.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using SuperDB.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using SuperDB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\_Imports.razor"
using SuperDB.Client.Server;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/superhero/{id:int}")]
    public partial class SuperHero : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\SAMUEL OLUROTIMI\source\repos\SuperDB\SuperDB\Client\Pages\SuperHero.razor"
       
    [Parameter]
    public int Id { get; set; }

    SuperDB.Shared.SuperHero hero =null;
    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("This is the Id ->" + Id);
        hero = await SuperHeroService.GetSuperHero(Id);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISuperHeroService SuperHeroService { get; set; }
    }
}
#pragma warning restore 1591
