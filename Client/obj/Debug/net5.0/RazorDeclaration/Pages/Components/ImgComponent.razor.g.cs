// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace peliculas.Client.Pages.Components
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
    public partial class ImgComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\esteb\OneDrive\Escritorio\Peliculas\Client\Pages\Components\ImgComponent.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImgURL { get; set; }
    [Parameter] public EventCallback<string> ImageSelected { get; set; }


    private string imageT;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var images = e.GetMultipleFiles();
        foreach (var image in images)
        {
            var tamaño = new byte[image.Size];
            await image.OpenReadStream().ReadAsync(tamaño);
            imageT =Convert.ToBase64String(tamaño);
            ImgURL = null;
            await ImageSelected.InvokeAsync(imageT);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
