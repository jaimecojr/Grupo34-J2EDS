#pragma checksum "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Categories\CreateCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4856a18debe1e9c0e31a0e10c240317501503048"
// <auto-generated/>
#pragma warning disable 1591
namespace peliculas.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using peliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using peliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Peliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\_Imports.razor"
using Peliculas.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Categories\CreateCategory.razor"
using peliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/create")]
    public partial class CreateCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<peliculas.Client.Pages.Components.FormCategory>(0);
            __builder.AddAttribute(1, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Categories\CreateCategory.razor"
                              Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Peliculas.Shared.Entity.Category>(
#nullable restore
#line 4 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Categories\CreateCategory.razor"
                                                  Category

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Categories\CreateCategory.razor"
       
    private Category Category = new Category();
    private void Create(){
        Console.WriteLine($"Nombre de la Categoria: {Category.NameCategory}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
