#pragma checksum "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d2325533969dfd9d5ad2210e586433b424f7e93"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sam\devel\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
    public partial class NewUserForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-field");
            __builder.AddAttribute(2, "b-b7nrg0bgbc");
            __builder.AddMarkupContent(3, "<label b-b7nrg0bgbc>Name: </label>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "b-b7nrg0bgbc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor"
                                NewUser.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewUser.Name = __value, NewUser.Name))));
            __builder.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewUser.Name));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-field");
            __builder.AddAttribute(13, "b-b7nrg0bgbc");
            __builder.AddMarkupContent(14, "<label b-b7nrg0bgbc>Username: </label>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "b-b7nrg0bgbc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
            __builder.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor"
                                NewUser.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewUser.Username = __value, NewUser.Username))));
            __builder.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewUser.Username));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-field");
            __builder.AddAttribute(24, "b-b7nrg0bgbc");
            __builder.AddMarkupContent(25, "<label b-b7nrg0bgbc>Email Address: </label>\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "b-b7nrg0bgbc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
            __builder.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor"
                                NewUser.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewUser.Email = __value, NewUser.Email))));
            __builder.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewUser.Email));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-field");
            __builder.AddAttribute(35, "b-b7nrg0bgbc");
            __builder.AddMarkupContent(36, "<label b-b7nrg0bgbc>Password: </label>\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "b-b7nrg0bgbc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
            __builder.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor"
                                NewUser.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewUser.Password = __value, NewUser.Password))));
            __builder.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewUser.Password));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Sam\devel\BlazorTest\Shared\NewUserForm.razor"
       
    [Parameter] public NewUser NewUser { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
