#pragma checksum "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3944f8214574fbe0c559d767d0c88162d818d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Empleados), @"mvc.1.0.view", @"/Views/Empleados/Empleados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Empleados.cshtml", typeof(AspNetCore.Views_Empleados_Empleados))]
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
#line 1 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\_ViewImports.cshtml"
using AdministracionWeb;

#line default
#line hidden
#line 2 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\_ViewImports.cshtml"
using AdministracionWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3944f8214574fbe0c559d767d0c88162d818d3", @"/Views/Empleados/Empleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7163007cd94d315e63184f4950331a0f31525ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Empleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d672d77a72134065970428095fad2dd2", async() => {
                BeginContext(64, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Empleados</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(164, 839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "906aa6edc3204517877b18dd5ff34d77", async() => {
                BeginContext(170, 353, true);
                WriteLiteral(@"
    <h2>Lista de empelados</h2>
    <table border=""1"">
        <tr>
            <th>Nombres</th>
            <th>Apellidos</th>
            <th>Sexo</th>
            <th>Estado Civil</th>
            <th>Tipo Sangre</th>
            <th>Fecha Nacimiento</th>
            <th>Fecha Contrato</th>
            <th>Foto</th>

        </tr>

");
                EndContext();
#line 28 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
         foreach(var Empleado in ViewBag.empleados)
        {

#line default
#line hidden
                BeginContext(587, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(618, 16, false);
#line 31 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.nombres);

#line default
#line hidden
                EndContext();
                BeginContext(634, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(658, 18, false);
#line 32 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.apellidos);

#line default
#line hidden
                EndContext();
                BeginContext(676, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(700, 16, false);
#line 33 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.id_sexo);

#line default
#line hidden
                EndContext();
                BeginContext(716, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(740, 23, false);
#line 34 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.id_estadocivil);

#line default
#line hidden
                EndContext();
                BeginContext(763, 24, true);
                WriteLiteral(" </td>\r\n            <td>");
                EndContext();
                BeginContext(788, 22, false);
#line 35 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.id_tiposangre);

#line default
#line hidden
                EndContext();
                BeginContext(810, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(834, 25, false);
#line 36 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.fecha_nacimiento);

#line default
#line hidden
                EndContext();
                BeginContext(859, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(883, 23, false);
#line 37 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.fecha_contrato);

#line default
#line hidden
                EndContext();
                BeginContext(906, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(930, 13, false);
#line 38 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
           Write(Empleado.foto);

#line default
#line hidden
                EndContext();
                BeginContext(943, 22, true);
                WriteLiteral("</td>\r\n        </tr>\r\n");
                EndContext();
#line 40 "C:\Users\ALEXIS\source\repos\AdministracionWeb\AdministracionWeb\Views\Empleados\Empleados.cshtml"
        }

#line default
#line hidden
                BeginContext(976, 20, true);
                WriteLiteral("    </table>\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(1003, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591