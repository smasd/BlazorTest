#pragma checksum "C:\Users\Sam\devel\BlazorTest\Shared\LoginForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6acbd63d6a8c4809beb49ae1f40deac2e695f7e2"
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
    public partial class LoginForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-field");
            __builder.AddMarkupContent(2, "<label>Username: </label>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(4);
            __builder.AddAttribute(5, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\Sam\devel\BlazorTest\Shared\LoginForm.razor"
                                Login.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Login.Username = __value, Login.Username))));
            __builder.AddAttribute(7, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Login.Username));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-field");
            __builder.AddMarkupContent(11, "<label>Password: </label>\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
            __builder.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Sam\devel\BlazorTest\Shared\LoginForm.razor"
                                Login.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Login.Password = __value, Login.Password))));
            __builder.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Login.Password));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Sam\devel\BlazorTest\Shared\LoginForm.razor"
       
    [Parameter] public Login Login { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591