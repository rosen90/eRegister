<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="GalleryWebForm.aspx.cs" Inherits="eRegister.UserWebForms.GalleryWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="col-md-9">
        <div id="title" class="col-md-8" style="text-align: left">
            <h3>Галерия</h3>
        </div>
        <div class="col-md-4" style="text-align: right">
            <h3 style="text-align: left" id="lblHeader" runat="server">Качване на снимки</h3>
        </div>
               <asp:FileUpload ID="FileUpload1" Visible="true" runat="server"/>
                        <asp:Button ID="btnUpload" Visible="true" runat="server" Text="Качи" OnClick="Upload" />
                        <hr />
                        <div class="row">
                           <div class="col-md-3">

                               <table>
                                    <tr>
                                    <td>
                                       <asp:ListView ID="lvPhotos" runat="server"> 
                                        <LayoutTemplate>              
                                               <table ID="groupPlaceholderContainer" runat="server" border="0" cellpadding="0" cellspacing="0">
                                                     <tr ID="groupPlaceholder" runat="server">
                                                     </tr>
                                               </table>                       
                                        </LayoutTemplate>                       
                                        <GroupTemplate>
                                                <tr ID="itemPlaceholderContainer" runat="server">
                                                    <td ID="itemPlaceholder" runat="server">
                                                    </td>
                                                </tr>
                                            </GroupTemplate>          
                                            <ItemTemplate>
                                                <td runat="server" align="center" style="background-color: #e8e8e8; padding: 10px; color: #333333;">                   
                                                <a href='<%# Container.DataItem %>'>
                                                <asp:Image CssClass="Timg" runat="server" ID="imPhoto" ImageUrl='<%# Container.DataItem %>' Width="180" Height="200"/>
                                                </a>
                                                </td>               
                                            </ItemTemplate>            
                                        </asp:ListView>
                                    </td>
                                    </tr>
                                </table>                             
                            </div>
                        </div>
		</div>
</asp:Content>

