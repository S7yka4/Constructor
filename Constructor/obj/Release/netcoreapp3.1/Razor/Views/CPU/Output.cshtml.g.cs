#pragma checksum "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "076f96943ebd786f24d4642f56336ea99c8670d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CPU_Output), @"mvc.1.0.view", @"/Views/CPU/Output.cshtml")]
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
#line 1 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
using Constructor.Storage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076f96943ebd786f24d4642f56336ea99c8670d6", @"/Views/CPU/Output.cshtml")]
    #nullable restore
    public class Views_CPU_Output : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CPU>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076f96943ebd786f24d4642f56336ea99c8670d62812", async() => {
                WriteLiteral("\r\n        <h2>ID сборки</h2>\r\n        <h1>");
#nullable restore
#line 6 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
       Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <h3>раз</h3>\r\n");
#nullable restore
#line 8 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
         foreach (var tmp in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Id   </label>");
#nullable restore
#line 10 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                           Write(tmp.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Название   </label>");
#nullable restore
#line 12 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                                 Write(tmp.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Ссылка   </label>");
#nullable restore
#line 14 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                               Write(tmp.Img);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Количество   </label>");
#nullable restore
#line 16 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                                   Write(tmp.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Цена   </label>");
#nullable restore
#line 18 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                             Write(tmp.Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Сокет   </label>");
#nullable restore
#line 20 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                              Write(tmp.Socket);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>Частота   </label>");
#nullable restore
#line 22 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                                Write(tmp.Frequency);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>ECC  </label>");
#nullable restore
#line 24 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                           Write(tmp.ECC);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <label>TDP </label>");
#nullable restore
#line 26 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
                          Write(tmp.TDP);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 28 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
             using (Html.BeginForm("EditAssembly", "CPU", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" name=\"CPUId\"");
                BeginWriteAttribute("value", " value=\"", 940, "\"", 955, 1);
#nullable restore
#line 31 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
WriteAttributeValue("", 948, tmp.Id, 948, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"Добавить в сборку\">\r\n");
#nullable restore
#line 33 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br /><br /><br />\r\n");
#nullable restore
#line 35 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\CPU\Output.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CPU>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591