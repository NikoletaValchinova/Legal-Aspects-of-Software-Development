#pragma checksum "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd1b879e6e928aae1c95ef5b2aca257ef5a1f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UniAccreditations.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(UniAccreditations.Pages.Pages_Index), null)]
namespace UniAccreditations.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\_ViewImports.cshtml"
using UniAccreditations;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1b879e6e928aae1c95ef5b2aca257ef5a1f85", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec2a612133060dde15d199094b765a210f627b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 233, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css\">\r\n<script type=\"text/javascript\" charset=\"utf8\" src=\"https://cdn.datatables.net/1.10.20/js/jquery.dataTables.js\"></script>\r\n");
            EndContext();
            BeginContext(304, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fd1b879e6e928aae1c95ef5b2aca257ef5a1f854602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(365, 514, true);
            WriteLiteral(@"

<table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
    <thead>
        <tr>
            <th>Наименование на ВУ/ филиал/ основно звено</th>
            <th>Шифър на ПН</th>
            <th>Наименование на професионалното направление</th>
            <th>Вид процедура</th>
            <th>Статус на процедурата</th>
            <th>Акредитационна оценка</th>
            <th>Дата, до която е валидна акредитацията</th>
        </tr>
    </thead>
    <tbody>
        ");
            EndContext();
            BeginContext(880, 44, false);
#line 24 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
   Write(UniAccreditations.Pages.IndexModel.getInfo());

#line default
#line hidden
            EndContext();
            BeginContext(924, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
         foreach (var element in @UniAccreditations.Pages.IndexModel.UniList)
        {

#line default
#line hidden
            BeginContext(1016, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1047, 20, false);
#line 28 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(0));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1091, 20, false);
#line 29 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(1));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1135, 20, false);
#line 30 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(2));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1179, 20, false);
#line 31 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(3));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1223, 20, false);
#line 32 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(4));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1267, 20, false);
#line 33 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(5));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1311, 20, false);
#line 34 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
           Write(element.ElementAt(6));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\ROG STRIX SCAR II\Desktop\spasi-master\spasi-master\DrugStore\DrugStore\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1364, 127, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#example\').DataTable();\r\n    });\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
