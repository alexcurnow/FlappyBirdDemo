#pragma checksum "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875ebd34388c12ae03bd0b6db224737cd9ea4edb"
// <auto-generated/>
#pragma warning disable 1591
namespace FlappyBirdDemo.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class GameContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"border-left\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "game-container");
            __builder.AddAttribute(3, "tabindex", "0");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
                                                   _gameManager.StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 2 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
                                                                                     HandleKeyUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<div class=\"border-top\">start</div>    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sky");
            __builder.OpenComponent<FlappyBirdDemo.Web.Components.Bird>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlappyBirdDemo.Web.Models.BirdModel>(
#nullable restore
#line 5 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
                     _gameManager.Bird

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <div class=\"ground\"></div>");
#nullable restore
#line 8 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
     foreach (var pipe in _gameManager.Pipes)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FlappyBirdDemo.Web.Components.Pipe>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlappyBirdDemo.Web.Models.PipeModel>(
#nullable restore
#line 11 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
                     pipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<div class=\"border-right\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\src\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
      
    GameManager _gameManager;



    protected override void OnInitialized()
    {
        _gameManager = new GameManager();
        _gameManager.MainLoopCompleted += (o, e) => StateHasChanged();
    }

    void HandleKeyUp(KeyboardEventArgs e)
    {
        if (e.Key == " ")
            _gameManager.Jump();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
