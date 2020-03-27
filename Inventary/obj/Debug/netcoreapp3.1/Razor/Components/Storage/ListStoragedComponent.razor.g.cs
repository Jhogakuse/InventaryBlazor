#pragma checksum "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd09655555ca53a6b074a2fb7519e0b008cea15c"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Components.Storage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Wherehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\_Imports.razor"
using Inventary.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListStoragedComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th>Producto</th>\r\n            <th>Bodega</th>\r\n            <th>Cantidad</th>\r\n            <th>Última Actualización</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 15 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
         foreach (var storage in storages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 18 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
                     storage.Product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 19 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
                     storage.Warehouse.WarehouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 20 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
                     storage.PartialQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 21 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
                     storage.LastUpdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 23 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Storage\ListStoragedComponent.razor"
       
    List<StorageEntity> storages = new List<StorageEntity>();

    protected override async Task OnInitializedAsync()
    {
        storages = B_Storage.StorageList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
