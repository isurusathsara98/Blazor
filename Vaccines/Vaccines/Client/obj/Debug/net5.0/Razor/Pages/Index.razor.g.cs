#pragma checksum "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b418ec86e57d7f28e35c3a6c00c700ff84b426a"
// <auto-generated/>
#pragma warning disable 1591
namespace Vaccines.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Vaccines.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\_Imports.razor"
using Vaccines.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
using Vaccines.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Vaccine details</h3>");
#nullable restore
#line 9 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
 if (vacine.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span>Loading Super Heroes ...</span>");
#nullable restore
#line 12 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Vaccine Name </th>\r\n                <th>Batch No </th>\r\n                <th>Distributed Area</th>\r\n                <th>No of Doses</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
             foreach (var vac in vacine)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
                         vac.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
                         vac.BatchNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
                         vac.Area

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
                         vac.NoofDoses

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\isuru.sa\source\repos\Vaccines\Vaccines\Client\Pages\Index.razor"
       
    List<Vaccines.Shared.VaccineInfo> vacine = new List<Vaccines.Shared.VaccineInfo>();
    protected override async Task OnInitializedAsync()
    {

        vacine = await Http.GetFromJsonAsync<List<VaccineInfo>>("api/Vaccine");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591