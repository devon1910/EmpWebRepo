#pragma checksum "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d848c0597edb4a83e2d5ca7f4110d23516d1d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PersonalSalary), @"mvc.1.0.view", @"/Views/User/PersonalSalary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/PersonalSalary.cshtml", typeof(AspNetCore.Views_User_PersonalSalary))]
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
#line 1 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\_ViewImports.cshtml"
using CybProjWeb;

#line default
#line hidden
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\_ViewImports.cshtml"
using CybProjWeb.Models;

#line default
#line hidden
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
using CybProjWeb.Entities;

#line default
#line hidden
#line 5 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d848c0597edb4a83e2d5ca7f4110d23516d1d2", @"/Views/User/PersonalSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af53c18dec47a2b1313f5aa8998b431a29c79aa", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PersonalSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CybProjWeb.Entities.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
  
    ViewData["Title"] = "Personal Salary";

#line default
#line hidden
#line 9 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
  
    var loggedInUserName = @UserManager.GetUserName(User);
    var loggedInEmail = await UserManager.GetEmailAsync(
                        UserManager.Users.FirstOrDefault(u => u.UserName == loggedInUserName));

#line default
#line hidden
#line 14 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
 foreach (var s in Model)
{

    

#line default
#line hidden
#line 17 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
     if (s.Account.Email == loggedInEmail)
    {

#line default
#line hidden
            BeginContext(556, 1901, true);
            WriteLiteral(@"        <div class=""container-fluid"">
            <div class=""row"">

                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <div class=""d-flex align-items-center mb-4"">
                                <h4 class=""card-title"">Employee Details</h4>
                            </div>

                            <div class=""table-responsive"">
                                <table class=""table no-wrap v-middle mb-0"">
                                    <thead>
                                        <tr class=""border-0"">
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
                                                Name
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Grade
             ");
            WriteLiteral(@"                               </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
                                                Level
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Step
                                            </th>

                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td class=""border-top-0 px-2 py-4"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2457, "\"", 2481, 1);
#line 54 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 2465, s.Account.Email, 2465, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2482, 483, true);
            WriteLiteral(@" class=""form-control"" id=""name"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2965, "\"", 2985, 1);
#line 60 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 2973, s.GradeName, 2973, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2986, 465, true);
            WriteLiteral(@" class=""form-control"" id=""grade"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 px-2 py-4"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3451, "\"", 3472, 1);
#line 66 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 3459, s.GradeLevel, 3459, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3473, 483, true);
            WriteLiteral(@" class=""form-control"" id=""name"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3956, "\"", 3976, 1);
#line 72 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 3964, s.GradeStep, 3964, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3977, 2153, true);
            WriteLiteral(@" class=""form-control"" id=""grade"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                        </tr>



                                    </tbody>
                                </table>
                            </div>

                            <!--SALARY BREAKDOWN-->


                            <div class=""d-flex align-items-center mb-4"">
                                <h4 class=""card-title"">Salary Breakdown</h4>
                            </div>

                            <div class=""table-responsive"">
                                <table class=""table no-wrap v-middle mb-0"">
                                    <thead>
                                        <tr class=""border-0"">
                                            <th class=""border-0 font-14 font-weight-medium text-muted"">
      ");
            WriteLiteral(@"                                          PayItem
                                            </th>
                                            <th class=""border-0 font-14 font-weight-medium text-muted px-2"">
                                                Percentage(N)
                                            </th>

                                            <th class=""border-0 font-14 font-weight-medium text-muted text-center"">
                                                PayItem Type
                                            </th>

                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td>
                                                <label for=""Housing"">Housing</label>
                                            </td>

                                            <td>
                                       ");
            WriteLiteral("         <div class=\"form-group\">\r\n                                                    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6130, "\"", 6148, 1);
#line 118 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 6138, s.Housing, 6138, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6149, 425, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6574, "\"", 6600, 1);
#line 125 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 6582, s.HousingItemType, 6582, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6601, 654, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Lunch"">Lunch</label>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7255, "\"", 7271, 1);
#line 138 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 7263, s.Lunch, 7263, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7272, 425, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7697, "\"", 7721, 1);
#line 145 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 7705, s.LunchItemType, 7705, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7722, 709, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Transport"">Transport</label>
                                            </td>
                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8431, "\"", 8451, 1);
#line 157 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 8439, s.Transport, 8439, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8452, 425, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8877, "\"", 8905, 1);
#line 164 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 8885, s.TransportItemType, 8885, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8906, 707, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <label for=""Medical"">Medical</label>
                                            </td>

                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9613, "\"", 9631, 1);
#line 177 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 9621, s.Medical, 9621, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9632, 425, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                            <td>

                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10057, "\"", 10083, 1);
#line 184 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue("", 10065, s.MedicalItemType, 10065, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10084, 575, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Tax </td>
                                            <td>
                                                <div class=""form-group"">
                                                    <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10659, "\"", 10675, 2);
            WriteAttributeValue("", 10667, "N", 10667, 1, true);
#line 193 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
WriteAttributeValue(" ", 10668, s.Tax, 10669, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10676, 1335, true);
            WriteLiteral(@" class=""form-control"" disabled />
                                                    <span class=""text-danger""></span>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>


                        </div>
                    </div>
                </div>

                <!--Total Salary-->

                <div class=""d-flex align-items-center mb-4"">
                    <h3 class=""card-title"">Total Salary</h3>
                </div>
                <div class=""table-responsive"">
                    <table class=""table no-wrap v-middle mb-0"">

                        <tbody>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Basic Salary:</h4>
                                </td");
            WriteLiteral(@">
                                <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(12012, 13, false);
#line 224 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.BasicSalary);

#line default
#line hidden
            EndContext();
            BeginContext(12025, 593, true);
            WriteLiteral(@"</h4>
                                </td>

                            </tr>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Gross Salary:</h4>
                                </td>
                                <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(12619, 13, false);
#line 236 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.GrossSalary);

#line default
#line hidden
            EndContext();
            BeginContext(12632, 591, true);
            WriteLiteral(@"</h4>
                                </td>

                            </tr>
                            <tr>
                                <td class=""border-top-0 px-2 py-4"">
                                    <h4>Net Salary:</h4>
                                </td>
                                <td class=""border-top-0 px-2 py-4"">
                                    --------------------------------
                                </td>
                                <td class=""border-top-0 text-muted px-2 py-4 font-14"">
                                    <h4>N ");
            EndContext();
            BeginContext(13224, 11, false);
#line 248 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
                                     Write(s.NetSalary);

#line default
#line hidden
            EndContext();
            BeginContext(13235, 209, true);
            WriteLiteral("</h4>\r\n                                </td>\r\n\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 258 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
    }
    

#line default
#line hidden
#line 270 "C:\Users\Ekpokpobe Davidson\source\repos\CybProjWeb\CybProjWeb\Views\User\PersonalSalary.cshtml"
       


}

#line default
#line hidden
            BeginContext(13805, 18, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Account> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Account> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CybProjWeb.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
