#pragma checksum "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6438c19463065632e4ae44414f20f2690c493f9"
// <auto-generated/>
#pragma warning disable 1591
namespace TicketsApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using TicketsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using TicketsApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
using TicketsApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class UsersList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color: #2163ac\" class=\"PageHeader\"> Utilisateurs</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "GridActions");
            __builder.OpenComponent<DevExpress.Blazor.DxButton>(3);
            __builder.AddAttribute(4, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                           ButtonRenderStyle.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                             RefreshGrid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "RenderStyleMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyleMode>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                           ButtonRenderStyleMode.Outline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Text", "Actualiser");
            __builder.AddAttribute(8, "SizeMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.SizeMode?>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                                                                                       SizeMode.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "IconCssClass", "undo");
            __builder.AddAttribute(10, "style", "margin: 0.5em;");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __Blazor.TicketsApp.Pages.UsersList.TypeInference.CreateDxDataGrid_0(__builder, 12, 13, 
#nullable restore
#line 16 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                   Userslist

#line default
#line hidden
#nullable disable
            , 14, "UserId", 15, 
#nullable restore
#line 18 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                DataGridNavigationMode.VirtualScrolling

#line default
#line hidden
#nullable disable
            , 16, "Ajouter/Editer Utilisateur", 17, "my-style", 18, 
#nullable restore
#line 21 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                      25

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 22 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                           true

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 23 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                      400

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 24 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                   ScrollBarMode.Auto

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 25 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                           (dataItem) => OnRowRemoving(dataItem)

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 26 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                            (newValues) => OnRowInserting(newValues)

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 27 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                           (updatingDataItem, newValues) => OnRowUpdating(updatingDataItem, newValues)

#line default
#line hidden
#nullable disable
            , 25, "mw-1100", 26, 
#nullable restore
#line 29 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                     ScrollBarMode.Visible

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 30 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                      DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 28, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(29);
                __builder2.AddAttribute(30, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(32);
                __builder2.AddAttribute(33, "Width", "80px");
                __builder2.AddAttribute(34, "Field", "UserId");
                __builder2.AddAttribute(35, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 33 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Caption", "Id");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(38);
                __builder2.AddAttribute(39, "Width", "180px");
                __builder2.AddAttribute(40, "Field", "UserName");
                __builder2.AddAttribute(41, "Caption", "Login");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(43);
                __builder2.AddAttribute(44, "Width", "180px");
                __builder2.AddAttribute(45, "Field", "UserNom");
                __builder2.AddAttribute(46, "Caption", "Nom");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(48);
                __builder2.AddAttribute(49, "Width", "180px");
                __builder2.AddAttribute(50, "Field", "UserPrenom");
                __builder2.AddAttribute(51, "Caption", "Prénom");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(53);
                __builder2.AddAttribute(54, "Width", "180px");
                __builder2.AddAttribute(55, "Field", "UserTelFixe");
                __builder2.AddAttribute(56, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 37 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Caption", "Tél fixe");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(60);
                __builder2.AddAttribute(61, "Width", "180px");
                __builder2.AddAttribute(62, "Field", "UserTelMob");
                __builder2.AddAttribute(63, "Caption", "Tél portable");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(65);
                __builder2.AddAttribute(66, "Width", "180px");
                __builder2.AddAttribute(67, "Field", "UserFax");
                __builder2.AddAttribute(68, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                 false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 39 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "Caption", "Fax");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(72);
                __builder2.AddAttribute(73, "Width", "180px");
                __builder2.AddAttribute(74, "Field", "UserEmail");
                __builder2.AddAttribute(75, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 40 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "Caption", "Email");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(78);
                __builder2.AddAttribute(79, "Width", "180px");
                __builder2.AddAttribute(80, "Field", "UserDescript");
                __builder2.AddAttribute(81, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 41 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Caption", "Déscription");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(85);
                __builder2.AddAttribute(86, "Width", "180px");
                __builder2.AddAttribute(87, "Field", "UserMaxCapacity");
                __builder2.AddAttribute(88, "Caption", "Déconnexion(minutes)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(90);
                __builder2.AddAttribute(91, "Width", "180px");
                __builder2.AddAttribute(92, "Field", "UserPassword");
                __builder2.AddAttribute(93, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 43 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "Caption", "Mot de passe");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(97);
                __builder2.AddAttribute(98, "Width", "180px");
                __builder2.AddAttribute(99, "Field", "UserDateNaiss");
                __builder2.AddAttribute(100, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 47 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "Caption", "Date de naissance");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __Blazor.TicketsApp.Pages.UsersList.TypeInference.CreateDxDataGridComboBoxColumn_1(__builder2, 104, 105, "180px", 106, 
#nullable restore
#line 48 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                        nameof(Role.RoleId)

#line default
#line hidden
#nullable disable
                , 107, "Role", 108, 
#nullable restore
#line 50 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                         Roleslist

#line default
#line hidden
#nullable disable
                , 109, 
#nullable restore
#line 51 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                  nameof(Role.RoleName)

#line default
#line hidden
#nullable disable
                , 110, 
#nullable restore
#line 52 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                   nameof(Role.RoleId)

#line default
#line hidden
#nullable disable
                , 111, (context) => (__builder3) => {
                    __Blazor.TicketsApp.Pages.UsersList.TypeInference.CreateDxComboBox_2(__builder3, 112, 113, 
#nullable restore
#line 54 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                   Roleslist

#line default
#line hidden
#nullable disable
                    , 114, 
#nullable restore
#line 55 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                            ListRenderMode.Virtual

#line default
#line hidden
#nullable disable
                    , 115, 
#nullable restore
#line 56 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                           DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                    , 116, 
#nullable restore
#line 57 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                     DataEditorClearButtonDisplayMode.Auto

#line default
#line hidden
#nullable disable
                    , 117, 
#nullable restore
#line 58 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                            nameof(Role.RoleName)

#line default
#line hidden
#nullable disable
                    , 118, 
#nullable restore
#line 59 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                             nameof(Role.RoleId)

#line default
#line hidden
#nullable disable
                    , 119, 
#nullable restore
#line 60 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                   newCellValue => ((CellEditContext)context).OnChanged(newCellValue.RoleId)

#line default
#line hidden
#nullable disable
                    , 120, 
#nullable restore
#line 61 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                     ((CellEditContext)context).CellValue

#line default
#line hidden
#nullable disable
                    , 121, (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(122);
                        __builder4.AddAttribute(123, "FieldName", "RoleId");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(124, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(125);
                        __builder4.AddAttribute(126, "FieldName", "RoleName");
                        __builder4.CloseComponent();
                    }
                    );
                }
                );
            }
            );
            __builder.AddMarkupContent(127, "\r\n");
            __builder.OpenComponent<DevExpress.Blazor.DxPopup>(128);
            __builder.AddAttribute(129, "HeaderText", "Changer mot de passe");
            __builder.AddAttribute(130, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                     PopupVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "CssClass", "RolePopup");
            __builder.AddAttribute(132, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment<DevExpress.Blazor.IPopupElementInfo>)((context) => (__builder2) => {
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "custom-header bg-primary text-white w-100");
                __builder2.AddMarkupContent(135, "<span class=\"demo-icon-info\">Changer le mot de passe</span>\r\n            ");
                __builder2.OpenElement(136, "a");
                __builder2.AddAttribute(137, "class", "close-button oi oi-x text-white");
                __builder2.AddAttribute(138, "href", "javascript:;");
                __builder2.AddAttribute(139, "aria-hidden", "true");
                __builder2.AddAttribute(140, "role", "button");
                __builder2.AddAttribute(141, "aria-label", "Close popup");
                __builder2.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                 ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(143, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "row");
                __builder2.AddMarkupContent(146, "<div class=\"col-md-5\">Nouveau mot de passe :</div>\r\n            ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "col-md-6 passInput");
                __builder2.OpenComponent<DevExpress.Blazor.DxTextBox>(149);
                __builder2.AddAttribute(150, "Password", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(151, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 83 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                        newPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPassword = __value, newPassword))));
                __builder2.AddAttribute(153, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n        ");
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "row");
                __builder2.AddMarkupContent(157, "<div class=\"col-md-5\">Confirmer le nouveau mot de passe :</div>\r\n            ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "col-md-6 passInput");
                __builder2.OpenComponent<DevExpress.Blazor.DxTextBox>(160);
                __builder2.AddAttribute(161, "Password", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 91 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 91 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                        confirmedPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(163, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => confirmedPassword = __value, confirmedPassword))));
                __builder2.AddAttribute(164, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => confirmedPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n        ");
                __builder2.OpenElement(166, "input");
                __builder2.AddAttribute(167, "type", "button");
                __builder2.AddAttribute(168, "class", "btn btn-success closePassPop");
                __builder2.AddAttribute(169, "value", "Enregistrer");
                __builder2.AddAttribute(170, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                                                  () => { SaveNewPassword(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(171, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<DevExpress.Blazor.IPopupElementInfo>)((context) => (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxButton>(172);
                __builder2.AddAttribute(173, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 98 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                               ButtonRenderStyle.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(174, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\UsersList.razor"
                                                                     ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(175, "Text", "Fermer");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(176, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(177, @"<style>
    .closePassPop {
        position: absolute;
        bottom: -50px;
        height: 32px;
        font-size: 14px;
        line-height: 13px;
        right: 90px;
    }

    .passInput {
        padding: 0;
    }

    .RolePopup {
        max-width: 50% !important;
    }

    a.close-button {
        float: right;
        right: 10px;
    }

    .custom-header {
        height: 45px;
        padding: 10px;
    }

    .RolePopup .row {
        height: 50px;
    }

    .editPassBtn {
        font-size: 14px;
        height: 30px;
    }

    .my-style {
        min-width: 80%;
        vertical-align: middle;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.TicketsApp.Pages.UsersList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::DevExpress.Blazor.DataGridNavigationMode __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Int32 __arg7, int __seq8, global::DevExpress.Blazor.ScrollBarMode __arg8, int __seq9, global::System.Action<T> __arg9, int __seq10, global::System.Action<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> __arg10, int __seq11, global::System.Action<T, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> __arg11, int __seq12, global::System.String __arg12, int __seq13, global::DevExpress.Blazor.ScrollBarMode __arg13, int __seq14, global::DevExpress.Blazor.DataGridEditMode __arg14, int __seq15, global::Microsoft.AspNetCore.Components.RenderFragment __arg15)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "KeyFieldName", __arg1);
        __builder.AddAttribute(__seq2, "DataNavigationMode", __arg2);
        __builder.AddAttribute(__seq3, "PopupEditFormHeaderText", __arg3);
        __builder.AddAttribute(__seq4, "PopupEditFormCssClass", __arg4);
        __builder.AddAttribute(__seq5, "PageSize", __arg5);
        __builder.AddAttribute(__seq6, "ShowFilterRow", __arg6);
        __builder.AddAttribute(__seq7, "VerticalScrollableHeight", __arg7);
        __builder.AddAttribute(__seq8, "VerticalScrollBarMode", __arg8);
        __builder.AddAttribute(__seq9, "RowRemoving", __arg9);
        __builder.AddAttribute(__seq10, "RowInserting", __arg10);
        __builder.AddAttribute(__seq11, "RowUpdating", __arg11);
        __builder.AddAttribute(__seq12, "CssClass", __arg12);
        __builder.AddAttribute(__seq13, "HorizontalScrollBarMode", __arg13);
        __builder.AddAttribute(__seq14, "EditMode", __arg14);
        __builder.AddAttribute(__seq15, "Columns", __arg15);
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<T> __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<System.Object> __arg6)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Width", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Caption", __arg2);
        __builder.AddAttribute(__seq3, "Data", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.AddAttribute(__seq5, "ValueFieldName", __arg5);
        __builder.AddAttribute(__seq6, "EditTemplate", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_2<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::DevExpress.Blazor.ListRenderMode __arg1, int __seq2, global::DevExpress.Blazor.DataGridFilteringMode __arg2, int __seq3, global::DevExpress.Blazor.DataEditorClearButtonDisplayMode __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Action<TData> __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ListRenderMode", __arg1);
        __builder.AddAttribute(__seq2, "FilteringMode", __arg2);
        __builder.AddAttribute(__seq3, "ClearButtonDisplayMode", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.AddAttribute(__seq5, "ValueFieldName", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItemChanged", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ChildContent", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
