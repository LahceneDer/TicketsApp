#pragma checksum "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8581e898b251ed95204bb7f7c539690bc43b204b"
// <auto-generated/>
#pragma warning disable 1591
namespace TicketsApp.Pages.Ticket
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
#line 2 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
using TicketsApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tickets")]
    public partial class TicketsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color: #2163ac\" class=\"PageHeader\"> Tickets</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "GridActions");
            __builder.OpenComponent<DevExpress.Blazor.DxButton>(3);
            __builder.AddAttribute(4, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                           ButtonRenderStyle.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                             RefreshGrid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "RenderStyleMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyleMode>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                           ButtonRenderStyleMode.Outline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Text", "Actualiser");
            __builder.AddAttribute(8, "SizeMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.SizeMode?>(
#nullable restore
#line 12 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
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
            __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxDataGrid_0(__builder, 12, 13, 
#nullable restore
#line 16 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                   Ticketslist

#line default
#line hidden
#nullable disable
            , 14, "TicketId", 15, 
#nullable restore
#line 18 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                DataGridNavigationMode.VirtualScrolling

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 19 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                            true

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 20 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                     ScrollBarMode.Visible

#line default
#line hidden
#nullable disable
            , 18, "Add/Edit ticket", 19, "my-style", 20, 
#nullable restore
#line 23 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                      25

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 24 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                           true

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 25 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                      400

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 26 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                   ScrollBarMode.Auto

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 27 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                           (dataItem) => OnRowRemoving(dataItem)

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 28 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                            (newValues) => OnRowInserting(newValues)

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 29 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                           (updatingDataItem, newValues) => OnRowUpdating(updatingDataItem, newValues)

#line default
#line hidden
#nullable disable
            , 27, "mw-1100", 28, 
#nullable restore
#line 31 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                      DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 29, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(30);
                __builder2.AddAttribute(31, "Width", "120px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(33);
                __builder2.AddAttribute(34, "Width", "50px");
                __builder2.AddAttribute(35, "Field", "TicketId");
                __builder2.AddAttribute(36, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 34 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Caption", "Id");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxDataGridComboBoxColumn_1(__builder2, 40, 41, "180px", 42, 
#nullable restore
#line 35 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                        nameof(User.UserId)

#line default
#line hidden
#nullable disable
                , 43, "User", 44, 
#nullable restore
#line 37 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                         Userslist

#line default
#line hidden
#nullable disable
                , 45, 
#nullable restore
#line 38 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                  nameof(User.UserName)

#line default
#line hidden
#nullable disable
                , 46, 
#nullable restore
#line 39 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   nameof(User.UserId)

#line default
#line hidden
#nullable disable
                , 47, (context) => (__builder3) => {
                    __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxComboBox_2(__builder3, 48, 49, 
#nullable restore
#line 41 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                   Userslist

#line default
#line hidden
#nullable disable
                    , 50, 
#nullable restore
#line 42 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            ListRenderMode.Virtual

#line default
#line hidden
#nullable disable
                    , 51, 
#nullable restore
#line 43 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                           DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                    , 52, 
#nullable restore
#line 44 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                     DataEditorClearButtonDisplayMode.Auto

#line default
#line hidden
#nullable disable
                    , 53, 
#nullable restore
#line 45 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            nameof(User.UserName)

#line default
#line hidden
#nullable disable
                    , 54, 
#nullable restore
#line 46 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                             nameof(User.UserId)

#line default
#line hidden
#nullable disable
                    , 55, 
#nullable restore
#line 47 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   newCellValue => ((CellEditContext)context).OnChanged(newCellValue.UserId)

#line default
#line hidden
#nullable disable
                    , 56, 
#nullable restore
#line 48 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                     ((CellEditContext)context).CellValue

#line default
#line hidden
#nullable disable
                    , 57, (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(58);
                        __builder4.AddAttribute(59, "FieldName", "UserId");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(61);
                        __builder4.AddAttribute(62, "FieldName", "UserName");
                        __builder4.CloseComponent();
                    }
                    );
                }
                );
                __builder2.AddMarkupContent(63, "\r\n        ");
                __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxDataGridComboBoxColumn_3(__builder2, 64, 65, "180px", 66, 
#nullable restore
#line 54 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                        nameof(Customer.CustomerId)

#line default
#line hidden
#nullable disable
                , 67, "Customer", 68, 
#nullable restore
#line 56 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                         Customerslist

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 57 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                  nameof(Customer.CustomerName)

#line default
#line hidden
#nullable disable
                , 70, 
#nullable restore
#line 58 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   nameof(Customer.CustomerId)

#line default
#line hidden
#nullable disable
                , 71, (context) => (__builder3) => {
                    __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxComboBox_4(__builder3, 72, 73, 
#nullable restore
#line 60 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                   Customerslist

#line default
#line hidden
#nullable disable
                    , 74, 
#nullable restore
#line 61 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            ListRenderMode.Virtual

#line default
#line hidden
#nullable disable
                    , 75, 
#nullable restore
#line 62 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                           DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                    , 76, 
#nullable restore
#line 63 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                     DataEditorClearButtonDisplayMode.Auto

#line default
#line hidden
#nullable disable
                    , 77, 
#nullable restore
#line 64 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            nameof(Customer.CustomerName)

#line default
#line hidden
#nullable disable
                    , 78, 
#nullable restore
#line 65 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                             nameof(Customer.CustomerId)

#line default
#line hidden
#nullable disable
                    , 79, 
#nullable restore
#line 66 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   newCellValue => ((CellEditContext)context).OnChanged(newCellValue.CustomerId)

#line default
#line hidden
#nullable disable
                    , 80, 
#nullable restore
#line 67 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                     ((CellEditContext)context).CellValue

#line default
#line hidden
#nullable disable
                    , 81, (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(82);
                        __builder4.AddAttribute(83, "FieldName", "CustomerId");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(84, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(85);
                        __builder4.AddAttribute(86, "FieldName", "CustomerName");
                        __builder4.CloseComponent();
                    }
                    );
                }
                );
                __builder2.AddMarkupContent(87, "\r\n        ");
                __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxDataGridComboBoxColumn_5(__builder2, 88, 89, "180px", 90, 
#nullable restore
#line 73 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                         true

#line default
#line hidden
#nullable disable
                , 91, 
#nullable restore
#line 73 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                , 92, 
#nullable restore
#line 73 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                            nameof(TicketType.TicketTypeId)

#line default
#line hidden
#nullable disable
                , 93, "TicketType", 94, 
#nullable restore
#line 75 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                         TicketTypeslist

#line default
#line hidden
#nullable disable
                , 95, 
#nullable restore
#line 76 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                  nameof(TicketType.TicketTypeName)

#line default
#line hidden
#nullable disable
                , 96, 
#nullable restore
#line 77 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   nameof(TicketType.TicketTypeId)

#line default
#line hidden
#nullable disable
                , 97, (context) => (__builder3) => {
                    __Blazor.TicketsApp.Pages.Ticket.TicketsList.TypeInference.CreateDxComboBox_6(__builder3, 98, 99, 
#nullable restore
#line 79 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                   TicketTypeslist

#line default
#line hidden
#nullable disable
                    , 100, 
#nullable restore
#line 80 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            ListRenderMode.Virtual

#line default
#line hidden
#nullable disable
                    , 101, 
#nullable restore
#line 81 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                           DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                    , 102, 
#nullable restore
#line 82 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                     DataEditorClearButtonDisplayMode.Auto

#line default
#line hidden
#nullable disable
                    , 103, 
#nullable restore
#line 83 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                            nameof(TicketType.TicketTypeName)

#line default
#line hidden
#nullable disable
                    , 104, 
#nullable restore
#line 84 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                             nameof(TicketType.TicketTypeId)

#line default
#line hidden
#nullable disable
                    , 105, 
#nullable restore
#line 85 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                   newCellValue => ((CellEditContext)context).OnChanged(newCellValue.TicketTypeId)

#line default
#line hidden
#nullable disable
                    , 106, 
#nullable restore
#line 86 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                     ((CellEditContext)context).CellValue

#line default
#line hidden
#nullable disable
                    , 107, (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(108);
                        __builder4.AddAttribute(109, "FieldName", "TicketTypeId");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(110, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(111);
                        __builder4.AddAttribute(112, "FieldName", "TicketTypeName");
                        __builder4.CloseComponent();
                    }
                    );
                }
                );
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(114);
                __builder2.AddAttribute(115, "Width", "120px");
                __builder2.AddAttribute(116, "Field", "DateDeResoudre");
                __builder2.AddAttribute(117, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 92 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "Caption", "Date De Resoudre");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(120);
                __builder2.AddAttribute(121, "Width", "120px");
                __builder2.AddAttribute(122, "Field", "Duree");
                __builder2.AddAttribute(123, "DisplayFormat", "T");
                __builder2.AddAttribute(124, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 93 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "Caption", "Duree");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(127);
                __builder2.AddAttribute(128, "Width", "120px");
                __builder2.AddAttribute(129, "Field", "Date");
                __builder2.AddAttribute(130, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 94 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "Caption", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(133);
                __builder2.AddAttribute(134, "Width", "80px");
                __builder2.AddAttribute(135, "Field", "Description");
                __builder2.AddAttribute(136, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 95 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 95 "C:\Users\lahcene\source\repos\TicketsApp\TicketsApp\Pages\Ticket\TicketsList.razor"
                                                                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "Caption", "Description");
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(139, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(140, @"<style>
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
namespace __Blazor.TicketsApp.Pages.Ticket.TicketsList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::DevExpress.Blazor.DataGridNavigationMode __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::DevExpress.Blazor.ScrollBarMode __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Int32 __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::System.Int32 __arg9, int __seq10, global::DevExpress.Blazor.ScrollBarMode __arg10, int __seq11, global::System.Action<T> __arg11, int __seq12, global::System.Action<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> __arg12, int __seq13, global::System.Action<T, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> __arg13, int __seq14, global::System.String __arg14, int __seq15, global::DevExpress.Blazor.DataGridEditMode __arg15, int __seq16, global::Microsoft.AspNetCore.Components.RenderFragment __arg16)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "KeyFieldName", __arg1);
        __builder.AddAttribute(__seq2, "DataNavigationMode", __arg2);
        __builder.AddAttribute(__seq3, "ShowGroupPanel", __arg3);
        __builder.AddAttribute(__seq4, "HorizontalScrollBarMode", __arg4);
        __builder.AddAttribute(__seq5, "PopupEditFormHeaderText", __arg5);
        __builder.AddAttribute(__seq6, "PopupEditFormCssClass", __arg6);
        __builder.AddAttribute(__seq7, "PageSize", __arg7);
        __builder.AddAttribute(__seq8, "ShowFilterRow", __arg8);
        __builder.AddAttribute(__seq9, "VerticalScrollableHeight", __arg9);
        __builder.AddAttribute(__seq10, "VerticalScrollBarMode", __arg10);
        __builder.AddAttribute(__seq11, "RowRemoving", __arg11);
        __builder.AddAttribute(__seq12, "RowInserting", __arg12);
        __builder.AddAttribute(__seq13, "RowUpdating", __arg13);
        __builder.AddAttribute(__seq14, "CssClass", __arg14);
        __builder.AddAttribute(__seq15, "EditMode", __arg15);
        __builder.AddAttribute(__seq16, "Columns", __arg16);
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
        public static void CreateDxDataGridComboBoxColumn_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<T> __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<System.Object> __arg6)
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
        public static void CreateDxComboBox_4<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::DevExpress.Blazor.ListRenderMode __arg1, int __seq2, global::DevExpress.Blazor.DataGridFilteringMode __arg2, int __seq3, global::DevExpress.Blazor.DataEditorClearButtonDisplayMode __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Action<TData> __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
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
        public static void CreateDxDataGridComboBoxColumn_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean? __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.Generic.IEnumerable<T> __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment<System.Object> __arg8)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Width", __arg0);
        __builder.AddAttribute(__seq1, "Visible", __arg1);
        __builder.AddAttribute(__seq2, "EditorVisible", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "Caption", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "TextFieldName", __arg6);
        __builder.AddAttribute(__seq7, "ValueFieldName", __arg7);
        __builder.AddAttribute(__seq8, "EditTemplate", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_6<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::DevExpress.Blazor.ListRenderMode __arg1, int __seq2, global::DevExpress.Blazor.DataGridFilteringMode __arg2, int __seq3, global::DevExpress.Blazor.DataEditorClearButtonDisplayMode __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Action<TData> __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
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
