#pragma checksum "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4acd1a7e3b63288523aa3562f9e4454a54e0b8dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acd1a7e3b63288523aa3562f9e4454a54e0b8dd", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SEDC.PizzaApp.Models.Pizza.Pizza>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>These are our pizzas:</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Index.cshtml"
 for (int i = 0; i < Model.Count(); i++) //Model == List<Pizza>
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 7 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Index.cshtml"
  Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Index.cshtml"
                   Write(Model[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\vices\Desktop\SEDC\dotNet\dotNet - MVC\Class 02 - Controllers\SEDC.LibraryApp\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SEDC.PizzaApp.Models.Pizza.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591