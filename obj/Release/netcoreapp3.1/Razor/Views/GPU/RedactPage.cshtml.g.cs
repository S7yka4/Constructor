#pragma checksum "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb313dd1aa859cdab925840e3d581852493af3a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GPU_RedactPage), @"mvc.1.0.view", @"/Views/GPU/RedactPage.cshtml")]
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
#line 1 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
using Constructor.Storage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb313dd1aa859cdab925840e3d581852493af3a5", @"/Views/GPU/RedactPage.cshtml")]
    #nullable restore
    public class Views_GPU_RedactPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GPU>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb313dd1aa859cdab925840e3d581852493af3a52830", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
         using (Html.BeginForm("RedactGPU", "GPU", FormMethod.Post))
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Название   </label><input type=\"text\" name=\"_Name\"");
                BeginWriteAttribute("value", " value=", 215, "", 233, 1);
#nullable restore
#line 8 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 222, Model.Name, 222, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Ссылка   </label><input type=\"text\" name=\"_Img\"");
                BeginWriteAttribute("value", " value=", 310, "", 327, 1);
#nullable restore
#line 9 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 317, Model.Img, 317, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Количество   </label><input type=\"text\" name=\"_Count\"");
                BeginWriteAttribute("value", " value=", 410, "", 429, 1);
#nullable restore
#line 10 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 417, Model.Count, 417, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Цена   </label><input type=\"text\" name=\"_Cost\"");
                BeginWriteAttribute("value", " value=", 505, "", 523, 1);
#nullable restore
#line 11 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 512, Model.Cost, 512, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Частота   </label><input type=\"text\" name=\"_Clock\"");
                BeginWriteAttribute("value", " value=", 603, "", 622, 1);
#nullable restore
#line 12 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 610, Model.Clock, 610, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Объем видеопамяти</label><input type=\"text\" name=\"_MemorySize\"");
                BeginWriteAttribute("value", " value=", 714, "", 738, 1);
#nullable restore
#line 13 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 721, Model.MemorySize, 721, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Тип памяти</label><input type=\"text\" name=\"_MemoryType\"");
                BeginWriteAttribute("value", " value=", 823, "", 847, 1);
#nullable restore
#line 14 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 830, Model.MemoryType, 830, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>TDP   </label><input type=\"text\" name=\"_TDP\"");
                BeginWriteAttribute("value", " value=", 921, "", 938, 1);
#nullable restore
#line 15 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 928, Model.TDP, 928, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Рекомендованная мощность блока питания</label><input type=\"text\" name=\"_RecommendFSPPower\"");
                BeginWriteAttribute("value", " value=", 1058, "", 1089, 1);
#nullable restore
#line 16 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 1065, Model.RecommendFSPPower, 1065, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1142, "\"", 1159, 1);
#nullable restore
#line 17 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
WriteAttributeValue("", 1150, Model.Id, 1150, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Изменить запись\">\r\n");
#nullable restore
#line 19 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /><br /><br />\r\n");
#nullable restore
#line 21 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
         using (Html.BeginForm("MainPage", "Main"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"В главное меню\">\r\n");
#nullable restore
#line 24 "C:\Users\S7yka4\Desktop\Новая папка (2)\Constructor\Views\GPU\RedactPage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GPU> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591