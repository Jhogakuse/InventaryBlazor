#pragma checksum "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df66e8cf9ecd6d6d7cdc37b197fe4833f8be2dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Components.Ejercicios.BlazorPages
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
    public partial class Form001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
             titleForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<label for=\"userName\">Nombre de usuario</label>\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "name", "userName");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
                                                                              userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<label for=\"colorUser\">¿Tu color favorito?</label>\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "name", "colorUser");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
                                                                               colorUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => colorUser = __value, colorUser));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "form-text text-muted");
            __builder.AddContent(26, 
#nullable restore
#line 16 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
                                             userMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-success");
            __builder.AddAttribute(32, "value", "Cambio");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
                                                                          ChangeText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddContent(38, 
#nullable restore
#line 22 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
     userName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.AddContent(40, 
#nullable restore
#line 23 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
     colorUser

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.AddContent(42, 
#nullable restore
#line 24 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
     userMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\DesarrolloAllInOne\source\repos\Inventary\Inventary\Components\Ejercicios\BlazorPages\Form001.razor"
      
    [Parameter]
    public string Message { get; set; }

    string titleForm = "El mensaje es: ";
    string userName, colorUser, userMessage;

    protected override async Task OnInitializedAsync() {
        titleForm = Message;
    }

    private void ChangeText()
    {
        userMessage = "Usuario " + userName + " color favorito es " + colorUser;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
